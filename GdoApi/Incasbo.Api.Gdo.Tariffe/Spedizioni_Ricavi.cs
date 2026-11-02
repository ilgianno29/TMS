namespace Incasbo.Api.Gdo.Tariffe;

public class Spedizioni_Ricavi : Ricavi
{
	public override string TableName { get; set; }

	public override string DocumentKeyFieldName { get; set; }

	public Spedizioni_Ricavi()
	{
		TableName = "Spedizioni_Ricavi";
		DocumentKeyFieldName = "Unibol";
	}
}
