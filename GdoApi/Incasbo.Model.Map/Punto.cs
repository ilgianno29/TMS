namespace Incasbo.Model.Map;

public class Punto
{
	public decimal Longitudine { get; set; }

	public decimal Latitudine { get; set; }

	public Punto(decimal longitudine, decimal latitudine)
	{
		Longitudine = longitudine;
		Latitudine = latitudine;
	}
}
