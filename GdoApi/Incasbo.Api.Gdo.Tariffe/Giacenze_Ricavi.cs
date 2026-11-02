namespace Incasbo.Api.Gdo.Tariffe;

public class Giacenze_Ricavi : Ricavi
{
	public override string TableName { get; set; }

	public override string DocumentKeyFieldName { get; set; }

	public Giacenze_Ricavi()
	{
		TableName = "Giacenze_Ricavi";
		DocumentKeyFieldName = "IdGiacenza";
	}
}
