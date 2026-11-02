using System;
using System.Collections.Generic;
using Incasbo.Api.Statistics;
using Xunit;

namespace Delsy.Tests;

/// <summary>Il JSON deve restare identico a quello prodotto dal vecchio JavaScriptSerializer.</summary>
public class LegacyJsonTests
{
    [Fact]
    public void Enum_come_numero_e_nomi_proprieta_invariati()
    {
        var filtri = new List<StatisticRunningFilter>
        {
            new StatisticRunningFilter { NomeCampo = "Codice", DescrizioneCampo = "Cod", ValoreCampo = "A1" }
        };
        string json = LegacyJson.Serialize(filtri);

        Assert.StartsWith("[{\"NomeCampo\":\"Codice\",\"DescrizioneCampo\":\"Cod\",\"TipoCampo\":", json);
        Assert.Contains("\"ValoreCampo\":\"A1\"", json);
        Assert.Matches("\"Operatore\":\\d+", json);
    }

    [Fact]
    public void Date_nel_formato_Microsoft()
    {
        var utc = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
        Assert.Equal("\"\\/Date(1704164645000)\\/\"", LegacyJson.Serialize(utc));
    }
}
