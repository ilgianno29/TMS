namespace Incasbo.Api.Gdo.Tariffe;

public class Simulation_Result
{
	public string IdDocumento { get; set; }

	public string Vettore { get; set; }

	public string Corrispondente { get; set; }

	public Costi Costi { get; set; }

	public decimal TotaleCosto { get; set; }

	public Ricavi Ricavi { get; set; }

	public decimal TotaleRicavi { get; set; }

	public string Errore { get; set; }

	public string Warning { get; set; }

	public Simulation_Result()
	{
		IdDocumento = "";
		Vettore = "";
		Corrispondente = "";
		TotaleCosto = 0m;
		TotaleRicavi = 0m;
		Errore = "";
		Warning = "";
	}
}
