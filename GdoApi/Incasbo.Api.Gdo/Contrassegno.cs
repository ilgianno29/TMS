using System;
using Incasbo.Web.Library;

namespace Incasbo.Api.Gdo;

[CustomListAttributes("TableName", "Contrassegni", "Key", new string[] { "Id" })]
public class Contrassegno
{
	public int Id { get; set; }

	public int Stato { get; set; }

	public string UnibolMaster { get; set; }

	public string UnibolApertura { get; set; }

	public string UnibolChiusura { get; set; }

	public string Cliente { get; set; }

	public string ClienteFatturazione { get; set; }

	public string Corrispondente { get; set; }

	public string Trasportatore { get; set; }

	public string TrasportatoreFatturazione { get; set; }

	public DateTime DataCreazione { get; set; }

	// TODO: in VB la proprietà si chiamava "Contrassegno" (stesso nome della classe, non ammesso in C#).
	// Verificare il mapping verso la colonna Contrassegni.Contrassegno nell ORM.
	public decimal ImportoContrassegno { get; set; }

	public DateTime? DataEsito { get; set; }

	public string CausaleEsito { get; set; }

	public string NoteEsito { get; set; }

	public DateTime? DataIncasso { get; set; }

	public DateTime? DataCompetenzaAttiva { get; set; }

	public DateTime? DataCompetenzaPassiva { get; set; }

	public int? IdRimessa { get; set; }

	public string TipoIncasso { get; set; }

	public string NoteIncasso { get; set; }

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

	public DateTime? DatAgg { get; set; }

	public string UteAgg { get; set; }

	public DateTime? DatIns { get; set; }

	public string UteIns { get; set; }

	public Contrassegno()
	{
		UnibolMaster = "";
		UnibolApertura = "";
		UnibolChiusura = null;
		Cliente = "";
		ClienteFatturazione = "";
		Corrispondente = null;
		Trasportatore = null;
		TrasportatoreFatturazione = null;
		DataEsito = null;
		CausaleEsito = null;
		NoteEsito = null;
		DataIncasso = null;
		DataCompetenzaAttiva = null;
		DataCompetenzaPassiva = null;
		IdRimessa = null;
		TipoIncasso = null;
		NoteIncasso = null;
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
		UteAgg = null;
		UteIns = null;
	}
}
