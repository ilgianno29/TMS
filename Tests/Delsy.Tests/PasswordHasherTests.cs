using Incasbo.Security;
using Xunit;

namespace Delsy.Tests;

public class PasswordHasherTests
{
    [Fact]
    public void Hash_e_verifica()
    {
        string hash = PasswordHasher.Hash("Segreta!2024", 10000);
        Assert.StartsWith("PBKDF2-SHA256$10000$", hash);
        Assert.True(PasswordHasher.Verify("Segreta!2024", hash));
        Assert.False(PasswordHasher.Verify("segreta!2024", hash));
        Assert.False(PasswordHasher.Verify("", hash));
    }

    [Fact]
    public void Stessa_password_hash_diversi_grazie_al_salt()
    {
        Assert.NotEqual(PasswordHasher.Hash("abc123456789", 10000), PasswordHasher.Hash("abc123456789", 10000));
    }

    [Fact]
    public void Lunghezza_entro_il_massimo_dichiarato()
    {
        Assert.True(PasswordHasher.Hash("x").Length <= PasswordHasher.MaxHashLength);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("password-in-chiaro")]
    [InlineData("PBKDF2-SHA256$abc$xx$yy")]
    [InlineData("PBKDF2-SHA256$10000$non-base64!$x")]
    public void Valori_non_validi_non_verificano(string? stored)
    {
        Assert.False(PasswordHasher.Verify("password-in-chiaro", stored!));
    }

    [Fact]
    public void NeedsRehash_per_poche_iterazioni_o_vecchio_formato()
    {
        Assert.True(PasswordHasher.NeedsRehash(PasswordHasher.Hash("a", 10000)));
        Assert.True(PasswordHasher.NeedsRehash("vecchia-cifrata"));
        Assert.False(PasswordHasher.NeedsRehash(PasswordHasher.Hash("a")));
    }
}
