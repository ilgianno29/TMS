using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class StringKeyDictionaryCollection : Dictionary<string, object>
{
	public new object this[string Key]
	{
		get
		{
			if (!ContainsKey(Key))
			{
				return null;
			}
			return base[Key];
		}
		set
		{
			if (!ContainsKey(Key))
			{
				Add(Key, RuntimeHelpers.GetObjectValue(value));
			}
			else
			{
				base[Key] = RuntimeHelpers.GetObjectValue(value);
			}
		}
	}

	public StringKeyDictionaryCollection()
		: base((IEqualityComparer<string>?)StringComparer.OrdinalIgnoreCase)
	{
	}

	public new void Add(string Key, object Value)
	{
		try
		{
			if (ContainsKey(Key))
			{
				Remove(Key);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		base.Add(Key, RuntimeHelpers.GetObjectValue(Value));
	}
}
