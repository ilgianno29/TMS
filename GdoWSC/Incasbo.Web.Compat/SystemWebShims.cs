#if !NETFRAMEWORK
// Sostituti minimi dei tipi di System.Web usati dal codice ASMX originale
// (IncasWebService, IncasServiceFormsAuth, GdoWSC), cosi' quel codice compila
// e funziona su .NET 8 senza essere riscritto. I dati arrivano da AsmxRequestContext.
using System;
using System.Collections.Specialized;
using System.Security.Principal;

namespace Incasbo.Web.Compat;

public sealed class HttpRequest
{
	private readonly AsmxRequestContext _context;

	internal HttpRequest(AsmxRequestContext context)
	{
		_context = context;
	}

	public string UserHostAddress => _context.UserHostAddress;

	public string UserHostName => _context.UserHostName;

	public int TotalBytes => _context.TotalBytes;

	public NameValueCollection ServerVariables
	{
		get
		{
			NameValueCollection vars = new NameValueCollection();
			vars["APPL_PHYSICAL_PATH"] = _context.ApplicationPhysicalPath;
			vars["REMOTE_ADDR"] = _context.UserHostAddress;
			vars["REMOTE_HOST"] = _context.UserHostName;
			return vars;
		}
	}
}

public sealed class HttpContext
{
	private readonly AsmxRequestContext _context;

	private HttpContext(AsmxRequestContext context)
	{
		_context = context;
		Request = new HttpRequest(context);
	}

	/// <summary>Come in ASP.NET: null fuori da una richiesta (es. nei servizi WCF).</summary>
	public static HttpContext Current => AsmxRequestContext.Current == null ? null : new HttpContext(AsmxRequestContext.Current);

	public HttpRequest Request { get; }

	public HttpSessionState Session => _context.Session;
}

/// <summary>Base dei servizi ASMX (System.Web.Services.WebService).</summary>
public abstract class WebService : IDisposable
{
	public HttpContext Context => HttpContext.Current;

	public HttpSessionState Session => AsmxRequestContext.Current?.Session;

	public IPrincipal User
	{
		get
		{
			string name = AsmxRequestContext.Current?.AuthenticatedUser;
			return string.IsNullOrEmpty(name)
				? new GenericPrincipal(new GenericIdentity(""), Array.Empty<string>())
				: new GenericPrincipal(new GenericIdentity(name, "Forms"), Array.Empty<string>());
		}
	}

	public virtual void Dispose()
	{
	}
}

/// <summary>System.Web.Security.FormsAuthentication: cookie di login.</summary>
public static class FormsAuthentication
{
	public static void SetAuthCookie(string userName, bool createPersistentCookie)
	{
		AsmxRequestContext context = AsmxRequestContext.Current ?? throw new InvalidOperationException("Nessuna richiesta ASMX in corso.");
		context.SetAuthCookie?.Invoke(userName, createPersistentCookie);
		context.AuthenticatedUser = userName;
	}

	public static void SignOut()
	{
		AsmxRequestContext context = AsmxRequestContext.Current;
		if (context != null)
		{
			context.SignOut?.Invoke();
			context.AuthenticatedUser = null;
		}
	}
}

[AttributeUsage(AttributeTargets.Class, Inherited = true)]
public sealed class WebServiceAttribute : Attribute
{
	public string Namespace { get; set; } = "http://tempuri.org/";

	public string Name { get; set; }

	public string Description { get; set; }
}

[AttributeUsage(AttributeTargets.Method, Inherited = true)]
public sealed class WebMethodAttribute : Attribute
{
	public string Description { get; set; } = "";

	public bool EnableSession { get; set; }

	public string MessageName { get; set; }
}

public enum WsiProfiles
{
	None = 0,
	BasicProfile1_1 = 1
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
public sealed class WebServiceBindingAttribute : Attribute
{
	public WsiProfiles ConformsTo { get; set; }

	public string Name { get; set; }

	public string Namespace { get; set; }
}
#endif
