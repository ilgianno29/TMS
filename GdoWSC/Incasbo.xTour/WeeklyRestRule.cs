using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class WeeklyRestRule : TransientVO
{
	private int maximumBiweeklyDrivingPeriodField;

	private int maximumPeriodBetweenWeeklyRestsField;

	private int maximumWeeklyDrivingPeriodField;

	private int weeklyRestPeriodField;

	[XmlAttribute]
	public int maximumBiweeklyDrivingPeriod
	{
		get
		{
			return maximumBiweeklyDrivingPeriodField;
		}
		set
		{
			maximumBiweeklyDrivingPeriodField = value;
			RaisePropertyChanged("maximumBiweeklyDrivingPeriod");
		}
	}

	[XmlAttribute]
	public int maximumPeriodBetweenWeeklyRests
	{
		get
		{
			return maximumPeriodBetweenWeeklyRestsField;
		}
		set
		{
			maximumPeriodBetweenWeeklyRestsField = value;
			RaisePropertyChanged("maximumPeriodBetweenWeeklyRests");
		}
	}

	[XmlAttribute]
	public int maximumWeeklyDrivingPeriod
	{
		get
		{
			return maximumWeeklyDrivingPeriodField;
		}
		set
		{
			maximumWeeklyDrivingPeriodField = value;
			RaisePropertyChanged("maximumWeeklyDrivingPeriod");
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
