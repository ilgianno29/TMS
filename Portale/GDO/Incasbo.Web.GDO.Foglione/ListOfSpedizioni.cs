using System.Collections.Generic;
using System.Data;
using Incasbo.Web.Library;

namespace Incasbo.Web.GDO.Foglione;

public class ListOfSpedizioni : List<Spedizione>
{
	public ListOfSpedizioni()
	{
	}

	public ListOfSpedizioni(List<Spedizione> o)
		: base((IEnumerable<Spedizione>)o)
	{
	}

	public DataTable ConvertToDataTable()
	{
		return modGeneral.ConvertListToDataTable<Spedizione>((IList<Spedizione>)this);
	}
}
