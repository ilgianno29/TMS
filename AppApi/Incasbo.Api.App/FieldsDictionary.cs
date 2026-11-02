using System;
using System.Collections.Generic;

namespace Incasbo.Api.App;

public class FieldsDictionary : Dictionary<string, string>
{
	public FieldsDictionary()
		: base((IEqualityComparer<string>?)StringComparer.OrdinalIgnoreCase)
	{
	}
}
