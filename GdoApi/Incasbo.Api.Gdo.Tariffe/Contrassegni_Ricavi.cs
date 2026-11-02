namespace Incasbo.Api.Gdo.Tariffe;

public class Contrassegni_Ricavi : Ricavi
{
	public override string TableName { get; set; }

	public override string DocumentKeyFieldName { get; set; }

	public Contrassegni_Ricavi()
	{
		TableName = "Contrassegni_Ricavi";
		DocumentKeyFieldName = "IdContrassegno";
	}
}
