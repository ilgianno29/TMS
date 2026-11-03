using Delsy.Listini.Spiegazione;

namespace Delsy.Listini.Bozze;

public enum Gravita { Errore, Avviso }

/// <summary>Un problema trovato nella bozza. <see cref="Tariffa"/> indica la riga della griglia (null = contratto).</summary>
public sealed record Problema(Gravita Gravita, string Messaggio, Guid? Tariffa = null);

/// <summary>Codici esistenti in anagrafica, per controllare quello che si scrive nella bozza.</summary>
public sealed class Anagrafiche
{
	public HashSet<string> Trasportatori { get; init; } = Nuovo();
	public HashSet<string> Contratti { get; init; } = Nuovo();
	public HashSet<string> Voci { get; init; } = Nuovo();
	public HashSet<string> CampiCalcolo { get; init; } = Nuovo();
	public Dictionary<string, HashSet<string>> Criteri { get; init; } = new(StringComparer.OrdinalIgnoreCase);

	public static HashSet<string> Nuovo(IEnumerable<string>? valori = null) =>
		new((valori ?? Enumerable.Empty<string>()).Select(v => v.Trim()), StringComparer.OrdinalIgnoreCase);
}

/// <summary>
/// Controlli sulla bozza prima del salvataggio e dell'approvazione.
/// Gli errori bloccano l'invio in validazione e l'approvazione; gli avvisi no.
/// </summary>
public static class Controlli
{
	/// <summary>Lunghezza massima delle colonne di TariffePassiveTestata.</summary>
	private static readonly Dictionary<string, int> Lunghezze = new(StringComparer.OrdinalIgnoreCase)
	{
		["TipoDocumento"] = 15, ["TipoSpedizione"] = 6, ["TipoMerce"] = 6, ["TipoMezzo"] = 6, ["Cliente"] = 15,
		["GruppoTariffarioPartenza"] = 15, ["PCSPartenza"] = 15, ["MacroZonaArrivo"] = 6, ["ZonaArrivo"] = 6,
		["GruppoTariffarioArrivo"] = 15, ["PCSArrivo"] = 15
	};

	public static List<Problema> Esegui(ListinoModificabile l, Anagrafiche a)
	{
		List<Problema> p = new();
		DatiContratto c = l.Contratto;

		if (string.IsNullOrWhiteSpace(c.Codice)) p.Add(Errore("Manca il codice del contratto."));
		else if (c.Codice.Trim().Length > 15) p.Add(Errore("Il codice del contratto può avere al massimo 15 caratteri."));
		else if (l.ContrattoNuovo && a.Contratti.Contains(c.Codice.Trim())) p.Add(Errore($"Esiste già un contratto con codice {c.Codice.Trim()}."));
		if (string.IsNullOrWhiteSpace(c.Descrizione)) p.Add(Errore("Manca la descrizione del contratto."));
		if (string.IsNullOrWhiteSpace(c.Trasportatore)) p.Add(Errore("Manca il vettore."));
		else if (!a.Trasportatori.Contains(c.Trasportatore.Trim())) p.Add(Errore($"Il vettore {c.Trasportatore} non esiste in anagrafica."));
		if (c.DataFine.Date < c.DataInizio.Date) p.Add(Errore("La data di fine validità è precedente a quella di inizio."));
		if (c.Arrotondamento < 0) p.Add(Errore("L'arrotondamento degli importi non può essere negativo."));
		if (l.ChiudiPrecedente is { } ch && ch.NuovaDataFine.Date >= c.DataInizio.Date)
			p.Add(Errore($"Il contratto {ch.Codice} deve finire prima dell'inizio del nuovo."));

		if (l.Tariffe.Count == 0) p.Add(Avviso("Il listino non ha tariffe: il calcolo non troverà nessun prezzo."));

		foreach (IGrouping<string, TariffaModificabile> doppie in l.Tariffe.GroupBy(t => t.ChiaveCriteri).Where(g => g.Count() > 1))
		{
			foreach (TariffaModificabile t in doppie.Skip(1))
			{
				p.Add(Errore($"{t.Etichetta}: esiste già una tariffa con gli stessi criteri nel listino.", t.Chiave));
			}
		}

		foreach (TariffaModificabile t in l.Tariffe)
		{
			ControllaTariffa(t, a, p);
		}
		return p;
	}

