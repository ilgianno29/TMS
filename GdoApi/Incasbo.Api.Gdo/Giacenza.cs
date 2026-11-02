using System;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;

namespace Incasbo.Api.Gdo;

[CustomListAttributes("TableName", "Giacenze", "Key", new string[] { "Id" })]
public class Giacenza
{
	public int Id { get; set; }

	public int Stato { get; set; }

	public DateTime DataApertura { get; set; }

	public DateTime? DataChiusura { get; set; }

	public int GiorniGiacenza { get; set; }

	public string UnibolMaster { get; set; }

	public string UnibolApertura { get; set; }

	public int ProgressivoApertura { get; set; }

	public string UnibolChiusura { get; set; }

	public int? ProgressivoChiusura { get; set; }

	public string Cliente { get; set; }

	public string ClienteFatturazione { get; set; }

	public string Corrispondente { get; set; }

	public string Trasportatore { get; set; }

	public string TrasportatoreFatturazione { get; set; }

	public DateTime? DataCompetenzaAttiva { get; set; }

	public DateTime? DataCompetenzaPassiva { get; set; }

	public int? IdFatturaAttiva { get; set; }

	public int? IdFatturaPassiva { get; set; }

	public string BloccaCosti { get; set; }

	public string BloccaRicavi { get; set; }

	public string TipoContrattoAttivoApplicato { get; set; }

	public string TipoContrattoPassivoApplicato { get; set; }

	public string ErroreTariffaAttiva { get; set; }

	public string ErroreTariffaPassiva { get; set; }

	public string Note1 { get; set; }

	public string Note2 { get; set; }

	public string Note3 { get; set; }

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

	public string CausaleChiusura { get; set; }

	public string NoteChiusura { get; set; }

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

	public DateTime? DatAgg { get; set; }

	public string UteAgg { get; set; }

	public DateTime? DatIns { get; set; }

	public string UteIns { get; set; }

	public Giacenza()
	{
		Stato = 10;
		DataApertura = DateAndTime.Now;
		DataChiusura = null;
		GiorniGiacenza = 0;
		UnibolMaster = "";
		UnibolApertura = "";
		UnibolChiusura = null;
		ProgressivoChiusura = null;
		Cliente = "";
		ClienteFatturazione = "";
		Corrispondente = null;
		Trasportatore = null;
		TrasportatoreFatturazione = null;
		DataCompetenzaAttiva = null;
		DataCompetenzaPassiva = null;
		IdFatturaAttiva = null;
		IdFatturaPassiva = null;
		BloccaCosti = "N";
		BloccaRicavi = "N";
		TipoContrattoAttivoApplicato = "N";
		TipoContrattoPassivoApplicato = "N";
		ErroreTariffaAttiva = null;
		ErroreTariffaPassiva = null;
		Note1 = null;
		Note2 = null;
		Note3 = null;
		FillerAlfa1 = null;
		FillerAlfa2 = null;
		FillerAlfa3 = null;
		FillerAlfa4 = null;
		FillerAlfa5 = null;
		FillerAlfa6 = null;
		FillerAlfa7 = null;
		FillerAlfa8 = null;
		FillerAlfa9 = null;
		FillerAlfa10 = null;
		Peso = null;
		Colli = null;
		Pallet = null;
		Volume = null;
		CampoCalcolo1 = null;
		CampoCalcolo2 = null;
		CampoCalcolo3 = null;
		CampoCalcolo4 = null;
		CampoCalcolo5 = null;
		CampoCalcolo6 = null;
		CampoCalcolo7 = null;
		CampoCalcolo8 = null;
		CampoCalcolo9 = null;
		CampoCalcolo10 = null;
		CausaleChiusura = null;
		NoteChiusura = null;
		UteAgg = "";
		UteIns = "";
	}
}
