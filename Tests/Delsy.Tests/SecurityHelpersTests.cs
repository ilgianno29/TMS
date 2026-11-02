using Incasbo.Security;
using Xunit;

namespace Delsy.Tests;

public class SafeRedirectTests
{
    [Theory]
    [InlineData("~/wfi/Form/WFStandardgrid.aspx?nomrif=DM.ANA.MEZZI")]
    [InlineData("/WFI/Form/WFIDesktop2.aspx")]
    [InlineData("/WFI/Form/x.aspx?ora=10:30")]
    public void Indirizzi_interni_ammessi(string url) => Assert.True(SafeRedirect.IsLocal(url));

    [Theory]
    [InlineData("http://sito-esterno.example/login")]
    [InlineData("https://sito-esterno.example")]
    [InlineData("//sito-esterno.example/x")]
    [InlineData("/\\sito-esterno.example")]
    [InlineData("~//sito-esterno.example")]
    [InlineData("javascript:alert(1)")]
    [InlineData("/javascript:alert(1)")]
    [InlineData("/x\\..\\y")]
    [InlineData("/x\r\nSet-Cookie: a=b")]
    [InlineData("pagina.aspx")]
    [InlineData("")]
    [InlineData(null)]
    public void Indirizzi_esterni_o_ambigui_rifiutati(string? url)
    {
        Assert.False(SafeRedirect.IsLocal(url!));
        Assert.Equal("", SafeRedirect.LocalOrEmpty(url!));
    }
}

public class ConfigNamesTests
{
    [Theory]
    [InlineData("", "")]
    [InlineData("Lucart", "Lucart")]
    [InlineData("_Test-2", "_Test-2")]
    [InlineData("..\\..\\Windows\\win", "")]
    [InlineData("../../x", "")]
    [InlineData("\\\\server\\share\\x", "")]
    [InlineData("C:\\x", "")]
    [InlineData(null, "")]
    public void Solo_nomi_semplici(string? input, string expected) => Assert.Equal(expected, ConfigNames.Sanitize(input!));
}

public class DeviceTokensTests
{
    [Fact]
    public void Token_casuali_lunghi_e_adatti_all_indirizzo()
    {
        string a = DeviceTokens.NewToken(), b = DeviceTokens.NewToken();
        Assert.NotEqual(a, b);
        Assert.Equal(43, a.Length); // 256 bit in Base64 URL senza '='
        Assert.Matches("^[A-Za-z0-9_-]+$", a);
    }

    [Fact]
    public void Hash_SHA256_esadecimale_stabile()
    {
        Assert.Equal("ba7816bf8f01cfea414140de5dae2223b00361a396177a9cb410ff61f20015ad", DeviceTokens.Hash("abc"));
        Assert.Equal(64, DeviceTokens.Hash(DeviceTokens.NewToken()).Length);
    }
}
