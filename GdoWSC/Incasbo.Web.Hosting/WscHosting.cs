using System;
using System.IO;

namespace Incasbo.Web.Hosting;

/// <summary>
/// Informazioni sull'applicazione web, indipendenti dall'host (IIS classico o ASP.NET Core).
/// </summary>
public static class WscHosting
{
#if !NETFRAMEWORK
	private static string _applicationRoot;
#endif

	/// <summary>
	/// Cartella fisica dell'applicazione, con il separatore finale
	/// (come HostingEnvironment.ApplicationPhysicalPath di ASP.NET classico).
	/// Qui si trovano IniConfig\, Log\, ecc.
	/// </summary>
	public static string ApplicationRoot
	{
		get
		{
#if NETFRAMEWORK
			return System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;
#else
			return _applicationRoot ?? throw new InvalidOperationException("WscHosting.ApplicationRoot non impostato: chiamare WscHosting.Initialize all'avvio.");
#endif
		}
	}

#if !NETFRAMEWORK
	/// <summary>Da chiamare all'avvio dell'host ASP.NET Core (di solito con ContentRootPath).</summary>
	public static void Initialize(string applicationRoot)
	{
		if (string.IsNullOrWhiteSpace(applicationRoot))
		{
			throw new ArgumentException("Cartella dell'applicazione mancante.", nameof(applicationRoot));
		}
		string full = Path.GetFullPath(applicationRoot);
		_applicationRoot = full.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal) ? full : full + Path.DirectorySeparatorChar;
	}
#endif
}
