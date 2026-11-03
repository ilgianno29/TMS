using System;
using System.IO;
using System.Linq;
using Delsy.Listini.Dati;
using Delsy.Listini.Motore;
using Delsy.Listini.Spiegazione;
using Xunit;
using Xunit.Abstractions;

namespace Delsy.Tests;

/// <summary>«Perché questo costo?» contro il database di prova (DELSY_TEST_DB).</summary>
public class SpiegazioneIntegrazioneTests
{
    private readonly ITestOutputHelper _out;
    public SpiegazioneIntegrazioneTests(ITestOutputHelper output) => _out = output;

    private static string? Cs => Environment.GetEnvironmentVariable("DELSY_TEST_DB");

    private static ServizioSpiegazione Servizio() =>
        new(new Db(Cs!), () => MotoreTariffe.Apri(Cs!, "TEST", Path.Combine(Path.GetTempPath(), "delsy-log")));

    private void Stampa(SpiegazioneDocumento d)
    {
        _out.WriteLine($"== {d.Titolo} contratto={d.Contratto?.Codice} tariffa={d.TariffaApplicata?.IdTariffa} totale={d.Totale}");
        foreach (var m in d.DatiMancanti) _out.WriteLine("  mancante: " + m);
        foreach (var m in d.MessaggiMotore) _out.WriteLine("  motore: " + m);
        foreach (var v in d.TariffeVicine) _out.WriteLine($"  vicina {v.IdTariffa}: " + string.Join("; ", v.NonCorrispondenti.Select(c => $"{c.Etichetta} {c.ValoreDocumento}≠{c.ValoreTariffa}")));
    }

    [SkippableFact]
    public void Viaggio_costo_zero_con_transit_point()
    {
        Skip.If(Cs is null, "DELSY_TEST_DB non impostata");
        SpiegazioneViaggio s = Servizio().SpiegaViaggio("1856");
        Stampa(s.Viaggio);
        s.Spedizioni.ForEach(Stampa);

        Assert.Equal("BENNATO 2024", s.Viaggio.Contratto?.Codice);
        Assert.Equal(123130, s.Viaggio.TariffaApplicata?.IdTariffa);
        Assert.Equal(0m, s.Viaggio.Totale);
        Assert.Equal(3, s.Spedizioni.Count);
        Assert.All(s.Spedizioni, sp => Assert.NotNull(sp.TariffaApplicata));
        Assert.Equal(991m, s.Totale);
    }

    [SkippableFact]
    public void Viaggio_senza_tariffa_mostra_la_piu_vicina()
    {
        Skip.If(Cs is null, "DELSY_TEST_DB non impostata");
        SpiegazioneViaggio s = Servizio().SpiegaViaggio("1851");
        Stampa(s.Viaggio);

        Assert.Null(s.Viaggio.TariffaApplicata);
        Assert.Equal(0m, s.Viaggio.Totale);
        ConfrontoTariffa vicina = s.Viaggio.TariffeVicine.First();
        Assert.Equal(200001, vicina.IdTariffa);
        Criterio sbagliato = Assert.Single(vicina.NonCorrispondenti);
        Assert.Equal("ZonaArrivo", sbagliato.Nome);
        Assert.Equal("LIGPO", sbagliato.ValoreDocumento);
        Assert.Equal("CORTI", sbagliato.ValoreTariffa);
    }
}
