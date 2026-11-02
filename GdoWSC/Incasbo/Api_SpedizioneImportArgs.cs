using System;
using System.Runtime.Serialization;
using Microsoft.VisualBasic;

namespace Incasbo;

[DataContract]
public class Api_SpedizioneImportArgs
{
	[DataMember]
	public string Id { get; set; }

	[DataMember]
	public string IdTrasmissione { get; set; }

	[DataMember]
	public string NumeroOrdine { get; set; }

	[DataMember]
	public DateTime? DataOrdine { get; set; }

	[DataMember]
	public string NumeroBolla { get; set; }

	[DataMember]
	public DateTime? DataBolla { get; set; }

	[DataMember]
	public string NumeroOrdineCliente { get; set; }

	[DataMember]
	public DateTime? DataOrdineCliente { get; set; }

	[DataMember]
	public string TipoServizio { get; set; }

	[DataMember]
	public string Cliente { get; set; }

	[DataMember]
	public string Mittente { get; set; }

	[DataMember]
	public string MittenteRagioneSociale { get; set; }

	[DataMember]
	public string TipoSpedizione { get; set; }

	[DataMember]
	public string TipoSpedizionePassivo { get; set; }

	[DataMember]
	public string TipoMerce { get; set; }

	[DataMember]
	public string PCSPartenza { get; set; }

	[DataMember]
	public string PCSPartenzaEsterno { get; set; }

	[DataMember]
	public string PCSPartenza_RagSoc { get; set; }

	[DataMember]
	public string PCSPartenza_Indirizzo { get; set; }

	[DataMember]
	public string PCSPartenza_Cap { get; set; }

	[DataMember]
	public string PCSPartenza_Localita { get; set; }

	[DataMember]
	public string PCSPartenza_Provincia { get; set; }

	[DataMember]
	public string PCSPartenza_Nazione { get; set; }

	[DataMember]
	public string PCSDestinazione { get; set; }

	[DataMember]
	public string PCSDestinazioneEsterno { get; set; }

	[DataMember]
	public string PCSDestinazione_RagSoc { get; set; }

	[DataMember]
	public string PCSDestinazione_Indirizzo { get; set; }

	[DataMember]
	public string PCSDestinazione_Cap { get; set; }

	[DataMember]
	public string PCSDestinazione_Localita { get; set; }

	[DataMember]
	public string PCSDestinazione_Provincia { get; set; }

	[DataMember]
	public string PCSDestinazione_Nazione { get; set; }

	[DataMember]
	public string Destinatario { get; set; }

	[DataMember]
	public string DestinatarioCliente { get; set; }

	[DataMember]
	public string ZonaSpedizione { get; set; }

	[DataMember]
	public string ZonaPartenzaTariffaAttiva { get; set; }

	[DataMember]
	public string ZonaArrivoTariffaAttiva { get; set; }

	[DataMember]
	public string ZonaPartenzaTariffaPassiva { get; set; }

	[DataMember]
	public string ZonaArrivoTariffaPassiva { get; set; }

	[DataMember]
	public DateTime? DataConsegnaPrevista1 { get; set; }

	[DataMember]
	public DateTime? DataConsegnaPrevista2 { get; set; }

	[DataMember]
	public string NoteConsegnaPrevista { get; set; }

	[DataMember]
	public DateTime? DataRitiroPrevista1 { get; set; }

	[DataMember]
	public DateTime? DataRitiroPrevista2 { get; set; }

	[DataMember]
	public string NoteRitiroPrevisto { get; set; }

	[DataMember]
	public string Corrispondente { get; set; }

	[DataMember]
	public string Trasportatore { get; set; }

	[DataMember]
	public decimal Peso { get; set; }

	[DataMember]
	public int Colli { get; set; }

	[DataMember]
	public int Pallet { get; set; }

	[DataMember]
	public decimal Volume { get; set; }

	[DataMember]
	public decimal CampoCalcolo1 { get; set; }

