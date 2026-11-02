using Incasbo.Web.Library;
using Xunit;
using static Incasbo.Web.Library.DBFormatFunctions;

namespace Delsy.Tests;

/// <summary>Fissano il comportamento attuale delle funzioni di formattazione SQL.</summary>
public class DBFormatFunctionsTests
{
    [Theory]
    [InlineData("abc", "'abc'")]
    [InlineData("l'albero", "'l''albero'")]
    [InlineData("x'; DROP TABLE T; --", "'x''; DROP TABLE T; --'")]
    [InlineData("", "NULL")]
    [InlineData(null, "NULL")]
    public void SQLFormatString_raddoppia_gli_apici(string? input, string expected)
    {
        Assert.Equal(expected, SQLFormatString(eServerType.SQL, input!));
    }

    [Theory]
    [InlineData("12,5", "12.5")]
    [InlineData("100", "100")]
    [InlineData("", "NULL")]
    public void SQLFormatNumber_usa_il_punto_decimale(string input, string expected)
    {
        Assert.Equal(expected, SQLFormatNumber(eServerType.SQL, input));
    }
}
