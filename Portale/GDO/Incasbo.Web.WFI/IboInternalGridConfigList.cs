using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class IboInternalGridConfigList : KeyedCollection<string, IboInternalGridConfig>
{
// Proprieta' VB con parametro, convertita in metodi
	public IboInternalGridConfig get_GetItemByToolbarId(string ToolbarId)
	{
		using (IEnumerator<IboInternalGridConfig> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				IboInternalGridConfig current = enumerator.Current;
				if (Operators.CompareString(current.ToolbarId.ToUpper(), ToolbarId.ToUpper(), false) == 0)
				{
					return current;
				}
			}
		}
		return null;
	}


	protected override string GetKeyForItem(IboInternalGridConfig item)
	{
		return item.Id;
	}
}
