#if !NETFRAMEWORK
using System;
using System.Threading;

namespace Incasbo.Web.Compat;

/// <summary>
/// Dati della richiesta ASMX in corso, impostati dall'host ASP.NET Core
/// (GdoWSC.Host) prima di eseguire un metodo del servizio.
/// Sostituisce cio' che in ASP.NET classico forniva HttpContext.Current.
/// </summary>
public sealed class AsmxRequestContext
{
	private static readonly AsyncLocal<AsmxRequestContext> _current = new AsyncLocal<AsmxRequestContext>();

	/// <summary>Richiesta corrente, oppure null fuori da una chiamata ASMX (es. servizi WCF).</summary>
	public static AsmxRequestContext Current
	{
		get => _current.Value;
		set => _current.Value = value;
	}

	public HttpSessionState Session { get; init; }

	public string UserHostAddress { get; init; } = "";

	public string UserHostName { get; init; } = "";

	public int TotalBytes { get; init; }

	/// <summary>Cartella fisica dell'applicazione (ServerVariables["APPL_PHYSICAL_PATH"]).</summary>
	public string ApplicationPhysicalPath { get; init; } = "";

	/// <summary>Nome dell'utente autenticato dal cookie di login, oppure null.</summary>
	public string AuthenticatedUser { get; set; }

	/// <summary>Emette il cookie di login (FormsAuthentication.SetAuthCookie).</summary>
	public Action<string, bool> SetAuthCookie { get; init; }

	/// <summary>Cancella il cookie di login (FormsAuthentication.SignOut).</summary>
	public Action SignOut { get; init; }
}
#endif
