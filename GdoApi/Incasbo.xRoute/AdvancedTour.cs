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
public class AdvancedTour : ExtendedRoute
{
	private RecreationPeriods recreationPeriodsField;

	private TourEvent[] wrappedTourEventsField;

	private TourPointResult[] wrappedTourPointResultsField;

	private int defermentPotentialField;

	private int genuineWaitingPeriodField;

	private bool isViolatedField;

	private string remainingPeriodsField;

	private DateTime startTimeField;

	private bool startTimeFieldSpecified;

	private int tourPeriodField;

	[XmlElement(IsNullable = true, Order = 0)]
	public RecreationPeriods recreationPeriods
	{
		get
		{
			return recreationPeriodsField;
		}
		set
		{
			recreationPeriodsField = value;
			RaisePropertyChanged("recreationPeriods");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
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

	[XmlArray(IsNullable = true, Order = 2)]
	public TourPointResult[] wrappedTourPointResults
	{
		get
		{
			return wrappedTourPointResultsField;
		}
		set
		{
			wrappedTourPointResultsField = value;
			RaisePropertyChanged("wrappedTourPointResults");
		}
	}

	[XmlAttribute]
	public int defermentPotential
	{
		get
		{
			return defermentPotentialField;
		}
		set
		{
			defermentPotentialField = value;
			RaisePropertyChanged("defermentPotential");
		}
	}

	[XmlAttribute]
	public int genuineWaitingPeriod
	{
		get
		{
			return genuineWaitingPeriodField;
		}
		set
		{
			genuineWaitingPeriodField = value;
			RaisePropertyChanged("genuineWaitingPeriod");
		}
	}

	[XmlAttribute]
	public bool isViolated
	{
		get
		{
			return isViolatedField;
		}
		set
		{
			isViolatedField = value;
			RaisePropertyChanged("isViolated");
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
	public DateTime startTime
	{
		get
		{
			return startTimeField;
		}
		set
		{
			startTimeField = value;
			RaisePropertyChanged("startTime");
		}
	}

	[XmlIgnore]
	public bool startTimeSpecified
	{
		get
		{
			return startTimeFieldSpecified;
		}
		set
		{
			startTimeFieldSpecified = value;
			RaisePropertyChanged("startTimeSpecified");
		}
	}

	[XmlAttribute]
	public int tourPeriod
	{
		get
		{
			return tourPeriodField;
		}
		set
		{
			tourPeriodField = value;
			RaisePropertyChanged("tourPeriod");
		}
	}
}