	private static void ControllaTariffa(TariffaModificabile t, Anagrafiche a, List<Problema> p)
	{
		string nome = t.Etichetta;
		foreach ((string criterio, string etichetta) in CriteriTariffa.Elenco)
		{
			string v = t.Criterio(criterio);
			if (v == CriteriTariffa.Tutti) continue;
			if (v.Length > Lunghezze[criterio])
				p.Add(Errore($"{nome}: {etichetta} «{v}» è troppo lungo (massimo {Lunghezze[criterio]} caratteri).", t.Chiave));
			else if (a.Criteri.TryGetValue(criterio, out HashSet<string>? validi) && !validi.Contains(v))
				p.Add(Errore($"{nome}: {etichetta} «{v}» non esiste in anagrafica.", t.Chiave));
		}

		if (t.Voci.Count == 0)
		{
			p.Add(Errore($"{nome}: la tariffa non ha voci di costo.", t.Chiave));
			return;
		}
		foreach (IGrouping<string, VoceModificabile> g in t.Voci.GroupBy(v => v.Voce.Trim().ToUpperInvariant()).Where(g => g.Count() > 1))
			p.Add(Avviso($"{nome}: la voce {g.Key} è presente {g.Count()} volte e verrà calcolata {g.Count()} volte.", t.Chiave));

		foreach (VoceModificabile v in t.Voci)
		{
			string nv = $"{nome} · {v.Voce}";
			if (string.IsNullOrWhiteSpace(v.Voce)) p.Add(Errore($"{nome}: c'è una voce senza codice.", t.Chiave));
			else if (!a.Voci.Contains(v.Voce.Trim())) p.Add(Errore($"{nv}: la voce non esiste o non è attiva.", t.Chiave));
			if (string.IsNullOrWhiteSpace(v.CampoCalcolo)) p.Add(Errore($"{nv}: manca la base di calcolo (bancali, peso, forfait…).", t.Chiave));
			else if (a.CampiCalcolo.Count > 0 && !a.CampiCalcolo.Contains(v.CampoCalcolo.Trim()))
				p.Add(Errore($"{nv}: la base di calcolo «{v.CampoCalcolo}» non esiste tra i dati di viaggi e spedizioni.", t.Chiave));
			ControllaFasce(v, nv, t.Chiave, p);
		}
	}

	private static void ControllaFasce(VoceModificabile v, string nome, Guid tariffa, List<Problema> p)
	{
		if (v.Fasce.Count == 0)
		{
			p.Add(Errore($"{nome}: nessuna fascia di prezzo.", tariffa));
			return;
		}
		List<FasciaModificabile> f = v.Fasce.OrderBy(x => x.Da).ThenBy(x => x.A).ToList();
		foreach (FasciaModificabile x in f)
		{
			if (x.A <= x.Da) p.Add(Errore($"{nome}: la fascia {x.Da:0.##}–{x.A:0.##} ha il limite superiore non maggiore dell'inferiore.", tariffa));
			if (x.Da < 0 || x.Fisso < 0 || x.Variabile < 0 || x.Percentuale < 0) p.Add(Errore($"{nome}: valori negativi nella fascia {x.Da:0.##}–{x.A:0.##}.", tariffa));
		}
		for (int i = 1; i < f.Count; i++)
		{
			if (f[i].Da < f[i - 1].A)
				p.Add(Errore($"{nome}: le fasce {f[i - 1].Da:0.##}–{f[i - 1].A:0.##} e {f[i].Da:0.##}–{f[i].A:0.##} si sovrappongono.", tariffa));
			else if (f[i].Da > f[i - 1].A)
				p.Add(Avviso($"{nome}: tra {f[i - 1].A:0.##} e {f[i].Da:0.##} non c'è nessuna fascia: in quell'intervallo non verrà calcolato niente.", tariffa));
		}
		if (f[0].Da > 0)
			p.Add(Avviso($"{nome}: la prima fascia parte da {f[0].Da:0.##}: sotto questo valore non verrà calcolato niente.", tariffa));
		if (f.All(x => x.TuttoZero))
			p.Add(Avviso($"{nome}: tutti gli importi sono a zero (va bene solo per il costo zero).", tariffa));
	}

	private static Problema Errore(string m, Guid? t = null) => new(Gravita.Errore, m, t);
	private static Problema Avviso(string m, Guid? t = null) => new(Gravita.Avviso, m, t);
}
