using System;
using Microsoft.VisualBasic;

namespace Incasbo.Web.GDO.Foglione;

public class FoglioneFilter
{
	public string TipoMerce { get; set; }

	public string PCSPartena { get; set; }

	public string ZonaPartenza { get; set; }

	public string TipoSpedizione { get; set; }

	public DateTime DataRiferimento { get; set; }

	public string Pianificatore { get; set; }

	public bool Admin { get; set; }

	public FoglioneFilter()
	{
		TipoMerce = "";
		PCSPartena = "";
		ZonaPartenza = "";
		TipoSpedizione = "";
		DataRiferimento = DateAndTime.Now.Date;
		Pianificatore = "";
		Admin = false;
	}
}
