namespace Incasbo.Api.Gdo.Tariffe;

public class Costo : CostoRicavo
{
	public virtual string Fornitore { get; set; }

	public Costo()
	{
		Fornitore = "";
	}
}
