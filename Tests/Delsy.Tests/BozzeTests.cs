using System;
using System.Collections.Generic;
using System.Linq;
using Delsy.Listini.Bozze;
using Xunit;

namespace Delsy.Tests;

/// <summary>Differenze e controlli delle bozze, senza database.</summary>
public class BozzeTests
{
    private static TariffaModificabile Tariffa(int? id, string zona, params (decimal Da, decimal A, decimal Var)[] fasce)
    {
        var t = new TariffaModificabile { IdTariffa = id };
        t.ImpostaCriterio("TipoDocumento", "SPEDIZIONE");
        t.ImpostaCriterio("PCSPartenza", "STDIECIMO");
        t.ImpostaCriterio("ZonaArrivo", zona);
        int idf = (id ?? 0) * 10;
        t.Voci.Add(new VoceModificabile
        {
            IdVoce = id, Voce = "NOLO", CampoCalcolo = "Pallet",
            Fasce = fasce.Select(f => new FasciaModificabile { IdFascia = id == null ? null : ++idf, Da = f.Da, A = f.A, Variabile = f.Var }).ToList()
        });
        return t;
    }

    private static ListinoModificabile Listino() => new()
    {
        Contratto = new DatiContratto { Codice = "BENNATO 2024", Descrizione = "BENNATO 2024", Trasportatore = "BENNATO", DataInizio = new DateTime(2024, 1, 1), DataFine = new DateTime(2026, 12, 31) },
        Tariffe = { Tariffa(1, "CORTI", (0, 5, 44), (5, 10, 39)), Tariffa(2, "TOLME", (0, 5, 35), (5, 10, 31)) }
    };

    private static Anagrafiche Anagrafiche() => new()
    {
        Trasportatori = Delsy.Listini.Bozze.Anagrafiche.Nuovo(new[] { "BENNATO" }),
        Contratti = Delsy.Listini.Bozze.Anagrafiche.Nuovo(new[] { "BENNATO 2024" }),
        Voci = Delsy.Listini.Bozze.Anagrafiche.Nuovo(new[] { "NOLO", "FUEL" }),
        CampiCalcolo = Delsy.Listini.Bozze.Anagrafiche.Nuovo(new[] { "Pallet", "Forfait", "Peso" }),
        Criteri = new(StringComparer.OrdinalIgnoreCase) { ["ZonaArrivo"] = Delsy.Listini.Bozze.Anagrafiche.Nuovo(new[] { "CORTI", "TOLME", "CROVI" }) }
    };

    [Fact]
    public void Nessuna_modifica_nessuna_riga()
    {
        Assert.Empty(Differenze.Calcola(Listino(), Listino()));
    }

    [Fact]
    public void Modifica_di_un_prezzo_diventa_una_riga_leggibile()
    {
        var originale = Listino();
        var nuovo = originale.Copia();
        nuovo.Tariffe[0].Voci[0].Fasce[0].Variabile = 46;
        var riga = Assert.Single(Differenze.Calcola(originale, nuovo));
        Assert.Equal(("TESTATA", "MODIFICA", (int?)1), (riga.Oggetto, riga.Operazione, riga.IdOriginale));
        Assert.Contains("NOLO 0–5: 44,00 €/u → 46,00 €/u", riga.Descrizione);
        Assert.Contains("CORTI", riga.Descrizione);
    }

    [Fact]
    public void Nuova_ed_eliminata_e_ricostruzione_della_bozza()
    {
        var originale = Listino();
        var nuovo = originale.Copia();
        nuovo.Tariffe.RemoveAt(1);
        nuovo.Tariffe.Add(Tariffa(null, "CROVI", (0, 10, 41), (10, 33, 32.5m)));
        nuovo.Contratto.DataFine = new DateTime(2027, 6, 30);
        var righe = Differenze.Calcola(originale, nuovo);
        Assert.Equal(new[] { "CONTRATTO MODIFICA", "TESTATA NUOVA", "TESTATA ELIMINA" }, righe.Select(r => $"{r.Oggetto} {r.Operazione}"));
        Assert.Contains("fine 31/12/2026 → 30/06/2027", righe[0].Descrizione);

        var ricostruito = Differenze.Applica(originale, righe);
        Assert.Equal(new DateTime(2027, 6, 30), ricostruito.Contratto.DataFine);
        Assert.Equal(new[] { "CORTI", "CROVI" }, ricostruito.Tariffe.Select(t => t.Destinazione).OrderBy(x => x));
        Assert.Empty(Differenze.Calcola(originale, ricostruito).Select(r => r.Descrizione).Except(righe.Select(r => r.Descrizione)));
    }

    [Fact]
    public void Le_fasce_possono_essere_diverse_da_zona_a_zona()
    {
        var l = Listino();
        l.Tariffe[1].Voci[0].Fasce = new() { new() { Da = 0, A = 8, Variabile = 33 }, new() { Da = 8, A = 33, Variabile = 26 } };
        Assert.DoesNotContain(Controlli.Esegui(l, Anagrafiche()), p => p.Gravita == Gravita.Errore);
        Assert.NotEqual(l.Tariffe[0].Voci[0].SchemaFasce, l.Tariffe[1].Voci[0].SchemaFasce);
    }

    [Fact]
    public void Controlli_trovano_gli_errori_tipici()
    {
        var l = Listino();
        l.Tariffe[0].Voci[0].Fasce.Add(new FasciaModificabile { Da = 8, A = 20, Variabile = 30 });   // si sovrappone a 5-10
        l.Tariffe[1].ImpostaCriterio("ZonaArrivo", "ZZZ");                                          // zona inesistente
        l.Tariffe.Add(Tariffa(null, "CORTI", (0, 5, 1)));                                            // stessi criteri della prima
        l.Tariffe.Add(Tariffa(null, "CROVI", (0, 5, 1), (6, 10, 1)));                                // buco 5-6 (avviso)
        var p = Controlli.Esegui(l, Anagrafiche());
        Assert.Contains(p, x => x.Gravita == Gravita.Errore && x.Messaggio.Contains("si sovrappongono"));
        Assert.Contains(p, x => x.Gravita == Gravita.Errore && x.Messaggio.Contains("«ZZZ» non esiste"));
        Assert.Contains(p, x => x.Gravita == Gravita.Errore && x.Messaggio.Contains("stessi criteri"));
        Assert.Contains(p, x => x.Gravita == Gravita.Avviso && x.Messaggio.Contains("tra 5 e 6"));
    }

    [Fact]
    public void Contratto_nuovo_con_codice_esistente_e_date_invertite()
    {
        var l = Listino();
        l.ContrattoNuovo = true;
        l.Contratto.DataFine = new DateTime(2023, 1, 1);
        var p = Controlli.Esegui(l, Anagrafiche()).Select(x => x.Messaggio).ToList();
        Assert.Contains(p, m => m.Contains("Esiste già un contratto"));
        Assert.Contains(p, m => m.Contains("fine validità è precedente"));
    }
}
