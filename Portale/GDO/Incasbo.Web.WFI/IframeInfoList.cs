using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class IframeInfoList : Dictionary<string, IframeInfo>
{
	public IframeInfoList()
		: base((IEqualityComparer<string>?)StringComparer.OrdinalIgnoreCase)
	{
	}

	public IframeInfo GetIFrameInfoByCallerName(string Caller)
	{
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, IframeInfo> current = enumerator.Current;
				if (Operators.CompareString(current.Value.IFrameCaller.ToUpper(), Caller.ToUpper(), false) == 0)
				{
					return current.Value;
				}
			}
		}
		return null;
	}

	public IframeInfo GetIFrameInfoByUrl(string Url)
	{
		using (Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, IframeInfo> current = enumerator.Current;
				string[] array = current.Value.IFrameUrl.Split(new char[1] { '?' });
				array[0] = array[0].Replace("\\", "/");
				if (array[0].Contains("/"))
				{
					string[] array2 = array[0].Split(new char[1] { '/' });
					if (Operators.CompareString(array2[checked(array2.Length - 1)].ToUpper(), Url.ToUpper(), false) == 0)
					{
						return current.Value;
					}
				}
				else if (Operators.CompareString(array[0].ToUpper(), Url.ToUpper(), false) == 0)
				{
					return current.Value;
				}
			}
		}
		return null;
	}
}
