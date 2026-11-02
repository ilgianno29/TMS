using System;

namespace Incasbo.Web.GDO.Foglione;

public class PlanningDate
{
	protected bool? _Festivo;

	public DateTime Data { get; set; }

	public string GiornoDellaSettimana => Data.ToString("dddd");

	public bool Festivo
	{
		get
		{
			if (_Festivo.HasValue)
			{
				return _Festivo.Value;
			}
			if ((Data.DayOfWeek == DayOfWeek.Sunday) | (Data.DayOfWeek == DayOfWeek.Saturday))
			{
				return true;
			}
			return false;
		}
		set
		{
			_Festivo = value;
		}
	}
}
