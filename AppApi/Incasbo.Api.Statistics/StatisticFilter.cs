using System.Collections.Generic;

namespace Incasbo.Api.Statistics;

public class StatisticFilter
{
	public long Id { get; set; }

	public string CodiceStatistica { get; set; }

	public string NomeCampo { get; set; }

	public StatisticFieldType TipoCampo { get; set; }

	public string DescrizioneCampo { get; set; }

	public StatisticOperatore Operatore { get; set; }

	public string ValoreCampo { get; set; }

	public string Caption { get; set; }

	public string IdControlloUI { get; set; }

	public string ProprietaControlloUI { get; set; }

	public Dictionary<string, string> ProprietaControlloUIList { get; set; }

	public bool Enabled { get; set; }

	public bool Visibile { get; set; }

	public bool Attivo { get; set; }

	public string Tooltip { get; set; }

	public bool Required { get; set; }

	public StatisticFilter()
	{
		string codiceStatistica = "";
		CodiceStatistica = codiceStatistica;
		codiceStatistica = "";
		NomeCampo = codiceStatistica;
		StatisticFieldType tipoCampo = StatisticFieldType.Stringa;
		TipoCampo = tipoCampo;
		codiceStatistica = "";
		DescrizioneCampo = codiceStatistica;
		StatisticOperatore operatore = StatisticOperatore.Uguale;
		Operatore = operatore;
		codiceStatistica = "";
		ValoreCampo = codiceStatistica;
		codiceStatistica = "";
		Caption = codiceStatistica;
		codiceStatistica = "";
		IdControlloUI = codiceStatistica;
		codiceStatistica = "";
		ProprietaControlloUI = codiceStatistica;
		Dictionary<string, string> proprietaControlloUIList = new Dictionary<string, string>();
		ProprietaControlloUIList = proprietaControlloUIList;
		codiceStatistica = "";
		Tooltip = codiceStatistica;
		bool required = false;
		Required = required;
	}
}
