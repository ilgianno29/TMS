using System.Collections.ObjectModel;

namespace Incasbo.Api.Gdo.Tariffe;

public abstract class CostiRicavi : KeyedCollection<string, CostoRicavo>
{
	public abstract string TableName { get; set; }

	public abstract string DocumentKeyFieldName { get; set; }

	protected override string GetKeyForItem(CostoRicavo item)
	{
		return item.Voce;
	}
}
