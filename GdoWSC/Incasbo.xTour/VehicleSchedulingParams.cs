using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
public class VehicleSchedulingParams : PlanningParams
{
	private int availableMachineTimeField;

	private bool availableMachineTimeFieldSpecified;

	private VehicleSchedulingGoal goalField;

	private bool optimizeSchedulingQualityField;

	private bool optimizeSchedulingQualityFieldSpecified;

	[XmlAttribute]
	public int availableMachineTime
	{
		get
		{
			return availableMachineTimeField;
		}
		set
		{
			availableMachineTimeField = value;
			RaisePropertyChanged("availableMachineTime");
		}
	}

	[XmlIgnore]
	public bool availableMachineTimeSpecified
	{
		get
		{
			return availableMachineTimeFieldSpecified;
		}
		set
		{
			availableMachineTimeFieldSpecified = value;
			RaisePropertyChanged("availableMachineTimeSpecified");
		}
	}

	[XmlAttribute]
	public VehicleSchedulingGoal goal
	{
		get
		{
			return goalField;
		}
		set
		{
			goalField = value;
			RaisePropertyChanged("goal");
		}
	}

	[XmlAttribute]
	public bool optimizeSchedulingQuality
	{
		get
		{
			return optimizeSchedulingQualityField;
		}
		set
		{
			optimizeSchedulingQualityField = value;
			RaisePropertyChanged("optimizeSchedulingQuality");
		}
	}

	[XmlIgnore]
	public bool optimizeSchedulingQualitySpecified
	{
		get
		{
			return optimizeSchedulingQualityFieldSpecified;
		}
		set
		{
			optimizeSchedulingQualityFieldSpecified = value;
			RaisePropertyChanged("optimizeSchedulingQualitySpecified");
		}
	}
}
