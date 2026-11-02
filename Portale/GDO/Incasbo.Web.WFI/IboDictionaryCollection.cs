using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class IboDictionaryCollection<TKey, TValue> : Dictionary<TKey, TValue>
{
	public new TValue this[TKey Key]
	{
		get
		{
			if (!ContainsKey(Key))
			{
				return default(TValue);
			}
			return base[Key];
		}
		set
		{
			if (!ContainsKey(Key))
			{
				Add(Key, value);
			}
			else
			{
				base[Key] = value;
			}
		}
	}

	public new void Remove(TKey Key)
	{
		try
		{
			base.Remove(Key);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public new void Add(TKey Key, TValue Value)
	{
		try
		{
			Remove(Key);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		base.Add(Key, Value);
	}
}
