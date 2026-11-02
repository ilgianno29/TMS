using System;
using System.Collections.ObjectModel;

namespace Incasbo.Web.WFI;

public class QueryCache : KeyedCollection<string, QueryCacheItem>
{
	public DateTime LastUsage { get; set; }

	public QueryCache()
	{
		LastUsage = DateTime.Now;
	}

	public QueryCacheItem Item(string Key)
	{
		LastUsage = DateTime.Now;
		return base[Key];
	}

	protected override string GetKeyForItem(QueryCacheItem item)
	{
		return item.SqlQuery;
	}
}
