using Delsy.Listini.Dati;
using Delsy.Listini.Registro;
using Microsoft.Data.SqlClient;

namespace Delsy.Listini.Bozze;

public static class StatiBozza
{
	public const string Bozza = "BOZZA", Validazione = "VALIDAZIONE", Approvata = "APPROVATA", Applicata = "APPLICATA",
		Rifiutata = "RIFIUTATA", Annullata = "ANNULLATA";

	public static readonly string[] Aperti = { Bozza, Validazione, Approvata };

	public static string Etichetta(string stato) => stato switch
	{
		Bozza => "In bozza", Validazione => "Da approvare", Approvata => "Approvata, in attesa", Applicata => "Applicata",
		Rifiutata => "Rifiutata", Annullata => "Annullata", _ => stato
	};
}

public sealed record InfoBozza(int IdBozza, string Codice, string? Contratto, string? ContrattoNuovo, string Trasportatore, string Titolo,
	string Origine, string? FileOrigine, string Stato, DateTime? ApplicaDal, string? Note, string CreataDa, DateTime CreataIl,
	string? InviataDa, DateTime? InviataIl, string? DecisaDa, DateTime? DecisaIl, string? NotaDecisione, DateTime? ApplicataIl, int Righe)
{
	public string CodiceContratto => Contratto ?? ContrattoNuovo ?? "";
	public bool Modificabile => Stato == StatiBozza.Bozza;
}

public sealed class BozzaAperta
{
	public required InfoBozza Info { get; init; }
	public required ListinoModificabile Listino { get; init; }
	/// <summary>Il listino in vigore (null se la bozza crea un contratto nuovo).</summary>
	public ListinoModificabile? InVigore { get; init; }
	public required IReadOnlyList<RigaBozza> Righe { get; init; }
}

/// <summary>Il listino è cambiato dopo che la bozza è stata preparata: va riaperta e controllata.</summary>
public sealed class ConflittoListinoException(string message) : Exception(message);

/// <summary>Operazione non permessa (stato della bozza, controlli non superati, dati mancanti).</summary>
public sealed class OperazioneBozzaException(string message) : Exception(message);

/// <summary>
/// Bozze dei listini: creazione, salvataggio, invio in validazione, approvazione o rifiuto, applicazione alle tabelle del motore.
/// Ogni passaggio scrive nel registro, nella stessa transazione della modifica.
/// </summary>
public sealed class ServizioBozze
{
	private readonly Db _db;
	private readonly ServizioAnagrafiche _anagrafiche;

	public ServizioBozze(Db db, ServizioAnagrafiche anagrafiche)
	{
		_db = db;
		_anagrafiche = anagrafiche;
	}

	private const string SqlInfo = @"
SELECT B.*, (SELECT COUNT(*) FROM TAR_BozzeRighe R WHERE R.IdBozza = B.IdBozza) AS NumeroRighe FROM TAR_Bozze B";

	public IReadOnlyList<InfoBozza> Elenco(params string[] stati)
	{
		string filtro = stati.Length == 0 ? "" : $" WHERE B.Stato IN ({string.Join(", ", stati.Select((_, i) => "@s" + i))})";
		return _db.Righe(SqlInfo + filtro + " ORDER BY B.IdBozza DESC", stati.Select((s, i) => ("@s" + i, (object?)s)).ToArray()).Select(Info).ToList();
	}

	public InfoBozza? Info(int id) => _db.Righe(SqlInfo + " WHERE B.IdBozza = @id", ("@id", id)).Select(Info).FirstOrDefault();

	public BozzaAperta Apri(int id)
	{
		using SqlConnection c = _db.Apri();
		return Apri(c, null, id);
	}

	private BozzaAperta Apri(SqlConnection c, SqlTransaction? tx, int id)
	{
		InfoBozza info = Db.Righe(c, tx, SqlInfo + " WHERE B.IdBozza = @id", ("@id", id)).Select(Info).FirstOrDefault()
			?? throw new OperazioneBozzaException($"Bozza {id} non trovata.");
		List<RigaBozza> righe = LeggiRighe(c, tx, id);
		ListinoModificabile? inVigore = info.Contratto == null ? null : ArchivioListini.Carica(c, tx, info.Contratto);
		ListinoModificabile listino = Differenze.Applica(inVigore, righe);
		return new BozzaAperta { Info = info, Listino = listino, InVigore = inVigore, Righe = righe };
	}

