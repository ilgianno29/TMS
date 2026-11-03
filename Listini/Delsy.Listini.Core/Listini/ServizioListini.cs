using Delsy.Listini.Dati;
using Delsy.Listini.Spiegazione;

namespace Delsy.Listini.Listini;

/// <summary>Lettura dei listini passivi in vigore (tabelle usate dal motore).</summary>
public sealed class ServizioListini
{
	private readonly Db _db;

	public ServizioListini(Db db) => _db = db;

	private const string SqlContratti = @"
SELECT C.Codice, C.Descrizione, C.Trasportatore, T.RagioneSociale, C.DataInizioValidita, C.DataFineValidita, C.Attivo,
       (SELECT COUNT(*) FROM TariffePassiveTestata X WHERE X.Contratto = C.Codice) AS Tariffe,
       COALESCE(C.DatAgg, C.DatIns) AS UltimaModifica, COALESCE(C.UteAgg, C.UteIns) AS ModificatoDa,
       (SELECT COUNT(*) FROM TAR_Bozze B WHERE B.Contratto = C.Codice AND B.Stato IN ('BOZZA', 'VALIDAZIONE', 'APPROVATA')) AS BozzeAperte
FROM TariffeContratti C LEFT JOIN Trasportatori T ON T.Codice = C.Trasportatore
WHERE C.AttivaPassiva = 'P'";

	public IReadOnlyList<ContrattoListino> Contratti() =>
		_db.Righe(SqlContratti + " ORDER BY C.Trasportatore, C.DataInizioValidita DESC").Select(Contratto).ToList();

	public DettaglioContratto? Dettaglio(string codice)
	{
		ContrattoListino? c = _db.Righe(SqlContratti + " AND C.Codice = @c", ("@c", codice)).Select(Contratto).FirstOrDefault();
		if (c == null)
		{
			return null;
		}
		List<Dictionary<string, object?>> fasce = _db.Righe(@"
SELECT F.* FROM TariffePassiveFasce F JOIN TariffePassiveVoci V ON V.IdVoce = F.IdVoce JOIN TariffePassiveTestata T ON T.IdTariffa = V.IdTariffa
WHERE T.Contratto = @c ORDER BY F.IdVoce, F.FasciaInferiore", ("@c", codice));
		List<Dictionary<string, object?>> voci = _db.Righe(@"
SELECT V.*, VO.Descrizione AS DescrizioneVoce FROM TariffePassiveVoci V JOIN TariffePassiveTestata T ON T.IdTariffa = V.IdTariffa
LEFT JOIN Voci VO ON VO.Codice = V.Voce WHERE T.Contratto = @c ORDER BY V.IdTariffa, V.IdVoce", ("@c", codice));
		List<Dictionary<string, object?>> testate = _db.Righe("SELECT * FROM TariffePassiveTestata WHERE Contratto = @c ORDER BY IdTariffa", ("@c", codice));

		ILookup<int, FasciaListino> fascePerVoce = fasce.ToLookup(f => Convert.ToInt32(f["IdVoce"]), f => new FasciaListino(
			Convert.ToInt32(f["IdFascia"]), f.Numero("FasciaInferiore"), f.Numero("FasciaSuperiore"), f.Numero("Fisso"), f.Numero("Variabile"), f.Numero("Percentuale")));
		ILookup<int, VoceListino> vociPerTariffa = voci.ToLookup(v => Convert.ToInt32(v["IdTariffa"]), v => new VoceListino(
			Convert.ToInt32(v["IdVoce"]), v.Testo("Voce"), v.Testo("DescrizioneVoce"), v.Testo("CampoCalcolo"), v.Testo("flgEccedenza"),
			fascePerVoce[Convert.ToInt32(v["IdVoce"])].ToList()));

		List<TariffaListino> tariffe = testate.Select(t => new TariffaListino(
			Convert.ToInt32(t["IdTariffa"]),
			CriteriTariffa.Elenco.ToDictionary(e => e.Nome, e => t.Testo(e.Nome), StringComparer.OrdinalIgnoreCase),
			vociPerTariffa[Convert.ToInt32(t["IdTariffa"])].ToList())).ToList();
		return new DettaglioContratto(c, tariffe);
	}

	private static ContrattoListino Contratto(Dictionary<string, object?> r) => new(
		r.Testo("Codice"), r.Testo("Descrizione"), r.Testo("Trasportatore"), r.Testo("RagioneSociale"),
		r.Data("DataInizioValidita"), r.Data("DataFineValidita"), r.Testo("Attivo") != "N", Convert.ToInt32(r["Tariffe"]),
		r.Data("UltimaModifica"), r.Testo("ModificatoDa"), Convert.ToInt32(r["BozzeAperte"]));
}
