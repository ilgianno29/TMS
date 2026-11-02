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
public class RecreationPeriods : TransientVO
{
	private int breakPeriodField;

	private int dailyRestPeriodField;

	private int weeklyRestPeriodField;

	[XmlAttribute]
	public int breakPeriod
	{
		get
		{
			return breakPeriodField;
		}
		set
		{
			breakPeriodField = value;
			RaisePropertyChanged("breakPeriod");
		}
	}

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
