using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using AsmxRequestContext = Incasbo.Web.Compat.AsmxRequestContext;
using HttpSessionState = Incasbo.Web.Compat.HttpSessionState;
using WebService = Incasbo.Web.Compat.WebService;
using Incasbo.Web.Hosting;
using Incasbo.Web.WSC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Incasbo.Web.Host.Asmx;

/// <summary>
/// Esegue un servizio ASMX (es. Incasbo.Web.WSC.GdoWSC) su ASP.NET Core con lo stesso protocollo
/// di ASP.NET classico: SOAP 1.1 e 1.2 document/literal, SOAPAction = namespace/metodo,
/// parametri ByRef restituiti nella risposta, sessione e cookie di login.
/// </summary>
public sealed class AsmxSoapEndpoint<TService> where TService : WebService, new()
{
	private const string Soap11Ns = "http://schemas.xmlsoap.org/soap/envelope/";
	private const string Soap12Ns = "http://www.w3.org/2003/05/soap-envelope";
	private const int MaxRequestBytes = 4 * 1024 * 1024;

	private static readonly ConcurrentDictionary<(Type, string, string), XmlSerializer> Serializers = new ConcurrentDictionary<(Type, string, string), XmlSerializer>();

	private readonly AsmxServiceDescription _service = new AsmxServiceDescription(typeof(TService));
	private readonly AsmxSessionStore _sessions;
	private readonly FormsAuthCookie _auth;
	private readonly AsmxOptions _options;
	private readonly ILogger _logger;

	public AsmxSoapEndpoint(AsmxSessionStore sessions, FormsAuthCookie auth, IOptions<AsmxOptions> options, ILogger<AsmxSoapEndpoint<TService>> logger)
	{
		_sessions = sessions;
		_auth = auth;
		_options = options.Value;
		_logger = logger;
	}

	public AsmxServiceDescription Description => _service;

	public async Task HandleAsync(HttpContext http)
	{
		if (HttpMethods.IsGet(http.Request.Method))
		{
			await HandleGetAsync(http);
			return;
		}
		if (!HttpMethods.IsPost(http.Request.Method))
		{
			http.Response.StatusCode = StatusCodes.Status405MethodNotAllowed;
			return;
		}

		string contentType = http.Request.ContentType ?? "";
		bool soap12 = contentType.StartsWith("application/soap+xml", StringComparison.OrdinalIgnoreCase);
		string envelopeNs = soap12 ? Soap12Ns : Soap11Ns;

		byte[] body;
		using (MemoryStream ms = new MemoryStream())
		{
			await http.Request.Body.CopyToAsync(ms);
			if (ms.Length > MaxRequestBytes)
			{
				await WriteFaultAsync(http, soap12, client: true, "Richiesta troppo grande.");
				return;
			}
			body = ms.ToArray();
		}

		XElement payload;
		try
		{
			XDocument doc = XDocument.Load(new MemoryStream(body));
			XElement envelope = doc.Root;
			if (envelope == null || envelope.Name != XName.Get("Envelope", envelopeNs))
			{
				await WriteFaultAsync(http, soap12, client: true, "Busta SOAP non valida per il Content-Type " + contentType + ".");
				return;
			}
			payload = envelope.Element(XName.Get("Body", envelopeNs))?.Elements().FirstOrDefault();
		}
		catch (XmlException ex)
		{
			await WriteFaultAsync(http, soap12, client: true, "XML non valido: " + ex.Message);
			return;
		}

		AsmxServiceDescription.Operation operation = ResolveOperation(http, soap12, contentType, payload, out string routingError);
		if (operation == null)
		{
			await WriteFaultAsync(http, soap12, client: true, routingError);
			return;
		}

		// Sessione (EnableSession=true) e cookie di login
		http.Request.Cookies.TryGetValue(_options.SessionCookieName, out string sessionId);
		AsmxSessionStore.Entry session = _sessions.GetOrCreate(sessionId, out bool created);
		if (created || sessionId != session.State.SessionID)
		{
			http.Response.Cookies.Append(_options.SessionCookieName, session.State.SessionID, new CookieOptions { HttpOnly = true, Path = "/", SameSite = SameSiteMode.Lax, Secure = http.Request.IsHttps });
		}
		string user = _auth.Read(http);

		object[] arguments;
		try
		{
			arguments = ReadArguments(operation, payload);
		}
		catch (Exception ex) when (ex is InvalidOperationException || ex is FormatException || ex is XmlException)
		{
			await WriteFaultAsync(http, soap12, client: true, "Parametri non validi: " + (ex.InnerException?.Message ?? ex.Message));
			return;
		}

		// ASP.NET esegue le richieste della stessa sessione una alla volta
		await session.Lock.WaitAsync(http.RequestAborted);
		object result;
		try
		{
			AsmxRequestContext.Current = new AsmxRequestContext
			{
				Session = session.State,
				UserHostAddress = http.Connection.RemoteIpAddress?.ToString() ?? "",
				UserHostName = http.Connection.RemoteIpAddress?.ToString() ?? "",
				TotalBytes = body.Length,
				ApplicationPhysicalPath = WscHosting.ApplicationRoot,
				AuthenticatedUser = user,
				SetAuthCookie = (name, persistent) => _auth.Write(http, name, persistent),
				SignOut = () => _auth.Delete(http)
			};
			BeginRequest(session.State);
			try
			{
				using TService service = new TService();
				result = operation.Method.Invoke(service, arguments);
			}
			finally
			{
				EndRequest(session.State);
			}
		}
		catch (TargetInvocationException ex)
		{
			_logger.LogError(ex.InnerException, "Errore in {Operation}", operation.Name);
			await WriteFaultAsync(http, soap12, client: false, "Server was unable to process request. ---> " + ex.InnerException?.Message);
			return;
		}
		finally
		{
			AsmxRequestContext.Current = null;
			session.Lock.Release();
		}

		await WriteResponseAsync(http, soap12, operation, result, arguments);
	}

