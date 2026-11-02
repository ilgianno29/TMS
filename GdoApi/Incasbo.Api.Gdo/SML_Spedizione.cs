using System;
using Incasbo.Web.Library;

namespace Incasbo.Api.Gdo;

[CustomListAttributes("TableName", "SML_Spedizioni", "Key", new string[] { "Unibol" })]
public class SML_Spedizione
{
	public string Unibol { get; set; }

	public int IdSessione { get; set; }

	public string CodiceGiro { get; set; }

	public int Stato { get; set; }

	public string Cliente { get; set; }

	public string NumeroBolla { get; set; }

	public DateTime? DataBolla { get; set; }

	public string NumeroOrdine { get; set; }

	public DateTime? DataOrdine { get; set; }

	public string TipoSpedizione { get; set; }

	public string TipoMerce { get; set; }

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

	public string ZonaSpedizione { get; set; }

	public string Macrozona { get; set; }

	public string Corrispondente { get; set; }

	public decimal? Peso { get; set; }

	public int? Colli { get; set; }

	public int? Pallet { get; set; }

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

	public string Note { get; set; }

	public DateTime? DataOraPartenza { get; set; }

	public DateTime? DataOraArrivo { get; set; }

	public DateTime? DataOraConsegna { get; set; }

	public int? IdViaggio { get; set; }

	public int Sequenza { get; set; }

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

	public DateTime? DatIns { get; set; }

	public string UteIns { get; set; }

	public DateTime? DatAgg { get; set; }

	public string UteAgg { get; set; }

	public SML_Spedizione()
	{
		Unibol = "";
		CodiceGiro = "";
		Cliente = "";
		NumeroBolla = "";
		DataBolla = null;
		NumeroOrdine = "";
		DataOrdine = null;
		TipoSpedizione = "";
		TipoMerce = "";
		PCSPartenza = "";
		PCSPartenza_RagSoc = "";
		PCSPartenza_Indirizzo = "";
		PCSPartenza_Cap = "";
		PCSPartenza_Localita = "";
		PCSPartenza_Provincia = "";
		PCSPartenza_Nazione = "";
		PCSDestinazione = "";
		PCSDestinazione_RagSoc = "";
		PCSDestinazione_Indirizzo = "";
		PCSDestinazione_Cap = "";
		PCSDestinazione_Localita = "";
		PCSDestinazione_Provincia = "";
		PCSDestinazione_Nazione = "";
		ZonaSpedizione = "";
		Macrozona = "";
		Corrispondente = "";
		Note = "";
		DataOraPartenza = null;
		DataOraArrivo = null;
		DataOraConsegna = null;
		FillerAlfa1 = "";
		FillerAlfa2 = "";
		FillerAlfa3 = "";
		FillerAlfa4 = "";
		FillerAlfa5 = "";
		FillerAlfa6 = "";
		FillerAlfa7 = "";
		FillerAlfa8 = "";
		FillerAlfa9 = "";
		FillerAlfa10 = "";
		FillerData1 = null;
		FillerData2 = null;
		FillerData3 = null;
		FillerData4 = null;
		FillerData5 = null;
		UteIns = "";
		UteAgg = "";
	}
}
