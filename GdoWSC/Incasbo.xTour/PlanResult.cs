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
public class PlanResult : TransientVO
{
	private int[] wrappedScheduledOrderIdsField;

	private int[] wrappedScheduledVehicleIdsField;

	private UnscheduledOrderAnalysisResult[] wrappedUnscheduledOrderAnalysisResultsField;

	private int[] wrappedUnscheduledOrderIdsField;

	private int[] wrappedUnscheduledVehicleIdsField;

	private double totalChainCostsField;

	private double totalTourCostsField;

	private int totalTourCountField;

	private int totalTourDistanceField;

	private int totalTourDrivingPeriodField;

	private int totalTourPeriodField;

	[XmlArray(IsNullable = true, Order = 0)]
	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	public int[] wrappedScheduledOrderIds
	{
		get
		{
			return wrappedScheduledOrderIdsField;
		}
		set
		{
			wrappedScheduledOrderIdsField = value;
			RaisePropertyChanged("wrappedScheduledOrderIds");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	public int[] wrappedScheduledVehicleIds
	{
		get
		{
			return wrappedScheduledVehicleIdsField;
		}
		set
		{
			wrappedScheduledVehicleIdsField = value;
			RaisePropertyChanged("wrappedScheduledVehicleIds");
		}
	}

	[XmlArray(IsNullable = true, Order = 2)]
	public UnscheduledOrderAnalysisResult[] wrappedUnscheduledOrderAnalysisResults
	{
		get
		{
			return wrappedUnscheduledOrderAnalysisResultsField;
		}
		set
		{
			wrappedUnscheduledOrderAnalysisResultsField = value;
			RaisePropertyChanged("wrappedUnscheduledOrderAnalysisResults");
		}
	}

	[XmlArray(IsNullable = true, Order = 3)]
	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	public int[] wrappedUnscheduledOrderIds
	{
		get
		{
			return wrappedUnscheduledOrderIdsField;
		}
		set
		{
			wrappedUnscheduledOrderIdsField = value;
			RaisePropertyChanged("wrappedUnscheduledOrderIds");
		}
	}

	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	[XmlArray(IsNullable = true, Order = 4)]
	public int[] wrappedUnscheduledVehicleIds
	{
		get
		{
			return wrappedUnscheduledVehicleIdsField;
		}
		set
		{
			wrappedUnscheduledVehicleIdsField = value;
			RaisePropertyChanged("wrappedUnscheduledVehicleIds");
		}
	}

	[XmlAttribute]
	public double totalChainCosts
	{
		get
		{
			return totalChainCostsField;
		}
		set
		{
			totalChainCostsField = value;
			RaisePropertyChanged("totalChainCosts");
		}
	}

	[XmlAttribute]
	public double totalTourCosts
	{
		get
		{
			return totalTourCostsField;
		}
		set
		{
			totalTourCostsField = value;
			RaisePropertyChanged("totalTourCosts");
		}
	}

	[XmlAttribute]
	public int totalTourCount
	{
		get
		{
			return totalTourCountField;
		}
		set
		{
			totalTourCountField = value;
			RaisePropertyChanged("totalTourCount");
		}
	}

	[XmlAttribute]
	public int totalTourDistance
	{
		get
		{
			return totalTourDistanceField;
		}
		set
		{
			totalTourDistanceField = value;
			RaisePropertyChanged("totalTourDistance");
		}
	}

	[XmlAttribute]
	public int totalTourDrivingPeriod
	{
		get
		{
			return totalTourDrivingPeriodField;
		}
		set
		{
			totalTourDrivingPeriodField = value;
			RaisePropertyChanged("totalTourDrivingPeriod");
		}
	}

	[XmlAttribute]
	public int totalTourPeriod
	{
		get
		{
			return totalTourPeriodField;
		}
		set
		{
			totalTourPeriodField = value;
			RaisePropertyChanged("totalTourPeriod");
		}
	}
}
