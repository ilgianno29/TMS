namespace Incasbo.Web.WFI;

public class MultiViewForeignKey
{
	public string FieldName1 { get; set; }

	public string FieldName2 { get; set; }

	public string ViewId { get; set; }

	public int ViewIndex { get; set; }

	public MultiViewForeignKey()
	{
		FieldName1 = "";
		FieldName2 = "";
		ViewId = "";
	}

	public MultiViewForeignKey(string _FieldName1, string _FieldName2, string _ViewId, int _ViewIndex)
	{
		FieldName1 = "";
		FieldName2 = "";
		ViewId = "";
		FieldName1 = _FieldName1;
		FieldName2 = _FieldName2;
		ViewId = _ViewId;
		ViewIndex = _ViewIndex;
	}
}