	/// <summary>Nuova bozza per modificare un contratto esistente.</summary>
	public int NuovaModifica(string contratto, string utente, string? titolo = null, string origine = "MANUALE", string? fileOrigine = null)
	{
		using SqlConnection c = _db.Apri();
		using SqlTransaction tx = c.BeginTransaction();
		ListinoModificabile l = ArchivioListini.Carica(c, tx, contratto) ?? throw new OperazioneBozzaException($"Il contratto {contratto} non esiste.");
		ControllaNessunaBozzaAperta(c, tx, contratto);
		int id = InserisciBozza(c, tx, contratto, null, l.Contratto.Trasportatore, titolo ?? $"Modifica {contratto}", origine, fileOrigine, utente);
		RegistroListini.Scrivi(c, tx, U(utente), "BOZZA_CREATA", $"Creata la bozza {Codice(id)} per modificare il contratto {contratto}.", contratto, id);
		tx.Commit();
		return id;
	}

	/// <summary>Nuova bozza che crea un contratto nuovo (vuoto oppure con le tariffe indicate).</summary>
	public int NuovoContratto(ListinoModificabile listino, string utente, string? titolo = null, string origine = "MANUALE", string? fileOrigine = null)
	{
		listino.ContrattoNuovo = true;
		DatiContratto d = listino.Contratto;
		d.Codice = d.Codice.Trim().ToUpperInvariant();
		using SqlConnection c = _db.Apri();
		using SqlTransaction tx = c.BeginTransaction();
		if (Db.Righe(c, tx, "SELECT 1 FROM TariffeContratti WHERE Codice = @c", ("@c", d.Codice)).Count > 0)
			throw new OperazioneBozzaException($"Esiste già un contratto con codice {d.Codice}.");
		ControllaNessunaBozzaAperta(c, tx, d.Codice);
		int id = InserisciBozza(c, tx, null, d.Codice, d.Trasportatore, titolo ?? $"Nuovo listino {d.Codice}", origine, fileOrigine, utente);
		ScriviRighe(c, tx, id, Differenze.Calcola(null, listino));
		string desc = origine == "RINNOVO"
			? $"Creata la bozza {Codice(id)}: rinnovo con nuovo contratto {d.Codice} ({listino.Tariffe.Count} tariffe copiate)."
			: $"Creata la bozza {Codice(id)} per il nuovo contratto {d.Codice}.";
		RegistroListini.Scrivi(c, tx, U(utente), "BOZZA_CREATA", desc, d.Codice, id, new { Contratto = d, Tariffe = listino.Tariffe.Count });
		tx.Commit();
		return id;
	}

	/// <summary>Rinnovo: nuovo contratto con le stesse tariffe di uno esistente, da correggere dove i prezzi cambiano.</summary>
	public int Rinnovo(string contrattoOrigine, DatiContratto nuovo, bool chiudiPrecedente, string utente)
	{
		ListinoModificabile origine;
		using (SqlConnection c = _db.Apri())
			origine = ArchivioListini.Carica(c, null, contrattoOrigine) ?? throw new OperazioneBozzaException($"Il contratto {contrattoOrigine} non esiste.");
		ListinoModificabile l = new()
		{
			Contratto = nuovo,
			ContrattoNuovo = true,
			Tariffe = origine.Tariffe.Select(t => t.CopiaComeNuova()).ToList()
		};
		if (chiudiPrecedente && origine.Contratto.DataFine.Date >= nuovo.DataInizio.Date)
			l.ChiudiPrecedente = new ChiusuraContratto(contrattoOrigine, origine.Contratto.DataFine.Date, nuovo.DataInizio.Date.AddDays(-1));
		return NuovoContratto(l, utente, $"Rinnovo {contrattoOrigine} → {nuovo.Codice.Trim().ToUpperInvariant()}", "RINNOVO");
	}

