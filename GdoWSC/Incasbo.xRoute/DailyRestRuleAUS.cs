using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
public class DailyRestRuleAUS : TransientVO
{
	private int dailyRestPeriodField;

	private int maximumDailyWorkingPeriodField;

	[XmlAttribute]
	public int dailyRestPeriod
	{
		get
		{
			return dailyRestPeriodField;
		}
		set
		{
			dailyRestPeriodField = value;
			RaisePropertyChanged("dailyRestPeriod");
		}
	}

	[XmlAttribute]
	public int maximumDailyWorkingPeriod
	{
		get
		{
			return maximumDailyWorkingPeriodField;
		}
		set
		{
			maximumDailyWorkingPeriodField = value;
			RaisePropertyChanged("maximumDailyWorkingPeriod");
		}
	}
}
