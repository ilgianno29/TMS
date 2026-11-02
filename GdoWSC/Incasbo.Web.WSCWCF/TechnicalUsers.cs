using System;
using System.Collections.Concurrent;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Incasbo.Security;
using Incasbo.Web.Library;

namespace Incasbo.Web.WSCWCF;

/// <summary>
/// Utenti tecnici dei servizi (EU_INCAS, ES, ENGINE), prima con password fissa nel codice.
/// <list type="bullet">
/// <item>Le chiamate <b>interne</b> (il servizio che fa login da solo, la manutenzione) usano
/// <see cref="InternalPassword"/>: un segreto casuale generato all'avvio, che non esce dal processo.</item>
/// <item>Le chiamate <b>esterne</b> con un utente tecnico (es. il WMS con "ES") sono accettate solo se
/// l'utente e' configurato in IniConfig\UtentiTecnici.ini con l'hash della password.
/// Un utente non configurato viene rifiutato.</item>
/// </list>
/// Formato del file:
/// <code>
/// [ES]
/// PasswordHash=PBKDF2-SHA256$600000$...$...
/// </code>
/// </summary>
public static class TechnicalUsers
{
	public const string ConfigFileName = "UtentiTecnici.ini";

	/// <summary>Segreto per le sole chiamate interne: casuale, diverso a ogni avvio.</summary>
	public static string InternalPassword { get; } = NewSecret();

	// Cache delle verifiche riuscite: PBKDF2 e' volutamente lento e il WMS fa login a ogni chiamata
	private static readonly ConcurrentDictionary<string, string> _verified = new ConcurrentDictionary<string, string>(StringComparer.Ordinal);

	/// <summary>True se la chiamata usa le credenziali interne (stesso processo).</summary>
	public static bool IsInternal(string user, string password, string embeddedUser)
	{
		return string.Equals(user, embeddedUser, StringComparison.Ordinal) && PasswordHasher.FixedTimeEquals(password, InternalPassword);
	}

	/// <summary>
	/// Verifica una chiamata esterna con un utente tecnico, leggendo l'hash da
	/// <paramref name="iniConfigDir"/>\UtentiTecnici.ini. False se l'utente non e' configurato.
	/// </summary>
	public static bool VerifyExternal(string user, string password, string iniConfigDir)
	{
		if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(iniConfigDir))
		{
			return false;
		}
		string stored = ReadHash(Path.Combine(iniConfigDir, ConfigFileName), user);
		if (!PasswordHasher.IsHash(stored))
		{
			return false;
		}
		string cacheKey = user + "\n" + Sha256(password);
		if (_verified.TryGetValue(cacheKey, out string cachedHash) && string.Equals(cachedHash, stored, StringComparison.Ordinal))
		{
			return true;
		}
		if (!PasswordHasher.Verify(password, stored))
		{
			return false;
		}
		_verified[cacheKey] = stored;
		return true;
	}

	private static string ReadHash(string path, string user)
	{
		try
		{
			if (!File.Exists(path))
			{
				return null;
			}
			IniFile ini = new IniFile();
			ini.Load(path, false);
			return ini.GetKeyValue(user, "PasswordHash")?.Trim();
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static string NewSecret()
	{
		byte[] bytes = new byte[32];
		using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
		{
			rng.GetBytes(bytes);
		}
		return "internal:" + Convert.ToBase64String(bytes);
	}

	private static string Sha256(string value)
	{
		using (SHA256 sha = SHA256.Create())
		{
			return Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(value)));
		}
	}
}