	/// <summary>Salva il listino modificato nella bozza (solo le differenze dal listino in vigore) e registra cosa è cambiato.</summary>
	public IReadOnlyList<Problema> Salva(int id, ListinoModificabile listino, string utente, string? postazione = null)
	{
		using SqlConnection c = _db.Apri();
		using SqlTransaction tx = c.BeginTransaction();
		BozzaAperta b = Apri(c, tx, id);
		if (!b.Info.Modificabile) throw new OperazioneBozzaException($"La bozza {b.Info.Codice} è «{StatiBozza.Etichetta(b.Info.Stato)}»: non si può modificare.");
		if (b.Info.ContrattoNuovo != null)
		{
			listino.ContrattoNuovo = true;
			listino.Contratto.Codice = b.Info.ContrattoNuovo; // il codice del contratto nuovo si sceglie alla creazione
		}
		else listino.Contratto.Codice = b.Info.Contratto!;

		List<string> cambiamenti = Differenze.Descrivi(b.Listino, listino);
		if (b.Listino.ChiudiPrecedente != listino.ChiudiPrecedente && listino.ChiudiPrecedente == null && b.Listino.ChiudiPrecedente != null)
			cambiamenti.Add($"Non viene più chiuso il contratto {b.Listino.ChiudiPrecedente.Codice}");
		List<RigaBozza> righe = Differenze.Calcola(b.InVigore, listino);
		Db.Comando(c, tx, "DELETE FROM TAR_BozzeRighe WHERE IdBozza = @id", ("@id", id)).ExecuteNonQuery();
		ScriviRighe(c, tx, id, righe);
		if (cambiamenti.Count > 0)
		{
			RegistroListini.Scrivi(c, tx, U(utente), "MODIFICA",
				$"Bozza {b.Info.Codice}: {cambiamenti.Count} {(cambiamenti.Count == 1 ? "modifica" : "modifiche")}. {cambiamenti[0]}{(cambiamenti.Count > 1 ? " …" : "")}",
				b.Info.CodiceContratto, id, new { Modifiche = cambiamenti }, postazione);
		}
		tx.Commit();
		return Controlli.Esegui(listino, _anagrafiche.PerControlli());
	}

	public IReadOnlyList<Problema> Controlla(ListinoModificabile listino) => Controlli.Esegui(listino, _anagrafiche.PerControlli());

	public void InviaInValidazione(int id, string utente)
	{
		BozzaAperta b = Apri(id);
		if (b.Righe.Count == 0) throw new OperazioneBozzaException("La bozza non contiene modifiche.");
		ControllaSenzaErrori(b.Listino);
		Transizione(id, utente, new[] { StatiBozza.Bozza }, StatiBozza.Validazione, "INVIATA",
			$"Bozza {b.Info.Codice} inviata in validazione ({b.Righe.Count} {(b.Righe.Count == 1 ? "modifica" : "modifiche")}).",
			b.Info.CodiceContratto, "InviataDa = @u, InviataIl = SYSDATETIME()");
	}

	public void RiportaInBozza(int id, string utente)
	{
		InfoBozza i = Info(id) ?? throw new OperazioneBozzaException($"Bozza {id} non trovata.");
		Transizione(id, utente, new[] { StatiBozza.Validazione }, StatiBozza.Bozza, "RIPORTATA_IN_BOZZA",
			$"Bozza {i.Codice} riportata in bozza per altre modifiche.", i.CodiceContratto, "InviataDa = NULL, InviataIl = NULL");
	}

	public void Rifiuta(int id, string utente, string nota)
	{
		if (string.IsNullOrWhiteSpace(nota)) throw new OperazioneBozzaException("Per rifiutare una bozza scrivi il motivo.");
		InfoBozza i = Info(id) ?? throw new OperazioneBozzaException($"Bozza {id} non trovata.");
		Transizione(id, utente, new[] { StatiBozza.Validazione }, StatiBozza.Rifiutata, "RIFIUTATA",
			$"Bozza {i.Codice} rifiutata: {nota.Trim()}", i.CodiceContratto, "DecisaDa = @u, DecisaIl = SYSDATETIME(), NotaDecisione = @nota", nota.Trim());
	}

	public void Annulla(int id, string utente, string? nota = null)
	{
		InfoBozza i = Info(id) ?? throw new OperazioneBozzaException($"Bozza {id} non trovata.");
		Transizione(id, utente, StatiBozza.Aperti, StatiBozza.Annullata, "ANNULLATA",
			$"Bozza {i.Codice} annullata" + (string.IsNullOrWhiteSpace(nota) ? "." : $": {nota.Trim()}"), i.CodiceContratto,
			"NotaDecisione = COALESCE(@nota, NotaDecisione)", nota?.Trim());
	}

