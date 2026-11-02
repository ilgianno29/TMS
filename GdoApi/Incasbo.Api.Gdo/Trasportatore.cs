using System;
using Incasbo.Web.Library;

namespace Incasbo.Api.Gdo;

[CustomListAttributes("TableName", "Trasportatori", "Key", new string[] { "Codice" })]
public class Trasportatore
{
	public string Codice { get; set; }

	public string CodiceContabile { get; set; }

	public string RagioneSociale { get; set; }

	public string Indirizzo { get; set; }

	public string Cap { get; set; }

	public string Localita { get; set; }

	public string Provincia { get; set; }

	public string ZonaPartenza { get; set; }

	public string Nazione { get; set; }

	public string Telefono { get; set; }

	public string Cellulare { get; set; }

	public string Fax { get; set; }

	public string Riferimento { get; set; }

	public string Email { get; set; }

	public string PartitaIva { get; set; }

	public string CodicePagamento { get; set; }

	public string CodiceIva { get; set; }

	public string Note { get; set; }

	public string ReportBordero { get; set; }

	public string Attivo { get; set; }

	public string FatturaA { get; set; }

	public string ReportFattura { get; set; }

	public string DataPerFatturazione { get; set; }

	public string EsportazioneBolle { get; set; }

	public string CodiceFiscale { get; set; }

	public string AlboTrasportatori { get; set; }

	public string ZonaSpedizione { get; set; }

	public int? StatoMinimoSpedizioniFatt { get; set; }

	public int? StatoMinimoViaggiFatt { get; set; }

	public string IsDefault { get; set; }

	public DateTime? DatAgg { get; set; }

	public string UteAgg { get; set; }

	public DateTime? DatIns { get; set; }

	public string UteIns { get; set; }

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

	public Trasportatore()
	{
		Codice = "";
		CodiceContabile = null;
		RagioneSociale = null;
		Indirizzo = null;
		Cap = null;
		Localita = null;
		Provincia = null;
		ZonaPartenza = null;
		Nazione = null;
		Telefono = null;
		Cellulare = null;
		Fax = null;
		Riferimento = null;
		Email = null;
		PartitaIva = null;
		CodicePagamento = null;
		CodiceIva = null;
		Note = null;
		ReportBordero = null;
		Attivo = null;
		FatturaA = null;
		ReportFattura = null;
		DataPerFatturazione = null;
		EsportazioneBolle = null;
		CodiceFiscale = null;
		AlboTrasportatori = null;
		ZonaSpedizione = null;
		StatoMinimoSpedizioniFatt = null;
		StatoMinimoViaggiFatt = null;
		IsDefault = null;
		UteAgg = null;
		UteIns = null;
	}
}
