namespace Incasbo.Api.Gdo.Tariffe;

public class CODDocument : TransportDocument
{
	public virtual string IdContrassegno { get; set; }

	public CODDocument()
	{
		IdContrassegno = "";
		_Costi = new Contrassegni_Costi();
		_Ricavi = new Contrassegni_Ricavi();
	}
}
