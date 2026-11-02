using Incasbo.Security;
using Incasbo.Web.Library;
using Xunit;

namespace Delsy.Tests;

public class UserPasswordsTests
{
    private static string Legacy(string plain) => new IboCrypt().EncryptString128Bit(plain);

    [Fact]
    public void Vecchia_password_cifrata_verificata_e_da_convertire()
    {
        string stored = Legacy("Mario.2024!");
        Assert.True(UserPasswords.Verify("Mario.2024!", stored, cryptographyEnable: true, out bool upgrade));
        Assert.True(upgrade);
        Assert.False(UserPasswords.Verify("mario.2024!", stored, true, out _));
    }

    [Fact]
    public void Non_si_entra_inviando_il_valore_cifrato_al_posto_della_password()
    {
        // "pass-the-hash": con la cifratura attiva il valore salvato non vale come password
        string stored = Legacy("Mario.2024!");
        Assert.False(UserPasswords.Verify(stored, stored, cryptographyEnable: true, out _));
    }

    [Fact]
    public void Vecchia_password_in_chiaro_con_cifratura_disattivata()
    {
        Assert.True(UserPasswords.Verify("chiaro123", "chiaro123", cryptographyEnable: false, out bool upgrade));
        Assert.True(upgrade);
        Assert.False(UserPasswords.Verify("altro", "chiaro123", false, out _));
    }

    [Fact]
    public void Nuovo_hash_verificato_senza_conversione()
    {
        string stored = UserPasswords.ForStorage("Nuova#Password1");
        Assert.True(UserPasswords.Verify("Nuova#Password1", stored, true, out bool upgrade));
        Assert.False(upgrade);
        Assert.True(UserPasswords.Verify("Nuova#Password1", stored, false, out _));
    }

    [Theory]
    [InlineData("", "x")]
    [InlineData("x", "")]
    [InlineData(null, "x")]
    public void Valori_vuoti_rifiutati(string? password, string stored)
    {
        Assert.False(UserPasswords.Verify(password!, stored, true, out _));
    }

    [Fact]
    public void Conversione_massiva_dal_vecchio_formato()
    {
        string hash = UserPasswords.UpgradeLegacy(Legacy("Abc!12345"), true)!;
        Assert.True(PasswordHasher.IsHash(hash));
        Assert.True(UserPasswords.Verify("Abc!12345", hash, true, out _));
        Assert.Null(UserPasswords.UpgradeLegacy(hash, true)); // gia' convertita
        Assert.Null(UserPasswords.UpgradeLegacy("", true));
        Assert.True(UserPasswords.Verify("inchiaro", UserPasswords.UpgradeLegacy("inchiaro", false)!, false, out _));
    }

    [Fact]
    public void La_parola_magica_non_vale_piu_come_password()
    {
        // Prima "__DO_NOT_VERIFY__" (con cifratura disattivata) faceva entrare senza password
        string stored = UserPasswords.ForStorage("vera-password-1");
        Assert.False(UserPasswords.Verify("__DO_NOT_VERIFY__", stored, false, out _));
    }
}
