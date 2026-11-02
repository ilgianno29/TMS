using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class IboApplicationVariables : IboDictionaryCollection<string, IboDictionaryCollection<string, object>>
{
	public new IboDictionaryCollection<string, object> this[string Key]
	{
		get
		{
			Key = Key.ToUpper();
			if (!ContainsKey(Key))
			{
				return null;
			}
			return base[Key];
		}
		set
		{
			Key = Key.ToUpper();
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

	public new void Add(string Key, IboDictionaryCollection<string, object> Value)
	{
		Key = Key.ToUpper();
		base.Add(Key, Value);
	}

	public new void Remove(string Key)
	{
		Key = Key.ToUpper();
		try
		{
			this[Key].Clear();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			base.Remove(Key);
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
	}
}
