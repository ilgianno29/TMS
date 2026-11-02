namespace Incasbo.Api.Gdo.Tariffe;

public class TourDocument : TransportDocument
{
	public virtual string IdViaggio { get; set; }

	public TourDocument()
	{
		IdViaggio = "";
		_Costi = new Viaggi_Costi();
		_Ricavi = new Viaggi_Ricavi();
	}
}
