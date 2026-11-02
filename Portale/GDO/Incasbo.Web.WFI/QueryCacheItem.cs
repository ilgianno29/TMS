using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Incasbo.Web.WFI;

public class QueryCacheItem
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _SqlQueryResult;

	public string SqlQuery { get; set; }

	public object SqlQueryResult
	{
		[CompilerGenerated]
		get
		{
			return _SqlQueryResult;
		}
		[CompilerGenerated]
		set
		{
			_SqlQueryResult = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public QueryCacheItem()
	{
		SqlQuery = "";
	}

	public QueryCacheItem(string _sqlQuery, object _sqlQueryResult)
	{
		SqlQuery = "";
		SqlQuery = _sqlQuery;
		SqlQueryResult = RuntimeHelpers.GetObjectValue(_sqlQueryResult);
	}
}
