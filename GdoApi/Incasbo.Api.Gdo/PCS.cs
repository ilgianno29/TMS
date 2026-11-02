using System;
using Incasbo.Web.Library;

namespace Incasbo.Api.Gdo;

[CustomListAttributes("TableName", "PCS", "Key", new string[] { "Codice" })]
public class PCS
{
	[CustomListAttributes("Bind", true)]
	public string Codice { get; set; }

	[CustomListAttributes("Bind", false)]
	public string CodiceEsterno { get; set; }

	[CustomListAttributes("Bind", false)]
	public string Cliente { get; set; }

	public string RagioneSociale { get; set; }

	public string Indirizzo { get; set; }

	public string Cap { get; set; }

	public string Localita { get; set; }

	public string Provincia { get; set; }

	public string Nazione { get; set; }

	public string CodiceFiscale { get; set; }

	public string PartitaIva { get; set; }

	public string Telefono { get; set; }

	public string Fax { get; set; }

	public string Riferimento { get; set; }

	public string Email { get; set; }

	public string CodiceContabile { get; set; }

	public string CodicePagamento { get; set; }

	public string PuntoDiDestino { get; set; }

	public string PuntoDiCarico { get; set; }

	public string PuntoDiParcoVeicolare { get; set; }

	public string PuntoDiDeposito { get; set; }

	public string IsFiliale { get; set; }

	public string CodiceTrasportatore { get; set; }

	public string CodiceCaricatore { get; set; }

	public string Destinatario { get; set; }

	public string CodiceDestinatario { get; set; }

	public string GruppoTariffa { get; set; }

	public string PuntoRitiro1 { get; set; }

	public string PuntoRitiro2 { get; set; }

	public string PuntoRitiro3 { get; set; }

	public string CodificaAutomatica { get; set; }

	public string Note { get; set; }

	public string NotePerUfficio { get; set; }

	public string NotePerAutista { get; set; }

	public string Attivo { get; set; }

	public string IsDefault { get; set; }

	[CustomListAttributes("Bind", false)]
	public string Latitudine { get; set; }

	[CustomListAttributes("Bind", false)]
	public string Longitudine { get; set; }

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

	public PCS()
	{
		Codice = "";
		CodiceEsterno = "";
		Cliente = "";
		RagioneSociale = null;
		Indirizzo = null;
		Cap = null;
		Localita = null;
		Provincia = null;
		Nazione = null;
		CodiceFiscale = null;
		PartitaIva = null;
		Telefono = null;
		Fax = null;
		Riferimento = null;
		Email = null;
		CodiceContabile = null;
		CodicePagamento = null;
		PuntoDiDestino = null;
		PuntoDiCarico = null;
		PuntoDiParcoVeicolare = null;
		PuntoDiDeposito = null;
		IsFiliale = "N";
		CodiceTrasportatore = null;
		CodiceCaricatore = null;
		Destinatario = null;
		CodiceDestinatario = null;
		GruppoTariffa = null;
		PuntoRitiro1 = null;
		PuntoRitiro2 = null;
		PuntoRitiro3 = null;
		CodificaAutomatica = "N";
		Note = null;
		NotePerUfficio = null;
		NotePerAutista = null;
		Attivo = null;
		IsDefault = null;
		Latitudine = "";
		Longitudine = "";
		UteAgg = null;
		UteIns = null;
	}
}