	/// <summary>
	/// Approva la bozza. Si applica subito se crea un contratto nuovo o se <paramref name="applicaDal"/> è vuota o non futura;
	/// altrimenti resta «approvata» e viene applicata da <see cref="ApplicaInAttesa"/> alla data indicata.
	/// </summary>
	public string Approva(int id, string utente, string? nota = null, DateTime? applicaDal = null, string? postazione = null)
	{
		using SqlConnection c = _db.Apri();
		using SqlTransaction tx = c.BeginTransaction();
		BozzaAperta b = Apri(c, tx, id);
		if (b.Info.Stato != StatiBozza.Validazione)
			throw new OperazioneBozzaException($"Si possono approvare solo le bozze da approvare (questa è «{StatiBozza.Etichetta(b.Info.Stato)}»).");
		ControllaSenzaErrori(b.Listino);
		bool subito = b.Info.ContrattoNuovo != null || applicaDal == null || applicaDal.Value.Date <= DateTime.Today;
		Aggiorna(c, tx, id, StatiBozza.Validazione, subito ? StatiBozza.Applicata : StatiBozza.Approvata,
			"DecisaDa = @u, DecisaIl = SYSDATETIME(), NotaDecisione = @nota, ApplicaDal = @dal" + (subito ? ", ApplicataIl = SYSDATETIME()" : ""),
			utente, nota?.Trim(), applicaDal?.Date);
		RegistroListini.Scrivi(c, tx, U(utente), "APPROVATA",
			$"Bozza {b.Info.Codice} approvata" + (subito ? "." : $": verrà applicata il {applicaDal:dd/MM/yyyy}.") + (string.IsNullOrWhiteSpace(nota) ? "" : $" Nota: {nota.Trim()}"),
			b.Info.CodiceContratto, id, null, postazione);
		if (subito) Applica(c, tx, b, utente, postazione);
		tx.Commit();
		return subito ? StatiBozza.Applicata : StatiBozza.Approvata;
	}

	/// <summary>Applica le bozze approvate con data di applicazione raggiunta. Restituisce i messaggi per il log.</summary>
	public IReadOnlyList<string> ApplicaInAttesa(DateTime oggi, string utente = "SISTEMA")
	{
		List<string> esiti = new();
		foreach (InfoBozza i in Elenco(StatiBozza.Approvata).Where(x => x.ApplicaDal != null && x.ApplicaDal.Value.Date <= oggi.Date))
		{
			try
			{
				using SqlConnection c = _db.Apri();
				using SqlTransaction tx = c.BeginTransaction();
				BozzaAperta b = Apri(c, tx, i.IdBozza);
				Aggiorna(c, tx, i.IdBozza, StatiBozza.Approvata, StatiBozza.Applicata, "ApplicataIl = SYSDATETIME()", utente, null, null);
				Applica(c, tx, b, utente, null);
				tx.Commit();
				esiti.Add($"Bozza {i.Codice} applicata.");
			}
			catch (Exception e) when (e is ConflittoListinoException or OperazioneBozzaException or SqlException)
			{
				new RegistroListini(_db).Scrivi(U(utente), "APPLICAZIONE_NON_RIUSCITA", $"Bozza {i.Codice} non applicata: {e.Message}", i.CodiceContratto, i.IdBozza);
				esiti.Add($"Bozza {i.Codice} non applicata: {e.Message}");
			}
		}
		return esiti;
	}

