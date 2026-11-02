using System;

namespace Incasbo.Api.Gdo;

public class Spedizione_Tratta
{
	public string IdSpedizioneMadre { get; set; }

	public string IdSubSpedizione { get; set; }

	public string Descrizione { get; set; }

	public int Sequenza { get; set; }

	public int TotaleTratte { get; set; }

	public string TipoServizio { get; set; }

	public string Partenza { get; set; }

	public string Arrivo { get; set; }

	public string Corrispondente { get; set; }

	public DateTime? DataConsegna { get; set; }

	public Spedizione_Tratta()
	{
		IdSpedizioneMadre = "";
		IdSubSpedizione = "";
		Descrizione = "";
		TipoServizio = "";
		Partenza = "";
		Arrivo = "";
		Corrispondente = "";
	}
}
