namespace Incasbo.Api.Gdo.Tariffe;

public class ShippingDocument : TransportDocument
{
	public virtual string Unibol { get; set; }

	public ShippingDocument()
	{
		Unibol = "";
		_Costi = new Spedizioni_Costi();
		_Ricavi = new Spedizioni_Ricavi();
	}
}
