using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public class DriverRegulations : RegulationsBase
{
	private BreakIntervals breakIntervalsField;

	private BreakRule breakRuleField;

	private DailyRestRule dailyRestRuleField;

	private WeeklyRestRule weeklyRestRuleField;

	private WorkingRule workingRuleField;

	[XmlElement(IsNullable = true, Order = 0)]
	public BreakIntervals breakIntervals
	{
		get
		{
			return breakIntervalsField;
		}
		set
		{
			breakIntervalsField = value;
			RaisePropertyChanged("breakIntervals");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public BreakRule breakRule
	{
		get
		{
			return breakRuleField;
		}
		set
		{
			breakRuleField = value;
			RaisePropertyChanged("breakRule");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public DailyRestRule dailyRestRule
	{
		get
		{
			return dailyRestRuleField;
		}
		set
		{
			dailyRestRuleField = value;
			RaisePropertyChanged("dailyRestRule");
		}
	}

	[XmlElement(IsNullable = true, Order = 3)]
	public WeeklyRestRule weeklyRestRule
	{
		get
		{
			return weeklyRestRuleField;
		}
		set
		{
			weeklyRestRuleField = value;
			RaisePropertyChanged("weeklyRestRule");
		}
	}

	[XmlElement(IsNullable = true, Order = 4)]
	public WorkingRule workingRule
	{
		get
		{
			return workingRuleField;
		}
		set
		{
			workingRuleField = value;
			RaisePropertyChanged("workingRule");
		}
	}
}
