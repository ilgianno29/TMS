using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class DriverRegulationsAUS : RegulationsBase
{
	private BreakRuleAUS breakRuleField;

	private DailyRestRuleAUS dailyRestRuleField;

	private WeeklyRestRuleAUS weeklyRestRuleField;

	[XmlElement(IsNullable = true, Order = 0)]
	public BreakRuleAUS breakRule
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

	[XmlElement(IsNullable = true, Order = 1)]
	public DailyRestRuleAUS dailyRestRule
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

	[XmlElement(IsNullable = true, Order = 2)]
	public WeeklyRestRuleAUS weeklyRestRule
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
}