	[DataMember]
	public decimal CampoCalcolo2 { get; set; }

	[DataMember]
	public decimal CampoCalcolo3 { get; set; }

	[DataMember]
	public decimal CampoCalcolo4 { get; set; }

	[DataMember]
	public decimal CampoCalcolo5 { get; set; }

	[DataMember]
	public decimal CampoCalcolo6 { get; set; }

	[DataMember]
	public decimal CampoCalcolo7 { get; set; }

	[DataMember]
	public decimal CampoCalcolo8 { get; set; }

	[DataMember]
	public decimal CampoCalcolo9 { get; set; }

	[DataMember]
	public decimal CampoCalcolo10 { get; set; }

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
	public decimal Contrassegno { get; set; }

	[DataMember]
	public string Note { get; set; }

	[DataMember]
	public string FillerAlfa1 { get; set; }

	[DataMember]
	public string FillerAlfa2 { get; set; }

	[DataMember]
	public string FillerAlfa3 { get; set; }

	[DataMember]
	public string FillerAlfa4 { get; set; }

	[DataMember]
	public string FillerAlfa5 { get; set; }

	[DataMember]
	public string FillerAlfa6 { get; set; }

	[DataMember]
	public string FillerAlfa7 { get; set; }

	[DataMember]
	public string FillerAlfa8 { get; set; }

	[DataMember]
	public string FillerAlfa9 { get; set; }

	[DataMember]
	public string FillerAlfa10 { get; set; }

	[DataMember]
	public DateTime? FillerData1 { get; set; }

	[DataMember]
	public DateTime? FillerData2 { get; set; }

	[DataMember]
	public DateTime? FillerData3 { get; set; }

	[DataMember]
	public DateTime? FillerData4 { get; set; }

	[DataMember]
	public DateTime? FillerData5 { get; set; }

	[DataMember]
	public DateTime? DataSpedizione { get; set; }

	[DataMember]
	public string BloccoAmministrativo { get; set; }

	[DataMember]
	public DateTime DatIns { get; set; }

	[DataMember]
	public string UteIns { get; set; }

	[DataMember]
	public DateTime DatAgg { get; set; }

	[DataMember]
	public string UteAgg { get; set; }

	[DataMember]
	public DateTime? DataElaborazione { get; set; }

	[DataMember]
	public string StatoElaborazione { get; set; }

	public Api_SpedizioneImportArgs()
	{
		Peso = default(decimal);
		int colli = 0;
		Colli = colli;
		colli = 0;
		Pallet = colli;
		Volume = default(decimal);
		CampoCalcolo1 = default(decimal);
		CampoCalcolo2 = default(decimal);
		CampoCalcolo3 = default(decimal);
		CampoCalcolo4 = default(decimal);
		CampoCalcolo5 = default(decimal);
		CampoCalcolo6 = default(decimal);
		CampoCalcolo7 = default(decimal);
		CampoCalcolo8 = default(decimal);
		CampoCalcolo9 = default(decimal);
		CampoCalcolo10 = default(decimal);
		string flag = "N";
		Flag1 = flag;
		flag = "N";
		Flag2 = flag;
		flag = "N";
		Flag3 = flag;
		flag = "N";
		Flag4 = flag;
		flag = "N";
		Flag5 = flag;
		flag = "N";
		Flag6 = flag;
		flag = "N";
		Flag7 = flag;
		flag = "N";
		Flag8 = flag;
		flag = "N";
		Flag9 = flag;
		flag = "N";
		Flag10 = flag;
		Contrassegno = default(decimal);
		flag = "N";
		BloccoAmministrativo = flag;
		DateTime now = DateAndTime.Now;
		DatIns = now;
		flag = "XXX";
		UteIns = flag;
		now = DateAndTime.Now;
		DatAgg = now;
		flag = "XXX";
		UteAgg = flag;
		flag = "N";
		StatoElaborazione = flag;
	}
}
