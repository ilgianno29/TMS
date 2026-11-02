using System;
using System.Text;
using Incasbo.Security;

// Strumento da riga di comando per la gestione delle password di Delsy.
//   DelsyPassword hash      -> chiede una password e stampa l'hash da mettere in UtentiTecnici.ini
//   DelsyPassword genera    -> genera una password casuale robusta e ne stampa anche l'hash
//   DelsyPassword migra-utenti --connessione "..." [--cifratura true|false] [--tabella WFI_UTENTI] [--esegui]
//                           -> converte in hash tutte le password utenti ancora nel vecchio formato
//                              (senza --esegui mostra solo cosa farebbe)

if (args.Length == 0 || args[0] is "-h" or "--help" or "aiuto")
{
	Console.WriteLine("Uso:");
	Console.WriteLine("  DelsyPassword hash     Chiede una password e stampa l'hash (PasswordHash=...)");
	Console.WriteLine("  DelsyPassword genera   Genera una password casuale e il relativo hash");
	Console.WriteLine("  DelsyPassword migra-utenti --connessione \"Server=...;Database=...;...\" [--cifratura true|false] [--tabella WFI_UTENTI] [--esegui]");
	Console.WriteLine("                         Converte in hash le password nel vecchio formato. Senza --esegui e' una prova.");
	Console.WriteLine("                         --cifratura = valore di LoginManager/CryptographyEnable (default true).");
	return 0;
}

switch (args[0].ToLowerInvariant())
{
	case "hash":
	{
		string first = ReadSecret("Password: ");
		string second = ReadSecret("Ripeti la password: ");
		if (first != second)
		{
			Console.Error.WriteLine("Le password non coincidono.");
			return 1;
		}
		if (first.Length < 12)
		{
			Console.Error.WriteLine("Password troppo corta: usare almeno 12 caratteri.");
			return 1;
		}
		Console.WriteLine("PasswordHash=" + PasswordHasher.Hash(first));
		return 0;
	}
	case "genera":
	{
		string password = GeneratePassword(24);
		Console.WriteLine("Password (da configurare nel sistema che si collega, es. il WMS): " + password);
		Console.WriteLine("PasswordHash=" + PasswordHasher.Hash(password));
		return 0;
	}
	case "migra-utenti":
		return MigraUtenti.Run(args);
	default:
		Console.Error.WriteLine("Comando sconosciuto: " + args[0]);
		return 1;
}

static string ReadSecret(string prompt)
{
	Console.Write(prompt);
	if (Console.IsInputRedirected)
	{
		return Console.ReadLine() ?? "";
	}
	StringBuilder sb = new StringBuilder();
	while (true)
	{
		ConsoleKeyInfo key = Console.ReadKey(intercept: true);
		if (key.Key == ConsoleKey.Enter)
		{
			Console.WriteLine();
			return sb.ToString();
		}
		if (key.Key == ConsoleKey.Backspace)
		{
			if (sb.Length > 0) sb.Length--;
		}
		else if (!char.IsControl(key.KeyChar))
		{
			sb.Append(key.KeyChar);
		}
	}
}

static string GeneratePassword(int length)
{
	const string alphabet = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz23456789-_.";
	char[] chars = new char[length];
	for (int i = 0; i < length; i++)
	{
		chars[i] = alphabet[System.Security.Cryptography.RandomNumberGenerator.GetInt32(alphabet.Length)];
	}
	return new string(chars);
}
