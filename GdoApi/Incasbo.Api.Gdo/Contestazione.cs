using System;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;

namespace Incasbo.Api.Gdo;

[CustomListAttributes("TableName", "Contestazioni", "Key", new string[] { "Id" })]
public class Contestazione
{
	public int Id { get; set; }

	public string TipoContestazione { get; set; }

	public int Stato { get; set; }

	public string TipoSoggetto { get; set; }

	public string Soggetto_Codice { get; set; }

	public string Soggetto_RagioneSociale { get; set; }

	public string Soggetto_Indirizzo { get; set; }

	public string Soggetto_Cap { get; set; }

	public string Soggetto_Localita { get; set; }

	public string Soggetto_Provincia { get; set; }

	public string Soggetto_Nazione { get; set; }

	public string Unibol { get; set; }

	public DateTime DataApertura { get; set; }

	public DateTime? DataChiusura { get; set; }

	public string Riferimento1 { get; set; }

	public DateTime? DataRiferimento1 { get; set; }

	public string NoteRiferimento1 { get; set; }

	public string Riferimento2 { get; set; }

	public DateTime? DataRiferimento2 { get; set; }

	public string NoteRiferimento2 { get; set; }

	public string Note1 { get; set; }

	public string Note2 { get; set; }

	public string Note3 { get; set; }

	public DateTime? DatAgg { get; set; }

	public string UteAgg { get; set; }

	public DateTime? DatIns { get; set; }

	public string UteIns { get; set; }

	public Contestazione()
	{
		TipoContestazione = "";
		Stato = 10;
		TipoSoggetto = "X";
		Soggetto_Codice = null;
		Soggetto_RagioneSociale = null;
		Soggetto_Indirizzo = null;
		Soggetto_Cap = null;
		Soggetto_Localita = null;
		Soggetto_Provincia = null;
		Soggetto_Nazione = null;
		Unibol = null;
		DataApertura = DateAndTime.Now;
		DataChiusura = null;
		Riferimento1 = null;
		DataRiferimento1 = null;
		NoteRiferimento1 = null;
		Riferimento2 = null;
		DataRiferimento2 = null;
		NoteRiferimento2 = null;
		Note1 = null;
		Note2 = null;
		Note3 = null;
		UteAgg = null;
		UteIns = null;
	}
}
