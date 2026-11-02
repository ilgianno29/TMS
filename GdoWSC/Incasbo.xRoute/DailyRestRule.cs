using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class DailyRestRule : TransientVO
{
	private int extendedDrivingPeriodField;

	private int firstSplitRestPeriodField;

	private int maximumPeriodBetweenEndOfDailyRestsField;

	private int numberOfExtendedDrivingPeriodsField;

	private int numberOfReducedRestPeriodsField;

	private int reducedRestPeriodField;

	private int regularDrivingPeriodField;

	private int regularRestPeriodField;

	private int secondSplitRestPeriodField;

	[XmlAttribute]
	public int extendedDrivingPeriod
	{
		get
		{
			return extendedDrivingPeriodField;
		}
		set
		{
			extendedDrivingPeriodField = value;
			RaisePropertyChanged("extendedDrivingPeriod");
		}
	}

	[XmlAttribute]
	public int firstSplitRestPeriod
	{
		get
		{
			return firstSplitRestPeriodField;
		}
		set
		{
			firstSplitRestPeriodField = value;
			RaisePropertyChanged("firstSplitRestPeriod");
		}
	}

	[XmlAttribute]
	public int maximumPeriodBetweenEndOfDailyRests
	{
		get
		{
			return maximumPeriodBetweenEndOfDailyRestsField;
		}
		set
		{
			maximumPeriodBetweenEndOfDailyRestsField = value;
			RaisePropertyChanged("maximumPeriodBetweenEndOfDailyRests");
		}
	}

	[XmlAttribute]
	public int numberOfExtendedDrivingPeriods
	{
		get
		{
			return numberOfExtendedDrivingPeriodsField;
		}
		set
		{
			numberOfExtendedDrivingPeriodsField = value;
			RaisePropertyChanged("numberOfExtendedDrivingPeriods");
		}
	}

	[XmlAttribute]
	public int numberOfReducedRestPeriods
	{
		get
		{
			return numberOfReducedRestPeriodsField;
		}
		set
		{
			numberOfReducedRestPeriodsField = value;
			RaisePropertyChanged("numberOfReducedRestPeriods");
		}
	}

	[XmlAttribute]
	public int reducedRestPeriod
	{
		get
		{
			return reducedRestPeriodField;
		}
		set
		{
			reducedRestPeriodField = value;
			RaisePropertyChanged("reducedRestPeriod");
		}
	}

	[XmlAttribute]
	public int regularDrivingPeriod
	{
		get
		{
			return regularDrivingPeriodField;
		}
		set
		{
			regularDrivingPeriodField = value;
			RaisePropertyChanged("regularDrivingPeriod");
		}
	}

	[XmlAttribute]
	public int regularRestPeriod
	{
		get
		{
			return regularRestPeriodField;
		}
		set
		{
			regularRestPeriodField = value;
			RaisePropertyChanged("regularRestPeriod");
		}
	}

	[XmlAttribute]
	public int secondSplitRestPeriod
	{
		get
		{
			return secondSplitRestPeriodField;
		}
		set
		{
			secondSplitRestPeriodField = value;
			RaisePropertyChanged("secondSplitRestPeriod");
		}
	}
}
