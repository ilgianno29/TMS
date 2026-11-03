using System.Globalization;

namespace Delsy.Listini.Web.Components.Shared;

/// <summary>Formati italiani per importi, quantità e date.</summary>
public static class Formato
{
	private static readonly CultureInfo It = CultureInfo.GetCultureInfo("it-IT");

	public static string Euro(decimal v) => v.ToString("#,##0.00 €", It);

	public static string Numero(decimal v) => v == Math.Round(v) ? v.ToString("#,##0", It) : v.ToString("#,##0.###", It);

	public static string Data(DateTime? d) => d?.ToString("dd/MM/yyyy", It) ?? "—";

	public static string DataOra(DateTime d) => d.ToString("dd/MM/yyyy HH:mm", It);

	/// <summary>"*ALL" diventa "Tutti" per chi legge.</summary>
	public static string Criterio(string? v) => string.IsNullOrWhiteSpace(v) || v == CriteriTariffaTutti ? "Tutti" : v;

	private const string CriteriTariffaTutti = Delsy.Listini.Spiegazione.CriteriTariffa.Tutti;

	public static string ClasseStato(string stato) => stato switch
	{
		"Valido" => "ok",
		"In scadenza" or "Futuro" => "warn",
		"Scaduto" => "bad",
		_ => "lock"
	};
}
