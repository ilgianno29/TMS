using Delsy.Listini.Dati;
using Delsy.Listini.Spiegazione;
using Microsoft.Data.SqlClient;

namespace Delsy.Listini.Bozze;

/// <summary>Lettura e scrittura dei listini nelle tabelle usate dal motore (TariffeContratti, TariffePassiveTestata/Voci/Fasce).</summary>
public static class ArchivioListini
{
	public static ListinoModificabile? Carica(SqlConnection c, SqlTransaction? tx, string codice)
	{
		Dictionary<string, object?>? r = Db.Righe(c, tx,
			"SELECT * FROM TariffeContratti WHERE Codice = @c AND AttivaPassiva = 'P'", ("@c", codice)).FirstOrDefault();
		if (r == null) return null;
		ListinoModificabile l = new()
		{
			Contratto = new DatiContratto
			{
				Codice = r.Testo("Codice"), Descrizione = r.Testo("Descrizione"), Trasportatore = r.Testo("Trasportatore"),
				DataInizio = r.Data("DataInizioValidita")!.Value.Date, DataFine = r.Data("DataFineValidita")!.Value.Date,
				Arrotondamento = r.Numero("ArrotondamentoImporti"), Attivo = r.Testo("Attivo") != "N"
			}
		};
		List<Dictionary<string, object?>> fasce = Db.Righe(c, tx, @"
SELECT F.* FROM TariffePassiveFasce F JOIN TariffePassiveVoci V ON V.IdVoce = F.IdVoce JOIN TariffePassiveTestata T ON T.IdTariffa = V.IdTariffa
WHERE T.Contratto = @c", ("@c", codice));
		List<Dictionary<string, object?>> voci = Db.Righe(c, tx, @"
SELECT V.* FROM TariffePassiveVoci V JOIN TariffePassiveTestata T ON T.IdTariffa = V.IdTariffa WHERE T.Contratto = @c", ("@c", codice));
		ILookup<int, FasciaModificabile> fPerVoce = fasce.ToLookup(f => Convert.ToInt32(f["IdVoce"]), f => new FasciaModificabile
		{
			IdFascia = Convert.ToInt32(f["IdFascia"]), Da = f.Numero("FasciaInferiore"), A = f.Numero("FasciaSuperiore"),
			Fisso = f.Numero("Fisso"), Variabile = f.Numero("Variabile"), Percentuale = f.Numero("Percentuale")
		});
		ILookup<int, VoceModificabile> vPerTariffa = voci.ToLookup(v => Convert.ToInt32(v["IdTariffa"]), v => new VoceModificabile
		{
			IdVoce = Convert.ToInt32(v["IdVoce"]), Voce = v.Testo("Voce"), CampoCalcolo = v.Testo("CampoCalcolo"), Eccedenza = v.Testo("flgEccedenza"),
			Fasce = fPerVoce[Convert.ToInt32(v["IdVoce"])].OrderBy(f => f.Da).ToList()
		});
		foreach (Dictionary<string, object?> t in Db.Righe(c, tx, "SELECT * FROM TariffePassiveTestata WHERE Contratto = @c ORDER BY IdTariffa", ("@c", codice)))
		{
			int id = Convert.ToInt32(t["IdTariffa"]);
			TariffaModificabile tm = new() { IdTariffa = id, Chiave = ChiaveDaId(id), Voci = vPerTariffa[id].OrderBy(v => v.IdVoce).ToList() };
			foreach ((string nome, _) in CriteriTariffa.Elenco) tm.ImpostaCriterio(nome, t.Testo(nome));
			l.Tariffe.Add(tm);
		}
		return l;
	}

	/// <summary>Chiave stabile per le tariffe esistenti, così le modifiche si ritrovano tra un salvataggio e l'altro.</summary>
	public static Guid ChiaveDaId(int id) => new Guid(id, 0, 0, new byte[8]);

	/// <summary>Prossimo valore di un contatore Delsy (stessa logica di IboWebParam.LeggiContatore), dentro la transazione.</summary>
	public static int Contatore(SqlConnection c, SqlTransaction tx, string nome)
	{
		using SqlCommand cmd = Db.Comando(c, tx, @"
DECLARE @f varchar(6) = (SELECT TOP 1 Filiale FROM VW_WFI_PARAMETRICA WHERE Nome = @n AND TipoDato = 'CONT');
IF @f IS NULL THROW 50001, 'Contatore non trovato in Parametrica.', 1;
UPDATE WFI_PARAMETRICA SET Valore = CAST(CAST(Valore AS bigint) + 1 AS varchar(255))
OUTPUT inserted.Valore WHERE Nome = @n AND Filiale = @f;", ("@n", nome));
		return Convert.ToInt32(cmd.ExecuteScalar());
	}

	public const string ContatoreTestata = "COUNTERS.TRA.TARIFFEPASSIVE.TESTATA";
	public const string ContatoreVoci = "COUNTERS.TRA.TARIFFEPASSIVE.VOCI";
	public const string ContatoreFasce = "COUNTERS.TRA.TARIFFEPASSIVE.FASCE";

	public static void InserisciContratto(SqlConnection c, SqlTransaction tx, DatiContratto d, string utente) =>
		Esegui(c, tx, @"
INSERT INTO TariffeContratti (Codice, AttivaPassiva, Trasportatore, ContrattoTrasporto, Descrizione, Attivo, DataInizioValidita, DataFineValidita,
  ArrotondamentoImporti, UteIns, UteAgg, DatIns, DatAgg)
VALUES (@c, 'P', @t, 'S', @d, @a, @i, @f, @r, @u, @u, GETDATE(), GETDATE())",
			("@c", d.Codice.Trim()), ("@t", d.Trasportatore.Trim()), ("@d", d.Descrizione.Trim()), ("@a", d.Attivo ? "S" : "N"),
			("@i", d.DataInizio.Date), ("@f", d.DataFine.Date), ("@r", d.Arrotondamento), ("@u", utente));

	public static void AggiornaContratto(SqlConnection c, SqlTransaction tx, DatiContratto d, string utente) =>
		Esegui(c, tx, @"
UPDATE TariffeContratti SET Trasportatore = @t, Descrizione = @d, Attivo = @a, DataInizioValidita = @i, DataFineValidita = @f,
  ArrotondamentoImporti = @r, UteAgg = @u, DatAgg = GETDATE()
WHERE Codice = @c AND AttivaPassiva = 'P'",
			("@c", d.Codice.Trim()), ("@t", d.Trasportatore.Trim()), ("@d", d.Descrizione.Trim()), ("@a", d.Attivo ? "S" : "N"),
			("@i", d.DataInizio.Date), ("@f", d.DataFine.Date), ("@r", d.Arrotondamento), ("@u", utente));

	public static void ChiudiContratto(SqlConnection c, SqlTransaction tx, ChiusuraContratto ch, string utente) =>
		Esegui(c, tx, "UPDATE TariffeContratti SET DataFineValidita = @f, UteAgg = @u, DatAgg = GETDATE() WHERE Codice = @c AND AttivaPassiva = 'P'",
			("@c", ch.Codice), ("@f", ch.NuovaDataFine.Date), ("@u", utente));

	/// <summary>Scrive una tariffa nuova con voci e fasce; restituisce l'IdTariffa assegnato.</summary>
	public static int InserisciTariffa(SqlConnection c, SqlTransaction tx, string contratto, TariffaModificabile t, string utente)
	{
		int id = Contatore(c, tx, ContatoreTestata);
		Esegui(c, tx, $@"
INSERT INTO TariffePassiveTestata (IdTariffa, Contratto, {string.Join(", ", CriteriTariffa.Elenco.Select(e => e.Nome))}, UteIns, UteAgg, DatIns, DatAgg)
VALUES (@id, @c, {string.Join(", ", CriteriTariffa.Elenco.Select(e => "@" + e.Nome))}, @u, @u, GETDATE(), GETDATE())",
			ParametriCriteri(t).Append(("@id", id)).Append(("@c", contratto)).Append(("@u", utente)).ToArray());
		foreach (VoceModificabile v in t.Voci) InserisciVoce(c, tx, id, v, utente);
		return id;
	}

	public static void AggiornaTariffa(SqlConnection c, SqlTransaction tx, TariffaModificabile prima, TariffaModificabile dopo, string utente)
	{
		int id = dopo.IdTariffa!.Value;
		Esegui(c, tx, $@"UPDATE TariffePassiveTestata SET {string.Join(", ", CriteriTariffa.Elenco.Select(e => $"{e.Nome} = @{e.Nome}"))},
  UteAgg = @u, DatAgg = GETDATE() WHERE IdTariffa = @id",
			ParametriCriteri(dopo).Append(("@id", id)).Append(("@u", utente)).ToArray());

		HashSet<int> vociRimaste = new();
		foreach (VoceModificabile v in dopo.Voci)
		{
			VoceModificabile? vp = v.IdVoce == null ? null : prima.Voci.FirstOrDefault(x => x.IdVoce == v.IdVoce);
			if (vp == null)
			{
				InserisciVoce(c, tx, id, v, utente);
				continue;
			}
			vociRimaste.Add(vp.IdVoce!.Value);
			Esegui(c, tx, "UPDATE TariffePassiveVoci SET Voce = @v, CampoCalcolo = @cc, flgEccedenza = @e, UteAgg = @u, DatAgg = GETDATE() WHERE IdVoce = @id",
				("@v", v.Voce.Trim().ToUpperInvariant()), ("@cc", v.CampoCalcolo.Trim()), ("@e", Eccedenza(v)), ("@u", utente), ("@id", vp.IdVoce));
			HashSet<int> fasceRimaste = new();
			foreach (FasciaModificabile f in v.Fasce)
			{
				if (f.IdFascia is int idf && vp.Fasce.Any(x => x.IdFascia == idf))
				{
					fasceRimaste.Add(idf);
					Esegui(c, tx, @"UPDATE TariffePassiveFasce SET FasciaInferiore = @da, FasciaSuperiore = @a, Fisso = @fi, Variabile = @va, Percentuale = @pe,
  UteAgg = @u, DatAgg = GETDATE() WHERE IdFascia = @id",
						("@da", f.Da), ("@a", f.A), ("@fi", f.Fisso), ("@va", f.Variabile), ("@pe", f.Percentuale), ("@u", utente), ("@id", idf));
				}
				else InserisciFascia(c, tx, vp.IdVoce!.Value, f, utente);
			}
			foreach (FasciaModificabile f in vp.Fasce.Where(x => !fasceRimaste.Contains(x.IdFascia!.Value)))
				Esegui(c, tx, "DELETE FROM TariffePassiveFasce WHERE IdFascia = @id", ("@id", f.IdFascia));
		}
		foreach (VoceModificabile v in prima.Voci.Where(x => !vociRimaste.Contains(x.IdVoce!.Value)))
		{
			Esegui(c, tx, "DELETE FROM TariffePassiveFasce WHERE IdVoce = @id", ("@id", v.IdVoce));
			Esegui(c, tx, "DELETE FROM TariffePassiveVoci WHERE IdVoce = @id", ("@id", v.IdVoce));
		}
	}

	public static void EliminaTariffa(SqlConnection c, SqlTransaction tx, int idTariffa)
	{
		Esegui(c, tx, "DELETE F FROM TariffePassiveFasce F JOIN TariffePassiveVoci V ON V.IdVoce = F.IdVoce WHERE V.IdTariffa = @id", ("@id", idTariffa));
		Esegui(c, tx, "DELETE FROM TariffePassiveVoci WHERE IdTariffa = @id", ("@id", idTariffa));
		Esegui(c, tx, "DELETE FROM TariffePassiveTestata WHERE IdTariffa = @id", ("@id", idTariffa));
	}

	private static void InserisciVoce(SqlConnection c, SqlTransaction tx, int idTariffa, VoceModificabile v, string utente)
	{
		int id = Contatore(c, tx, ContatoreVoci);
		Esegui(c, tx, @"INSERT INTO TariffePassiveVoci (IdVoce, IdTariffa, Voce, CampoCalcolo, flgEccedenza, UteIns, UteAgg, DatIns, DatAgg)
VALUES (@id, @t, @v, @cc, @e, @u, @u, GETDATE(), GETDATE())",
			("@id", id), ("@t", idTariffa), ("@v", v.Voce.Trim().ToUpperInvariant()), ("@cc", v.CampoCalcolo.Trim()), ("@e", Eccedenza(v)), ("@u", utente));
		foreach (FasciaModificabile f in v.Fasce) InserisciFascia(c, tx, id, f, utente);
	}

	private static void InserisciFascia(SqlConnection c, SqlTransaction tx, int idVoce, FasciaModificabile f, string utente)
	{
		int id = Contatore(c, tx, ContatoreFasce);
		Esegui(c, tx, @"INSERT INTO TariffePassiveFasce (IdFascia, IdVoce, FasciaInferiore, FasciaSuperiore, Fisso, Variabile, Percentuale, UteIns, UteAgg, DatIns, DatAgg)
VALUES (@id, @v, @da, @a, @fi, @va, @pe, @u, @u, GETDATE(), GETDATE())",
			("@id", id), ("@v", idVoce), ("@da", f.Da), ("@a", f.A), ("@fi", f.Fisso), ("@va", f.Variabile), ("@pe", f.Percentuale), ("@u", utente));
	}

	private static string Eccedenza(VoceModificabile v) => string.IsNullOrWhiteSpace(v.Eccedenza) ? "N" : v.Eccedenza.Trim().ToUpperInvariant()[..1];

	private static IEnumerable<(string, object?)> ParametriCriteri(TariffaModificabile t) =>
		CriteriTariffa.Elenco.Select(e => ("@" + e.Nome, (object?)t.Criterio(e.Nome)));

	private static void Esegui(SqlConnection c, SqlTransaction tx, string sql, params (string, object?)[] p)
	{
		using SqlCommand cmd = Db.Comando(c, tx, sql, p);
		cmd.ExecuteNonQuery();
	}
}
