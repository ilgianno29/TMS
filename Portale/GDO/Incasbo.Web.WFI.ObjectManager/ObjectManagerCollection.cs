using System.Collections.ObjectModel;

namespace Incasbo.Web.WFI.ObjectManager;

public class ObjectManagerCollection : KeyedCollection<string, AbstractObjectManager>
{
	protected override string GetKeyForItem(AbstractObjectManager item)
	{
		return item.ObjectManagerName;
	}
}
