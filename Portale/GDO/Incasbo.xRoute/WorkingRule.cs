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
public class WorkingRule : TransientVO
{
	private int breakPeriodField;

	private int dailyRestPeriodField;

	private int extendedBreakPeriodField;

	private int maxWorkingPeriodPerWeekField;

	private int maxWorkingPeriodWithoutBreakField;

	private int maxWorkingPeriodWithoutDailyRestField;

	private int maxWorkingPeriodWithoutExtendedBreakField;

	private int minPartialBreakLengthField;

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
	public int extendedBreakPeriod
	{
		get
		{
			return extendedBreakPeriodField;
		}
		set
		{
			extendedBreakPeriodField = value;
			RaisePropertyChanged("extendedBreakPeriod");
		}
	}

	[XmlAttribute]
	public int maxWorkingPeriodPerWeek
	{
		get
		{
			return maxWorkingPeriodPerWeekField;
		}
		set
		{
			maxWorkingPeriodPerWeekField = value;
			RaisePropertyChanged("maxWorkingPeriodPerWeek");
		}
	}

	[XmlAttribute]
	public int maxWorkingPeriodWithoutBreak
	{
		get
		{
			return maxWorkingPeriodWithoutBreakField;
		}
		set
		{
			maxWorkingPeriodWithoutBreakField = value;
			RaisePropertyChanged("maxWorkingPeriodWithoutBreak");
		}
	}

	[XmlAttribute]
	public int maxWorkingPeriodWithoutDailyRest
	{
		get
		{
			return maxWorkingPeriodWithoutDailyRestField;
		}
		set
		{
			maxWorkingPeriodWithoutDailyRestField = value;
			RaisePropertyChanged("maxWorkingPeriodWithoutDailyRest");
		}
	}

	[XmlAttribute]
	public int maxWorkingPeriodWithoutExtendedBreak
	{
		get
		{
			return maxWorkingPeriodWithoutExtendedBreakField;
		}
		set
		{
			maxWorkingPeriodWithoutExtendedBreakField = value;
			RaisePropertyChanged("maxWorkingPeriodWithoutExtendedBreak");
		}
	}

	[XmlAttribute]
	public int minPartialBreakLength
	{
		get
		{
			return minPartialBreakLengthField;
		}
		set
		{
			minPartialBreakLengthField = value;
			RaisePropertyChanged("minPartialBreakLength");
		}
	}
}
