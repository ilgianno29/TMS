using System;
using Incasbo.Web.Library;

namespace Incasbo.Api.Gdo;

[CustomListAttributes("TableName", "Spedizioni", "Key", new string[] { "Unibol" })]
public class SubSpedizione
{
	public string Unibol { get; set; }

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

	public DateTime? DataConsegnaPrevista1 { get; set; }

	public DateTime? DataConsegnaPrevista2 { get; set; }

	public string ZonaSpedizione { get; set; }

	public string ZonaArrivoTariffaAttiva { get; set; }

	public string ZonaArrivoTariffaPassiva { get; set; }

	public string ZonaPartenzaTariffaAttiva { get; set; }

	public string ZonaPartenzaTariffaPassiva { get; set; }

	public string Corrispondente { get; set; }

	[CustomListAttributes("Bind", false)]
	public string TipoMerce { get; set; }

	public DateTime? DatAgg { get; set; }

	public string UteAgg { get; set; }

	public SubSpedizione()
	{
		Unibol = "";
		PCSPartenza = null;
		PCSPartenza_RagSoc = null;
		PCSPartenza_Indirizzo = null;
		PCSPartenza_Cap = null;
		PCSPartenza_Localita = null;
		PCSPartenza_Provincia = null;
		PCSPartenza_Nazione = null;
		PCSDestinazione = null;
		PCSDestinazione_RagSoc = null;
		PCSDestinazione_Indirizzo = null;
		PCSDestinazione_Cap = null;
		PCSDestinazione_Localita = null;
		PCSDestinazione_Provincia = null;
		PCSDestinazione_Nazione = null;
		DataConsegnaPrevista1 = null;
		DataConsegnaPrevista2 = null;
		ZonaSpedizione = null;
		ZonaArrivoTariffaAttiva = null;
		ZonaArrivoTariffaPassiva = null;
		ZonaPartenzaTariffaAttiva = null;
		ZonaPartenzaTariffaPassiva = null;
		Corrispondente = null;
		TipoMerce = null;
		UteAgg = null;
	}
}
