using System;
using System.Collections.Generic;

namespace Incasbo.Web.WFI;

public class BeforeImageFieldsCollection : Dictionary<string, BeforeImageField>
{
	public BeforeImageFieldsCollection()
		: base((IEqualityComparer<string>?)StringComparer.OrdinalIgnoreCase)
	{
	}
}
