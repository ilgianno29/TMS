using System;

namespace Incasbo.Web.GDO.Foglione;

public class Viaggio
{
	public int IdViaggio { get; set; }

	public string AutistaRiferimento { get; set; }

	public string MotriceRiferimento { get; set; }

	public DateTime DataRiferimentoInizio { get; set; }

	public DateTime DataRiferimentoFine { get; set; }

	public int Stato { get; set; }

	public string TipoViaggio { get; set; }

	public DateTime? DataPartenzaPianificata { get; set; }

	public DateTime? DataArrivoPianificata { get; set; }

	public DateTime? DataPartenzaEffettiva { get; set; }

	public DateTime? DataArrivoEffettiva { get; set; }

	public string MotricePianificata { get; set; }

	public string Rimorchio1Pianificato { get; set; }

	public string Rimorchio2Pianificato { get; set; }

	public string Contenitore1Pianificato { get; set; }

	public string Contenitore2Pianificato { get; set; }

	public string Autista1Pianificato { get; set; }

	public string Autista1Pianificato_RagSoc { get; set; }

	public string Autista2Pianificato { get; set; }

	public string MotriceEffettiva { get; set; }

	public string Rimorchio1Effettivo { get; set; }

	public string Rimorchio2Effettivo { get; set; }

	public string Contenitore1Effettivo { get; set; }

	public string Contenitore2Effettivo { get; set; }

	public string Autista1Effettivo { get; set; }

	public string Autista1Effettivo_RagSoc { get; set; }

	public string Autista2Effettivo { get; set; }

	public string Vettore { get; set; }

	public string Vettore_RagSoc { get; set; }

	public string TipoSpedizione { get; set; }

	public string TipoSpedizione_Descrizione { get; set; }

	public string TipoMerce { get; set; }

	public string TipoMerce_Descrizione { get; set; }

	public string Cliente { get; set; }

	public string Cliente_RagSoc { get; set; }

	public string PCSPartenza { get; set; }

	public string PCSPartenza_RagSoc { get; set; }

	public string PCSPartenza_Localita { get; set; }

	public string PCSPartenza_Provincia { get; set; }

	public string PCSArrivo { get; set; }

	public string PCSArrivo_RagSoc { get; set; }

	public string PCSArrivo_Localita { get; set; }

	public string PCSArrivo_Provincia { get; set; }

	public string PCSPartenzaEffettivo { get; set; }

	public string PCSPartenzaEffettivo_RagSoc { get; set; }

	public string PCSPartenzaEffettivo_Localita { get; set; }

	public string PCSPartenzaEffettivo_Provincia { get; set; }

	public string PCSArrivoEffettivo { get; set; }

	public string PCSArrivoEffettivo_RagSoc { get; set; }

	public string PCSArrivoEffettivo_Localita { get; set; }

	public string PCSArrivoEffettivo_Provincia { get; set; }

	public int Peso { get; set; }

	public int Colli { get; set; }

	public int Pallet { get; set; }

	public int Volume { get; set; }

	public int NumeroSpedizioni { get; set; }

	public string Terminale { get; set; }

	public string Targa { get; set; }

	public int KmPianificati { get; set; }

	public string TempoPrevisto { get; set; }

	public string FlagViaggioSospeso { get; set; }

	public string Viaggio_Descrizione { get; set; }

	public string Viaggio_ToolTip { get; set; }

	public Viaggio()
	{
		IdViaggio = 0;
		AutistaRiferimento = "";
		MotriceRiferimento = "";
		Stato = 0;
		TipoViaggio = "";
		MotricePianificata = "";
		Rimorchio1Pianificato = "";
		Rimorchio2Pianificato = "";
		Contenitore1Pianificato = "";
		Contenitore2Pianificato = "";
		Autista1Pianificato = "";
		Autista1Pianificato_RagSoc = "";
		Autista2Pianificato = "";
		MotriceEffettiva = "";
		Rimorchio1Effettivo = "";
		Rimorchio2Effettivo = "";
		Contenitore1Effettivo = "";
		Contenitore2Effettivo = "";
		Autista1Effettivo = "";
		Autista1Effettivo_RagSoc = "";
		Autista2Effettivo = "";
		Vettore = "";
		Vettore_RagSoc = "";
		TipoSpedizione = "";
		TipoSpedizione_Descrizione = "";
		TipoMerce = "";
		TipoMerce_Descrizione = "";
		Cliente = "";
		Cliente_RagSoc = "";
		PCSPartenza = "";
		PCSPartenza_RagSoc = "";
		PCSPartenza_Localita = "";
		PCSPartenza_Provincia = "";
		PCSArrivo = "";
		PCSArrivo_RagSoc = "";
		PCSArrivo_Localita = "";
		PCSArrivo_Provincia = "";
		PCSPartenzaEffettivo = "";
		PCSPartenzaEffettivo_RagSoc = "";
		PCSPartenzaEffettivo_Localita = "";
		PCSPartenzaEffettivo_Provincia = "";
		PCSArrivoEffettivo = "";
		PCSArrivoEffettivo_RagSoc = "";
		PCSArrivoEffettivo_Localita = "";
		PCSArrivoEffettivo_Provincia = "";
		Peso = 0;
		Colli = 0;
		Pallet = 0;
		Volume = 0;
		NumeroSpedizioni = 0;
		Terminale = "";
		Targa = "";
		KmPianificati = 0;
		TempoPrevisto = "";
		FlagViaggioSospeso = "";
		Viaggio_Descrizione = "";
		Viaggio_ToolTip = "";
	}
}
