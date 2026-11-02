using Incasbo.Web.Library;
using Microsoft.Data.SqlClient;
using Xunit;

namespace Delsy.Tests;

public class SqlServerConnectionStringTests
{
    [Fact]
    public void Build_con_utente_e_password()
    {
        var cs = DBConnection.BuildSqlServerConnectionString("srv01", "DELSY", "utente", "pwd", false, 30);
        var b = new SqlConnectionStringBuilder(cs);

        Assert.Equal("srv01", b.DataSource);
        Assert.Equal("DELSY", b.InitialCatalog);
        Assert.Equal("utente", b.UserID);
        Assert.Equal("pwd", b.Password);
        Assert.False(b.IntegratedSecurity);
        Assert.Equal(30, b.ConnectTimeout);
        Assert.Equal(SqlConnectionEncryptOption.Optional, b.Encrypt);
    }

    [Fact]
    public void Build_password_con_caratteri_speciali_non_rompe_la_stringa()
    {
        // Con la vecchia concatenazione un ';' nella password corrompeva la stringa di connessione
        var cs = DBConnection.BuildSqlServerConnectionString("srv01", "DELSY", "utente", "a;b'c=d", false, 60);
        Assert.Equal("a;b'c=d", new SqlConnectionStringBuilder(cs).Password);
    }

    [Fact]
    public void Build_sicurezza_integrata_non_include_credenziali()
    {
        var b = new SqlConnectionStringBuilder(
            DBConnection.BuildSqlServerConnectionString("srv01", "DELSY", "utente", "pwd", true, 60));

        Assert.True(b.IntegratedSecurity);
        Assert.Equal("", b.UserID);
        Assert.Equal("", b.Password);
    }

    [Fact]
    public void Build_timeout_zero_diventa_60()
    {
        var b = new SqlConnectionStringBuilder(
            DBConnection.BuildSqlServerConnectionString("srv01", "DELSY", "u", "p", false, 0));
        Assert.Equal(60, b.ConnectTimeout);
    }

    [Fact]
    public void Normalize_converte_la_vecchia_stringa_OLEDB()
    {
        // Formato generato dal codice originale con provider OleDb
        const string oleDb = "Provider=SQLOLEDB;Persist Security Info=False;User ID=gdo;Password=x;Initial Catalog=DELSY;Server=srv01;Connect Timeout=45;";
        var b = new SqlConnectionStringBuilder(DBConnection.NormalizeSqlServerConnectionString(oleDb));

        Assert.False(b.ContainsKey("Provider"));
        Assert.Equal("srv01", b.DataSource);
        Assert.Equal("DELSY", b.InitialCatalog);
        Assert.Equal("gdo", b.UserID);
        Assert.Equal(45, b.ConnectTimeout);
        Assert.Equal(SqlConnectionEncryptOption.Optional, b.Encrypt);
    }

    [Fact]
    public void Normalize_accetta_Integrated_Security_SSPI()
    {
        const string oleDb = "Provider=SQLOLEDB;Integrated Security=SSPI;Initial Catalog=DELSY;Server=srv01;";
        var b = new SqlConnectionStringBuilder(DBConnection.NormalizeSqlServerConnectionString(oleDb));
        Assert.True(b.IntegratedSecurity);
    }

    [Fact]
    public void Normalize_rispetta_Encrypt_se_specificato()
    {
        var b = new SqlConnectionStringBuilder(
            DBConnection.NormalizeSqlServerConnectionString("Server=srv01;Database=DELSY;Integrated Security=true;Encrypt=True"));
        Assert.Equal(SqlConnectionEncryptOption.Mandatory, b.Encrypt);
    }

    [Theory]
    [InlineData(null, "")]
    [InlineData("", "")]
    public void Normalize_stringa_vuota(string? input, string expected)
    {
        Assert.Equal(expected, DBConnection.NormalizeSqlServerConnectionString(input!));
    }

    [Fact]
    public void Normalize_stringa_non_valida_da_errore_chiaro()
    {
        var ex = Assert.Throws<System.ArgumentException>(
            () => DBConnection.NormalizeSqlServerConnectionString("Server=srv01;ChiaveInesistente=1"));
        Assert.Contains("SQL Server", ex.Message);
    }
}
