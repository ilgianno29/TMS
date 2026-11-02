using System.Collections.Generic;

namespace Incasbo.Web.GDO.Foglione;

public class FoglioneModel
{
	public List<Autista> Autisti { get; set; }

	public List<Mezzo> Mezzi { get; set; }

	public List<Viaggio> Viaggi { get; set; }

	public List<PlanningDate> PlanningDates { get; set; }

	public List<Appointment> Appointments { get; set; }

	public ListOfSpedizioni Spedizioni { get; set; }

	public List<MezzoLibero> MezziLiberi { get; set; }
}
