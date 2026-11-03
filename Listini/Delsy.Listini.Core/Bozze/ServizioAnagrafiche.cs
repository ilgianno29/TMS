using Delsy.Listini.Dati;

namespace Delsy.Listini.Bozze;

public sealed record VoceAnagrafica(string Codice, string Descrizione);

/// <summary>Codici da anagrafica per controlli ed elenchi a discesa dell'editor.</summary>
public sealed class ServizioAnagrafiche
{
	private readonly Db _db;

	public ServizioAnagrafiche(Db db) => _db = db;

	/// <summary>Da quale tabella prendere i valori validi di ogni criterio della tariffa.</summary>
	private static readonly Dictionary<string, string> Sorgenti = new(StringComparer.OrdinalIgnoreCase)
	{
		["TipoDocumento"] = "SELECT Codice, Descrizione FROM TariffeTipiDocumento WHERE TariffaPassiva = 'S'",
		["TipoSpedizione"] = "SELECT Codice, Descrizione FROM TipiSpedizione",
		["TipoMerce"] = "SELECT Codice, Descrizione FROM TipiMerce",
		["TipoMezzo"] = "SELECT Codice, Descrizione FROM TipiMezzo",
		["Cliente"] = "SELECT Codice, RagioneSociale AS Descrizione FROM Clienti",
		["GruppoTariffarioPartenza"] = "SELECT Codice, Descrizione FROM PCS_GruppiTariffari",
		["PCSPartenza"] = "SELECT Codice, RagioneSociale AS Descrizione FROM PCS",
		["MacroZonaArrivo"] = "SELECT Codice, Descrizione FROM ZoneMacro",
		["ZonaArrivo"] = "SELECT Codice, Descrizione FROM Zone",
		["GruppoTariffarioArrivo"] = "SELECT Codice, Descrizione FROM PCS_GruppiTariffari",
		["PCSArrivo"] = "SELECT Codice, RagioneSociale AS Descrizione FROM PCS"
	};

	public IReadOnlyList<VoceAnagrafica> Elenco(string criterio) =>
		_db.Righe(Sorgenti[criterio] + " ORDER BY Codice").Select(r => new VoceAnagrafica(r.Testo("Codice"), r.Testo("Descrizione"))).ToList();

	public IReadOnlyList<VoceAnagrafica> Vettori() =>
		_db.Righe("SELECT Codice, RagioneSociale FROM Trasportatori WHERE ISNULL(Attivo, 'S') <> 'N' ORDER BY Codice")
			.Select(r => new VoceAnagrafica(r.Testo("Codice"), r.Testo("RagioneSociale"))).ToList();

	public IReadOnlyList<VoceAnagrafica> Voci() =>
		_db.Righe("SELECT Codice, Descrizione FROM Voci WHERE ISNULL(Attivo, 'S') <> 'N' AND (Viaggio = 'S' OR Spedizione = 'S') ORDER BY Codice")
			.Select(r => new VoceAnagrafica(r.Testo("Codice"), r.Testo("Descrizione"))).ToList();

	/// <summary>Basi di calcolo: colonne numeriche dei documenti che il motore tariffa (viaggi e spedizioni).</summary>
	public IReadOnlyList<string> CampiCalcolo() =>
		_db.Righe(@"
SELECT DISTINCT c.name FROM sys.columns c
WHERE c.object_id IN (OBJECT_ID('TAR_PAS_TourDocument'), OBJECT_ID('TAR_PAS_ShippingDocument'))
  AND TYPE_NAME(c.system_type_id) IN ('int', 'bigint', 'smallint', 'decimal', 'numeric', 'float', 'real', 'money')
  AND c.name NOT LIKE 'Id%' AND c.name NOT IN ('Stato', 'StatoWMS', 'StatoSpuntaUscita', 'ProgressivoConsegna')
ORDER BY c.name").Select(r => r.Testo("name")).ToList();

	public Anagrafiche PerControlli() => new()
	{
		Trasportatori = Anagrafiche.Nuovo(_db.Righe("SELECT Codice FROM Trasportatori").Select(r => r.Testo("Codice"))),
		Contratti = Anagrafiche.Nuovo(_db.Righe("SELECT Codice FROM TariffeContratti").Select(r => r.Testo("Codice"))),
		Voci = Anagrafiche.Nuovo(Voci().Select(v => v.Codice)),
		CampiCalcolo = Anagrafiche.Nuovo(CampiCalcolo()),
		Criteri = Sorgenti.Keys.ToDictionary(k => k, k => Anagrafiche.Nuovo(Elenco(k).Select(v => v.Codice)), StringComparer.OrdinalIgnoreCase)
	};
}
