using System;
using System.Security.Cryptography;

namespace Incasbo.Web.WFI;

/// <summary>
/// Sostituisce la parola magica "__DO_NOT_VERIFY__", usata dalle pagine di login per gli utenti
/// gia' autenticati dal cookie (ricordami). Quella stringa era fissa: con CryptographyEnable=False
/// chiunque poteva digitarla come password ed entrare con qualsiasi utente.
/// Il token e' casuale e cambia a ogni avvio: non puo' essere inviato dall'esterno.
/// </summary>
public static class TrustedLogin
{
	public static string Token { get; } = CreateToken();

	public static bool IsToken(string value) => Incasbo.Security.PasswordHasher.FixedTimeEquals(value, Token);

	private static string CreateToken()
	{
		byte[] bytes = new byte[32];
		using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
		{
			rng.GetBytes(bytes);
		}
		return "trusted-login:" + Convert.ToBase64String(bytes);
	}
}
