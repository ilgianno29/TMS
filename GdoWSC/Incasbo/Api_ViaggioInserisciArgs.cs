using System;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Api_ViaggioInserisciArgs : Api_ViaggioArgs
{
	[DataMember]
	public string IdViaggioLinea { get; set; }

	[DataMember]
	public string TipoViaggio { get; set; }

	[DataMember]
	public int Stato { get; set; }

	[DataMember]
	public DateTime? DataPartenzaPianificata { get; set; }

	[DataMember]
	public DateTime? DataArrivoPianificata { get; set; }

	[DataMember]
	public DateTime? DataPartenzaEffettiva { get; set; }

	[DataMember]
	public DateTime? DataArrivoEffettiva { get; set; }

	[DataMember]
	public string MotricePianificata { get; set; }

	[DataMember]
	public string Rimorchio1Pianificato { get; set; }

	[DataMember]
	public string Contenitore1Pianificato { get; set; }

	[DataMember]
	public string Rimorchio2Pianificato { get; set; }

	[DataMember]
	public string Contenitore2Pianificato { get; set; }

	[DataMember]
	public string MotriceEffettiva { get; set; }

	[DataMember]
	public string Rimorchio1Effettivo { get; set; }

	[DataMember]
	public string Contenitore1Effettivo { get; set; }

	[DataMember]
	public string Rimorchio2Effettivo { get; set; }

	[DataMember]
	public string Contenitore2Effettivo { get; set; }

	[DataMember]
	public string TipoUnitaViaggiante { get; set; }

	[DataMember]
	public string Vettore { get; set; }

	[DataMember]
	public string Autista1Pianificato { get; set; }

	[DataMember]
	public string Autista1Effettivo { get; set; }

	[DataMember]
	public string Autista2Effettivo { get; set; }

	[DataMember]
	public string TipoSpedizione { get; set; }

	[DataMember]
	public string TipoMerce { get; set; }

	[DataMember]
	public string ZonaPartenza { get; set; }

	[DataMember]
	public string ZonaArrivo { get; set; }

	[DataMember]
	public string Cliente { get; set; }

	[DataMember]
	public string TipoSpedizioneAttiva { get; set; }

	[DataMember]
	public string ZonaPartenzaTariffaAttiva { get; set; }

	[DataMember]
	public string ZonaArrivoTariffaAttiva { get; set; }

	[DataMember]
	public string PCSPartenza { get; set; }

	[DataMember]
	public string PCSArrivo { get; set; }

	[DataMember]
	public string PCSPartenzaEffettivo { get; set; }

	[DataMember]
	public string PCSArrivoEffettivo { get; set; }

	[DataMember]
	public int KmPianificati { get; set; }

	[DataMember]
	public int KmManuali { get; set; }

	[DataMember]
	public int KmGPS { get; set; }

	[DataMember]
	public int KmRicalcolati { get; set; }

	[DataMember]
	public decimal? PesoPassivo { get; set; }

	[DataMember]
	public int? ColliPassivo { get; set; }

	[DataMember]
	public int? PalletPassivo { get; set; }

	[DataMember]
	public decimal? VolumePassivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo1Passivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo2Passivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo3Passivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo4Passivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo5Passivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo6Passivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo7Passivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo8Passivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo9Passivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo10Passivo { get; set; }

	[DataMember]
	public decimal? PesoAttivo { get; set; }

	[DataMember]
	public int? ColliAttivo { get; set; }

	[DataMember]
	public int? PalletAttivo { get; set; }

	[DataMember]
	public decimal? VolumeAttivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo1Attivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo2Attivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo3Attivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo4Attivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo5Attivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo6Attivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo7Attivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo8Attivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo9Attivo { get; set; }

	[DataMember]
	public decimal? CampoCalcolo10Attivo { get; set; }

	[DataMember]
	public string Flag1 { get; set; }

	[DataMember]
	public string Flag2 { get; set; }

	[DataMember]
	public string Flag3 { get; set; }

	[DataMember]
	public string Flag4 { get; set; }

	[DataMember]
	public string Flag5 { get; set; }

	[DataMember]
	public string Flag6 { get; set; }

	[DataMember]
	public string Flag7 { get; set; }

	[DataMember]
	public string Flag8 { get; set; }

	[DataMember]
	public string Flag9 { get; set; }

	[DataMember]
	public string Flag10 { get; set; }

	[DataMember]
	public string Note1 { get; set; }

	[DataMember]
	public string Note2 { get; set; }

	[DataMember]
	public string Terminale { get; set; }

	[DataMember]
	public string IdViaggioOBC { get; set; }

	[DataMember]
	public string IdViaggioHost { get; set; }

	[DataMember]
	public string UteIns { get; set; }

	[DataMember]
	public string UteAgg { get; set; }

	public Api_ViaggioInserisciArgs()
	{
		string idViaggioLinea = "";
		IdViaggioLinea = idViaggioLinea;
		idViaggioLinea = "";
		TipoViaggio = idViaggioLinea;
		int stato = 10;
		Stato = stato;
		idViaggioLinea = "";
		MotricePianificata = idViaggioLinea;
		idViaggioLinea = "";
		Rimorchio1Pianificato = idViaggioLinea;
		idViaggioLinea = "";
		Contenitore1Pianificato = idViaggioLinea;
		idViaggioLinea = "";
		Rimorchio2Pianificato = idViaggioLinea;
		idViaggioLinea = "";
		Contenitore2Pianificato = idViaggioLinea;
		idViaggioLinea = "";
		MotriceEffettiva = idViaggioLinea;
		idViaggioLinea = "";
		Rimorchio1Effettivo = idViaggioLinea;
		idViaggioLinea = "";
		Contenitore1Effettivo = idViaggioLinea;
		idViaggioLinea = "";
		Rimorchio2Effettivo = idViaggioLinea;
		idViaggioLinea = "";
		Contenitore2Effettivo = idViaggioLinea;
		idViaggioLinea = "";
		TipoUnitaViaggiante = idViaggioLinea;
		idViaggioLinea = "";
		Vettore = idViaggioLinea;
		idViaggioLinea = "";
		Autista1Pianificato = idViaggioLinea;
		idViaggioLinea = "";
		Autista1Effettivo = idViaggioLinea;
		idViaggioLinea = "";
		Autista2Effettivo = idViaggioLinea;
		idViaggioLinea = "";
		TipoSpedizione = idViaggioLinea;
		idViaggioLinea = "";
		TipoMerce = idViaggioLinea;
		idViaggioLinea = "";
		ZonaPartenza = idViaggioLinea;
		idViaggioLinea = "";
		ZonaArrivo = idViaggioLinea;
		idViaggioLinea = "";
		Cliente = idViaggioLinea;
		idViaggioLinea = "";
		TipoSpedizioneAttiva = idViaggioLinea;
		idViaggioLinea = "";
		ZonaPartenzaTariffaAttiva = idViaggioLinea;
		idViaggioLinea = "";
		ZonaArrivoTariffaAttiva = idViaggioLinea;
		idViaggioLinea = "";
		PCSPartenza = idViaggioLinea;
		idViaggioLinea = "";
		PCSArrivo = idViaggioLinea;
		idViaggioLinea = "";
		PCSPartenzaEffettivo = idViaggioLinea;
		idViaggioLinea = "";
		PCSArrivoEffettivo = idViaggioLinea;
		idViaggioLinea = "N";
		Flag1 = idViaggioLinea;
		idViaggioLinea = "N";
		Flag2 = idViaggioLinea;
		idViaggioLinea = "N";
		Flag3 = idViaggioLinea;
		idViaggioLinea = "N";
		Flag4 = idViaggioLinea;
		idViaggioLinea = "N";
		Flag5 = idViaggioLinea;
		idViaggioLinea = "N";
		Flag6 = idViaggioLinea;
		idViaggioLinea = "N";
		Flag7 = idViaggioLinea;
		idViaggioLinea = "N";
		Flag8 = idViaggioLinea;
		idViaggioLinea = "N";
		Flag9 = idViaggioLinea;
		idViaggioLinea = "N";
		Flag10 = idViaggioLinea;
		idViaggioLinea = "";
		Note1 = idViaggioLinea;
		idViaggioLinea = "";
		Note2 = idViaggioLinea;
		idViaggioLinea = "";
		Terminale = idViaggioLinea;
		idViaggioLinea = "";
		IdViaggioOBC = idViaggioLinea;
		idViaggioLinea = "";
		IdViaggioHost = idViaggioLinea;
		idViaggioLinea = "";
		UteIns = idViaggioLinea;
		idViaggioLinea = "";
		UteAgg = idViaggioLinea;
	}
}
