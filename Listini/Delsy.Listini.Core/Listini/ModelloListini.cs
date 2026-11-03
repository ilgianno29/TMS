namespace Delsy.Listini.Listini;

/// <summary>Riepilogo di un contratto passivo (listino di un vettore).</summary>
public sealed record ContrattoListino(string Codice, string Descrizione, string Trasportatore, string NomeTrasportatore,
	DateTime? DataInizio, DateTime? DataFine, bool Attivo, int Tariffe, DateTime? UltimaModifica, string ModificatoDa, int BozzeAperte)
{
	public string StatoValidita(DateTime oggi) =>
		!Attivo ? "Disattivo"
		: DataInizio > oggi ? "Futuro"
		: DataFine < oggi ? "Scaduto"
		: DataFine < oggi.AddDays(60) ? "In scadenza"
		: "Valido";
}

public sealed record FasciaListino(int IdFascia, decimal Da, decimal A, decimal Fisso, decimal Variabile, decimal Percentuale);

public sealed record VoceListino(int IdVoce, string Voce, string DescrizioneVoce, string CampoCalcolo, string Eccedenza, IReadOnlyList<FasciaListino> Fasce)
{
	/// <summary>Una sola fascia "tutto compreso" con solo importo fisso: è un forfait.</summary>
	public bool Forfait => Fasce.Count == 1 && Fasce[0].Variabile == 0 && Fasce[0].Percentuale == 0;
}

/// <summary>Una testata tariffa: i criteri a cui si applica e le sue voci.</summary>
public sealed record TariffaListino(int IdTariffa, IReadOnlyDictionary<string, string> Criteri, IReadOnlyList<VoceListino> Voci)
{
	public string Criterio(string nome) => Criteri.TryGetValue(nome, out string? v) && !string.IsNullOrWhiteSpace(v) ? v : Spiegazione.CriteriTariffa.Tutti;

	/// <summary>Destinazione leggibile: la più specifica tra PCS, gruppo, zona e macro zona di arrivo.</summary>
	public string Destinazione =>
		Primo("PCSArrivo", "GruppoTariffarioArrivo", "ZonaArrivo", "MacroZonaArrivo") ?? "Tutte";

	public string Partenza => Primo("PCSPartenza", "GruppoTariffarioPartenza") ?? "Tutte";

	private string? Primo(params string[] nomi) =>
		nomi.Select(Criterio).FirstOrDefault(v => v != Spiegazione.CriteriTariffa.Tutti);
}

public sealed record DettaglioContratto(ContrattoListino Contratto, IReadOnlyList<TariffaListino> Tariffe);
