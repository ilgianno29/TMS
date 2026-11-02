using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class ChainResult : TransientVO
{
	private TourEvent[] wrappedTourEventsField;

	private double chainCostsField;

	private int distanceFromStartLocationField;

	private int distanceToEndLocationField;

	private int drivingPeriodField;

	private int endTimeField;

	private int periodFromStartLocationField;

	private int periodToEndLocationField;

	private string remainingPeriodsField;

	private string vehicleDescriptionField;

	[XmlArray(IsNullable = true, Order = 0)]
	public TourEvent[] wrappedTourEvents
	{
		get
		{
			return wrappedTourEventsField;
		}
		set
		{
			wrappedTourEventsField = value;
			RaisePropertyChanged("wrappedTourEvents");
		}
	}

	[XmlAttribute]
	public double chainCosts
	{
		get
		{
			return chainCostsField;
		}
		set
		{
			chainCostsField = value;
			RaisePropertyChanged("chainCosts");
		}
	}

	[XmlAttribute]
	public int distanceFromStartLocation
	{
		get
		{
			return distanceFromStartLocationField;
		}
		set
		{
			distanceFromStartLocationField = value;
			RaisePropertyChanged("distanceFromStartLocation");
		}
	}

	[XmlAttribute]
	public int distanceToEndLocation
	{
		get
		{
			return distanceToEndLocationField;
		}
		set
		{
			distanceToEndLocationField = value;
			RaisePropertyChanged("distanceToEndLocation");
		}
	}

	[XmlAttribute]
	public int drivingPeriod
	{
		get
		{
			return drivingPeriodField;
		}
		set
		{
			drivingPeriodField = value;
			RaisePropertyChanged("drivingPeriod");
		}
	}

	[XmlAttribute]
	public int endTime
	{
		get
		{
			return endTimeField;
		}
		set
		{
			endTimeField = value;
			RaisePropertyChanged("endTime");
		}
	}

	[XmlAttribute]
	public int periodFromStartLocation
	{
		get
		{
			return periodFromStartLocationField;
		}
		set
		{
			periodFromStartLocationField = value;
			RaisePropertyChanged("periodFromStartLocation");
		}
	}

	[XmlAttribute]
	public int periodToEndLocation
	{
		get
		{
			return periodToEndLocationField;
		}
		set
		{
			periodToEndLocationField = value;
			RaisePropertyChanged("periodToEndLocation");
		}
	}

	[XmlAttribute]
	public string remainingPeriods
	{
		get
		{
			return remainingPeriodsField;
		}
		set
		{
			remainingPeriodsField = value;
			RaisePropertyChanged("remainingPeriods");
		}
	}

	[XmlAttribute]
	public string vehicleDescription
	{
		get
		{
			return vehicleDescriptionField;
		}
		set
		{
			vehicleDescriptionField = value;
			RaisePropertyChanged("vehicleDescription");
		}
	}
}
