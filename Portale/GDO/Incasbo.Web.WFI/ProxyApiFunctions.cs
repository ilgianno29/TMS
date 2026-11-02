using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class ProxyApiFunctions
{
	public static IIboProxyApiFunctions GetProxy(string sProxyName)
	{
		string text = "Incasbo.Web.WFICustom.StandardProxyApiFunctions";
		string text2 = "";
		if (Operators.CompareString(sProxyName, "", false) != 0)
		{
			if (sProxyName.Contains(";"))
			{
				string[] array = Strings.Split(sProxyName, " ", -1, (CompareMethod)0);
				text2 = array[0];
				text = array[1];
			}
			else
			{
				text = sProxyName;
			}
		}
		return IncasReflection.InstantiateClass(text, ref text2) as IIboProxyApiFunctions;
	}
}
