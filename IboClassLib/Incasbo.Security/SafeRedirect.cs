using System;

namespace Incasbo.Security;

/// <summary>
/// Controllo degli indirizzi di destinazione presi dalla richiesta (es. parametro "r" dell'autologin),
/// per evitare reindirizzamenti verso siti esterni (phishing).
/// </summary>
public static class SafeRedirect
{
	/// <summary>True solo per indirizzi interni all'applicazione: "~/..." oppure "/..." (non "//", non "/\").</summary>
	public static bool IsLocal(string url)
	{
		if (string.IsNullOrWhiteSpace(url))
		{
			return false;
		}
		foreach (char c in url)
		{
			if (char.IsControl(c))
			{
				return false;
			}
		}
		string u = url.Trim();
		if (u.StartsWith("~/", StringComparison.Ordinal))
		{
			u = u.Substring(1);
		}
		if (!u.StartsWith("/", StringComparison.Ordinal) || u.StartsWith("//", StringComparison.Ordinal) || u.StartsWith("/\\", StringComparison.Ordinal))
		{
			return false;
		}
		// Nessuno schema ("http:", "javascript:") nella parte del percorso; i ':' nei parametri sono ammessi
		int query = u.IndexOfAny(new[] { '?', '#' });
		string path = query >= 0 ? u.Substring(0, query) : u;
		return path.IndexOf(':') < 0 && path.IndexOf('\\') < 0;
	}

	/// <summary>Restituisce l'indirizzo se interno, altrimenti stringa vuota (= pagina iniziale dell'utente).</summary>
	public static string LocalOrEmpty(string url) => IsLocal(url) ? url.Trim() : "";
}
