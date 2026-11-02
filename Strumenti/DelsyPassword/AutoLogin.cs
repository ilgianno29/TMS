using System;
using Incasbo.Security;
using Microsoft.Data.SqlClient;

/// <summary>Gestione dei token di autologin (tabella WFI_AUTOLOGIN_TOKEN).</summary>
internal static class AutoLogin
{
	public static int Run(string command, string[] args)
	{
		string? connessione = Option(args, "--connessione");
		if (string.IsNullOrWhiteSpace(connessione))
		{
			Console.Error.WriteLine("Indicare --connessione \"...\" (stringa di connessione SQL Server).");
			return 1;
		}
		using SqlConnection db = new SqlConnection(connessione);
		db.Open();
		switch (command)
		{
			case "autologin-crea":
			{
				string? utente = Option(args, "--utente");
				string? descrizione = Option(args, "--descrizione");
				string? pagina = Option(args, "--pagina");
				string? scadenza = Option(args, "--scadenza");
				string url = Option(args, "--url") ?? "http://SERVER/WFI/Form/WFIAutoLogin.aspx";
				if (string.IsNullOrWhiteSpace(utente) || string.IsNullOrWhiteSpace(descrizione))
				{
					Console.Error.WriteLine("Indicare --utente e --descrizione (es. \"Totem magazzino 1\").");
					return 1;
				}
				if (!string.IsNullOrEmpty(pagina) && !SafeRedirect.IsLocal(pagina))
				{
					Console.Error.WriteLine("--pagina deve essere un indirizzo interno (es. ~/wfi/Form/WFStandardGrid.aspx?nomrif=...).");
					return 1;
				}
				DateTime? scad = null;
				if (!string.IsNullOrEmpty(scadenza))
				{
					if (!DateTime.TryParse(scadenza, System.Globalization.CultureInfo.GetCultureInfo("it-IT"), System.Globalization.DateTimeStyles.None, out DateTime d))
					{
						Console.Error.WriteLine("--scadenza non valida (es. 31/12/2027).");
						return 1;
					}
					scad = d;
				}
				string token = DeviceTokens.NewToken();
				using SqlCommand ins = new SqlCommand("INSERT INTO dbo.WFI_AUTOLOGIN_TOKEN (TokenHash, Utente, Descrizione, Pagina, Scadenza, UteIns) OUTPUT INSERTED.Id VALUES (@h, @u, @d, @p, @s, @ui)", db);
				ins.Parameters.AddWithValue("@h", DeviceTokens.Hash(token));
				ins.Parameters.AddWithValue("@u", utente.ToUpperInvariant());
				ins.Parameters.AddWithValue("@d", descrizione);
				ins.Parameters.AddWithValue("@p", (object?)pagina ?? DBNull.Value);
				ins.Parameters.AddWithValue("@s", (object?)scad ?? DBNull.Value);
				ins.Parameters.AddWithValue("@ui", "DELSYPWD");
				int id = Convert.ToInt32(ins.ExecuteScalar());
				Console.WriteLine($"Token creato (Id {id}) per {utente.ToUpperInvariant()} - {descrizione}");
				Console.WriteLine("Copiare ORA l'indirizzo: il token non verra' piu' mostrato.");
				Console.WriteLine(url + "?t=" + token);
				return 0;
			}
			case "autologin-elenca":
			{
				using SqlCommand sel = new SqlCommand("SELECT Id, Utente, Descrizione, Attivo, Scadenza, UltimoUso, UltimoIP FROM dbo.WFI_AUTOLOGIN_TOKEN ORDER BY Id", db);
				using SqlDataReader r = sel.ExecuteReader();
				Console.WriteLine("Id | Utente | Descrizione | Attivo | Scadenza | Ultimo uso | Ultimo IP");
				while (r.Read())
				{
					Console.WriteLine($"{r.GetInt32(0)} | {r.GetString(1)} | {r.GetString(2)} | {r.GetString(3)} | {(r.IsDBNull(4) ? "-" : r.GetDateTime(4).ToString("dd/MM/yyyy"))} | {(r.IsDBNull(5) ? "-" : r.GetDateTime(5).ToString("dd/MM/yyyy HH:mm"))} | {(r.IsDBNull(6) ? "-" : r.GetString(6))}");
				}
				return 0;
			}
			case "autologin-revoca":
			{
				if (!int.TryParse(Option(args, "--id"), out int id))
				{
					Console.Error.WriteLine("Indicare --id (vedi autologin-elenca).");
					return 1;
				}
				using SqlCommand upd = new SqlCommand("UPDATE dbo.WFI_AUTOLOGIN_TOKEN SET Attivo = 'N' WHERE Id = @id", db);
				upd.Parameters.AddWithValue("@id", id);
				Console.WriteLine(upd.ExecuteNonQuery() == 1 ? $"Token {id} revocato." : $"Token {id} non trovato.");
				return 0;
			}
			default:
				Console.Error.WriteLine("Comando sconosciuto: " + command);
				return 1;
		}
	}

	private static string? Option(string[] args, string name)
	{
		int i = Array.IndexOf(args, name);
		return i >= 0 && i + 1 < args.Length ? args[i + 1] : null;
	}
}
