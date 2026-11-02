using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Incasbo.Web.Compat;
using Incasbo.Web.Host.Asmx;
using Incasbo.Web.Hosting;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Xunit;

namespace Delsy.Tests;

/// <summary>Servizio ASMX di prova con lo stesso schema di GdoWSC (login a form + sessione).</summary>
[WebService(Namespace = "http://test.local/Asmx")]
public class FakeAsmxService : WebService
{
    [WebMethod(EnableSession = true)]
    public bool LogIn(string User, string Password, ref string rsMess)
    {
        if (Password == "ok")
        {
            FormsAuthentication.SetAuthCookie(User, true);
            rsMess = "";
            return true;
        }
        rsMess = "Credenziali non valide";
        return false;
    }

    [WebMethod(EnableSession = true)]
    public bool isAuthenticate() => User.Identity!.IsAuthenticated;

    [WebMethod(EnableSession = true)]
    public string WhoAmI() => User.Identity!.Name ?? "";

    [WebMethod(EnableSession = true)]
    public bool LogOut(ref string rsmess)
    {
        FormsAuthentication.SignOut();
        rsmess = "ciao";
        return true;
    }

    [WebMethod(EnableSession = true)]
    public int Counter()
    {
        int n = (Session["n"] as int? ?? 0) + 1;
        Session["n"] = n;
        return n;
    }

    [WebMethod(EnableSession = true)]
    public bool AddOneDay(ref DateTime value, ref string note)
    {
        value = value.AddDays(1);
        note = (note ?? "(null)") + "!";
        return true;
    }

    [WebMethod(EnableSession = true)]
    public string Boom() => throw new InvalidOperationException("errore di prova");

    [WebMethod(EnableSession = true)]
    public string ClientInfo() => Incasbo.Web.Compat.HttpContext.Current!.Request.UserHostAddress + "|" + Incasbo.Web.Compat.HttpContext.Current.Request.TotalBytes;
}

public class AsmxEndpointTests
{
    private const string Ns = "http://test.local/Asmx";
    private readonly AsmxSoapEndpoint<FakeAsmxService> _endpoint;
    private readonly AsmxSessionStore _sessions;
    private string? _sessionCookie;
    private string? _authCookie;

    public AsmxEndpointTests()
    {
        WscHosting.Initialize(Path.GetTempPath());
        var options = Options.Create(new AsmxOptions());
        _sessions = new AsmxSessionStore(options, NullLogger<AsmxSessionStore>.Instance);
        var auth = new FormsAuthCookie(new EphemeralDataProtectionProvider(), options);
        _endpoint = new AsmxSoapEndpoint<FakeAsmxService>(_sessions, auth, options, NullLogger<AsmxSoapEndpoint<FakeAsmxService>>.Instance);
    }

    private async Task<(int Status, XElement? Body, string Raw)> CallAsync(string operation, string parameters = "", bool soap12 = false, string? action = null)
    {
        var http = new DefaultHttpContext();
        http.Request.Method = "POST";
        http.Connection.RemoteIpAddress = System.Net.IPAddress.Parse("10.1.2.3");
        string envNs = soap12 ? "http://www.w3.org/2003/05/soap-envelope" : "http://schemas.xmlsoap.org/soap/envelope/";
        string xml = $"<?xml version=\"1.0\" encoding=\"utf-8\"?><soap:Envelope xmlns:soap=\"{envNs}\"><soap:Body><{operation} xmlns=\"{Ns}\">{parameters}</{operation}></soap:Body></soap:Envelope>";
        http.Request.Body = new MemoryStream(Encoding.UTF8.GetBytes(xml));
        action ??= Ns + "/" + operation;
        if (soap12)
        {
            http.Request.ContentType = $"application/soap+xml; charset=utf-8; action=\"{action}\"";
        }
        else
        {
            http.Request.ContentType = "text/xml; charset=utf-8";
            http.Request.Headers["SOAPAction"] = "\"" + action + "\"";
        }
        var cookies = new[] { _sessionCookie is null ? null : "ASP.NET_SessionId=" + _sessionCookie, _authCookie is null ? null : "GdoWSC=" + _authCookie }.Where(c => c != null);
        if (cookies.Any()) http.Request.Headers.Cookie = string.Join("; ", cookies);
        http.Response.Body = new MemoryStream();

        await _endpoint.HandleAsync(http);

        foreach (string setCookie in http.Response.Headers.SetCookie.ToArray()!)
        {
            string pair = setCookie.Split(';')[0];
            string name = pair[..pair.IndexOf('=')], value = pair[(pair.IndexOf('=') + 1)..];
            bool expired = setCookie.Contains("expires=Thu, 01 Jan 1970", StringComparison.OrdinalIgnoreCase);
            if (name == "ASP.NET_SessionId") _sessionCookie = value;
            if (name == "GdoWSC") _authCookie = expired || value.Length == 0 ? null : value;
        }
        http.Response.Body.Position = 0;
        string raw = new StreamReader(http.Response.Body).ReadToEnd();
        XElement? body = XDocument.Parse(raw).Root!.Element(XName.Get("Body", envNs))!.Elements().First();
        return (http.Response.StatusCode, body, raw);
    }

