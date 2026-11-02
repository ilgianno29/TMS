using System;
using System.IO;
using Incasbo.Security;
using Incasbo.Web.WSCWCF;
using Xunit;

namespace Delsy.Tests;

public class TechnicalUsersTests : IDisposable
{
    private readonly string _dir = Path.Combine(Path.GetTempPath(), "delsy-tu-" + Guid.NewGuid());

    public TechnicalUsersTests() => Directory.CreateDirectory(_dir);
    public void Dispose() => Directory.Delete(_dir, true);

    private void Configure(string content) => File.WriteAllText(Path.Combine(_dir, TechnicalUsers.ConfigFileName), content);

    [Fact]
    public void La_vecchia_password_fissa_non_e_piu_accettata()
    {
        Configure("[ES]\nPasswordHash=" + PasswordHasher.Hash("NuovaPasswordWms!", 10000) + "\n");
        Assert.False(TechnicalUsers.VerifyExternal("ES", "74incasbo04", _dir));
        Assert.False(TechnicalUsers.IsInternal("ES", "74incasbo04", "ES"));
        Assert.False(TechnicalUsers.IsInternal("EU_INCAS", "74incasbo04", "EU_INCAS"));
    }

    [Fact]
    public void Utente_configurato_accettato_con_la_password_giusta()
    {
        Configure("[ES]\nPasswordHash=" + PasswordHasher.Hash("NuovaPasswordWms!", 10000) + "\n");
        Assert.True(TechnicalUsers.VerifyExternal("ES", "NuovaPasswordWms!", _dir));
        Assert.True(TechnicalUsers.VerifyExternal("ES", "NuovaPasswordWms!", _dir)); // dalla cache
        Assert.False(TechnicalUsers.VerifyExternal("ES", "sbagliata", _dir));
    }

    [Fact]
    public void Utente_non_configurato_o_file_assente_rifiutato()
    {
        Assert.False(TechnicalUsers.VerifyExternal("ES", "qualsiasi", _dir));
        Configure("[ES]\nPasswordHash=" + PasswordHasher.Hash("x-123456789012", 10000) + "\n");
        Assert.False(TechnicalUsers.VerifyExternal("EU_INCAS", "x-123456789012", _dir));
    }

    [Fact]
    public void Hash_vuoto_o_password_in_chiaro_nel_file_non_valgono()
    {
        Configure("[ES]\nPasswordHash=\n[EU_INCAS]\nPasswordHash=74incasbo04\n");
        Assert.False(TechnicalUsers.VerifyExternal("ES", "", _dir));
        Assert.False(TechnicalUsers.VerifyExternal("EU_INCAS", "74incasbo04", _dir));
    }

    [Fact]
    public void Cambio_password_nel_file_invalida_la_cache()
    {
        Configure("[ES]\nPasswordHash=" + PasswordHasher.Hash("Prima-1234567", 10000) + "\n");
        Assert.True(TechnicalUsers.VerifyExternal("ES", "Prima-1234567", _dir));
        Configure("[ES]\nPasswordHash=" + PasswordHasher.Hash("Dopo-12345678", 10000) + "\n");
        Assert.False(TechnicalUsers.VerifyExternal("ES", "Prima-1234567", _dir));
        Assert.True(TechnicalUsers.VerifyExternal("ES", "Dopo-12345678", _dir));
    }

    [Fact]
    public void Credenziali_interne_valide_solo_con_il_segreto_di_processo()
    {
        Assert.True(TechnicalUsers.IsInternal("ENGINE", TechnicalUsers.InternalPassword, "ENGINE"));
        Assert.False(TechnicalUsers.IsInternal("ES", TechnicalUsers.InternalPassword, "ENGINE"));
        Assert.StartsWith("internal:", TechnicalUsers.InternalPassword);
        Assert.True(TechnicalUsers.InternalPassword.Length > 40);
    }
}
