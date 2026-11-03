using Delsy.Listini.Dati;
using Delsy.Listini.Motore;
using Incasbo.Api.Gdo.Tariffe;

namespace Delsy.Listini.Spiegazione;

/// <summary>
/// «Perché questo costo?» per i costi passivi (vettori).
/// Ricostruisce come il motore sceglie contratto e tariffa (per poterlo spiegare, anche quando non trova nulla)
/// e usa il motore originale in simulazione per gli importi: non salva niente.
/// </summary>
public sealed class ServizioSpiegazione
{
	private readonly Db _db;
	private readonly Func<MotoreTariffe> _apriMotore;

	public ServizioSpiegazione(Db db, Func<MotoreTariffe> apriMotore)
	{
		_db = db;
		_apriMotore = apriMotore;
	}

	private sealed record TipoDoc(string Codice, string Vista, string ColonnaId, string FiltroTipiDocumento, string ColonnaVociVisibili);

	private static readonly TipoDoc Viaggio = new("VIAGGIO", "TAR_PAS_TourDocument", "ID", "Viaggio = 'S'", "Voce_Viaggio");
	private static readonly TipoDoc Spedizione = new("SPEDIZIONE", "TAR_PAS_ShippingDocument", "ID", "Spedizione = 'S'", "Voce_Spedizione");

	/// <summary>Spiega il costo di un viaggio e delle spedizioni che hanno un corrispondente (es. Transit Point).</summary>
	public SpiegazioneViaggio SpiegaViaggio(string idViaggio)
	{
		Dictionary<string, object?> doc = Documento(Viaggio, idViaggio)
			?? throw new KeyNotFoundException($"Viaggio {idViaggio} non trovato.");
		using MotoreTariffe motore = _apriMotore();

		SpiegazioneDocumento sv = SpiegaDocumento(Viaggio, doc, doc.Testo("SoggettoPassivo"), $"Viaggio {idViaggio}");
		sv.Dati.InsertRange(0, new[]
		{
			("Tipo viaggio", doc.Testo("TipoViaggio")),
			("Vettore", doc.Testo("SoggettoPassivo")),
			("Data di competenza", DataRiferimento(doc).ToString("dd/MM/yyyy"))
		});
		Simula(sv, () => new Simulation_TariffeTrasportoPassiveViaggioEngine(motore.Contesto, idViaggio, doc.Testo("SoggettoPassivo")));

		SpiegazioneViaggio risultato = new SpiegazioneViaggio { Viaggio = sv, TipoViaggio = doc.Testo("TipoViaggio") };
		foreach (Dictionary<string, object?> s in _db.Righe(
			"SELECT S.UniBol, S.Corrispondente, C.CodiceTrasportatore FROM Spedizioni S LEFT JOIN Corrispondenti C ON C.Codice = S.Corrispondente " +
			"WHERE S.IdViaggio = @id AND S.Corrispondente IS NOT NULL AND S.Corrispondente <> '' ORDER BY S.UniBol", ("@id", idViaggio)))
		{
			string unibol = s.Testo("UniBol");
			string corrispondente = s.Testo("Corrispondente");
			Dictionary<string, object?>? ds = Documento(Spedizione, unibol);
			if (ds == null)
			{
				continue;
			}
			string trasportatore = s.Testo("CodiceTrasportatore");
			SpiegazioneDocumento sp = SpiegaDocumento(Spedizione, ds, trasportatore, $"Spedizione {unibol}");
			sp.Dati.InsertRange(0, new[]
			{
				("Corrispondente (Transit Point)", corrispondente),
				("Trasportatore del corrispondente", trasportatore == "" ? "non definito" : trasportatore),
				("Destinazione", ds.Testo("PCSDestinazione_RagSoc") == "" ? ds.Testo("PCSDestinazione") : ds.Testo("PCSDestinazione_RagSoc"))
			});
			if (trasportatore == "")
			{
				sp.DatiMancanti.Add($"Il corrispondente {corrispondente} non ha un trasportatore (PCS.CodiceTrasportatore) oppure non è un punto di deposito.");
			}
			else
			{
				Simula(sp, () => new Simulation_TariffeTrasportoPassiveSpedizioniEngine(motore.Contesto, unibol, corrispondente));
			}
			risultato.Spedizioni.Add(sp);
		}
		return risultato;
	}