	/// <summary>Scrive la bozza nelle tabelle del motore, dopo aver verificato che il listino non sia cambiato nel frattempo.</summary>
	private static void Applica(SqlConnection c, SqlTransaction tx, BozzaAperta b, string utente, string? postazione)
	{
		string u = U(utente);
		ListinoModificabile? vivo = b.Info.Contratto == null ? null : ArchivioListini.Carica(c, tx, b.Info.Contratto);
		List<string> conflitti = new();
		if (b.Info.ContrattoNuovo != null && Db.Righe(c, tx, "SELECT 1 FROM TariffeContratti WHERE Codice = @c", ("@c", b.Info.ContrattoNuovo)).Count > 0)
			conflitti.Add($"il contratto {b.Info.ContrattoNuovo} è stato creato nel frattempo");
		foreach (RigaBozza r in b.Righe.Where(r => r.DatiPrima != null))
		{
			if (r.Oggetto == Differenze.Contratto)
			{
				DatiContratto prima = JsonListini.Leggi<DatiContratto>(r.DatiPrima!);
				if (vivo == null || !vivo.Contratto.UgualeA(prima)) conflitti.Add("i dati del contratto sono cambiati");
			}
			else
			{
				TariffaModificabile prima = JsonListini.Leggi<TariffaModificabile>(r.DatiPrima!);
				TariffaModificabile? ora = vivo?.Tariffe.FirstOrDefault(t => t.IdTariffa == r.IdOriginale);
				if (ora == null) conflitti.Add($"la tariffa {prima.Etichetta} è stata eliminata");
				else if (ora.Canonico() != prima.Canonico()) conflitti.Add($"la tariffa {prima.Etichetta} è stata modificata");
			}
		}
		if (conflitti.Count > 0)
			throw new ConflittoListinoException($"Il listino è cambiato dopo la preparazione della bozza: {string.Join("; ", conflitti.Distinct())}. Annulla la bozza e preparane una nuova.");

		string contratto = b.Info.CodiceContratto;
		List<string> fatto = new();
		foreach (RigaBozza r in b.Righe.Where(r => r.Oggetto == Differenze.Contratto))
		{
			if (r.DatiDopo!.Contains("\"NuovaDataFine\"")) ArchivioListini.ChiudiContratto(c, tx, JsonListini.Leggi<ChiusuraContratto>(r.DatiDopo), u);
			else if (r.Operazione == Differenze.Nuova) ArchivioListini.InserisciContratto(c, tx, JsonListini.Leggi<DatiContratto>(r.DatiDopo), u);
			else ArchivioListini.AggiornaContratto(c, tx, JsonListini.Leggi<DatiContratto>(r.DatiDopo), u);
			fatto.Add(r.Descrizione);
		}
		IEnumerable<RigaBozza> tariffe = b.Righe.Where(r => r.Oggetto == Differenze.Testata);
		foreach (RigaBozza r in tariffe.Where(r => r.Operazione == Differenze.Elimina))
		{
			ArchivioListini.EliminaTariffa(c, tx, r.IdOriginale!.Value);
			fatto.Add(r.Descrizione);
		}
		foreach (RigaBozza r in tariffe.Where(r => r.Operazione == Differenze.Modifica))
		{
			ArchivioListini.AggiornaTariffa(c, tx, JsonListini.Leggi<TariffaModificabile>(r.DatiPrima!), JsonListini.Leggi<TariffaModificabile>(r.DatiDopo!), u);
			fatto.Add(r.Descrizione);
		}
		foreach (RigaBozza r in tariffe.Where(r => r.Operazione == Differenze.Nuova))
		{
			int nuovo = ArchivioListini.InserisciTariffa(c, tx, contratto, JsonListini.Leggi<TariffaModificabile>(r.DatiDopo!), u);
			fatto.Add($"{r.Descrizione} [tariffa {nuovo}]");
		}
		RegistroListini.Scrivi(c, tx, u, "APPLICATA",
			$"Bozza {b.Info.Codice} applicata al listino {contratto}: {fatto.Count} {(fatto.Count == 1 ? "modifica" : "modifiche")}.",
			contratto, b.Info.IdBozza, new { Modifiche = fatto }, postazione);
	}

	private void ControllaSenzaErrori(ListinoModificabile l)
	{
		List<Problema> errori = Controlli.Esegui(l, _anagrafiche.PerControlli()).Where(p => p.Gravita == Gravita.Errore).ToList();
		if (errori.Count > 0)
			throw new OperazioneBozzaException($"La bozza ha {errori.Count} {(errori.Count == 1 ? "errore" : "errori")} da correggere: {errori[0].Messaggio}");
	}

	private static void ControllaNessunaBozzaAperta(SqlConnection c, SqlTransaction tx, string contratto)
	{
		Dictionary<string, object?>? aperta = Db.Righe(c, tx,
			"SELECT TOP 1 Codice, Stato FROM TAR_Bozze WITH (UPDLOCK, HOLDLOCK) WHERE (Contratto = @c OR ContrattoNuovo = @c) AND Stato IN ('BOZZA', 'VALIDAZIONE', 'APPROVATA')",
			("@c", contratto)).FirstOrDefault();
		if (aperta != null)
			throw new OperazioneBozzaException($"Per il contratto {contratto} c'è già la bozza {aperta.Testo("Codice")} ({StatiBozza.Etichetta(aperta.Testo("Stato"))}): continua quella.");
	}

	private void Transizione(int id, string utente, string[] da, string a, string azione, string descrizione, string contratto, string altro, string? nota = null)
	{
		using SqlConnection c = _db.Apri();
		using SqlTransaction tx = c.BeginTransaction();
		Aggiorna(c, tx, id, da, a, altro, utente, nota, null);
		RegistroListini.Scrivi(c, tx, U(utente), azione, descrizione, contratto, id);
		tx.Commit();
	}

