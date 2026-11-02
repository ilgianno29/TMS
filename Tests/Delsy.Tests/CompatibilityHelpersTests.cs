using System.Globalization;
using System.IO;
using Incasbo.Web.Library;
using Xunit;

namespace Delsy.Tests;

public class CompatibilityHelpersTests
{
    [Fact]
    public void LegacyEncoding_Ansi_scrive_le_accentate_su_un_byte_come_Windows_1252()
    {
        var previous = CultureInfo.CurrentCulture;
        try
        {
            CultureInfo.CurrentCulture = new CultureInfo("it-IT");
            var bytes = LegacyEncoding.Ansi.GetBytes("perché");
            Assert.Equal(1252, LegacyEncoding.Ansi.CodePage);
            Assert.Equal(6, bytes.Length);
            Assert.Equal(0xE9, bytes[5]);
        }
        finally
        {
            CultureInfo.CurrentCulture = previous;
        }
    }

    [Fact]
    public void AssemblyLocation_restituisce_la_cartella_della_dll()
    {
        var assembly = typeof(AssemblyLocation).Assembly;
        string dir = AssemblyLocation.DirectoryOf(assembly);
        Assert.True(File.Exists(Path.Combine(dir, "IboClassLib.dll")));
    }
}
