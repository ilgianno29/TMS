using System.Globalization;
using System.Text;

namespace Incasbo.Web.Library;

/// <summary>Codifiche di testo compatibili con il comportamento di .NET Framework.</summary>
public static class LegacyEncoding
{
	/// <summary>
	/// Codifica ANSI di Windows (es. Windows-1252 su sistemi italiani).
	/// Su .NET Framework e' Encoding.Default; su .NET 8 Encoding.Default e' invece UTF-8,
	/// quindi i file prodotti per altri sistemi cambierebbero (lettere accentate diverse).
	/// </summary>
	public static Encoding Ansi
	{
		get
		{
#if NETFRAMEWORK
			return Encoding.Default;
#else
			Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
			return Encoding.GetEncoding(CultureInfo.CurrentCulture.TextInfo.ANSICodePage);
#endif
		}
	}
}
