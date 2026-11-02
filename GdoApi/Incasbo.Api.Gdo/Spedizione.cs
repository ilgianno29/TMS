using System;
using Incasbo.Web.Library;

namespace Incasbo.Api.Gdo;

[CustomListAttributes("TableName", "Spedizioni")]
public class Spedizione
{
	public string UniBol { get; set; }

	public string UniBolParent { get; set; }

	public string UniBolMaster { get; set; }

	public string Barcode { get; set; }

	[CustomListAttributes("Bind", false)]
	public string TransitoDeposito { get; set; }

	public int? Stato { get; set; }

	public int? StatoOBC { get; set; }

	public string TipoServizio { get; set; }

	public string Cliente { get; set; }

	public string Mittente { get; set; }

	public string MittenteRagioneSociale { get; set; }

	public string ClienteFatturazione { get; set; }

	public string NumeroBolla { get; set; }

	public DateTime? DataBolla { get; set; }

	public string NumeroOrdine { get; set; }

	public DateTime? DataOrdine { get; set; }

	public string NumeroOrdineCliente { get; set; }

	public DateTime? DataOrdineCliente { get; set; }

	public string TipoSpedizione { get; set; }

	public string TipoSpedizionePassivo { get; set; }

	public string TipoMerce { get; set; }

	public string Prebolla { get; set; }

	public string PCSPartenza { get; set; }

	public string PCSPartenza_RagSoc { get; set; }

	public string PCSPartenza_Indirizzo { get; set; }

	public string PCSPartenza_Cap { get; set; }

	public string PCSPartenza_Localita { get; set; }

	public string PCSPartenza_Provincia { get; set; }

	public string PCSPartenza_Nazione { get; set; }

	public string PCSDestinazione { get; set; }

	public string PCSDestinazione_RagSoc { get; set; }

	public string PCSDestinazione_Indirizzo { get; set; }

	public string PCSDestinazione_Cap { get; set; }

	public string PCSDestinazione_Localita { get; set; }

	public string PCSDestinazione_Provincia { get; set; }

	public string PCSDestinazione_Nazione { get; set; }

	public string DestinazioneCliente { get; set; }

	public string Destinatario { get; set; }

	public string DestinatarioCliente { get; set; }

	public string ZonaSpedizione { get; set; }

	public string ZonaPartenzaTariffaAttiva { get; set; }

	public string ZonaArrivoTariffaAttiva { get; set; }

	public string ZonaPartenzaTariffaPassiva { get; set; }

	public string ZonaArrivoTariffaPassiva { get; set; }

	public DateTime? DataConsegnaPrevista1 { get; set; }

	public DateTime? DataConsegnaPrevista2 { get; set; }

	public string NoteConsegnaPrevista { get; set; }

	public DateTime? DataRitiroPrevista1 { get; set; }

	public DateTime? DataRitiroPrevista2 { get; set; }

	public string NoteRitiroPrevisto { get; set; }

	public string Corrispondente { get; set; }

	public string Trasportatore { get; set; }

	public decimal? Peso { get; set; }

	public decimal? Colli { get; set; }

	public decimal? Pallet { get; set; }

	public decimal? Volume { get; set; }

	public decimal? CampoCalcolo1 { get; set; }

	public decimal? CampoCalcolo2 { get; set; }

	public decimal? CampoCalcolo3 { get; set; }

	public decimal? CampoCalcolo4 { get; set; }

	public decimal? CampoCalcolo5 { get; set; }

	public decimal? CampoCalcolo6 { get; set; }

	public decimal? CampoCalcolo7 { get; set; }

	public decimal? CampoCalcolo8 { get; set; }

	public decimal? CampoCalcolo9 { get; set; }

	public decimal? CampoCalcolo10 { get; set; }

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

	public string BloccoAmministrativo { get; set; }

	public decimal? Contrassegno { get; set; }

	public string Note { get; set; }

	public int? SequenzaOriginale { get; set; }

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

	public DateTime? DataSpedizione { get; set; }

	public string UnibolOBC { get; set; }

	public DateTime? DataOraPartenzaEffettiva { get; set; }

	public DateTime? DataOraArrivoEffettiva { get; set; }

	public int? SequenzaEffettiva { get; set; }

	public string IdViaggio { get; set; }

	public int? KmManuali { get; set; }

	public string UteIns { get; set; }

	public string UteAgg { get; set; }

	public int? StatoWms { get; set; }

	public Spedizione()
	{
		UniBol = "";
		UniBolParent = "";
		UniBolMaster = "";
		TransitoDeposito = "";
		NumeroBolla = "";
		NumeroOrdine = "";
		Prebolla = "S";
		BloccoAmministrativo = "N";
		UteIns = "";
		UteAgg = "";
	}
}
