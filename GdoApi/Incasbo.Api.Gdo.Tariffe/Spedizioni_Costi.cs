namespace Incasbo.Api.Gdo.Tariffe;

public class Spedizioni_Costi : Costi
{
	public override string TableName { get; set; }

	public override string FornitoreFieldName { get; set; }

	public override string DocumentKeyFieldName { get; set; }

	public Spedizioni_Costi()
	{
		TableName = "Spedizioni_Costi";
		FornitoreFieldName = "Trasportatore";
		DocumentKeyFieldName = "Unibol";
	}
}
