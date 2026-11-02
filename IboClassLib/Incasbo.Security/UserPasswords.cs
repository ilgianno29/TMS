using System;
using System.Security.Cryptography;
using Incasbo.Web.Library;

namespace Incasbo.Security;

/// <summary>
/// Verifica e salvataggio delle password degli utenti (tabella WFI_UTENTI, colonna PASSWORD).
/// <para>Valori salvati possibili:</para>
/// <list type="bullet">
/// <item>nuovo formato: hash PBKDF2 (<see cref="PasswordHasher"/>), non reversibile;</item>
/// <item>vecchio formato con CryptographyEnable=True: password cifrata con IboCrypt (reversibile);</item>
/// <item>vecchio formato con CryptographyEnable=False: password in chiaro.</item>
/// </list>
/// Una password nel vecchio formato verificata con successo va riscritta come hash
/// (<c>needsUpgrade</c> = true): cosi' ogni utente viene convertito al primo accesso.
/// </summary>
public static class UserPasswords
{
	/// <summary>Valore da salvare nel database per una nuova password.</summary>
	public static string ForStorage(string password) => PasswordHasher.Hash(password);

	/// <summary>
	/// Verifica la password inserita dall'utente (in chiaro) contro il valore salvato.
	/// </summary>
	/// <param name="cryptographyEnable">Impostazione LoginManager/CryptographyEnable: indica il formato
	/// delle password non ancora convertite (cifrate se true, in chiaro se false).</param>
	public static bool Verify(string password, string stored, bool cryptographyEnable, out bool needsUpgrade)
	{
		needsUpgrade = false;
		if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(stored))
		{
			return false;
		}
		if (PasswordHasher.IsHash(stored))
		{
			bool ok = PasswordHasher.Verify(password, stored);
			needsUpgrade = ok && PasswordHasher.NeedsRehash(stored);
			return ok;
		}
		bool legacyOk;
		if (cryptographyEnable)
		{
			string decrypted = TryDecrypt(stored);
			legacyOk = decrypted != null && PasswordHasher.FixedTimeEquals(password, decrypted);
		}
		else
		{
			legacyOk = PasswordHasher.FixedTimeEquals(password, stored);
		}
		needsUpgrade = legacyOk;
		return legacyOk;
	}

	/// <summary>Converte un valore nel vecchio formato in hash (per la conversione massiva). Null se non convertibile.</summary>
	public static string UpgradeLegacy(string stored, bool cryptographyEnable)
	{
		if (string.IsNullOrEmpty(stored) || PasswordHasher.IsHash(stored))
		{
			return null;
		}
		string plain = cryptographyEnable ? TryDecrypt(stored) : stored;
		return string.IsNullOrEmpty(plain) ? null : ForStorage(plain);
	}

	private static string TryDecrypt(string stored)
	{
		try
		{
			string value = new IboCrypt().DecryptString128Bit(stored);
			return string.IsNullOrEmpty(value) ? null : value;
		}
		catch (Exception ex) when (ex is CryptographicException || ex is FormatException || ex is ArgumentException)
		{
			return null;
		}
	}
}