	private static void Aggiorna(SqlConnection c, SqlTransaction tx, int id, string da, string a, string altro, string utente, string? nota, DateTime? dal) =>
		Aggiorna(c, tx, id, new[] { da }, a, altro, utente, nota, dal);

	private static void Aggiorna(SqlConnection c, SqlTransaction tx, int id, string[] da, string a, string altro, string utente, string? nota, DateTime? dal)
	{
		string stati = string.Join(", ", da.Select((_, i) => "@da" + i));
		List<(string, object?)> p = new() { ("@id", id), ("@a", a), ("@u", U(utente)), ("@nota", nota), ("@dal", dal) };
		p.AddRange(da.Select((s, i) => ("@da" + i, (object?)s)));
		using SqlCommand cmd = Db.Comando(c, tx, $"UPDATE TAR_Bozze SET Stato = @a, {altro} WHERE IdBozza = @id AND Stato IN ({stati})", p.ToArray());
		if (cmd.ExecuteNonQuery() == 0)
			throw new OperazioneBozzaException("La bozza è stata cambiata da un altro utente o non è nello stato giusto: ricarica la pagina.");
	}

	private static int InserisciBozza(SqlConnection c, SqlTransaction tx, string? contratto, string? contrattoNuovo, string trasportatore,
		string titolo, string origine, string? file, string utente)
	{
		using SqlCommand cmd = Db.Comando(c, tx, @"
INSERT INTO TAR_Bozze (Contratto, ContrattoNuovo, Trasportatore, Titolo, Origine, FileOrigine, CreataDa)
OUTPUT inserted.IdBozza VALUES (@c, @n, @t, @ti, @o, @f, @u)",
			("@c", contratto), ("@n", contrattoNuovo), ("@t", trasportatore), ("@ti", titolo.Length > 200 ? titolo[..200] : titolo),
			("@o", origine), ("@f", file), ("@u", U(utente)));
		return Convert.ToInt32(cmd.ExecuteScalar());
	}

	private static void ScriviRighe(SqlConnection c, SqlTransaction tx, int id, IEnumerable<RigaBozza> righe)
	{
		foreach (RigaBozza r in righe)
		{
			using SqlCommand cmd = Db.Comando(c, tx, @"
INSERT INTO TAR_BozzeRighe (IdBozza, Ordine, Oggetto, Operazione, IdOriginale, Descrizione, DatiPrima, DatiDopo, RifFile, Esito, Messaggio)
VALUES (@b, @o, @og, @op, @io, @d, @p, @dd, @rf, @e, @m)",
				("@b", id), ("@o", r.Ordine), ("@og", r.Oggetto), ("@op", r.Operazione), ("@io", r.IdOriginale), ("@d", r.Descrizione),
				("@p", r.DatiPrima), ("@dd", r.DatiDopo), ("@rf", r.RifFile), ("@e", r.Esito), ("@m", r.Messaggio));
			cmd.ExecuteNonQuery();
		}
	}

	private static List<RigaBozza> LeggiRighe(SqlConnection c, SqlTransaction? tx, int id) =>
		Db.Righe(c, tx, "SELECT * FROM TAR_BozzeRighe WHERE IdBozza = @id ORDER BY Ordine", ("@id", id))
			.Select(r => new RigaBozza(Convert.ToInt32(r["Ordine"]), r.Testo("Oggetto"), r.Testo("Operazione"), r["IdOriginale"] as int?,
				r.Testo("Descrizione"), r["DatiPrima"] as string, r["DatiDopo"] as string, r["RifFile"] as string, r.Testo("Esito"), r["Messaggio"] as string))
			.ToList();

	private static InfoBozza Info(Dictionary<string, object?> r) => new(
		Convert.ToInt32(r["IdBozza"]), r.Testo("Codice"), r["Contratto"] as string, r["ContrattoNuovo"] as string, r.Testo("Trasportatore"),
		r.Testo("Titolo"), r.Testo("Origine"), r["FileOrigine"] as string, r.Testo("Stato"), r.Data("ApplicaDal"), r["Note"] as string,
		r.Testo("CreataDa"), r.Data("CreataIl")!.Value, r["InviataDa"] as string, r.Data("InviataIl"), r["DecisaDa"] as string, r.Data("DecisaIl"),
		r["NotaDecisione"] as string, r.Data("ApplicataIl"), Convert.ToInt32(r["NumeroRighe"]));

	private static string Codice(int id) => $"B-{id:0000}";

	private static string U(string utente) => utente.Length > 15 ? utente[..15] : utente;
}
