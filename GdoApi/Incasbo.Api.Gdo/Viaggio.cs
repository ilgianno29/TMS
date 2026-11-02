using System;
using Incasbo.Web.Library;

namespace Incasbo.Api.Gdo;

[CustomListAttributes("TableName", "Viaggi")]
public class Viaggio
{
	public string IdViaggio { get; set; }

	public string TipoViaggio { get; set; }

	public int Stato { get; set; }

	public DateTime? DataPartenzaPianificata { get; set; }

	public DateTime? DataArrivoPianificata { get; set; }

	public DateTime? DataPartenzaEffettiva { get; set; }

	public DateTime? DataArrivoEffettiva { get; set; }

	public string MotricePianificata { get; set; }

	public string Rimorchio1Pianificato { get; set; }

	public string Contenitore1Pianificato { get; set; }

	public string Rimorchio2Pianificato { get; set; }

	public string Contenitore2Pianificato { get; set; }

	public string MotriceEffettiva { get; set; }

	public string Rimorchio1Effettivo { get; set; }

	public string Contenitore1Effettivo { get; set; }

	public string Rimorchio2Effettivo { get; set; }

	public string Contenitore2Effettivo { get; set; }

	public string TipoUnitaViaggiante { get; set; }

	public string Vettore { get; set; }

	public string Autista1Pianificato { get; set; }

	public string Autista2Pianificato { get; set; }

	public string Autista1Effettivo { get; set; }

	public string Autista2Effettivo { get; set; }

	public string TipoSpedizione { get; set; }

	public string TipoMerce { get; set; }

	public string ZonaPartenza { get; set; }

	public string ZonaArrivo { get; set; }

	public string Cliente { get; set; }

	public string TipoSpedizioneAttiva { get; set; }

	public string ZonaPartenzaTariffaAttiva { get; set; }

	public string ZonaArrivoTariffaAttiva { get; set; }

	public string PCSPartenza { get; set; }

	public string PCSArrivo { get; set; }

	public string PCSPartenzaEffettivo { get; set; }

	public string PCSArrivoEffettivo { get; set; }

	public int KmPianificati { get; set; }

	public int KmManuali { get; set; }

	public int KmGPS { get; set; }

	public int KmRicalcolati { get; set; }

	public decimal? PesoPassivo { get; set; }

	public int? ColliPassivo { get; set; }

	public int? PalletPassivo { get; set; }

	public decimal? VolumePassivo { get; set; }

	public decimal? CampoCalcolo1Passivo { get; set; }

	public decimal? CampoCalcolo2Passivo { get; set; }

	public decimal? CampoCalcolo3Passivo { get; set; }

	public decimal? CampoCalcolo4Passivo { get; set; }

	public decimal? CampoCalcolo5Passivo { get; set; }

	public decimal? CampoCalcolo6Passivo { get; set; }

	public decimal? CampoCalcolo7Passivo { get; set; }

	public decimal? CampoCalcolo8Passivo { get; set; }

	public decimal? CampoCalcolo9Passivo { get; set; }

	public decimal? CampoCalcolo10Passivo { get; set; }

	public decimal? PesoAttivo { get; set; }

	public int? ColliAttivo { get; set; }

	public int? PalletAttivo { get; set; }

	public decimal? VolumeAttivo { get; set; }

	public decimal? CampoCalcolo1Attivo { get; set; }

	public decimal? CampoCalcolo2Attivo { get; set; }

	public decimal? CampoCalcolo3Attivo { get; set; }

	public decimal? CampoCalcolo4Attivo { get; set; }

	public decimal? CampoCalcolo5Attivo { get; set; }

	public decimal? CampoCalcolo6Attivo { get; set; }

	public decimal? CampoCalcolo7Attivo { get; set; }

	public decimal? CampoCalcolo8Attivo { get; set; }

	public decimal? CampoCalcolo9Attivo { get; set; }

	public decimal? CampoCalcolo10Attivo { get; set; }

	public string Flag1 { get; set; }

	public string Flag2 { get; set; }

	public string Flag3 { get; set; }

	public string Flag4 { get; set; }

	public string Flag5 { get; set; }

	public string Flag6 { get; set; }

	public string Flag7 { get; set; }

	public string Flag8 { get; set; }

	public string Flag9 { get; set; }

	public string Flag10 { get; set; }

	public string Note1 { get; set; }

	public string Note2 { get; set; }

	public string Terminale { get; set; }

	public string IdViaggioOBC { get; set; }

	public string IdViaggioHost { get; set; }

	public string FillerAlfa1 { get; set; }

	public string FillerAlfa2 { get; set; }

	public string FillerAlfa3 { get; set; }

	public string FillerAlfa4 { get; set; }

	public string FillerAlfa5 { get; set; }

	public string FillerAlfa6 { get; set; }

	public string FillerAlfa7 { get; set; }

	public string FillerAlfa8 { get; set; }

	public string FillerAlfa9 { get; set; }

	public string FillerAlfa10 { get; set; }

	public DateTime? FillerData1 { get; set; }

	public DateTime? FillerData2 { get; set; }

	public DateTime? FillerData3 { get; set; }

	public DateTime? FillerData4 { get; set; }

	public DateTime? FillerData5 { get; set; }

	public string BloccaCosti { get; set; }

	public string BloccaRicavi { get; set; }

	public string UteIns { get; set; }

	public string UteAgg { get; set; }

	public Viaggio()
	{
		IdViaggio = "";
		TipoViaggio = "";
		Stato = 10;
		MotricePianificata = "";
		Rimorchio1Pianificato = "";
		Contenitore1Pianificato = "";
		Rimorchio2Pianificato = "";
		Contenitore2Pianificato = "";
		MotriceEffettiva = "";
		Rimorchio1Effettivo = "";
		Contenitore1Effettivo = "";
		Rimorchio2Effettivo = "";
		Contenitore2Effettivo = "";
		TipoUnitaViaggiante = "";
		Vettore = "";
		Autista1Pianificato = "";
		Autista2Pianificato = "";
		Autista1Effettivo = "";
		Autista2Effettivo = "";
		TipoSpedizione = "";
		TipoMerce = "";
		ZonaPartenza = "";
		ZonaArrivo = "";
		Cliente = "";
		TipoSpedizioneAttiva = "";
		ZonaPartenzaTariffaAttiva = "";
		ZonaArrivoTariffaAttiva = "";
		PCSPartenza = "";
		PCSArrivo = "";
		PCSPartenzaEffettivo = "";
		PCSArrivoEffettivo = "";
		UteIns = "";
		UteAgg = "";
	}
}
