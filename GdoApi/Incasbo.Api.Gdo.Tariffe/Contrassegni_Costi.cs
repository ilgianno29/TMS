namespace Incasbo.Api.Gdo.Tariffe;

public class Contrassegni_Costi : Costi
{
	public override string TableName { get; set; }

	public override string FornitoreFieldName { get; set; }

	public override string DocumentKeyFieldName { get; set; }

	public Contrassegni_Costi()
	{
		TableName = "Contrassegni_Costi";
		FornitoreFieldName = "Trasportatore";
		DocumentKeyFieldName = "IdContrassegno";
	}
}
