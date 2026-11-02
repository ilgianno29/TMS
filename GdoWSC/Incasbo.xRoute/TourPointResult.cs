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
public class TourPointResult : TransientVO
{
	private RecreationPeriods recreationPeriodsAtTourPointField;

	private RecreationPeriods recreationPeriodsOnRoadField;

	private DateTime arrivalTimeField;

	private bool arrivalTimeFieldSpecified;

	private DateTime departureTimeField;

	private bool departureTimeFieldSpecified;

	private DateTime endServiceTimeField;

	private bool endServiceTimeFieldSpecified;

	private int genuineWaitingPeriodField;

	private DateTime startServiceTimeField;

	private bool startServiceTimeFieldSpecified;

	private int stationIndexField;

	[XmlElement(IsNullable = true, Order = 0)]
	public RecreationPeriods recreationPeriodsAtTourPoint
	{
		get
		{
			return recreationPeriodsAtTourPointField;
		}
		set
		{
			recreationPeriodsAtTourPointField = value;
			RaisePropertyChanged("recreationPeriodsAtTourPoint");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public RecreationPeriods recreationPeriodsOnRoad
	{
		get
		{
			return recreationPeriodsOnRoadField;
		}
		set
		{
			recreationPeriodsOnRoadField = value;
			RaisePropertyChanged("recreationPeriodsOnRoad");
		}
	}

	[XmlAttribute]
	public DateTime arrivalTime
	{
		get
		{
			return arrivalTimeField;
		}
		set
		{
			arrivalTimeField = value;
			RaisePropertyChanged("arrivalTime");
		}
	}

	[XmlIgnore]
	public bool arrivalTimeSpecified
	{
		get
		{
			return arrivalTimeFieldSpecified;
		}
		set
		{
			arrivalTimeFieldSpecified = value;
			RaisePropertyChanged("arrivalTimeSpecified");
		}
	}

	[XmlAttribute]
	public DateTime departureTime
	{
		get
		{
			return departureTimeField;
		}
		set
		{
			departureTimeField = value;
			RaisePropertyChanged("departureTime");
		}
	}

	[XmlIgnore]
	public bool departureTimeSpecified
	{
		get
		{
			return departureTimeFieldSpecified;
		}
		set
		{
			departureTimeFieldSpecified = value;
			RaisePropertyChanged("departureTimeSpecified");
		}
	}

	[XmlAttribute]
	public DateTime endServiceTime
	{
		get
		{
			return endServiceTimeField;
		}
		set
		{
			endServiceTimeField = value;
			RaisePropertyChanged("endServiceTime");
		}
	}

	[XmlIgnore]
	public bool endServiceTimeSpecified
	{
		get
		{
			return endServiceTimeFieldSpecified;
		}
		set
		{
			endServiceTimeFieldSpecified = value;
			RaisePropertyChanged("endServiceTimeSpecified");
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
	public DateTime startServiceTime
	{
		get
		{
			return startServiceTimeField;
		}
		set
		{
			startServiceTimeField = value;
			RaisePropertyChanged("startServiceTime");
		}
	}

	[XmlIgnore]
	public bool startServiceTimeSpecified
	{
		get
		{
			return startServiceTimeFieldSpecified;
		}
		set
		{
			startServiceTimeFieldSpecified = value;
			RaisePropertyChanged("startServiceTimeSpecified");
		}
	}

	[XmlAttribute]
	public int stationIndex
	{
		get
		{
			return stationIndexField;
		}
		set
		{
			stationIndexField = value;
			RaisePropertyChanged("stationIndex");
		}
	}
}
