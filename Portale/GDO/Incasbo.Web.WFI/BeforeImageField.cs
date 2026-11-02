using System.Runtime.CompilerServices;

namespace Incasbo.Web.WFI;

public class BeforeImageField
{
	public string FieldName;

	public string FieldText;

	public object FieldValue;

	public BeforeImageField()
	{
		FieldName = "";
		FieldText = "";
		FieldValue = null;
	}

	public BeforeImageField(string sFieldName, string sFieldText, object objFieldValue)
	{
		FieldName = "";
		FieldText = "";
		FieldValue = null;
		FieldName = sFieldName;
		FieldText = sFieldText;
		FieldValue = RuntimeHelpers.GetObjectValue(objFieldValue);
	}
}
