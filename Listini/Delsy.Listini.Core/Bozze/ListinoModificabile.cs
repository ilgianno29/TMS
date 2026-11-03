using System.Text.Json;
using System.Text.Json.Serialization;
using Delsy.Listini.Spiegazione;

namespace Delsy.Listini.Bozze;

/// <summary>Dati del contratto modificabili dal modulo listini (le altre colonne di TariffeContratti restano come sono).</summary>
public sealed class DatiContratto
{
	public string Codice { get; set; } = "";
	public string Descrizione { get; set; } = "";
	public string Trasportatore { get; set; } = "";
	public DateTime DataInizio { get; set; } = DateTime.Today;
	public DateTime DataFine { get; set; } = new DateTime(DateTime.Today.Year, 12, 31);
	public decimal Arrotondamento { get; set; } = 0.01m;
	public bool Attivo { get; set; } = true;

	public DatiContratto Copia() => (DatiContratto)MemberwiseClone();

	public bool UgualeA(DatiContratto o) =>
		Codice == o.Codice && Descrizione == o.Descrizione && Trasportatore == o.Trasportatore && DataInizio.Date == o.DataInizio.Date
		&& DataFine.Date == o.DataFine.Date && Arrotondamento == o.Arrotondamento && Attivo == o.Attivo;
}

/// <summary>Una fascia di una voce: da/a sulla base di calcolo, importo fisso, variabile per unità, percentuale.</summary>
public sealed class FasciaModificabile
{
	public int? IdFascia { get; set; }
	public decimal Da { get; set; }
	public decimal A { get; set; }
	public decimal Fisso { get; set; }
	public decimal Variabile { get; set; }
	public decimal Percentuale { get; set; }

	public FasciaModificabile Copia() => (FasciaModificabile)MemberwiseClone();

	[JsonIgnore] public bool TuttoZero => Fisso == 0 && Variabile == 0 && Percentuale == 0;
}

/// <summary>Una voce (NOLO, FUEL, …) di una tariffa con le sue fasce.</summary>
public sealed class VoceModificabile
{
	public const string Forfait = "FORFAIT";

	/// <summary>Limite superiore usato da Delsy per le voci "senza limite" (es. forfait).</summary>
	public const decimal SenzaLimite = 999_999_999m;

	public int? IdVoce { get; set; }
	public string Voce { get; set; } = "NOLO";
	public string CampoCalcolo { get; set; } = Forfait;
	public string Eccedenza { get; set; } = "N";
	public List<FasciaModificabile> Fasce { get; set; } = new();

	public VoceModificabile Copia()
	{
		VoceModificabile v = (VoceModificabile)MemberwiseClone();
		v.Fasce = Fasce.Select(f => f.Copia()).ToList();
		return v;
	}

	/// <summary>Le fasce (da-a) come testo, per raggruppare le righe della griglia con le stesse fasce.</summary>
	[JsonIgnore] public string SchemaFasce => string.Join(" | ", Fasce.OrderBy(f => f.Da).Select(f => $"{f.Da:0.###}-{f.A:0.###}"));
}

/// <summary>Una tariffa: i criteri a cui si applica (partenza, destinazione, merce, …) e le voci.</summary>
public sealed class TariffaModificabile
{
	public int? IdTariffa { get; set; }

	/// <summary>Identificativo stabile anche per le tariffe nuove (non ancora salvate nel listino vero).</summary>
	public Guid Chiave { get; set; } = Guid.NewGuid();

	public Dictionary<string, string> Criteri { get; set; } = CriteriVuoti();

	public List<VoceModificabile> Voci { get; set; } = new();

	public static Dictionary<string, string> CriteriVuoti() =>
		CriteriTariffa.Elenco.ToDictionary(e => e.Nome, _ => CriteriTariffa.Tutti, StringComparer.OrdinalIgnoreCase);

	public string Criterio(string nome) =>
		Criteri.TryGetValue(nome, out string? v) && !string.IsNullOrWhiteSpace(v) ? v.Trim().ToUpperInvariant() : CriteriTariffa.Tutti;

	public void ImpostaCriterio(string nome, string? valore) =>
		Criteri[nome] = string.IsNullOrWhiteSpace(valore) ? CriteriTariffa.Tutti : valore.Trim().ToUpperInvariant();

	/// <summary>Chiave dei criteri: due tariffe dello stesso contratto non possono avere gli stessi criteri (indice univoco di Delsy).</summary>
	[JsonIgnore] public string ChiaveCriteri => string.Join("|", CriteriTariffa.Elenco.Select(e => Criterio(e.Nome)));

	[JsonIgnore] public string Partenza => Primo("PCSPartenza", "GruppoTariffarioPartenza") ?? "Tutte";

