using System;

namespace Incasbo.Web.GDO.Foglione;

public class Spedizione
{
	public string Unibol { get; set; }

	public int ProgressivoConsegna { get; set; }

	public int Stato { get; set; }

	public string TipoServizio { get; set; }

	public string Cliente { get; set; }

	public string Cliente_RagSoc { get; set; }

	public string Mittente { get; set; }

	public string Mittente_RagSoc { get; set; }

	public string NumeroOrdine { get; set; }

	public DateTime? DataOrdine { get; set; }

	public string NumeroBolla { get; set; }

	public DateTime? DataBolla { get; set; }

	public string NumeroOrdineCliente { get; set; }

	public DateTime? DataOrdineCliente { get; set; }

	public string TipoSpedizione { get; set; }

	public string TipoSpedizione_Descrizione { get; set; }

	public string TipoMerce { get; set; }

	public string TipoMerce_Descrizione { get; set; }

	public string PCSPartenza { get; set; }

	public string PCSPartenza_RagSoc { get; set; }

	public string PCSPartenza_Localita { get; set; }

	public string PCSPartenza_Provincia { get; set; }

	public string PCSDestinazione { get; set; }

	public string PCSDestinazione_RagSoc { get; set; }

	public string PCSDestinazione_Localita { get; set; }

	public string PCSDestinazione_Provincia { get; set; }

	public DateTime? DataConsegnaPrevista1 { get; set; }

	public DateTime? DataConsegnaPrevista2 { get; set; }

	public DateTime? DataRitiroPrevista1 { get; set; }

	public DateTime? DataRitiroPrevista2 { get; set; }

	public string Corrispondente { get; set; }

	public string Corrispondente_RagSoc { get; set; }

	public string Corrispondente_Localita { get; set; }

	public string Corrispondente_Provincia { get; set; }

	public string Trasportatore { get; set; }

	public string Trasportatore_RagSoc { get; set; }

	public decimal Peso { get; set; }

	public int Colli { get; set; }

	public int Pallet { get; set; }

	public decimal Volume { get; set; }

	public int? IdViaggio { get; set; }

	public int SequenzaPianificata { get; set; }

	public int SequenzaEffettiva { get; set; }

	public DateTime? DataSpedizione { get; set; }

	public DateTime? DataOraArrivoEffettiva { get; set; }

	public string Esito { get; set; }

	public Spedizione()
	{
		Unibol = "";
		ProgressivoConsegna = 0;
		Stato = 0;
		TipoServizio = "";
		Cliente = "";
		Cliente_RagSoc = "";
		Mittente = "";
		Mittente_RagSoc = "";
		NumeroOrdine = "";
		NumeroBolla = "";
		NumeroOrdineCliente = "";
		TipoSpedizione = "";
		TipoSpedizione_Descrizione = "";
		TipoMerce = "";
		TipoMerce_Descrizione = "";
		PCSPartenza = "";
		PCSPartenza_RagSoc = "";
		PCSPartenza_Localita = "";
		PCSPartenza_Provincia = "";
		PCSDestinazione = "";
		PCSDestinazione_RagSoc = "";
		PCSDestinazione_Localita = "";
		PCSDestinazione_Provincia = "";
		Corrispondente = "";
		Corrispondente_RagSoc = "";
		Corrispondente_Localita = "";
		Corrispondente_Provincia = "";
		Trasportatore = "";
		Trasportatore_RagSoc = "";
		Peso = 0m;
		Colli = 0;
		Pallet = 0;
		Volume = 0m;
		SequenzaPianificata = 0;
		SequenzaEffettiva = 0;
		Esito = "";
	}
}