    private static string? Value(XElement? response, string name) => response?.Element(XName.Get(name, Ns))?.Value;

    [Fact]
    public async Task Login_ok_emette_il_cookie_e_rende_autenticati()
    {
        Assert.Equal("false", Value((await CallAsync("isAuthenticate")).Body, "isAuthenticateResult"));

        var login = await CallAsync("LogIn", "<User>mario</User><Password>ok</Password><rsMess></rsMess>");
        Assert.Equal(200, login.Status);
        Assert.Equal("true", Value(login.Body, "LogInResult"));
        Assert.NotNull(_authCookie);

        Assert.Equal("true", Value((await CallAsync("isAuthenticate")).Body, "isAuthenticateResult"));
        Assert.Equal("mario", Value((await CallAsync("WhoAmI")).Body, "WhoAmIResult"));
    }

    [Fact]
    public async Task Login_errato_restituisce_il_messaggio_nel_parametro_ref()
    {
        var login = await CallAsync("LogIn", "<User>mario</User><Password>no</Password><rsMess></rsMess>");
        Assert.Equal("false", Value(login.Body, "LogInResult"));
        Assert.Equal("Credenziali non valide", Value(login.Body, "rsMess"));
        Assert.Null(_authCookie);
    }

    [Fact]
    public async Task Logout_cancella_il_cookie()
    {
        await CallAsync("LogIn", "<User>mario</User><Password>ok</Password>");
        var logout = await CallAsync("LogOut", "<rsmess />");
        Assert.Equal("ciao", Value(logout.Body, "rsmess"));
        Assert.Null(_authCookie);
        Assert.Equal("false", Value((await CallAsync("isAuthenticate")).Body, "isAuthenticateResult"));
    }

    [Fact]
    public async Task Cookie_di_login_manomesso_non_autentica()
    {
        await CallAsync("LogIn", "<User>mario</User><Password>ok</Password>");
        _authCookie = _authCookie![..^4] + "AAAA";
        Assert.Equal("false", Value((await CallAsync("isAuthenticate")).Body, "isAuthenticateResult"));
    }

    [Fact]
    public async Task La_sessione_mantiene_i_dati_tra_le_chiamate()
    {
        Assert.Equal("1", Value((await CallAsync("Counter")).Body, "CounterResult"));
        string first = _sessionCookie!;
        Assert.Equal("2", Value((await CallAsync("Counter")).Body, "CounterResult"));
        Assert.Equal("3", Value((await CallAsync("Counter", soap12: true)).Body, "CounterResult"));
        Assert.Equal(first, _sessionCookie);
        Assert.Matches("^[a-z0-5]{24}$", first);

        // senza cookie: nuova sessione
        _sessionCookie = null;
        Assert.Equal("1", Value((await CallAsync("Counter")).Body, "CounterResult"));
        Assert.NotEqual(first, _sessionCookie);
    }

    [Fact]
    public async Task Parametri_ref_DateTime_e_stringa()
    {
        var r = await CallAsync("AddOneDay", "<value>2024-01-31T10:00:00</value><note>x</note>");
        Assert.Equal("true", Value(r.Body, "AddOneDayResult"));
        Assert.StartsWith("2024-02-01T10:00:00", Value(r.Body, "value"));
        Assert.Equal("x!", Value(r.Body, "note"));

        // stringa assente -> null, come XmlSerializer
        var r2 = await CallAsync("AddOneDay", "<value>2024-01-31T10:00:00</value>");
        Assert.Equal("(null)!", Value(r2.Body, "note"));
    }

    [Fact]
    public async Task Eccezione_diventa_SOAP_fault_Server()
    {
        var r = await CallAsync("Boom");
        Assert.Equal(500, r.Status);
        Assert.Contains("<faultcode>soap:Server</faultcode>", r.Raw);
        Assert.Contains("errore di prova", r.Raw);
    }

    [Fact]
    public async Task SOAPAction_sconosciuta_diventa_SOAP_fault_Client()
    {
        var r = await CallAsync("Counter", action: Ns + "/Inesistente");
        Assert.Equal(500, r.Status);
        Assert.Contains("soap:Client", r.Raw);
        Assert.Contains("did not recognize the value of HTTP Header SOAPAction", r.Raw);
    }

    [Fact]
    public async Task Fault_in_SOAP_12()
    {
        var r = await CallAsync("Boom", soap12: true);
        Assert.Equal(500, r.Status);
        Assert.Contains("<soap:Value>soap:Receiver</soap:Value>", r.Raw);
    }

    [Fact]
    public async Task IP_del_client_e_dimensione_della_richiesta()
    {
        string? info = Value((await CallAsync("ClientInfo")).Body, "ClientInfoResult");
        Assert.StartsWith("10.1.2.3|", info);
        Assert.True(int.Parse(info!.Split('|')[1]) > 100);
    }

    [Fact]
    public async Task Le_richieste_della_stessa_sessione_non_si_sovrappongono()
    {
        await CallAsync("Counter");
        var tasks = Enumerable.Range(0, 20).Select(_ => CallAsync("Counter")).ToArray();
        await Task.WhenAll(tasks);
        Assert.Equal("22", Value((await CallAsync("Counter")).Body, "CounterResult"));
    }
}