	private AsmxServiceDescription.Operation ResolveOperation(HttpContext http, bool soap12, string contentType, XElement payload, out string error)
	{
		error = null;
		string action = null;
		if (soap12)
		{
			// application/soap+xml; action="..."
			string part = contentType.Split(';').Select(p => p.Trim()).FirstOrDefault(p => p.StartsWith("action=", StringComparison.OrdinalIgnoreCase));
			action = part?.Substring(7).Trim('"');
		}
		else if (http.Request.Headers.TryGetValue("SOAPAction", out var header))
		{
			action = header.ToString().Trim('"');
		}

		if (!string.IsNullOrEmpty(action))
		{
			AsmxServiceDescription.Operation byAction = _service.Operations.Values.FirstOrDefault(o => _service.SoapAction(o.Name) == action);
			if (byAction == null)
			{
				error = "Server did not recognize the value of HTTP Header SOAPAction: " + action + ".";
				return null;
			}
			if (payload == null || payload.Name != XName.Get(byAction.Name, _service.Namespace))
			{
				error = "Il corpo della richiesta non corrisponde a SOAPAction " + action + ".";
				return null;
			}
			return byAction;
		}
		if (payload != null && payload.Name.NamespaceName == _service.Namespace && _service.Operations.TryGetValue(payload.Name.LocalName, out var byBody))
		{
			return byBody;
		}
		error = "Operazione non riconosciuta" + (payload == null ? "." : ": " + payload.Name + ".");
		return null;
	}

	private object[] ReadArguments(AsmxServiceDescription.Operation operation, XElement payload)
	{
		object[] args = new object[operation.Parameters.Length];
		for (int i = 0; i < args.Length; i++)
		{
			ParameterInfo p = operation.Parameters[i];
			Type type = p.ParameterType.IsByRef ? p.ParameterType.GetElementType() : p.ParameterType;
			XElement element = payload.Element(XName.Get(p.Name, _service.Namespace));
			if (element == null)
			{
				// Elemento assente: come XmlSerializer (null per i riferimenti, valore predefinito per i tipi valore)
				args[i] = type.IsValueType ? Activator.CreateInstance(type) : null;
				continue;
			}
			using XmlReader reader = element.CreateReader();
			args[i] = GetSerializer(type, p.Name).Deserialize(reader);
		}
		return args;
	}

	private async Task WriteResponseAsync(HttpContext http, bool soap12, AsmxServiceDescription.Operation operation, object result, object[] arguments)
	{
		StringBuilder sb = new StringBuilder();
		XmlWriterSettings settings = new XmlWriterSettings { OmitXmlDeclaration = true, Encoding = new UTF8Encoding(false) };
		using (XmlWriter w = XmlWriter.Create(sb, settings))
		{
			string envNs = soap12 ? Soap12Ns : Soap11Ns;
			w.WriteStartElement("soap", "Envelope", envNs);
			w.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");
			w.WriteAttributeString("xmlns", "xsd", null, "http://www.w3.org/2001/XMLSchema");
			w.WriteStartElement("soap", "Body", envNs);
			w.WriteStartElement(operation.Name + "Response", _service.Namespace);
			if (operation.ReturnType != typeof(void))
			{
				WriteValue(w, operation.Name + "Result", operation.ReturnType, result);
			}
			for (int i = 0; i < operation.Parameters.Length; i++)
			{
				ParameterInfo p = operation.Parameters[i];
				if (p.ParameterType.IsByRef)
				{
					WriteValue(w, p.Name, p.ParameterType.GetElementType(), arguments[i]);
				}
			}
			w.WriteEndElement();
			w.WriteEndElement();
			w.WriteEndElement();
		}
		http.Response.StatusCode = StatusCodes.Status200OK;
		http.Response.ContentType = (soap12 ? "application/soap+xml" : "text/xml") + "; charset=utf-8";
		await http.Response.WriteAsync("<?xml version=\"1.0\" encoding=\"utf-8\"?>" + sb, new UTF8Encoding(false));
	}

