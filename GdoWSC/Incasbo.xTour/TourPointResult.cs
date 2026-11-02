using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
public class TourPointResult : TransientVO
{
	private Quantities currentQuantitiesField;

	private string[] wrappedTourPointViolationsField;

	private int arrivalTimeField;

	private int breakPeriodAtTourPointField;

	private int breakPeriodOnRoadField;

	private int delayField;

	private int departureTimeField;

	private int drivingDistanceField;

	private int drivingPeriodField;

	private int earlinessField;

	private int endServiceTimeField;

	private int orderIdField;

	private bool orderIdFieldSpecified;

	private int restPeriodAtTourPointField;

	private int restPeriodOnRoadField;

	private int servicePeriodField;

	private int startDistanceField;

	private int startServiceTimeField;

	private int waitingPeriodField;

	[XmlElement(IsNullable = true, Order = 0)]
	public Quantities currentQuantities
	{
		get
		{
			return currentQuantitiesField;
		}
		set
		{
			currentQuantitiesField = value;
			RaisePropertyChanged("currentQuantities");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
	[XmlArrayItem("String", Namespace = "http://wrappertypes.service.jabba.ptvag.com")]
	public string[] wrappedTourPointViolations
	{
		get
		{
			return wrappedTourPointViolationsField;
		}
		set
		{
			wrappedTourPointViolationsField = value;
			RaisePropertyChanged("wrappedTourPointViolations");
		}
	}

	[XmlAttribute]
	public int arrivalTime
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

	[XmlAttribute]
	public int breakPeriodAtTourPoint
	{
		get
		{
			return breakPeriodAtTourPointField;
		}
		set
		{
			breakPeriodAtTourPointField = value;
			RaisePropertyChanged("breakPeriodAtTourPoint");
		}
	}

	[XmlAttribute]
	public int breakPeriodOnRoad
	{
		get
		{
			return breakPeriodOnRoadField;
		}
		set
		{
			breakPeriodOnRoadField = value;
			RaisePropertyChanged("breakPeriodOnRoad");
		}
	}

	[XmlAttribute]
	public int delay
	{
		get
		{
			return delayField;
		}
		set
		{
			delayField = value;
			RaisePropertyChanged("delay");
		}
	}

	[XmlAttribute]
	public int departureTime
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

	[XmlAttribute]
	public int drivingDistance
	{
		get
		{
			return drivingDistanceField;
		}
		set
		{
			drivingDistanceField = value;
			RaisePropertyChanged("drivingDistance");
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
	public int earliness
	{
		get
		{
			return earlinessField;
		}
		set
		{
			earlinessField = value;
			RaisePropertyChanged("earliness");
		}
	}

	[XmlAttribute]
	public int endServiceTime
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

	[XmlAttribute]
	public int orderId
	{
		get
		{
			return orderIdField;
		}
		set
		{
			orderIdField = value;
			RaisePropertyChanged("orderId");
		}
	}

	[XmlIgnore]
	public bool orderIdSpecified
	{
		get
		{
			return orderIdFieldSpecified;
		}
		set
		{
			orderIdFieldSpecified = value;
			RaisePropertyChanged("orderIdSpecified");
		}
	}

	[XmlAttribute]
	public int restPeriodAtTourPoint
	{
		get
		{
			return restPeriodAtTourPointField;
		}
		set
		{
			restPeriodAtTourPointField = value;
			RaisePropertyChanged("restPeriodAtTourPoint");
		}
	}

	[XmlAttribute]
	public int restPeriodOnRoad
	{
		get
		{
			return restPeriodOnRoadField;
		}
		set
		{
			restPeriodOnRoadField = value;
			RaisePropertyChanged("restPeriodOnRoad");
		}
	}

	[XmlAttribute]
	public int servicePeriod
	{
		get
		{
			return servicePeriodField;
		}
		set
		{
			servicePeriodField = value;
			RaisePropertyChanged("servicePeriod");
		}
	}

	[XmlAttribute]
	public int startDistance
	{
		get
		{
			return startDistanceField;
		}
		set
		{
			startDistanceField = value;
			RaisePropertyChanged("startDistance");
		}
	}

	[XmlAttribute]
	public int startServiceTime
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

	[XmlAttribute]
	public int waitingPeriod
	{
		get
		{
			return waitingPeriodField;
		}
		set
		{
			waitingPeriodField = value;
			RaisePropertyChanged("waitingPeriod");
		}
	}
}
