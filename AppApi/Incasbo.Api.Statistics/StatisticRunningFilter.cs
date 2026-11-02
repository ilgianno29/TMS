using System.Runtime.CompilerServices;

namespace Incasbo.Api.Statistics;

public class StatisticRunningFilter
{
	[CompilerGenerated]
	private object _ValoreCampo;

	public string NomeCampo { get; set; }

	public string DescrizioneCampo { get; set; }

	public StatisticFieldType TipoCampo { get; set; }

	public object ValoreCampo
	{
		get
		{
			return _ValoreCampo;
		}
		set
		{
			_ValoreCampo = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public StatisticOperatore Operatore { get; set; }

	public StatisticRunningFilter()
	{
		string nomeCampo = "";
		NomeCampo = nomeCampo;
		nomeCampo = "";
		DescrizioneCampo = nomeCampo;
		StatisticFieldType tipoCampo = StatisticFieldType.Stringa;
		TipoCampo = tipoCampo;
		StatisticOperatore operatore = StatisticOperatore.Uguale;
		Operatore = operatore;
	}
}
