using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
[XmlInclude(typeof(Vehicle))]
[XmlInclude(typeof(SequencingVehicle))]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public abstract class BaseVehicle : AbstractVehicle
{
	private Capacities capacitiesField;

	private VehicleCosts costsField;

	private DriverSettings driverSettingsField;

	private CoDriverStatus coDriverStatusField;

	private int departureTimeFixedField;

	private bool departureTimeFixedFieldSpecified;

	private int depotUnloadingFunctionIdField;

	private bool depotUnloadingFunctionIdFieldSpecified;

	private int depotUploadingFunctionIdField;

	private bool depotUploadingFunctionIdFieldSpecified;

	private int dimaIdField;

	private bool dimaIdFieldSpecified;

	private double drivingPeriodFactorField;

	private bool drivingPeriodFactorFieldSpecified;

	private bool ignoreTransportPointServicePeriodField;

	private bool isPreloadedField;

	private double servicePeriodFactorField;

	private bool servicePeriodFactorFieldSpecified;

	private bool toursMustFitIntoSingleOperatingIntervalField;

	private int transportPointUnloadingFunctionIdField;

	private bool transportPointUnloadingFunctionIdFieldSpecified;

	private int transportPointUploadingFunctionIdField;

	private bool transportPointUploadingFunctionIdFieldSpecified;

	[XmlElement(IsNullable = true, Order = 0)]
	public Capacities capacities
	{
		get
		{
			return capacitiesField;
		}
		set
		{
			capacitiesField = value;
			RaisePropertyChanged("capacities");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public VehicleCosts costs
	{
		get
		{
			return costsField;
		}
		set
		{
			costsField = value;
			RaisePropertyChanged("costs");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public DriverSettings driverSettings
	{
		get
		{
			return driverSettingsField;
		}
		set
		{
			driverSettingsField = value;
			RaisePropertyChanged("driverSettings");
		}
	}

	[XmlAttribute]
	public CoDriverStatus coDriverStatus
	{
		get
		{
			return coDriverStatusField;
		}
		set
		{
			coDriverStatusField = value;
			RaisePropertyChanged("coDriverStatus");
		}
	}

	[XmlAttribute]
	public int departureTimeFixed
	{
		get
		{
			return departureTimeFixedField;
		}
		set
		{
			departureTimeFixedField = value;
			RaisePropertyChanged("departureTimeFixed");
		}
	}

	[XmlIgnore]
	public bool departureTimeFixedSpecified
	{
		get
		{
			return departureTimeFixedFieldSpecified;
		}
		set
		{
			departureTimeFixedFieldSpecified = value;
			RaisePropertyChanged("departureTimeFixedSpecified");
		}
	}

	[XmlAttribute]
	public int depotUnloadingFunctionId
	{
		get
		{
			return depotUnloadingFunctionIdField;
		}
		set
		{
			depotUnloadingFunctionIdField = value;
			RaisePropertyChanged("depotUnloadingFunctionId");
		}
	}

	[XmlIgnore]
	public bool depotUnloadingFunctionIdSpecified
	{
		get
		{
			return depotUnloadingFunctionIdFieldSpecified;
		}
		set
		{
			depotUnloadingFunctionIdFieldSpecified = value;
			RaisePropertyChanged("depotUnloadingFunctionIdSpecified");
		}
	}

	[XmlAttribute]
	public int depotUploadingFunctionId
	{
		get
		{
			return depotUploadingFunctionIdField;
		}
		set
		{
			depotUploadingFunctionIdField = value;
			RaisePropertyChanged("depotUploadingFunctionId");
		}
	}

	[XmlIgnore]
	public bool depotUploadingFunctionIdSpecified
	{
		get
		{
			return depotUploadingFunctionIdFieldSpecified;
		}
		set
		{
			depotUploadingFunctionIdFieldSpecified = value;
			RaisePropertyChanged("depotUploadingFunctionIdSpecified");
		}
	}

	[XmlAttribute]
	public int dimaId
	{
		get
		{
			return dimaIdField;
		}
		set
		{
			dimaIdField = value;
			RaisePropertyChanged("dimaId");
		}
	}

	[XmlIgnore]
	public bool dimaIdSpecified
	{
		get
		{
			return dimaIdFieldSpecified;
		}
		set
		{
			dimaIdFieldSpecified = value;
			RaisePropertyChanged("dimaIdSpecified");
		}
	}

	[XmlAttribute]
	public double drivingPeriodFactor
	{
		get
		{
			return drivingPeriodFactorField;
		}
		set
		{
			drivingPeriodFactorField = value;
			RaisePropertyChanged("drivingPeriodFactor");
		}
	}

	[XmlIgnore]
	public bool drivingPeriodFactorSpecified
	{
		get
		{
			return drivingPeriodFactorFieldSpecified;
		}
		set
		{
			drivingPeriodFactorFieldSpecified = value;
			RaisePropertyChanged("drivingPeriodFactorSpecified");
		}
	}

	[XmlAttribute]
	public bool ignoreTransportPointServicePeriod
	{
		get
		{
			return ignoreTransportPointServicePeriodField;
		}
		set
		{
			ignoreTransportPointServicePeriodField = value;
			RaisePropertyChanged("ignoreTransportPointServicePeriod");
		}
	}

	[XmlAttribute]
	public bool isPreloaded
	{
		get
		{
			return isPreloadedField;
		}
		set
		{
			isPreloadedField = value;
			RaisePropertyChanged("isPreloaded");
		}
	}

	[XmlAttribute]
	public double servicePeriodFactor
	{
		get
		{
			return servicePeriodFactorField;
		}
		set
		{
			servicePeriodFactorField = value;
			RaisePropertyChanged("servicePeriodFactor");
		}
	}

	[XmlIgnore]
	public bool servicePeriodFactorSpecified
	{
		get
		{
			return servicePeriodFactorFieldSpecified;
		}
		set
		{
			servicePeriodFactorFieldSpecified = value;
			RaisePropertyChanged("servicePeriodFactorSpecified");
		}
	}

	[XmlAttribute]
	public bool toursMustFitIntoSingleOperatingInterval
	{
		get
		{
			return toursMustFitIntoSingleOperatingIntervalField;
		}
		set
		{
			toursMustFitIntoSingleOperatingIntervalField = value;
			RaisePropertyChanged("toursMustFitIntoSingleOperatingInterval");
		}
	}

	[XmlAttribute]
	public int transportPointUnloadingFunctionId
	{
		get
		{
			return transportPointUnloadingFunctionIdField;
		}
		set
		{
			transportPointUnloadingFunctionIdField = value;
			RaisePropertyChanged("transportPointUnloadingFunctionId");
		}
	}

	[XmlIgnore]
	public bool transportPointUnloadingFunctionIdSpecified
	{
		get
		{
			return transportPointUnloadingFunctionIdFieldSpecified;
		}
		set
		{
			transportPointUnloadingFunctionIdFieldSpecified = value;
			RaisePropertyChanged("transportPointUnloadingFunctionIdSpecified");
		}
	}

	[XmlAttribute]
	public int transportPointUploadingFunctionId
	{
		get
		{
			return transportPointUploadingFunctionIdField;
		}
		set
		{
			transportPointUploadingFunctionIdField = value;
			RaisePropertyChanged("transportPointUploadingFunctionId");
		}
	}

	[XmlIgnore]
	public bool transportPointUploadingFunctionIdSpecified
	{
		get
		{
			return transportPointUploadingFunctionIdFieldSpecified;
		}
		set
		{
			transportPointUploadingFunctionIdFieldSpecified = value;
			RaisePropertyChanged("transportPointUploadingFunctionIdSpecified");
		}
	}
}
