using System.Text.Json;
using Delsy.Listini.Dati;
using Microsoft.Data.SqlClient;

namespace Delsy.Listini.Registro;

public sealed record VoceRegistro(long Id, DateTime DataOra, string Utente, string Azione, string Contratto, int? IdBozza,
	string Descrizione, string? Dettaglio, string Postazione);

/// <summary>Registro delle modifiche ai listini (TAR_Registro): si può solo aggiungere.</summary>
public sealed class RegistroListini
{
	private readonly Db _db;

	public RegistroListini(Db db) => _db = db;

	/// <summary>Scrive una voce nel registro, nella transazione indicata (così modifica e registro vanno o non vanno insieme).</summary>
	public static void Scrivi(SqlConnection c, SqlTransaction? tx, string utente, string azione, string descrizione,
		string? contratto = null, int? idBozza = null, object? dettaglio = null, string? postazione = null)
	{
		using SqlCommand cmd = Db.Comando(c, tx, @"
INSERT INTO TAR_Registro (Utente, Azione, Contratto, IdBozza, Descrizione, Dettaglio, Postazione)
VALUES (@u, @a, @c, @b, @d, @j, @p)",
			("@u", utente), ("@a", azione), ("@c", contratto), ("@b", idBozza), ("@d", descrizione),
			("@j", dettaglio == null ? null : JsonSerializer.Serialize(dettaglio)), ("@p", postazione));
		cmd.ExecuteNonQuery();
	}

	public void Scrivi(string utente, string azione, string descrizione, string? contratto = null, int? idBozza = null,
		object? dettaglio = null, string? postazione = null)
	{
		using SqlConnection c = _db.Apri();
		Scrivi(c, null, utente, azione, descrizione, contratto, idBozza, dettaglio, postazione);
	}

	public IReadOnlyList<VoceRegistro> Cerca(string? testo = null, string? utente = null, string? azione = null,
		DateTime? dal = null, DateTime? al = null, int massimo = 500)
	{
		return _db.Righe(@"
SELECT TOP (@max) * FROM TAR_Registro
WHERE (@t IS NULL OR Descrizione LIKE '%' + @t + '%' OR Contratto LIKE '%' + @t + '%')
  AND (@u IS NULL OR Utente = @u)
  AND (@a IS NULL OR Azione = @a)
  AND (@dal IS NULL OR DataOra >= @dal)
  AND (@al IS NULL OR DataOra < DATEADD(day, 1, @al))
ORDER BY IdRegistro DESC",
			("@max", massimo), ("@t", Vuoto(testo)), ("@u", Vuoto(utente)), ("@a", Vuoto(azione)), ("@dal", dal), ("@al", al))
			.Select(r => new VoceRegistro(Convert.ToInt64(r["IdRegistro"]), (DateTime)r["DataOra"]!, r.Testo("Utente"), r.Testo("Azione"),
				r.Testo("Contratto"), r["IdBozza"] as int?, r.Testo("Descrizione"), r["Dettaglio"] as string, r.Testo("Postazione")))
			.ToList();
	}

	private static string? Vuoto(string? s) => string.IsNullOrWhiteSpace(s) ? null : s.Trim();
}
