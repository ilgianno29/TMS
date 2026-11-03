using System;
using System.IO;
using System.Linq;
using Delsy.Listini.Bozze;
using Delsy.Listini.Dati;
using Delsy.Listini.Motore;
using Delsy.Listini.Registro;
using Delsy.Listini.Spiegazione;
using Xunit;

namespace Delsy.Tests;

/// <summary>Ciclo completo delle bozze sul database di prova (DELSY_TEST_DB); ogni test rimette i dati come prima.</summary>
[Collection("DatabaseDiProva")]
public class BozzeIntegrazioneTests
{
    private static string? Cs => Environment.GetEnvironmentVariable("DELSY_TEST_DB");
    private static Db Db => new(Cs!);
    private static ServizioBozze Bozze => new(Db, new ServizioAnagrafiche(Db));

    private static decimal Prezzo(int idTariffa, decimal da) => Convert.ToDecimal(Db.Righe(@"
SELECT F.Variabile FROM TariffePassiveFasce F JOIN TariffePassiveVoci V ON V.IdVoce = F.IdVoce WHERE V.IdTariffa = @t AND F.FasciaInferiore = @d",
        ("@t", idTariffa), ("@d", da)).Single()["Variabile"]);

    private static void ImpostaPrezzo(int idTariffa, decimal da, decimal prezzo) => Db.Esegui(@"
UPDATE F SET Variabile = @p FROM TariffePassiveFasce F JOIN TariffePassiveVoci V ON V.IdVoce = F.IdVoce WHERE V.IdTariffa = @t AND F.FasciaInferiore = @d",
        ("@t", idTariffa), ("@d", da), ("@p", prezzo));

    [SkippableFact]
    public void Modifica_approvata_cambia_il_costo_calcolato_dal_motore()
    {
        Skip.If(Cs is null, "DELSY_TEST_DB non impostata");
        try
        {
            int id = Bozze.NuovaModifica("BENNATO 2024", "TEST");
            var b = Bozze.Apri(id);
            var corti = b.Listino.Tariffe.Single(t => t.IdTariffa == 123134);
            corti.Voci[0].Fasce.Single(f => f.Da == 10).Variabile = 36;   // 77120 ha 12 bancali: fascia 10-20
            Assert.DoesNotContain(Bozze.Salva(id, b.Listino, "TEST"), p => p.Gravita == Gravita.Errore);

            var riga = Assert.Single(Bozze.Apri(id).Righe);
            Assert.Contains("10–20: 35,00 €/u → 36,00 €/u", riga.Descrizione);
            Assert.Equal(35m, Prezzo(123134, 10));                          // in bozza: il listino vero non cambia

            Bozze.InviaInValidazione(id, "TEST");
            Assert.Equal(StatiBozza.Applicata, Bozze.Approva(id, "TEST", "ok"));
            Assert.Equal(36m, Prezzo(123134, 10));

            var s = new ServizioSpiegazione(Db, () => MotoreTariffe.Apri(Cs!, "TEST", Path.Combine(Path.GetTempPath(), "delsy-log"))).SpiegaViaggio("1856");
            Assert.Equal(991m + 12m, s.Totale);

            var registro = new RegistroListini(Db).Cerca().Where(r => r.IdBozza == id).Select(r => r.Azione).ToList();
            Assert.Equal(new[] { "APPLICATA", "APPROVATA", "INVIATA", "MODIFICA", "BOZZA_CREATA" }, registro);
        }
        finally
        {
            ImpostaPrezzo(123134, 10, 35);
        }
    }

