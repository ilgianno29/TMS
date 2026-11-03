namespace Delsy.Listini.Spiegazione;

/// <summary>Una riga di costo calcolata dal motore Delsy.</summary>
public sealed record RigaCosto(string Voce, string DescrizioneVoce, string CampoCalcolo, decimal QuantitaOriginale, decimal QuantitaTassata,
	decimal ImportoUnitario, decimal Importo, string EstremiTariffa, string NoteDiCalcolo);

/// <summary>Il contratto scelto e perché.</summary>
public sealed record ContrattoScelto(string Codice, string Descrizione, DateTime DataInizio, DateTime DataFine, string Motivo);

/// <summary>Spiegazione del costo di un documento (viaggio o spedizione).</summary>
public sealed class SpiegazioneDocumento
{
	public required string TipoDocumento { get; init; } // VIAGGIO o SPEDIZIONE

	public required string Id { get; init; }

	public string Titolo { get; init; } = "";

	/// <summary>Dati del documento come li vede il motore (etichetta → valore).</summary>
	public List<(string Etichetta, string Valore)> Dati { get; } = new();

	/// <summary>Dati mancanti che impediscono il calcolo (stessi controlli del motore).</summary>
	public List<string> DatiMancanti { get; } = new();

	public string Soggetto { get; set; } = "";

	public ContrattoScelto? Contratto { get; set; }

	/// <summary>Contratti considerati (anche quelli scartati), per spiegare la scelta.</summary>
	public List<string> NoteContratto { get; } = new();

	public ConfrontoTariffa? TariffaApplicata { get; set; }

	/// <summary>Quando nessuna tariffa corrisponde: le più vicine, con i criteri che non tornano.</summary>
	public List<ConfrontoTariffa> TariffeVicine { get; } = new();

	public int TariffeDelContratto { get; set; }

	public List<RigaCosto> Costi { get; } = new();

	public decimal Totale => Costi.Sum(c => c.Importo);

	/// <summary>Messaggi del motore (errori e avvisi), mostrati così come sono.</summary>
	public List<string> MessaggiMotore { get; } = new();

	public bool BloccaCosti { get; set; }

	public bool Calcolato => DatiMancanti.Count == 0 && Contratto != null && TariffaApplicata != null && MessaggiMotore.Count == 0;
}

/// <summary>Spiegazione completa di un viaggio: il viaggio e le spedizioni tariffate a parte (es. via Transit Point).</summary>
public sealed class SpiegazioneViaggio
{
	public required SpiegazioneDocumento Viaggio { get; init; }

	public List<SpiegazioneDocumento> Spedizioni { get; } = new();

	public string TipoViaggio { get; set; } = "";

	public decimal Totale => Viaggio.Totale + Spedizioni.Sum(s => s.Totale);
}
