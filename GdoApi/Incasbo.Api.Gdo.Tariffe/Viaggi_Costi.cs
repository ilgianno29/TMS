namespace Incasbo.Api.Gdo.Tariffe;

public class Viaggi_Costi : Costi
{
	public override string TableName { get; set; }

	public override string FornitoreFieldName { get; set; }

	public override string DocumentKeyFieldName { get; set; }

	public Viaggi_Costi()
	{
		TableName = "Viaggi_Costi";
		FornitoreFieldName = "Trasportatore";
		DocumentKeyFieldName = "IdViaggio";
	}
}
