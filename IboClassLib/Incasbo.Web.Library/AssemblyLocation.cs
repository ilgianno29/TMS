using System;
using System.IO;
using System.Reflection;

namespace Incasbo.Web.Library;

/// <summary>Cartella da cui e' stata caricata una DLL (per trovare file di configurazione accanto ad essa).</summary>
public static class AssemblyLocation
{
	/// <summary>
	/// Su .NET Framework usa CodeBase: sotto IIS le DLL girano da una copia temporanea
	/// ("shadow copy") e CodeBase indica la cartella bin originale.
	/// Su .NET 8 non c'e' shadow copy e CodeBase e' obsoleto: si usa Location.
	/// </summary>
	public static string DirectoryOf(Assembly assembly)
	{
#if NETFRAMEWORK
		return new Uri(Path.GetDirectoryName(assembly.CodeBase)).LocalPath;
#else
		return Path.GetDirectoryName(assembly.Location);
#endif
	}
}
