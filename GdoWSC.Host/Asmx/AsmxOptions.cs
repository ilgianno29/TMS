using System;

namespace Incasbo.Web.Host.Asmx;

/// <summary>Impostazioni del servizio GdoWSC.asmx (equivalenti a system.web del Web.config).</summary>
public sealed class AsmxOptions
{
	/// <summary>Indirizzo del servizio, come il file GdoWSC.asmx del sito attuale.</summary>
	public string Path { get; set; } = "/GdoWSC.asmx";

	/// <summary>&lt;sessionState mode="InProc" timeout="10" /&gt;</summary>
	public int SessionTimeoutMinutes { get; set; } = 10;

	/// <summary>Nome del cookie di sessione di ASP.NET.</summary>
	public string SessionCookieName { get; set; } = "ASP.NET_SessionId";

	/// <summary>&lt;forms name="GdoWSC" path="/" timeout="10" /&gt;</summary>
	public string AuthCookieName { get; set; } = "GdoWSC";

	public string AuthCookiePath { get; set; } = "/";

	public int AuthTimeoutMinutes { get; set; } = 10;

	internal TimeSpan SessionTimeout => TimeSpan.FromMinutes(Math.Max(1, SessionTimeoutMinutes));

	internal TimeSpan AuthTimeout => TimeSpan.FromMinutes(Math.Max(1, AuthTimeoutMinutes));
}
