using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class KeyFigures : TransientVO
{
	private int costOfObjectiveFunctionField;

	private int numberOfInfeasibleOrdersField;

	private int numberOfScheduledOrdersField;

	private int numberOfScheduledVehiclesField;

	private int numberOfUnscheduledOrdersField;

	private int totalChainCostField;

	private int totalChainPeriodField;

	private int totalTourCostField;

	private int totalTourCountField;

	private int totalTourDistanceField;

	private int totalTourDrivingPeriodField;

	private int totalTourPeriodField;

	private int totalTourWaitingPeriodField;

	[XmlAttribute]
	public int costOfObjectiveFunction
	{
		get
		{
			return costOfObjectiveFunctionField;
		}
		set
		{
			costOfObjectiveFunctionField = value;
			RaisePropertyChanged("costOfObjectiveFunction");
		}
	}

	[XmlAttribute]
	public int numberOfInfeasibleOrders
	{
		get
		{
			return numberOfInfeasibleOrdersField;
		}
		set
		{
			numberOfInfeasibleOrdersField = value;
			RaisePropertyChanged("numberOfInfeasibleOrders");
		}
	}

	[XmlAttribute]
	public int numberOfScheduledOrders
	{
		get
		{
			return numberOfScheduledOrdersField;
		}
		set
		{
			numberOfScheduledOrdersField = value;
			RaisePropertyChanged("numberOfScheduledOrders");
		}
	}

	[XmlAttribute]
	public int numberOfScheduledVehicles
	{
		get
		{
			return numberOfScheduledVehiclesField;
		}
		set
		{
			numberOfScheduledVehiclesField = value;
			RaisePropertyChanged("numberOfScheduledVehicles");
		}
	}

	[XmlAttribute]
	public int numberOfUnscheduledOrders
	{
		get
		{
			return numberOfUnscheduledOrdersField;
		}
		set
		{
			numberOfUnscheduledOrdersField = value;
			RaisePropertyChanged("numberOfUnscheduledOrders");
		}
	}

	[XmlAttribute]
	public int totalChainCost
	{
		get
		{
			return totalChainCostField;
		}
		set
		{
			totalChainCostField = value;
			RaisePropertyChanged("totalChainCost");
		}
	}

	[XmlAttribute]
	public int totalChainPeriod
	{
		get
		{
			return totalChainPeriodField;
		}
		set
		{
			totalChainPeriodField = value;
			RaisePropertyChanged("totalChainPeriod");
		}
	}

	[XmlAttribute]
	public int totalTourCost
	{
		get
		{
			return totalTourCostField;
		}
		set
		{
			totalTourCostField = value;
			RaisePropertyChanged("totalTourCost");
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

	[XmlAttribute]
	public int totalTourWaitingPeriod
	{
		get
		{
			return totalTourWaitingPeriodField;
		}
		set
		{
			totalTourWaitingPeriodField = value;
			RaisePropertyChanged("totalTourWaitingPeriod");
		}
	}
}