	private void WriteValue(XmlWriter w, string name, Type type, object value)
	{
		if (value == null)
		{
			// XmlSerializer omette gli elementi null (minOccurs=0)
			return;
		}
		XmlSerializerNamespaces none = new XmlSerializerNamespaces();
		none.Add("", _service.Namespace);
		GetSerializer(type, name).Serialize(w, value, none);
	}

	private XmlSerializer GetSerializer(Type type, string elementName) =>
		Serializers.GetOrAdd((type, elementName, _service.Namespace), key => new XmlSerializer(key.Item1, new XmlRootAttribute(key.Item2) { Namespace = key.Item3 }));

	private static async Task WriteFaultAsync(HttpContext http, bool soap12, bool client, string message)
	{
		string text = SecurityElement.Escape(message ?? "");
		string xml = soap12
			? "<?xml version=\"1.0\" encoding=\"utf-8\"?><soap:Envelope xmlns:soap=\"" + Soap12Ns + "\"><soap:Body><soap:Fault><soap:Code><soap:Value>soap:" + (client ? "Sender" : "Receiver") + "</soap:Value></soap:Code><soap:Reason><soap:Text xml:lang=\"it\">" + text + "</soap:Text></soap:Reason><soap:Detail /></soap:Fault></soap:Body></soap:Envelope>"
			: "<?xml version=\"1.0\" encoding=\"utf-8\"?><soap:Envelope xmlns:soap=\"" + Soap11Ns + "\"><soap:Body><soap:Fault><faultcode>soap:" + (client ? "Client" : "Server") + "</faultcode><faultstring>" + text + "</faultstring><detail /></soap:Fault></soap:Body></soap:Envelope>";
		http.Response.StatusCode = StatusCodes.Status500InternalServerError;
		http.Response.ContentType = (soap12 ? "application/soap+xml" : "text/xml") + "; charset=utf-8";
		await http.Response.WriteAsync(xml, new UTF8Encoding(false));
	}

	private async Task HandleGetAsync(HttpContext http)
	{
		string location = http.Request.Scheme + "://" + http.Request.Host + http.Request.PathBase + http.Request.Path;
		if (http.Request.Query.Keys.Any(k => string.Equals(k, "wsdl", StringComparison.OrdinalIgnoreCase)))
		{
			http.Response.ContentType = "text/xml; charset=utf-8";
			await http.Response.WriteAsync(AsmxWsdl.Generate(_service, location), new UTF8Encoding(false));
			return;
		}
		StringBuilder html = new StringBuilder();
		html.Append("<!doctype html><html lang=\"it\"><head><meta charset=\"utf-8\"><title>").Append(WebUtility.HtmlEncode(_service.Name)).Append("</title></head><body>");
		html.Append("<h1>").Append(WebUtility.HtmlEncode(_service.Name)).Append("</h1><p>Descrizione del servizio: <a href=\"?WSDL\">WSDL</a></p><ul>");
		foreach (AsmxServiceDescription.Operation op in _service.Operations.Values.OrderBy(o => o.Name, StringComparer.Ordinal))
		{
			html.Append("<li><b>").Append(WebUtility.HtmlEncode(op.Name)).Append("</b> &ndash; ").Append(WebUtility.HtmlEncode(op.Description)).Append("</li>");
		}
		html.Append("</ul></body></html>");
		http.Response.ContentType = "text/html; charset=utf-8";
		await http.Response.WriteAsync(html.ToString());
	}

	/// <summary>Global.asax Application_BeginRequest.</summary>
	private static void BeginRequest(HttpSessionState session)
	{
		try
		{
			if (session["SessionEnvironment"] is WSC_SessionEnvironment env)
			{
				env.PerformanceLogAppend("BEGIN REQUEST - Session ID: " + env.WebSessionId);
			}
		}
		catch (Exception)
		{
			// come l'originale: il log delle prestazioni non deve bloccare la richiesta
		}
	}

	/// <summary>Global.asax Application_EndRequest.</summary>
	private static void EndRequest(HttpSessionState session)
	{
		try
		{
			if (session["SessionEnvironment"] is WSC_SessionEnvironment env)
			{
				env.PerformanceLogFlush("END REQUEST - Session ID: " + env.WebSessionId);
				env.PerformanceLogStopWatch();
			}
		}
		catch (Exception)
		{
		}
	}
}
