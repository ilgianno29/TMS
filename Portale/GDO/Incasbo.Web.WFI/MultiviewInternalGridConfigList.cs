using System.Collections.ObjectModel;

namespace Incasbo.Web.WFI;

public class MultiviewInternalGridConfigList : KeyedCollection<string, MultiviewInternalGridConfig>
{
	protected override string GetKeyForItem(MultiviewInternalGridConfig item)
	{
		return item.Id;
	}
}
