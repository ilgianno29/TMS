using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using Delsy.Listini.Motore;
using Incasbo.Api.Gdo.Tariffe;
using Xunit;
using Xunit.Abstractions;

namespace Delsy.Tests;

/// <summary>
/// Esegue il motore tariffe originale contro un database Delsy di prova
/// (Tests/DatabaseDiProva). Si attiva impostando DELSY_TEST_DB con la stringa di connessione.
/// </summary>
[Collection("DatabaseDiProva")]
public class MotoreTariffeIntegrazioneTests
{
    private readonly ITestOutputHelper _out;
    public MotoreTariffeIntegrazioneTests(ITestOutputHelper output) => _out = output;

    private static string? Db => Environment.GetEnvironmentVariable("DELSY_TEST_DB");

    [SkippableFact]
    public void Simulazione_viaggio_costo_zero()
    {
        Skip.If(Db is null, "DELSY_TEST_DB non impostata");
        using var motore = MotoreTariffe.Apri(Db!, "TEST", Path.Combine(Path.GetTempPath(), "delsy-log"));
        string warning = "", mess = "";
        var viaggio = new Simulation_TariffeTrasportoPassiveViaggioEngine(motore.Contesto, "1856", "BENNATO");
        var esito = viaggio.Run(ref warning, ref mess);
        _out.WriteLine($"VIAGGIO esito={esito} mess={mess} warning={warning}");
        decimal totViaggio = 0;
        foreach (Costo c in viaggio.Costi) { totViaggio += c.ImportoArrotondato; _out.WriteLine($"  {c.Voce} {c.CampoCalcolo} q={c.QuantitaTassata} imp={c.ImportoArrotondato} | {c.EstremiTariffa}"); }
        decimal totSped = 0;
        foreach (var unibol in new[] { "77120", "77125", "77131" })
        {
            string w = "", m = "";
            var sped = new Simulation_TariffeTrasportoPassiveSpedizioniEngine(motore.Contesto, unibol, "TPBELLUNO");
            var e2 = sped.Run(ref w, ref m);
            _out.WriteLine($"SPEDIZIONE {unibol} esito={e2} mess={m} warning={w}");
            foreach (Costo c in sped.Costi) { totSped += c.ImportoArrotondato; _out.WriteLine($"  {c.Voce} {c.CampoCalcolo} q={c.QuantitaTassata} unit={c.ImportoUnitario} imp={c.ImportoArrotondato} | {c.EstremiTariffa}"); }
        }
        _out.WriteLine($"TOTALE viaggio={totViaggio} spedizioni={totSped}");
        Assert.Equal(0m, totViaggio);
        Assert.Equal(12 * 35m + 9 * 31m + 8 * 36.5m, totSped);
        Assert.Equal(0, (int)esito);
    }
}
