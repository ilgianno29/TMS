using System.Globalization;
using Delsy.Listini.Spiegazione;

namespace Delsy.Listini.Bozze;

/// <summary>Una riga della bozza (tabella TAR_BozzeRighe).</summary>
public sealed record RigaBozza(int Ordine, string Oggetto, string Operazione, int? IdOriginale, string Descrizione,
	string? DatiPrima, string? DatiDopo, string? RifFile = null, string Esito = "OK", string? Messaggio = null);

/// <summary>
/// Differenze tra il listino in vigore e quello modificato. In bozza si salvano solo le differenze, una riga per
/// tariffa (con voci e fasce) e una per il contratto, con i dati prima e dopo: è anche quello che vede chi approva.
/// </summary>
public static class Differenze
{
	public const string Contratto = "CONTRATTO", Testata = "TESTATA";
	public const string Nuova = "NUOVA", Modifica = "MODIFICA", Elimina = "ELIMINA";

	private static readonly CultureInfo It = CultureInfo.GetCultureInfo("it-IT");

	public static List<RigaBozza> Calcola(ListinoModificabile? originale, ListinoModificabile nuovo)
	{
		List<RigaBozza> righe = new();
		int ordine = 0;

		if (nuovo.ContrattoNuovo)
		{
			righe.Add(new RigaBozza(++ordine, Contratto, Nuova, null, Corta($"Nuovo contratto {nuovo.Contratto.Codice} per il vettore {nuovo.Contratto.Trasportatore}, valido dal {D(nuovo.Contratto.DataInizio)} al {D(nuovo.Contratto.DataFine)}"),
				null, JsonListini.Scrivi(nuovo.Contratto)));
		}
		else if (originale != null && !originale.Contratto.UgualeA(nuovo.Contratto))
		{
			righe.Add(new RigaBozza(++ordine, Contratto, Modifica, null, Corta($"Contratto {nuovo.Contratto.Codice}: {DescriviContratto(originale.Contratto, nuovo.Contratto)}"),
				JsonListini.Scrivi(originale.Contratto), JsonListini.Scrivi(nuovo.Contratto)));
		}
		if (nuovo.ChiudiPrecedente is { } ch)
		{
			righe.Add(new RigaBozza(++ordine, Contratto, Modifica, null,
				Corta($"Il contratto {ch.Codice} finisce il {D(ch.NuovaDataFine)} invece del {D(ch.DataFineAttuale)}"), null, JsonListini.Scrivi(ch)));
		}

		Dictionary<int, TariffaModificabile> prima = (originale?.Tariffe ?? new()).Where(t => t.IdTariffa != null).ToDictionary(t => t.IdTariffa!.Value);
		HashSet<int> rimaste = new();
		foreach (TariffaModificabile t in nuovo.Tariffe)
		{
			if (t.IdTariffa is int id && prima.TryGetValue(id, out TariffaModificabile? p))
			{
				rimaste.Add(id);
				if (p.Canonico() != t.Canonico())
				{
					righe.Add(new RigaBozza(++ordine, Testata, Modifica, id, Corta($"{p.Etichetta}: {DescriviModifica(p, t)}"),
						JsonListini.Scrivi(p), JsonListini.Scrivi(t)));
				}
			}
			else
			{
				TariffaModificabile n = t.IdTariffa == null ? t : t.CopiaComeNuova();
				righe.Add(new RigaBozza(++ordine, Testata, Nuova, null, Corta($"Nuova tariffa {n.Etichetta}: {DescriviVoci(n)}"), null, JsonListini.Scrivi(n)));
			}
		}
		foreach (TariffaModificabile p in prima.Values.Where(p => !rimaste.Contains(p.IdTariffa!.Value)))
		{
			righe.Add(new RigaBozza(++ordine, Testata, Elimina, p.IdTariffa, Corta($"Eliminata la tariffa {p.Etichetta}"), JsonListini.Scrivi(p), null));
		}
		return righe;
	}

