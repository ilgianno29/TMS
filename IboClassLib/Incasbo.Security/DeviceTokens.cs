using System;
using System.Security.Cryptography;
using System.Text;

namespace Incasbo.Security;

/// <summary>
/// Token casuali per l'autologin dei dispositivi. Il token va mostrato una sola volta;
/// nel database si salva solo <see cref="Hash"/> (SHA-256: il token ha 256 bit casuali,
/// quindi non serve un hash lento come per le password).
/// </summary>
public static class DeviceTokens
{
	public static string NewToken()
	{
		byte[] bytes = new byte[32];
		using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
		{
			rng.GetBytes(bytes);
		}
		return Convert.ToBase64String(bytes).TrimEnd('=').Replace('+', '-').Replace('/', '_');
	}

	/// <summary>SHA-256 esadecimale minuscolo (64 caratteri), valore della colonna TokenHash.</summary>
	public static string Hash(string token)
	{
		using (SHA256 sha = SHA256.Create())
		{
			byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(token ?? ""));
			StringBuilder sb = new StringBuilder(64);
			foreach (byte b in hash)
			{
				sb.Append(b.ToString("x2"));
			}
			return sb.ToString();
		}
	}
}