	private Dictionary<string, object?>? Documento(TipoDoc tipo, string id) =>
		_db.Righe($"SELECT * FROM {tipo.Vista} WHERE {tipo.ColonnaId} = @id", ("@id", id)).FirstOrDefault();

	/// <summary>Stessa regola del DocumentLoader per la data che sceglie il contratto.</summary>
	public static DateTime DataRiferimento(IReadOnlyDictionary<string, object?> doc)
	{
		DateTime? data = doc.Data("DataCompetenzaPassiva");
		if (data == null)
		{
			string campo = doc.Testo("CampoDataCompetenzaPassiva");
			data = campo != "" ? doc.Data(campo) : null;
		}
		return (data ?? doc.Data("DataDocumento") ?? DateTime.Today).Date;
	}

	private SpiegazioneDocumento SpiegaDocumento(TipoDoc tipo, Dictionary<string, object?> doc, string soggetto, string titolo)
	{
		SpiegazioneDocumento sd = new SpiegazioneDocumento { TipoDocumento = tipo.Codice, Id = doc.Testo("ID"), Titolo = titolo, Soggetto = soggetto };
		sd.BloccaCosti = doc.Testo("BloccaCosti") == "S";

		// I valori con cui il motore cerca la tariffa (TariffeEngine, ramo passivo)
		Dictionary<string, string> criteri = new(StringComparer.OrdinalIgnoreCase)
		{
			["TipoSpedizione"] = doc.Testo("TipoSpedizionePassivo"),
			["TipoMerce"] = doc.Testo("TipoMerce"),
			["TipoMezzo"] = doc.Testo("TipoMezzo"),
			["Cliente"] = doc.Testo("Cliente"),
			["GruppoTariffarioPartenza"] = doc.Testo("GruppoTariffarioPartenza"),
			["PCSPartenza"] = doc.Testo("PCSPartenza"),
			["MacroZonaArrivo"] = doc.Testo("ZonaArrivoPassivaMacro"),
			["ZonaArrivo"] = doc.Testo("ZonaArrivoPassiva"),
			["GruppoTariffarioArrivo"] = doc.Testo("GruppoTariffarioArrivo"),
			["PCSArrivo"] = doc.Testo("PCSArrivo")
		};
		foreach ((string nome, string etichetta) in CriteriTariffa.Elenco.Where(c => c.Nome != "TipoDocumento"))
		{
			sd.Dati.Add((etichetta, criteri[nome] == "" ? "—" : criteri[nome]));
		}
		sd.Dati.Add(("Bancali / peso / colli", $"{doc.Numero("Pallet"):0.##} / {doc.Numero("Peso"):0.##} kg / {doc.Numero("Colli"):0.##}"));

		// Stessi controlli del motore prima del calcolo (TariffeEngine.Check)
		foreach ((string nome, string messaggio) in new[]
		{
			("TipoSpedizione", "Tipo spedizione non specificato"), ("TipoMerce", "Tipo merce non specificato"),
			("TipoMezzo", "Tipo mezzo non specificato"), ("PCSPartenza", "PCS di partenza non specificato"),
			("ZonaArrivo", "Zona di arrivo non specificata"), ("Cliente", "Cliente non specificato")
		})
		{
			if (criteri[nome] == "")
			{
				sd.DatiMancanti.Add(messaggio + $" sul {tipo.Codice.ToLowerInvariant()}: il motore non calcola il costo.");
			}
		}

		// Contratto: intestato al soggetto, poi al soggetto di fatturazione, poi generico (*ALL)
		DateTime dataRif = DataRiferimento(doc);
		string fatturaA = doc.Testo("SoggettoFatturazionePassiva");
		List<Dictionary<string, object?>> contratti = _db.Righe(
			"SELECT Codice, Descrizione, Attivo, DataInizioValidita, DataFineValidita, " +
			"CASE WHEN Trasportatore = @s THEN 1 WHEN Trasportatore = @f THEN 2 ELSE 3 END Priorita " +
			"FROM TariffeContratti WHERE AttivaPassiva = 'P' AND " + (tipo.Codice == "VIAGGIO" || tipo.Codice == "SPEDIZIONE" ? "ContrattoTrasporto = 'S' " : "ContrattoGiacenza = 'S' ") +
			"AND DataInizioValidita <= @d AND DataFineValidita >= @d AND Trasportatore IN (@s, @f, '*ALL') ORDER BY Priorita",
			("@s", soggetto), ("@f", fatturaA), ("@d", dataRif));
		if (contratti.Count == 0)
		{
			int fuoriData = Convert.ToInt32(_db.Righe("SELECT COUNT(*) N FROM TariffeContratti WHERE AttivaPassiva = 'P' AND Trasportatore IN (@s, @f)", ("@s", soggetto), ("@f", fatturaA))[0]["N"]);
			sd.NoteContratto.Add(fuoriData > 0
				? $"{soggetto} ha {fuoriData} contratti, ma nessuno valido al {dataRif:dd/MM/yyyy}."
				: $"Nessun contratto passivo per {soggetto}" + (fatturaA != "" && fatturaA != soggetto ? $" né per {fatturaA}" : "") + " né generico (*ALL).");
			return sd;
		}
		Dictionary<string, object?> c = contratti[0];
		string motivo = Convert.ToInt32(c["Priorita"]) switch
		{
			1 => $"intestato a {soggetto}",
			2 => $"intestato al soggetto di fatturazione {fatturaA}",
			_ => "contratto generico (*ALL)"
		};
		sd.Contratto = new ContrattoScelto(c.Testo("Codice"), c.Testo("Descrizione"), c.Data("DataInizioValidita")!.Value, c.Data("DataFineValidita")!.Value, motivo);
		if (c.Testo("Attivo") == "N")
		{
			sd.NoteContratto.Add($"Il contratto {sd.Contratto.Codice} non è attivo: il motore non calcola.");
		}
		if (contratti.Count > 1)
		{
			sd.NoteContratto.Add($"Altri contratti validi scartati perché meno specifici: {string.Join(", ", contratti.Skip(1).Select(x => x.Testo("Codice")))}.");
		}

		// Tariffe del contratto e confronto criterio per criterio
		List<string> tipiAmmessi = _db.Righe($"SELECT Codice FROM TariffeTipiDocumento WHERE TariffaPassiva = 'S' AND {tipo.FiltroTipiDocumento} AND Attivo = 'S'")
			.Select(r => r.Testo("Codice")).ToList();
		List<ConfrontoTariffa> confronti = _db.Righe("SELECT * FROM TAR_TariffePassiveTestata WHERE Contratto = @c", ("@c", sd.Contratto.Codice))
			.Select(t => CriteriTariffa.Confronta(Convert.ToInt32(t["IdTariffa"]), Convert.ToInt64(t["Peso"]),
				t.ToDictionary(k => k.Key, k => Convert.ToString(k.Value) ?? "", StringComparer.OrdinalIgnoreCase), criteri, tipiAmmessi))
			.ToList();
		sd.TariffeDelContratto = confronti.Count;
		sd.TariffaApplicata = CriteriTariffa.Applicata(confronti);
		if (sd.TariffaApplicata == null)
		{
			sd.TariffeVicine.AddRange(CriteriTariffa.PiuVicine(confronti));
		}
		return sd;
	}

	private static void Simula(SpiegazioneDocumento sd, Func<Simulation_TariffeEngine> crea)
	{
		if (sd.DatiMancanti.Count > 0 || sd.Contratto == null)
		{
			return;
		}
		Simulation_TariffeEngine motore = crea();
		string avvisi = "", messaggio = "";
		motore.Run(ref avvisi, ref messaggio);
		if (!string.IsNullOrWhiteSpace(messaggio)) sd.MessaggiMotore.Add(messaggio.Trim());
		if (!string.IsNullOrWhiteSpace(avvisi)) sd.MessaggiMotore.Add(avvisi.Trim());
		foreach (Costo c in motore.Costi)
		{
			sd.Costi.Add(new RigaCosto(c.Voce, "", c.CampoCalcolo, c.QuantitaOriginale, c.QuantitaTassata, c.ImportoUnitario, c.ImportoArrotondato,
				c.EstremiTariffa ?? "", c.NoteDiCalcolo ?? ""));
		}
	}
}