	/// <summary>Ricostruisce il listino modificato partendo da quello in vigore (null per un contratto nuovo) e dalle righe della bozza.</summary>
	public static ListinoModificabile Applica(ListinoModificabile? originale, IEnumerable<RigaBozza> righe)
	{
		ListinoModificabile l = originale?.Copia() ?? new ListinoModificabile { ContrattoNuovo = true };
		foreach (RigaBozza r in righe.OrderBy(r => r.Ordine))
		{
			if (r.Oggetto == Contratto)
			{
				if (r.DatiDopo == null) continue;
				if (r.DatiDopo.Contains("\"NuovaDataFine\"")) l.ChiudiPrecedente = JsonListini.Leggi<ChiusuraContratto>(r.DatiDopo);
				else
				{
					l.Contratto = JsonListini.Leggi<DatiContratto>(r.DatiDopo);
					if (r.Operazione == Nuova) l.ContrattoNuovo = true;
				}
				continue;
			}
			switch (r.Operazione)
			{
				case Nuova:
					l.Tariffe.Add(JsonListini.Leggi<TariffaModificabile>(r.DatiDopo!));
					break;
				case Modifica:
					int i = l.Tariffe.FindIndex(t => t.IdTariffa == r.IdOriginale);
					TariffaModificabile dopo = JsonListini.Leggi<TariffaModificabile>(r.DatiDopo!);
					if (i >= 0) l.Tariffe[i] = dopo; else l.Tariffe.Add(dopo);
					break;
				case Elimina:
					l.Tariffe.RemoveAll(t => t.IdTariffa == r.IdOriginale);
					break;
			}
		}
		return l;
	}

	/// <summary>Elenco leggibile delle differenze tra due versioni (per il registro dei salvataggi).</summary>
	public static List<string> Descrivi(ListinoModificabile? prima, ListinoModificabile dopo)
	{
		// stesso calcolo, ma confrontando anche le tariffe nuove tra loro (per chiave)
		List<string> d = new();
		if (prima != null && !prima.Contratto.UgualeA(dopo.Contratto))
			d.Add($"Contratto: {DescriviContratto(prima.Contratto, dopo.Contratto)}");
		Dictionary<Guid, TariffaModificabile> p = (prima?.Tariffe ?? new()).ToDictionary(t => t.Chiave);
		foreach (TariffaModificabile t in dopo.Tariffe)
		{
			if (p.Remove(t.Chiave, out TariffaModificabile? x))
			{
				if (x.Canonico() != t.Canonico()) d.Add($"{x.Etichetta}: {DescriviModifica(x, t)}");
			}
			else d.Add($"Nuova tariffa {t.Etichetta}: {DescriviVoci(t)}");
		}
		d.AddRange(p.Values.Select(x => $"Eliminata la tariffa {x.Etichetta}"));
		return d;
	}

	private static string DescriviContratto(DatiContratto a, DatiContratto b)
	{
		List<string> c = new();
		if (a.Descrizione != b.Descrizione) c.Add($"descrizione «{a.Descrizione}» → «{b.Descrizione}»");
		if (a.Trasportatore != b.Trasportatore) c.Add($"vettore {a.Trasportatore} → {b.Trasportatore}");
		if (a.DataInizio.Date != b.DataInizio.Date) c.Add($"inizio {D(a.DataInizio)} → {D(b.DataInizio)}");
		if (a.DataFine.Date != b.DataFine.Date) c.Add($"fine {D(a.DataFine)} → {D(b.DataFine)}");
		if (a.Arrotondamento != b.Arrotondamento) c.Add($"arrotondamento {N(a.Arrotondamento)} → {N(b.Arrotondamento)}");
		if (a.Attivo != b.Attivo) c.Add(b.Attivo ? "riattivato" : "disattivato");
		return string.Join("; ", c);
	}

