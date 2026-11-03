using System;
using System.Collections.Generic;
using System.Linq;
using Delsy.Listini.Spiegazione;
using Xunit;

namespace Delsy.Tests;

public class CriteriTariffaTests
{
    private static readonly string[] TipiSpedizione = { "SPEDIZIONE" };

    private static Dictionary<string, string> D(params (string K, string V)[] v) =>
        v.ToDictionary(x => x.K, x => x.V, StringComparer.OrdinalIgnoreCase);

    private static readonly Dictionary<string, string> Documento = D(
        ("TipoSpedizione", "STD"), ("TipoMerce", "CARTA"), ("TipoMezzo", "BIL"), ("Cliente", "LUCART"),
        ("PCSPartenza", "STDIECIMO"), ("MacroZonaArrivo", "NE"), ("ZonaArrivo", "CORTI"), ("PCSArrivo", "CL0001"));

    [Fact]
    public void Tariffa_generica_corrisponde_a_tutto()
    {
        var c = CriteriTariffa.Confronta(1, 0, D(), Documento, TipiSpedizione);
        Assert.True(c.Corrisponde);
        Assert.Equal(0, c.CriteriSpecificiCorrispondenti);
    }

    [Fact]
    public void Valore_diverso_non_corrisponde_e_viene_indicato()
    {
        var c = CriteriTariffa.Confronta(2, 10_000_000, D(("ZonaArrivo", "TOLME")), Documento, TipiSpedizione);
        Assert.False(c.Corrisponde);
        var sbagliato = Assert.Single(c.NonCorrispondenti);
        Assert.Equal("ZonaArrivo", sbagliato.Nome);
        Assert.Equal("CORTI", sbagliato.ValoreDocumento);
        Assert.Equal("TOLME", sbagliato.ValoreTariffa);
    }

    [Fact]
    public void Tipo_documento_non_ammesso_non_corrisponde()
    {
        var c = CriteriTariffa.Confronta(3, 0, D(("TipoDocumento", "VIAGGIO")), Documento, TipiSpedizione);
        Assert.False(c.Corrisponde);
        Assert.True(CriteriTariffa.Confronta(4, 0, D(("TipoDocumento", "spedizione")), Documento, TipiSpedizione).Corrisponde);
    }

    [Fact]
    public void Applicata_e_la_piu_specifica_tra_quelle_che_corrispondono()
    {
        var confronti = new[]
        {
            CriteriTariffa.Confronta(10, 100_000, D(("PCSPartenza", "STDIECIMO")), Documento, TipiSpedizione),
            CriteriTariffa.Confronta(11, 10_100_000, D(("PCSPartenza", "STDIECIMO"), ("ZonaArrivo", "CORTI")), Documento, TipiSpedizione),
            CriteriTariffa.Confronta(12, 1_000_000_000, D(("PCSArrivo", "CL0002")), Documento, TipiSpedizione),
        };
        Assert.Equal(11, CriteriTariffa.Applicata(confronti)!.IdTariffa);
    }

    [Fact]
    public void Piu_vicine_ordina_per_meno_criteri_sbagliati()
    {
        var confronti = new[]
        {
            CriteriTariffa.Confronta(20, 0, D(("ZonaArrivo", "TOLME"), ("TipoMezzo", "GEN")), Documento, TipiSpedizione),
            CriteriTariffa.Confronta(21, 0, D(("ZonaArrivo", "TOLME"), ("PCSPartenza", "STDIECIMO")), Documento, TipiSpedizione),
            CriteriTariffa.Confronta(22, 0, D(("ZonaArrivo", "TOLME")), Documento, TipiSpedizione),
        };
        Assert.Null(CriteriTariffa.Applicata(confronti));
        Assert.Equal(new[] { 21, 22, 20 }, CriteriTariffa.PiuVicine(confronti).Select(c => c.IdTariffa));
    }
}