    [SkippableFact]
    public void Nuovo_contratto_con_fasce_diverse_per_zona()
    {
        Skip.If(Cs is null, "DELSY_TEST_DB non impostata");
        string codice = "T" + DateTime.Now.ToString("HHmmssfff");
        try
        {
            var l = new ListinoModificabile
            {
                Contratto = new DatiContratto { Codice = codice, Descrizione = "Prova nuovo", Trasportatore = "TROSSI", DataInizio = new DateTime(2027, 1, 1), DataFine = new DateTime(2027, 12, 31) }
            };
            foreach (var (zona, fasce) in new[] { ("CORTI", new[] { (0m, 5m, 50m), (5m, 33m, 40m) }), ("TOLME", new[] { (0m, 10m, 30m), (10m, 33m, 25m) }) })
            {
                var t = new TariffaModificabile();
                t.ImpostaCriterio("TipoDocumento", "SPEDIZIONE");
                t.ImpostaCriterio("PCSPartenza", "STDIECIMO");
                t.ImpostaCriterio("ZonaArrivo", zona);
                t.Voci.Add(new VoceModificabile { Voce = "NOLO", CampoCalcolo = "Pallet", Fasce = fasce.Select(f => new FasciaModificabile { Da = f.Item1, A = f.Item2, Variabile = f.Item3 }).ToList() });
                l.Tariffe.Add(t);
            }
            int id = Bozze.NuovoContratto(l, "TEST");
            Assert.Throws<OperazioneBozzaException>(() => Bozze.NuovoContratto(l, "TEST"));   // già una bozza per lo stesso codice
            Bozze.InviaInValidazione(id, "TEST");
            Assert.Equal(StatiBozza.Applicata, Bozze.Approva(id, "TEST", applicaDal: new DateTime(2027, 1, 1)));   // contratto nuovo: subito (valida dal 2027)

            var d = new Delsy.Listini.Listini.ServizioListini(Db).Dettaglio(codice)!;
            Assert.Equal(2, d.Tariffe.Count);
            Assert.Equal(new[] { 30m, 25m }, d.Tariffe.Single(t => t.Destinazione == "TOLME").Voci[0].Fasce.Select(f => f.Variabile));
            Assert.True(d.Tariffe.All(t => t.IdTariffa >= 200001));
        }
        finally
        {
            Db.Esegui(@"DELETE F FROM TariffePassiveFasce F JOIN TariffePassiveVoci V ON V.IdVoce = F.IdVoce JOIN TariffePassiveTestata T ON T.IdTariffa = V.IdTariffa WHERE T.Contratto = @c;
DELETE V FROM TariffePassiveVoci V JOIN TariffePassiveTestata T ON T.IdTariffa = V.IdTariffa WHERE T.Contratto = @c;
DELETE FROM TariffePassiveTestata WHERE Contratto = @c; DELETE FROM TariffeContratti WHERE Codice = @c;", ("@c", codice));
        }
    }

    [SkippableFact]
    public void Se_il_listino_cambia_nel_frattempo_l_approvazione_si_ferma()
    {
        Skip.If(Cs is null, "DELSY_TEST_DB non impostata");
        int id = Bozze.NuovaModifica("BENNATO 2024", "TEST");
        try
        {
            var b = Bozze.Apri(id);
            b.Listino.Tariffe.Single(t => t.IdTariffa == 123136).Voci[0].Fasce[0].Variabile = 99;
            Bozze.Salva(id, b.Listino, "TEST");
            Bozze.InviaInValidazione(id, "TEST");
            ImpostaPrezzo(123136, 0, 36);                                   // qualcuno cambia il listino da Delsy
            var e = Assert.Throws<ConflittoListinoException>(() => Bozze.Approva(id, "TEST"));
            Assert.Contains("TOLME", e.Message);
            Assert.Equal(StatiBozza.Validazione, Bozze.Info(id)!.Stato);
            Assert.Equal(36m, Prezzo(123136, 0));
        }
        finally
        {
            ImpostaPrezzo(123136, 0, 35);
            Bozze.Annulla(id, "TEST", "test");
        }
    }

    [SkippableFact]
    public void Modifica_con_data_futura_si_applica_alla_data()
    {
        Skip.If(Cs is null, "DELSY_TEST_DB non impostata");
        int id = Bozze.NuovaModifica("BENNATO 2024", "TEST");
        try
        {
            var b = Bozze.Apri(id);
            b.Listino.Tariffe.Single(t => t.IdTariffa == 123137).Voci[0].Fasce[0].Variabile = 42;
            Bozze.Salva(id, b.Listino, "TEST");
            Bozze.InviaInValidazione(id, "TEST");
            DateTime domani = DateTime.Today.AddDays(1);
            Assert.Equal(StatiBozza.Approvata, Bozze.Approva(id, "TEST", applicaDal: domani));
            Assert.DoesNotContain(Bozze.ApplicaInAttesa(DateTime.Today), m => m.Contains($"B-{id:0000}"));
            Assert.Equal(41m, Prezzo(123137, 0));
            Assert.Contains($"Bozza B-{id:0000} applicata.", Bozze.ApplicaInAttesa(domani));
            Assert.Equal(42m, Prezzo(123137, 0));
            Assert.Equal(StatiBozza.Applicata, Bozze.Info(id)!.Stato);
        }
        finally
        {
            ImpostaPrezzo(123137, 0, 41);
            if (Bozze.Info(id)!.Stato != StatiBozza.Applicata) Bozze.Annulla(id, "TEST");
        }
    }

    [SkippableFact]
    public void Gli_errori_bloccano_l_invio()
    {
        Skip.If(Cs is null, "DELSY_TEST_DB non impostata");
        int id = Bozze.NuovaModifica("BENNATO 2024", "TEST");
        try
        {
            var b = Bozze.Apri(id);
            b.Listino.Tariffe[0].Voci[0].Voce = "XXX";
            var problemi = Bozze.Salva(id, b.Listino, "TEST");
            Assert.Contains(problemi, p => p.Gravita == Gravita.Errore && p.Messaggio.Contains("non esiste o non è attiva"));
            Assert.Throws<OperazioneBozzaException>(() => Bozze.InviaInValidazione(id, "TEST"));
            Assert.Throws<OperazioneBozzaException>(() => Bozze.Rifiuta(id, "TEST", " "));
        }
        finally
        {
            Bozze.Annulla(id, "TEST");
        }
    }
}
