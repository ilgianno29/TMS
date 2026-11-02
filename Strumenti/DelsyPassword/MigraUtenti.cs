using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Incasbo.Security;
using Microsoft.Data.SqlClient;

/// <summary>Conversione massiva delle password utenti dal vecchio formato (cifrato/in chiaro) all'hash PBKDF2.</summary>
internal static class MigraUtenti
{
	public static int Run(string[] args)
	{
		string? connessione = Option(args, "--connessione");
		string tabella = Option(args, "--tabella") ?? "WFI_UTENTI";
		bool cifratura = !string.Equals(Option(args, "--cifratura"), "false", StringComparison.OrdinalIgnoreCase);
		bool esegui = Array.Exists(args, a => a == "--esegui");
		if (string.IsNullOrWhiteSpace(connessione))
		{
			Console.Error.WriteLine("Indicare --connessione \"...\" (stringa di connessione SQL Server).");
			return 1;
		}
		if (!Regex.IsMatch(tabella, "^[A-Za-z_][A-Za-z0-9_]*$"))
		{
			Console.Error.WriteLine("Nome tabella non valido.");
			return 1;
		}

		using SqlConnection db = new SqlConnection(connessione);
		db.Open();

		// La colonna deve contenere l'hash (fino a 100 caratteri)
		using (SqlCommand len = new SqlCommand("SELECT COL_LENGTH(@t, 'PASSWORD'), TYPE_NAME(c.system_type_id) FROM sys.columns c WHERE c.object_id = OBJECT_ID(@t) AND c.name = 'PASSWORD'", db))
		{
			len.Parameters.AddWithValue("@t", tabella);
			using SqlDataReader r = len.ExecuteReader();
			if (!r.Read())
			{
				Console.Error.WriteLine($"Colonna {tabella}.PASSWORD non trovata.");
				return 1;
			}
			int bytes = Convert.ToInt32(r.GetValue(0));
			string type = r.GetString(1);
			int chars = type.StartsWith("n", StringComparison.OrdinalIgnoreCase) ? bytes / 2 : bytes;
			if (bytes != -1 && chars < PasswordHasher.MaxHashLength)
			{
				Console.Error.WriteLine($"La colonna PASSWORD e' di {chars} caratteri: eseguire prima Database/2026-11_01_password_hash.sql.");
				return 1;
			}
		}

		List<(string Codice, string Hash)> daAggiornare = new List<(string, string)>();
		int gia = 0, vuote = 0, nonConvertibili = 0;
		using (SqlCommand sel = new SqlCommand($"SELECT CODICE, PASSWORD FROM dbo.{tabella}", db))
		using (SqlDataReader r = sel.ExecuteReader())
		{
			while (r.Read())
			{
				string codice = r.GetString(0);
				string? stored = r.IsDBNull(1) ? null : r.GetString(1);
				if (string.IsNullOrEmpty(stored)) { vuote++; continue; }
				if (PasswordHasher.IsHash(stored)) { gia++; continue; }
				string? hash = UserPasswords.UpgradeLegacy(stored, cifratura);
				if (hash == null) { nonConvertibili++; Console.WriteLine($"  NON convertibile: {codice}"); continue; }
				daAggiornare.Add((codice, hash));
			}
		}

		Console.WriteLine($"Gia' convertite: {gia}  Da convertire: {daAggiornare.Count}  Vuote: {vuote}  Non convertibili: {nonConvertibili}");
		if (!esegui)
		{
			Console.WriteLine("Prova: nessuna modifica. Aggiungere --esegui per applicare.");
			return 0;
		}

		using SqlTransaction tx = db.BeginTransaction();
		foreach ((string codice, string hash) in daAggiornare)
		{
			// Aggiorna solo se il valore non e' cambiato nel frattempo (es. login concorrente)
			using SqlCommand upd = new SqlCommand($"UPDATE dbo.{tabella} SET PASSWORD = @h WHERE CODICE = @c AND PASSWORD NOT LIKE 'PBKDF2-SHA256$%'", db, tx);
			upd.Parameters.AddWithValue("@h", hash);
			upd.Parameters.AddWithValue("@c", codice);
			upd.ExecuteNonQuery();
		}
		tx.Commit();
		Console.WriteLine($"Convertite {daAggiornare.Count} password.");
		return 0;
	}

	private static string? Option(string[] args, string name)
	{
		int i = Array.IndexOf(args, name);
		return i >= 0 && i + 1 < args.Length ? args[i + 1] : null;
	}
}
