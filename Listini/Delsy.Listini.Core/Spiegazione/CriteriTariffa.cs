namespace Delsy.Listini.Spiegazione;

/// <summary>Un criterio di abbinamento tra documento (viaggio o spedizione) e testata tariffa.</summary>
public sealed record Criterio(string Nome, string Etichetta, string ValoreDocumento, string ValoreTariffa)
{
	/// <summary>La tariffa vale per qualsiasi valore (<c>*ALL</c>).</summary>
	public bool Qualsiasi => ValoreTariffa == CriteriTariffa.Tutti;

	/// <summary>Il criterio è soddisfatto: tariffa generica oppure valore uguale (senza distinzione maiuscole).</summary>
	public bool Corrisponde => Qualsiasi || string.Equals(ValoreDocumento?.Trim(), ValoreTariffa?.Trim(), StringComparison.OrdinalIgnoreCase);
}

/// <summary>Esito del confronto tra un documento e una testata tariffa.</summary>
public sealed record ConfrontoTariffa(int IdTariffa, long Peso, IReadOnlyList<Criterio> Criteri)
{
	public bool Corrisponde => Criteri.All(c => c.Corrisponde);

	public IEnumerable<Criterio> NonCorrispondenti => Criteri.Where(c => !c.Corrisponde);

	/// <summary>Criteri specifici (non *ALL) che corrispondono: misura di "vicinanza" per le tariffe non applicabili.</summary>
	public int CriteriSpecificiCorrispondenti => Criteri.Count(c => !c.Qualsiasi && c.Corrisponde);
}

/// <summary>
/// Regole di abbinamento del motore Delsy (TariffeEngine.Search), riprodotte per poterle spiegare:
/// una testata vale per il documento se ogni criterio è <c>*ALL</c> oppure uguale al valore del documento;
/// tra quelle valide il motore usa la più specifica (Peso più alto, vista TAR_TariffePassiveTestata).
/// </summary>
public static class CriteriTariffa
{
	public const string Tutti = "*ALL";

	/// <summary>I criteri della testata, nell'ordine in cui li mostra il portale.</summary>
	public static readonly (string Nome, string Etichetta)[] Elenco =
	{
		("TipoDocumento", "Tipo documento"),
		("TipoSpedizione", "Tipo spedizione"),
		("TipoMerce", "Tipo merce"),
		("TipoMezzo", "Tipo mezzo"),
		("Cliente", "Cliente"),
		("GruppoTariffarioPartenza", "Gruppo tariffario partenza"),
		("PCSPartenza", "PCS partenza"),
		("MacroZonaArrivo", "Macro zona arrivo"),
		("ZonaArrivo", "Zona arrivo"),
		("GruppoTariffarioArrivo", "Gruppo tariffario arrivo"),
		("PCSArrivo", "PCS arrivo")
	};

	/// <summary>
	/// Confronta il documento con una testata.
	/// <paramref name="tipiDocumentoAmmessi"/> sono i codici di TariffeTipiDocumento validi per questo documento
	/// (il motore accetta la testata se il suo TipoDocumento è *ALL oppure uno di questi).
	/// </summary>
	public static ConfrontoTariffa Confronta(int idTariffa, long peso, IReadOnlyDictionary<string, string> testata,
		IReadOnlyDictionary<string, string> documento, IReadOnlyCollection<string> tipiDocumentoAmmessi)
	{
		List<Criterio> criteri = new List<Criterio>(Elenco.Length);
		foreach ((string nome, string etichetta) in Elenco)
		{
			string valoreTariffa = Valore(testata, nome, Tutti);
			if (nome == "TipoDocumento")
			{
				// il documento non ha un solo "tipo": vale se la testata è *ALL o uno dei tipi ammessi
				string ammesso = valoreTariffa == Tutti ? Tutti
					: tipiDocumentoAmmessi.FirstOrDefault(t => string.Equals(t, valoreTariffa, StringComparison.OrdinalIgnoreCase)) ?? string.Join(", ", tipiDocumentoAmmessi);
				criteri.Add(new Criterio(nome, etichetta, ammesso, valoreTariffa));
				continue;
			}
			criteri.Add(new Criterio(nome, etichetta, Valore(documento, nome, ""), valoreTariffa));
		}
		return new ConfrontoTariffa(idTariffa, peso, criteri);
	}

	/// <summary>
	/// La tariffa che il motore applicherebbe (la più specifica tra quelle che corrispondono), oppure null.
	/// </summary>
	public static ConfrontoTariffa? Applicata(IEnumerable<ConfrontoTariffa> confronti) =>
		confronti.Where(c => c.Corrisponde).OrderByDescending(c => c.Peso).FirstOrDefault();

	/// <summary>
	/// Le tariffe più vicine quando nessuna corrisponde: meno criteri sbagliati, poi più criteri specifici giusti.
	/// </summary>
	public static IReadOnlyList<ConfrontoTariffa> PiuVicine(IEnumerable<ConfrontoTariffa> confronti, int quante = 3) =>
		confronti.Where(c => !c.Corrisponde)
			.OrderBy(c => c.NonCorrispondenti.Count())
			.ThenByDescending(c => c.CriteriSpecificiCorrispondenti)
			.ThenByDescending(c => c.Peso)
			.Take(quante)
			.ToList();

	private static string Valore(IReadOnlyDictionary<string, string> valori, string nome, string predefinito) =>
		valori.TryGetValue(nome, out string? v) && !string.IsNullOrWhiteSpace(v) ? v.Trim() : predefinito;
}
