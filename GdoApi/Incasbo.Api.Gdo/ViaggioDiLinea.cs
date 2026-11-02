using System;
using Incasbo.Web.Library;

namespace Incasbo.Api.Gdo;

[CustomListAttributes("TableName", "Viaggi_Linea")]
public class ViaggioDiLinea
{
	public string Id { get; set; }

	public string TipoViaggio { get; set; }

	public int Stato { get; set; }

	public DateTime? DataPartenzaPianificata { get; set; }

	public string Giro { get; set; }

	public string RiferimentoEsterno { get; set; }

	public string Descrizione { get; set; }

	public string Mezzo { get; set; }

	public string TipoMezzo { get; set; }

	public string Vettore { get; set; }

	public string Autista { get; set; }

	public string TipoSpedizione { get; set; }

	public string TipoMerce { get; set; }

	public string ZonaSpedizione { get; set; }

	public string ZonaTariffaAttiva { get; set; }

	public string ZonaTariffaPassiva { get; set; }

	public string PCSPartenza { get; set; }

	public string PCSArrivo { get; set; }

	public string Note { get; set; }

	public DateTime? CutOff { get; set; }

	public string UteIns { get; set; }

	public string UteAgg { get; set; }

	public ViaggioDiLinea()
	{
		Id = "";
		TipoViaggio = "";
		Stato = 10;
		Giro = "";
		RiferimentoEsterno = "";
		Descrizione = "";
		Mezzo = "";
		TipoMezzo = "";
		Vettore = "";
		Autista = "";
		TipoSpedizione = "";
		TipoMerce = "";
		ZonaSpedizione = "";
		ZonaTariffaAttiva = "";
		ZonaTariffaPassiva = "";
		PCSPartenza = "";
		PCSArrivo = "";
		Note = "";
		UteIns = "";
		UteAgg = "";
	}
}