	private static string DescriviModifica(TariffaModificabile a, TariffaModificabile b)
	{
		List<string> c = new();
		foreach ((string nome, string etichetta) in CriteriTariffa.Elenco)
		{
			if (a.Criterio(nome) != b.Criterio(nome)) c.Add($"{etichetta} {Formato(a.Criterio(nome))} → {Formato(b.Criterio(nome))}");
		}
		List<VoceModificabile> restanti = a.Voci.ToList();
		foreach (VoceModificabile vb in b.Voci)
		{
			VoceModificabile? va = restanti.FirstOrDefault(v => vb.IdVoce != null && v.IdVoce == vb.IdVoce)
				?? restanti.FirstOrDefault(v => v.IdVoce == null || vb.IdVoce == null ? string.Equals(v.Voce, vb.Voce, StringComparison.OrdinalIgnoreCase) : false);
			if (va == null)
			{
				c.Add($"aggiunta voce {DescriviVoce(vb)}");
				continue;
			}
			restanti.Remove(va);
			if (!string.Equals(va.Voce, vb.Voce, StringComparison.OrdinalIgnoreCase)) c.Add($"voce {va.Voce} → {vb.Voce}");
			if (!string.Equals(va.CampoCalcolo, vb.CampoCalcolo, StringComparison.OrdinalIgnoreCase)) c.Add($"{vb.Voce} base di calcolo {va.CampoCalcolo} → {vb.CampoCalcolo}");
			c.AddRange(DescriviFasce(vb.Voce, va.Fasce, vb.Fasce));
		}
		c.AddRange(restanti.Select(v => $"tolta voce {v.Voce}"));
		return c.Count == 0 ? "nessuna differenza visibile" : string.Join("; ", c);
	}

	private static IEnumerable<string> DescriviFasce(string voce, List<FasciaModificabile> a, List<FasciaModificabile> b)
	{
		List<FasciaModificabile> restanti = a.ToList();
		foreach (FasciaModificabile fb in b.OrderBy(f => f.Da))
		{
			FasciaModificabile? fa = restanti.FirstOrDefault(f => fb.IdFascia != null && f.IdFascia == fb.IdFascia)
				?? restanti.FirstOrDefault(f => f.Da == fb.Da && f.A == fb.A);
			if (fa == null)
			{
				yield return $"{voce} nuova fascia {Intervallo(fb)}: {Prezzo(fb)}";
				continue;
			}
			restanti.Remove(fa);
			if (fa.Da != fb.Da || fa.A != fb.A) yield return $"{voce} fascia {Intervallo(fa)} → {Intervallo(fb)}";
			if (Prezzo(fa) != Prezzo(fb)) yield return $"{voce} {Intervallo(fb)}: {Prezzo(fa)} → {Prezzo(fb)}";
		}
		foreach (FasciaModificabile f in restanti) yield return $"{voce} tolta fascia {Intervallo(f)}";
	}

	private static string DescriviVoci(TariffaModificabile t) => t.Voci.Count == 0 ? "senza voci" : string.Join("; ", t.Voci.Select(DescriviVoce));

	private static string DescriviVoce(VoceModificabile v) =>
		v.Fasce.Count == 1 && v.Fasce[0].A >= VoceModificabile.SenzaLimite
			? $"{v.Voce} {Prezzo(v.Fasce[0])}" + (v.CampoCalcolo.Equals(VoceModificabile.Forfait, StringComparison.OrdinalIgnoreCase) ? " forfait" : $" per {v.CampoCalcolo}")
			: $"{v.Voce} per {v.CampoCalcolo} " + string.Join(", ", v.Fasce.OrderBy(f => f.Da).Select(f => $"{Intervallo(f)}: {Prezzo(f)}"));

	public static string Prezzo(FasciaModificabile f)
	{
		List<string> p = new();
		if (f.Fisso != 0) p.Add(f.Fisso.ToString("#,##0.00", It) + " €");
		if (f.Variabile != 0) p.Add(f.Variabile.ToString("#,##0.00", It) + " €/u");
		if (f.Percentuale != 0) p.Add(f.Percentuale.ToString("0.##", It) + "%");
		return p.Count == 0 ? "0,00 €" : string.Join(" + ", p);
	}

	public static string Intervallo(FasciaModificabile f) => f.A >= VoceModificabile.SenzaLimite ? $"oltre {N(f.Da)}" : $"{N(f.Da)}–{N(f.A)}";

	private static string Formato(string v) => v == CriteriTariffa.Tutti ? "tutti" : v;

	private static string N(decimal d) => d.ToString("#,##0.###", It);

	private static string D(DateTime d) => d.ToString("dd/MM/yyyy", It);

	private static string Corta(string s) => s.Length <= 400 ? s : s[..397] + "…";
}
