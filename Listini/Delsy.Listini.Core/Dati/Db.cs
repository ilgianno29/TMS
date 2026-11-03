using System.Data;
using Microsoft.Data.SqlClient;

namespace Delsy.Listini.Dati;

/// <summary>Accesso semplice al database Delsy: solo query parametrizzate.</summary>
public sealed class Db
{
	private readonly string _connectionString;

	public Db(string connectionString)
	{
		_connectionString = connectionString;
	}

	public string ConnectionString => _connectionString;

	public SqlConnection Apri()
	{
		SqlConnection c = new SqlConnection(_connectionString);
		c.Open();
		return c;
	}

	/// <summary>Righe come dizionari colonna → valore (DBNull diventa null), nomi colonna senza distinzione maiuscole.</summary>
	public List<Dictionary<string, object?>> Righe(string sql, params (string Nome, object? Valore)[] parametri)
	{
		using SqlConnection c = Apri();
		return Righe(c, null, sql, parametri);
	}

	public static List<Dictionary<string, object?>> Righe(SqlConnection c, SqlTransaction? tx, string sql, params (string Nome, object? Valore)[] parametri)
	{
		using SqlCommand cmd = Comando(c, tx, sql, parametri);
		using SqlDataReader r = cmd.ExecuteReader();
		List<Dictionary<string, object?>> righe = new List<Dictionary<string, object?>>();
		while (r.Read())
		{
			Dictionary<string, object?> riga = new Dictionary<string, object?>(r.FieldCount, StringComparer.OrdinalIgnoreCase);
			for (int i = 0; i < r.FieldCount; i++)
			{
				riga[r.GetName(i)] = r.IsDBNull(i) ? null : r.GetValue(i);
			}
			righe.Add(riga);
		}
		return righe;
	}

	public int Esegui(string sql, params (string Nome, object? Valore)[] parametri)
	{
		using SqlConnection c = Apri();
		using SqlCommand cmd = Comando(c, null, sql, parametri);
		return cmd.ExecuteNonQuery();
	}

	public static SqlCommand Comando(SqlConnection c, SqlTransaction? tx, string sql, params (string Nome, object? Valore)[] parametri)
	{
		SqlCommand cmd = new SqlCommand(sql, c, tx) { CommandType = CommandType.Text, CommandTimeout = 120 };
		foreach ((string nome, object? valore) in parametri)
		{
			cmd.Parameters.AddWithValue(nome, valore ?? DBNull.Value);
		}
		return cmd;
	}
}

/// <summary>Letture comode dai dizionari restituiti da <see cref="Db.Righe(string, (string, object?)[])"/>.</summary>
public static class RigaExtensions
{
	public static string Testo(this IReadOnlyDictionary<string, object?> riga, string colonna) =>
		riga.TryGetValue(colonna, out object? v) && v != null ? Convert.ToString(v, System.Globalization.CultureInfo.InvariantCulture)!.Trim() : "";

	public static decimal Numero(this IReadOnlyDictionary<string, object?> riga, string colonna) =>
		riga.TryGetValue(colonna, out object? v) && v != null ? Convert.ToDecimal(v, System.Globalization.CultureInfo.InvariantCulture) : 0m;

	public static DateTime? Data(this IReadOnlyDictionary<string, object?> riga, string colonna) =>
		riga.TryGetValue(colonna, out object? v) && v is DateTime d ? d : null;
}
