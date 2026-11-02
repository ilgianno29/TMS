using System;
using Incasbo.Web.Library;
using Microsoft.Data.SqlClient;

namespace Incasbo.Web.WFI;

/// <summary>
/// Token di autologin per dispositivi (totem, monitor di reparto) al posto di utente e password nell'indirizzo.
/// <list type="bullet">
/// <item>Il token e' casuale (256 bit) e viene mostrato una sola volta alla creazione.</item>
/// <item>Nel database (WFI_AUTOLOGIN_TOKEN) si salva solo il suo hash SHA-256: chi legge la tabella non puo' usarlo.</item>
/// <item>Ogni token e' legato a un utente, puo' avere una scadenza ed essere revocato (Attivo='N').</item>
/// </list>
/// Creazione/elenco/revoca: strumento DelsyPassword (comandi autologin-*).
/// </summary>
public static class AutoLoginTokens
{
	public sealed class TokenInfo
	{
		public int Id { get; set; }

		public string Utente { get; set; }

		public string Pagina { get; set; }
	}

	public static string NewToken() => Incasbo.Security.DeviceTokens.NewToken();

	public static string Hash(string token) => Incasbo.Security.DeviceTokens.Hash(token);

	/// <summary>Cerca un token valido (attivo e non scaduto) e ne registra l'uso. Null se non valido.</summary>
	public static TokenInfo Find(WFIDbConnectionConfig db, string token, string clientIp)
	{
		if (db == null || string.IsNullOrWhiteSpace(token) || token.Length > 200)
		{
			return null;
		}
		string connectionString = DBConnection.BuildSqlServerConnectionString(db.DB_Server, db.DB_Database, db.DB_Username, db.DB_Password, db.DB_UseIntegratedSecurity, db.DB_TimeOut);
		using (SqlConnection connection = new SqlConnection(connectionString))
		{
			connection.Open();
			TokenInfo info = null;
			using (SqlCommand select = new SqlCommand("SELECT Id, Utente, Pagina FROM dbo.WFI_AUTOLOGIN_TOKEN WHERE TokenHash = @h AND Attivo = 'S' AND (Scadenza IS NULL OR Scadenza > GETDATE())", connection))
			{
				select.Parameters.AddWithValue("@h", Hash(token));
				using (SqlDataReader reader = select.ExecuteReader())
				{
					if (reader.Read())
					{
						info = new TokenInfo
						{
							Id = reader.GetInt32(0),
							Utente = reader.GetString(1),
							Pagina = reader.IsDBNull(2) ? "" : reader.GetString(2)
						};
					}
				}
			}
			if (info != null)
			{
				using (SqlCommand update = new SqlCommand("UPDATE dbo.WFI_AUTOLOGIN_TOKEN SET UltimoUso = GETDATE(), UltimoIP = @ip WHERE Id = @id", connection))
				{
					update.Parameters.AddWithValue("@ip", clientIp ?? "");
					update.Parameters.AddWithValue("@id", info.Id);
					update.ExecuteNonQuery();
				}
			}
			return info;
		}
	}
}
