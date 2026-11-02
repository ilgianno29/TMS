using System.Text.RegularExpressions;

namespace Incasbo.Security;

/// <summary>
/// I parametri CF e DBCFG dell'indirizzo scelgono il file di configurazione (WFIConfig&lt;CF&gt;.ini,
/// DBConfig&lt;DBCFG&gt;.ini). Senza controllo si potevano usare percorsi come "..\..\" per far caricare
/// altri file del server. Ora sono ammessi solo nomi semplici.
/// </summary>
public static class ConfigNames
{
	private static readonly Regex Allowed = new Regex("^[A-Za-z0-9_-]{0,64}$", RegexOptions.CultureInvariant);

	public static string Sanitize(string value) => value != null && Allowed.IsMatch(value) ? value : "";
}
