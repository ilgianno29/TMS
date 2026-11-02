using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class FieldNameAlias
{
	private string sFieldName;

	private string sAliasName;

	public string FieldName => sFieldName;

	public string AliasName => sAliasName;

	public FieldNameAlias(string vsFieldName, string vsAliasName)
	{
		sFieldName = "";
		sAliasName = "";
		sFieldName = vsFieldName;
		sAliasName = vsAliasName;
		if (Operators.CompareString(sAliasName.Trim(), "", false) == 0)
		{
			sAliasName = sFieldName;
		}
	}

	public override string ToString()
	{
		return sFieldName + " AS " + sAliasName;
	}
}
