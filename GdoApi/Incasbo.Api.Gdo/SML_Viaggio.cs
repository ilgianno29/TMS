using System;
using Incasbo.Web.Library;

namespace Incasbo.Api.Gdo;

[CustomListAttributes("TableName", "SML_Viaggi", "Key", new string[] { "IdViaggio" })]
public class SML_Viaggio
{
	public int IdViaggio { get; set; }

	public int IdSessione { get; set; }

	public string CodiceGiro { get; set; }

	public int Stato { get; set; }

	public string TipoViaggio { get; set; }

	public DateTime? DataPartenza { get; set; }

	public DateTime? DataArrivo { get; set; }

	public string Mezzo { get; set; }

	public string TipoMezzo { get; set; }

	public string Vettore { get; set; }

	public string Autista { get; set; }

	public string TipoSpedizione { get; set; }

	public string TipoMerce { get; set; }

	public string PCSPartenza { get; set; }

	public string PCSArrivo { get; set; }

	public string ZonaSpedizione { get; set; }

	public string Macrozona { get; set; }

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

	public string Note1 { get; set; }

	public string Note2 { get; set; }

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

	public DateTime? DatAgg { get; set; }

	public string UteAgg { get; set; }

	public DateTime? DatIns { get; set; }

	public string UteIns { get; set; }

	public SML_Viaggio()
	{
		CodiceGiro = "";
		TipoViaggio = "";
		DataPartenza = null;
		DataArrivo = null;
		Mezzo = "";
		TipoMezzo = "";
		Vettore = "";
		Autista = "";
		TipoSpedizione = "";
		TipoMerce = "";
		PCSPartenza = "";
		PCSArrivo = "";
		ZonaSpedizione = "";
		Macrozona = "";
		Note1 = "";
		Note2 = "";
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
		UteAgg = "";
		UteIns = "";
	}
}
