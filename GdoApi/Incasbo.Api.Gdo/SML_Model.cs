using System.Collections.Generic;

namespace Incasbo.Api.Gdo;

public class SML_Model
{
	public Dictionary<string, SML_MezzoDisponibilita> ListOfSML_MezziDisponibilita { get; set; }

	public Dictionary<string, SML_Mezzo> ListOfSML_Mezzi { get; set; }

	public Dictionary<string, SML_Spedizione> ListOfSML_Spedizioni { get; set; }

	public Dictionary<string, SML_Viaggio> ListOfSML_Viaggi { get; set; }

	public SML_Sessione SML_Sessione { get; set; }

	public SML_Model()
	{
		ListOfSML_MezziDisponibilita = new Dictionary<string, SML_MezzoDisponibilita>();
		ListOfSML_Mezzi = new Dictionary<string, SML_Mezzo>();
		ListOfSML_Spedizioni = new Dictionary<string, SML_Spedizione>();
		ListOfSML_Viaggi = new Dictionary<string, SML_Viaggio>();
		SML_Sessione = new SML_Sessione();
	}
}
