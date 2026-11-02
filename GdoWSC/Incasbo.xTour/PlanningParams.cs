using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(FindVehiclesForTourParams))]
[XmlInclude(typeof(VehicleSchedulingParams))]
[XmlInclude(typeof(StandardParams))]
[XmlInclude(typeof(SequencingParams))]
[XmlInclude(typeof(CalculationParams))]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[XmlInclude(typeof(BalancingParams))]
[XmlInclude(typeof(AreaParams))]
[XmlInclude(typeof(AmendingParams))]
[XmlInclude(typeof(OvernightParams))]
[XmlInclude(typeof(FindToursForOrderParams))]
[XmlInclude(typeof(FindOrdersForTourParams))]
[XmlInclude(typeof(FindToursForVehicleParams))]
[XmlInclude(typeof(UnscheduledOrderAnalysisParams))]
public abstract class PlanningParams : TransientVO
{
	private DistanceMatrixCalculation[] wrappedDistanceMatrixCalculationField;

	private LoadingFunction[] wrappedLoadingFunctionsField;

	private ProductIncompatibility[] wrappedProductIncompatibilitiesField;

	private RegulationsBase[] wrappedRegulationsField;

	private Restrictions restrictionsField;

	private double coDriverTransportPointLoadingFactorField;

	private bool coDriverTransportPointLoadingFactorFieldSpecified;

	private bool coDriverTransportPointsInSeparateToursField;

	private double directDistanceFactorField;

	private bool directDistanceFactorFieldSpecified;

	private int directVelocityField;

	private bool directVelocityFieldSpecified;

	private bool useDirectDistanceFallbackField;

	[XmlArray(IsNullable = true, Order = 0)]
	public DistanceMatrixCalculation[] wrappedDistanceMatrixCalculation
	{
		get
		{
			return wrappedDistanceMatrixCalculationField;
		}
		set
		{
			wrappedDistanceMatrixCalculationField = value;
			RaisePropertyChanged("wrappedDistanceMatrixCalculation");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
	public LoadingFunction[] wrappedLoadingFunctions
	{
		get
		{
			return wrappedLoadingFunctionsField;
		}
		set
		{
			wrappedLoadingFunctionsField = value;
			RaisePropertyChanged("wrappedLoadingFunctions");
		}
	}

	[XmlArray(IsNullable = true, Order = 2)]
	public ProductIncompatibility[] wrappedProductIncompatibilities
	{
		get
		{
			return wrappedProductIncompatibilitiesField;
		}
		set
		{
			wrappedProductIncompatibilitiesField = value;
			RaisePropertyChanged("wrappedProductIncompatibilities");
		}
	}

	[XmlArray(IsNullable = true, Order = 3)]
	public RegulationsBase[] wrappedRegulations
	{
		get
		{
			return wrappedRegulationsField;
		}
		set
		{
			wrappedRegulationsField = value;
			RaisePropertyChanged("wrappedRegulations");
		}
	}

	[XmlElement(IsNullable = true, Order = 4)]
	public Restrictions restrictions
	{
		get
		{
			return restrictionsField;
		}
		set
		{
			restrictionsField = value;
			RaisePropertyChanged("restrictions");
		}
	}

	[XmlAttribute]
	public double coDriverTransportPointLoadingFactor
	{
		get
		{
			return coDriverTransportPointLoadingFactorField;
		}
		set
		{
			coDriverTransportPointLoadingFactorField = value;
			RaisePropertyChanged("coDriverTransportPointLoadingFactor");
		}
	}

	[XmlIgnore]
	public bool coDriverTransportPointLoadingFactorSpecified
	{
		get
		{
			return coDriverTransportPointLoadingFactorFieldSpecified;
		}
		set
		{
			coDriverTransportPointLoadingFactorFieldSpecified = value;
			RaisePropertyChanged("coDriverTransportPointLoadingFactorSpecified");
		}
	}

	[XmlAttribute]
	public bool coDriverTransportPointsInSeparateTours
	{
		get
		{
			return coDriverTransportPointsInSeparateToursField;
		}
		set
		{
			coDriverTransportPointsInSeparateToursField = value;
			RaisePropertyChanged("coDriverTransportPointsInSeparateTours");
		}
	}

	[XmlAttribute]
	public double directDistanceFactor
	{
		get
		{
			return directDistanceFactorField;
		}
		set
		{
			directDistanceFactorField = value;
			RaisePropertyChanged("directDistanceFactor");
		}
	}

	[XmlIgnore]
	public bool directDistanceFactorSpecified
	{
		get
		{
			return directDistanceFactorFieldSpecified;
		}
		set
		{
			directDistanceFactorFieldSpecified = value;
			RaisePropertyChanged("directDistanceFactorSpecified");
		}
	}

	[XmlAttribute]
	public int directVelocity
	{
		get
		{
			return directVelocityField;
		}
		set
		{
			directVelocityField = value;
			RaisePropertyChanged("directVelocity");
		}
	}

	[XmlIgnore]
	public bool directVelocitySpecified
	{
		get
		{
			return directVelocityFieldSpecified;
		}
		set
		{
			directVelocityFieldSpecified = value;
			RaisePropertyChanged("directVelocitySpecified");
		}
	}

	[XmlAttribute]
	public bool useDirectDistanceFallback
	{
		get
		{
			return useDirectDistanceFallbackField;
		}
		set
		{
			useDirectDistanceFallbackField = value;
			RaisePropertyChanged("useDirectDistanceFallback");
		}
	}
}