	[JsonIgnore] public string Destinazione => Primo("PCSArrivo", "GruppoTariffarioArrivo", "ZonaArrivo", "MacroZonaArrivo") ?? "Tutte";

	/// <summary>Nome breve per messaggi e registro, es. "STDIECIMO → CORTI (SPEDIZIONE)".</summary>
	[JsonIgnore] public string Etichetta
	{
		get
		{
			List<string> extra = new[] { "TipoSpedizione", "TipoMezzo", "TipoMerce", "Cliente" }
				.Select(Criterio).Where(v => v != CriteriTariffa.Tutti).ToList();
			string doc = Criterio("TipoDocumento") == CriteriTariffa.Tutti ? "" : Criterio("TipoDocumento");
			if (doc != "") extra.Insert(0, doc);
			return $"{Partenza} → {Destinazione}" + (extra.Count > 0 ? $" ({string.Join(", ", extra)})" : "");
		}
	}

	private string? Primo(params string[] nomi) => nomi.Select(Criterio).FirstOrDefault(v => v != CriteriTariffa.Tutti);

	public TariffaModificabile Copia()
	{
		TariffaModificabile t = (TariffaModificabile)MemberwiseClone();
		t.Criteri = new Dictionary<string, string>(Criteri, StringComparer.OrdinalIgnoreCase);
		t.Voci = Voci.Select(v => v.Copia()).ToList();
		return t;
	}

	/// <summary>Copia come tariffa nuova (senza identificativi), per rinnovi e duplicazioni.</summary>
	public TariffaModificabile CopiaComeNuova()
	{
		TariffaModificabile t = Copia();
		t.IdTariffa = null;
		t.Chiave = Guid.NewGuid();
		foreach (VoceModificabile v in t.Voci)
		{
			v.IdVoce = null;
			v.Fasce.ForEach(f => f.IdFascia = null);
		}
		return t;
	}

	/// <summary>Forma normalizzata (criteri maiuscoli, voci e fasce ordinate) per confrontare due versioni.</summary>
	public string Canonico()
	{
		var forma = new
		{
			IdTariffa,
			Criteri = CriteriTariffa.Elenco.Select(e => Criterio(e.Nome)).ToArray(),
			Voci = Voci.OrderBy(v => v.IdVoce ?? int.MaxValue).ThenBy(v => v.Voce).Select(v => new
			{
				v.IdVoce,
				Voce = v.Voce.Trim().ToUpperInvariant(),
				CampoCalcolo = v.CampoCalcolo.Trim().ToUpperInvariant(),
				Eccedenza = v.Eccedenza.Trim().ToUpperInvariant(),
				Fasce = v.Fasce.OrderBy(f => f.Da).ThenBy(f => f.A).Select(f => new
				{
					f.IdFascia, Da = N(f.Da), A = N(f.A), Fisso = N(f.Fisso), Variabile = N(f.Variabile), Percentuale = N(f.Percentuale)
				}).ToArray()
			}).ToArray()
		};
		return JsonSerializer.Serialize(forma);
	}

	private static string N(decimal d) => decimal.Round(d, 5).ToString("0.#####", System.Globalization.CultureInfo.InvariantCulture);
}

/// <summary>Un listino (contratto passivo) come lo modifica l'utente: si parte da quello vero e si salva come bozza.</summary>
public sealed class ListinoModificabile
{
	public DatiContratto Contratto { get; set; } = new();

	/// <summary>Il contratto non esiste ancora: verrà creato all'approvazione.</summary>
	public bool ContrattoNuovo { get; set; }

	/// <summary>Per i rinnovi: chiude il contratto precedente il giorno prima dell'inizio del nuovo.</summary>
	public ChiusuraContratto? ChiudiPrecedente { get; set; }

	public List<TariffaModificabile> Tariffe { get; set; } = new();

	public ListinoModificabile Copia() => new()
	{
		Contratto = Contratto.Copia(),
		ContrattoNuovo = ContrattoNuovo,
		ChiudiPrecedente = ChiudiPrecedente == null ? null : ChiudiPrecedente with { },
		Tariffe = Tariffe.Select(t => t.Copia()).ToList()
	};
}

public sealed record ChiusuraContratto(string Codice, DateTime DataFineAttuale, DateTime NuovaDataFine);

public static class JsonListini
{
	public static readonly JsonSerializerOptions Opzioni = new() { WriteIndented = false };

	public static string Scrivi<T>(T valore) => JsonSerializer.Serialize(valore, Opzioni);

	public static T Leggi<T>(string json) => JsonSerializer.Deserialize<T>(json, Opzioni)!;
}
