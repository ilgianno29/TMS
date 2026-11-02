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
public class WeeklyRestRuleAUS : TransientVO
{
	private int maximumWeeklyWorkingPeriodField;

	private int weeklyRestPeriodField;

	[XmlAttribute]
	public int maximumWeeklyWorkingPeriod
	{
		get
		{
			return maximumWeeklyWorkingPeriodField;
		}
		set
		{
			maximumWeeklyWorkingPeriodField = value;
			RaisePropertyChanged("maximumWeeklyWorkingPeriod");
		}
	}

	[XmlAttribute]
	public int weeklyRestPeriod
	{
		get
		{
			return weeklyRestPeriodField;
		}
		set
		{
			weeklyRestPeriodField = value;
			RaisePropertyChanged("weeklyRestPeriod");
		}
	}
}
