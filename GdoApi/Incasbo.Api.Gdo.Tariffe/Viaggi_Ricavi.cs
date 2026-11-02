namespace Incasbo.Api.Gdo.Tariffe;

public class Viaggi_Ricavi : Ricavi
{
	public override string TableName { get; set; }

	public override string DocumentKeyFieldName { get; set; }

	public Viaggi_Ricavi()
	{
		TableName = "Viaggi_Ricavi";
		DocumentKeyFieldName = "IdViaggio";
	}
}
