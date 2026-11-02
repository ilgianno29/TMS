using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace Incasbo.Security;

/// <summary>
/// Hash delle password con PBKDF2-HMAC-SHA256 (salt casuale, molte iterazioni).
/// Formato salvato: "PBKDF2-SHA256$iterazioni$salt$hash" (Base64).
/// A differenza della vecchia cifratura (IboCrypt), dall'hash non si puo' risalire alla password.
/// </summary>
public static class PasswordHasher
{
	public const string Prefix = "PBKDF2-SHA256$";

	/// <summary>Iterazioni per i nuovi hash (raccomandazione OWASP per PBKDF2-HMAC-SHA256).</summary>
	public const int DefaultIterations = 600000;

	private const int SaltSize = 16;

	private const int HashSize = 32;

	/// <summary>Lunghezza massima di un hash nel formato prodotto (per dimensionare le colonne).</summary>
	public const int MaxHashLength = 100;

	public static string Hash(string password, int iterations = DefaultIterations)
	{
		if (password == null)
		{
			throw new ArgumentNullException(nameof(password));
		}
		if (iterations < 10000)
		{
			throw new ArgumentOutOfRangeException(nameof(iterations));
		}
		byte[] salt = new byte[SaltSize];
		using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
		{
			rng.GetBytes(salt);
		}
		byte[] hash = Derive(password, salt, iterations, HashSize);
		return Prefix + iterations.ToString(CultureInfo.InvariantCulture) + "$" + Convert.ToBase64String(salt) + "$" + Convert.ToBase64String(hash);
	}

	/// <summary>True se il valore salvato e' un hash nel nuovo formato.</summary>
	public static bool IsHash(string stored) => stored != null && stored.StartsWith(Prefix, StringComparison.Ordinal);

	/// <summary>Verifica una password contro un hash (confronto a tempo costante).</summary>
	public static bool Verify(string password, string stored)
	{
		if (password == null || !IsHash(stored))
		{
			return false;
		}
		string[] parts = stored.Split('$');
		if (parts.Length != 4 || !int.TryParse(parts[1], NumberStyles.None, CultureInfo.InvariantCulture, out int iterations) || iterations < 1)
		{
			return false;
		}
		byte[] salt;
		byte[] expected;
		try
		{
			salt = Convert.FromBase64String(parts[2]);
			expected = Convert.FromBase64String(parts[3]);
		}
		catch (FormatException)
		{
			return false;
		}
		byte[] actual = Derive(password, salt, iterations, expected.Length);
		return FixedTimeEquals(actual, expected);
	}

	/// <summary>True se l'hash usa meno iterazioni di quelle attuali e conviene rigenerarlo.</summary>
	public static bool NeedsRehash(string stored)
	{
		if (!IsHash(stored))
		{
			return true;
		}
		string[] parts = stored.Split('$');
		return parts.Length != 4 || !int.TryParse(parts[1], NumberStyles.None, CultureInfo.InvariantCulture, out int iterations) || iterations < DefaultIterations;
	}

	/// <summary>Confronto a tempo costante di due stringhe (per segreti in chiaro).</summary>
	public static bool FixedTimeEquals(string a, string b)
	{
		if (a == null || b == null)
		{
			return false;
		}
		return FixedTimeEquals(Encoding.UTF8.GetBytes(a), Encoding.UTF8.GetBytes(b));
	}

	private static bool FixedTimeEquals(byte[] a, byte[] b)
	{
		if (a.Length != b.Length)
		{
			return false;
		}
		int diff = 0;
		for (int i = 0; i < a.Length; i++)
		{
			diff |= a[i] ^ b[i];
		}
		return diff == 0;
	}

	private static byte[] Derive(string password, byte[] salt, int iterations, int length)
	{
		using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(Encoding.UTF8.GetBytes(password), salt, iterations, HashAlgorithmName.SHA256))
		{
			return pbkdf2.GetBytes(length);
		}
	}
}
