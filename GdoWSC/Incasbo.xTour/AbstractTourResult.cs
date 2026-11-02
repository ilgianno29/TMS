using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(TourResult))]
[DesignerCategory("code")]
[DebuggerStepThrough]
[XmlInclude(typeof(SequencingTourResult))]
public abstract class AbstractTourResult : TransientVO
{
	private Quantities deliveryQuantitiesField;

	private Quantities maxQuantitiesField;

	private Quantities pickupQuantitiesField;

	private TotalCosts totalCostsField;

	private string[] wrappedViolationsField;

	private int breakPeriodField;

	private bool coDriverRequiredField;

	private int depotAvailabilityForDeliveriesField;

	private bool depotAvailabilityForDeliveriesFieldSpecified;

	private int depotAvailabilityForPickupsField;

	private bool depotAvailabilityForPickupsFieldSpecified;

	private int depotUnloadingPeriodField;

	private int depotUploadingPeriodField;

	private int distanceField;

	private int distanceFromFirstToLastTransportPointField;

	private int drivingPeriodField;

	private int earlinessField;

	private int maxDistanceBetweenTransportPointsField;

	private int periodField;

	private string remainingPeriodsField;

	private int restPeriodField;

	private int servicePeriodField;

	private int startTimeField;

	private int startTimeLatestField;

	private bool tourChangedField;

	private int transportPointCountField;

	private int waitingPeriodField;

	[XmlElement(IsNullable = true, Order = 0)]
	public Quantities deliveryQuantities
	{
		get
		{
			return deliveryQuantitiesField;
		}
		set
		{
			deliveryQuantitiesField = value;
			RaisePropertyChanged("deliveryQuantities");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public Quantities maxQuantities
	{
		get
		{
			return maxQuantitiesField;
		}
		set
		{
			maxQuantitiesField = value;
			RaisePropertyChanged("maxQuantities");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public Quantities pickupQuantities
	{
		get
		{
			return pickupQuantitiesField;
		}
		set
		{
			pickupQuantitiesField = value;
			RaisePropertyChanged("pickupQuantities");
		}
	}

	[XmlElement(IsNullable = true, Order = 3)]
	public TotalCosts totalCosts
	{
		get
		{
			return totalCostsField;
		}
		set
		{
			totalCostsField = value;
			RaisePropertyChanged("totalCosts");
		}
	}

	[XmlArrayItem("String", Namespace = "http://wrappertypes.service.jabba.ptvag.com")]
	[XmlArray(IsNullable = true, Order = 4)]
	public string[] wrappedViolations
	{
		get
		{
			return wrappedViolationsField;
		}
		set
		{
			wrappedViolationsField = value;
			RaisePropertyChanged("wrappedViolations");
		}
	}

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
	public bool coDriverRequired
	{
		get
		{
			return coDriverRequiredField;
		}
		set
		{
			coDriverRequiredField = value;
			RaisePropertyChanged("coDriverRequired");
		}
	}

	[XmlAttribute]
	public int depotAvailabilityForDeliveries
	{
		get
		{
			return depotAvailabilityForDeliveriesField;
		}
		set
		{
			depotAvailabilityForDeliveriesField = value;
			RaisePropertyChanged("depotAvailabilityForDeliveries");
		}
	}

	[XmlIgnore]
	public bool depotAvailabilityForDeliveriesSpecified
	{
		get
		{
			return depotAvailabilityForDeliveriesFieldSpecified;
		}
		set
		{
			depotAvailabilityForDeliveriesFieldSpecified = value;
			RaisePropertyChanged("depotAvailabilityForDeliveriesSpecified");
		}
	}

	[XmlAttribute]
	public int depotAvailabilityForPickups
	{
		get
		{
			return depotAvailabilityForPickupsField;
		}
		set
		{
			depotAvailabilityForPickupsField = value;
			RaisePropertyChanged("depotAvailabilityForPickups");
		}
	}

	[XmlIgnore]
	public bool depotAvailabilityForPickupsSpecified
	{
		get
		{
			return depotAvailabilityForPickupsFieldSpecified;
		}
		set
		{
			depotAvailabilityForPickupsFieldSpecified = value;
			RaisePropertyChanged("depotAvailabilityForPickupsSpecified");
		}
	}

	[XmlAttribute]
	public int depotUnloadingPeriod
	{
		get
		{
			return depotUnloadingPeriodField;
		}
		set
		{
			depotUnloadingPeriodField = value;
			RaisePropertyChanged("depotUnloadingPeriod");
		}
	}

	[XmlAttribute]
	public int depotUploadingPeriod
	{
		get
		{
			return depotUploadingPeriodField;
		}
		set
		{
			depotUploadingPeriodField = value;
			RaisePropertyChanged("depotUploadingPeriod");
		}
	}

	[XmlAttribute]
	public int distance
	{
		get
		{
			return distanceField;
		}
		set
		{
			distanceField = value;
			RaisePropertyChanged("distance");
		}
	}

	[XmlAttribute]
	public int distanceFromFirstToLastTransportPoint
	{
		get
		{
			return distanceFromFirstToLastTransportPointField;
		}
		set
		{
			distanceFromFirstToLastTransportPointField = value;
			RaisePropertyChanged("distanceFromFirstToLastTransportPoint");
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
	public int maxDistanceBetweenTransportPoints
	{
		get
		{
			return maxDistanceBetweenTransportPointsField;
		}
		set
		{
			maxDistanceBetweenTransportPointsField = value;
			RaisePropertyChanged("maxDistanceBetweenTransportPoints");
		}
	}

	[XmlAttribute]
	public int period
	{
		get
		{
			return periodField;
		}
		set
		{
			periodField = value;
			RaisePropertyChanged("period");
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
	public int restPeriod
	{
		get
		{
			return restPeriodField;
		}
		set
		{
			restPeriodField = value;
			RaisePropertyChanged("restPeriod");
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
	public int startTime
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

	[XmlAttribute]
	public int startTimeLatest
	{
		get
		{
			return startTimeLatestField;
		}
		set
		{
			startTimeLatestField = value;
			RaisePropertyChanged("startTimeLatest");
		}
	}

	[XmlAttribute]
	public bool tourChanged
	{
		get
		{
			return tourChangedField;
		}
		set
		{
			tourChangedField = value;
			RaisePropertyChanged("tourChanged");
		}
	}

	[XmlAttribute]
	public int transportPointCount
	{
		get
		{
			return transportPointCountField;
		}
		set
		{
			transportPointCountField = value;
			RaisePropertyChanged("transportPointCount");
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
