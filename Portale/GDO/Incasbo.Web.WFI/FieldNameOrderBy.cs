namespace Incasbo.Web.WFI;

public class FieldNameOrderBy
{
	private string sFieldName;

	private sqlSelect.OrderBySortOrder eSortOrder;

	public string FieldName => sFieldName;

	public sqlSelect.OrderBySortOrder SortOrder => eSortOrder;

	public FieldNameOrderBy(string vsFieldName, sqlSelect.OrderBySortOrder veSortOrder)
	{
		sFieldName = "";
		sFieldName = vsFieldName;
		eSortOrder = veSortOrder;
	}

	public override string ToString()
	{
		string text = sFieldName + " ";
		if (eSortOrder == sqlSelect.OrderBySortOrder.Ascending)
		{
			text += "ASC";
		}
		else if (eSortOrder == sqlSelect.OrderBySortOrder.Descending)
		{
			text += "DESC";
		}
		else if (eSortOrder == sqlSelect.OrderBySortOrder.NotSet)
		{
			text = text ?? "";
		}
		return text;
	}
}
