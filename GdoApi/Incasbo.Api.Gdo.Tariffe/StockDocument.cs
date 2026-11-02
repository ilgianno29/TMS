namespace Incasbo.Api.Gdo.Tariffe;

public class StockDocument : TransportDocument
{
	public virtual string IdGiacenza { get; set; }

	public StockDocument()
	{
		IdGiacenza = "";
		_Costi = new Giacenze_Costi();
		_Ricavi = new Giacenze_Ricavi();
	}
}
