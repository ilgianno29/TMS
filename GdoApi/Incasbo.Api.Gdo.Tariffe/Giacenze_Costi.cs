namespace Incasbo.Api.Gdo.Tariffe;

public class Giacenze_Costi : Costi
{
	public override string TableName { get; set; }

	public override string FornitoreFieldName { get; set; }

	public override string DocumentKeyFieldName { get; set; }

	public Giacenze_Costi()
	{
		TableName = "Giacenze_Costi";
		FornitoreFieldName = "Trasportatore";
		DocumentKeyFieldName = "IdGiacenza";
	}
}
