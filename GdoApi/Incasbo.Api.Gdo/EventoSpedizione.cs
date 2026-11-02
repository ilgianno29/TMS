using System;

namespace Incasbo.Api.Gdo;

public class EventoSpedizione
{
	public string Unibol { get; set; }

	public string CodiceEvento { get; set; }

	public DateTime? DataOraEvento { get; set; }

	public string NoteInterne { get; set; }

	public string NoteEsterne { get; set; }

	public bool Importato { get; set; }

	public DateTime? DataConsegnaConcordata { get; set; }

	public DateTime? OraConsegnaConcordata1 { get; set; }

	public DateTime? OraConsegnaConcordata2 { get; set; }

	public string Riferimento { get; set; }

	public string Autista { get; set; }

	public string Terminale { get; set; }

	public string Motrice { get; set; }

	public string Rimorchio1 { get; set; }

	public string Contenitore1 { get; set; }

	public string Rimorchio2 { get; set; }

	public string Contenitore2 { get; set; }

	public string DatiAggiuntivi { get; set; }

	public string Latitudine { get; set; }

	public string Longitudine { get; set; }

	public DateTime? DataValiditaGPS { get; set; }

	public decimal? KmGPS { get; set; }

	public decimal? KmManuali { get; set; }

	public string Localita { get; set; }

	public string Indirizzo { get; set; }

	public string Cap { get; set; }

	public string Provincia { get; set; }

	public string Nazione { get; set; }

	public EventoSpedizione()
	{
		Unibol = "";
		CodiceEvento = "";
		NoteInterne = "";
		NoteEsterne = "";
		Riferimento = "";
		Autista = "";
		Terminale = "";
		Motrice = "";
		Rimorchio1 = "";
		Contenitore1 = "";
		Rimorchio2 = "";
		Contenitore2 = "";
		DatiAggiuntivi = "";
		Latitudine = "";
		Longitudine = "";
		Localita = "";
		Indirizzo = "";
		Cap = "";
		Provincia = "";
		Nazione = "";
	}
}
