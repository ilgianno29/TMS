using System;
using System.Collections.Generic;

namespace Incasbo.Web.Library;

public class TranslatableItemDictonary : Dictionary<TranslatableItem, TranslatableItem>
{
	private class EqualityComparer : IEqualityComparer<TranslatableItem>
	{
		public bool Equals1(TranslatableItem x, TranslatableItem y)
		{
			return string.Equals(x.Language.ToUpper() + x.Contesto.ToUpper() + x.Text.ToUpper(), y.Language.ToUpper() + y.Contesto.ToUpper() + y.Text.ToUpper(), StringComparison.OrdinalIgnoreCase);
		}

		bool IEqualityComparer<TranslatableItem>.Equals(TranslatableItem x, TranslatableItem y)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Equals1
			return this.Equals1(x, y);
		}

		public int GetHashCode1(TranslatableItem obj)
		{
			return (obj.Language.ToUpper() + "." + obj.Contesto.ToUpper() + "." + obj.Text.ToUpper()).GetHashCode();
		}

		int IEqualityComparer<TranslatableItem>.GetHashCode(TranslatableItem obj)
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetHashCode1
			return this.GetHashCode1(obj);
		}
	}

	public TranslatableItemDictonary()
		: base((IEqualityComparer<TranslatableItem>?)new EqualityComparer())
	{
	}
}
