using System.Collections.Generic;

namespace Incasbo.Api.Statistics;

public class Statistic
{
	public string Codice { get; set; }

	public string Descrizione { get; set; }

	public string Titolo { get; set; }

	public string Sottotitolo { get; set; }

	public StatisticType TipoStatistica { get; set; }

	public bool Asincrona { get; set; }

	public string Utente { get; set; }

	public string NomRep { get; set; }

	public string NomTab { get; set; }

	public string Param1 { get; set; }

	public string Param2 { get; set; }

	public string Param3 { get; set; }

	public string Param4 { get; set; }

	public string Param5 { get; set; }

	public bool Attivo { get; set; }

	public bool Visibile { get; set; }

	public List<StatisticFilter> Filtri { get; set; }

	public string PreprocessingClassName { get; set; }

	public Statistic()
	{
		string codice = "";
		Codice = codice;
		codice = "";
		Descrizione = codice;
		codice = "";
		Titolo = codice;
		codice = "";
		Sottotitolo = codice;
		StatisticType tipoStatistica = StatisticType.PDF;
		TipoStatistica = tipoStatistica;
		bool asincrona = false;
		Asincrona = asincrona;
		codice = "";
		Utente = codice;
		codice = "";
		NomRep = codice;
		codice = "";
		NomTab = codice;
		codice = "";
		Param1 = codice;
		codice = "";
		Param2 = codice;
		codice = "";
		Param3 = codice;
		codice = "";
		Param4 = codice;
		codice = "";
		Param5 = codice;
		asincrona = false;
		Attivo = asincrona;
		asincrona = false;
		Visibile = asincrona;
		List<StatisticFilter> filtri = new List<StatisticFilter>();
		Filtri = filtri;
		codice = "";
		PreprocessingClassName = codice;
	}
}
