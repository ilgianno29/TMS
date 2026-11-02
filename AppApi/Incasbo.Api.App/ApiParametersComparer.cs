using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.App;

internal class ApiParametersComparer : IEqualityComparer<string>
{
	public bool Equals1(string x, string y)
	{
		if (Operators.CompareString(x.ToUpper(), y.ToUpper(), false) == 0)
		{
			return true;
		}
		return false;
	}

	bool IEqualityComparer<string>.Equals(string x, string y)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Equals1
		return this.Equals1(x, y);
	}

	public int GetHashCode1(string obj)
	{
		return obj.ToUpper().GetHashCode();
	}

	int IEqualityComparer<string>.GetHashCode(string obj)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetHashCode1
		return this.GetHashCode1(obj);
	}
}
