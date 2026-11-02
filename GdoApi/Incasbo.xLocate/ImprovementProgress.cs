using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
public class ImprovementProgress : TransientVO
{
	private KeyFigures bestPlanField;

	private KeyFigures currentPlanField;

	private KeyFigures initialPlanField;

	private int availableMachineTimeField;

	private int iterationIndexField;

	private int numberOfImprovementsField;

	private int usedMachineTimeField;

	[XmlElement(IsNullable = true, Order = 0)]
	public KeyFigures bestPlan
	{
		get
		{
			return bestPlanField;
		}
		set
		{
			bestPlanField = value;
			RaisePropertyChanged("bestPlan");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public KeyFigures currentPlan
	{
		get
		{
			return currentPlanField;
		}
		set
		{
			currentPlanField = value;
			RaisePropertyChanged("currentPlan");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public KeyFigures initialPlan
	{
		get
		{
			return initialPlanField;
		}
		set
		{
			initialPlanField = value;
			RaisePropertyChanged("initialPlan");
		}
	}

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

	[XmlAttribute]
	public int iterationIndex
	{
		get
		{
			return iterationIndexField;
		}
		set
		{
			iterationIndexField = value;
			RaisePropertyChanged("iterationIndex");
		}
	}

	[XmlAttribute]
	public int numberOfImprovements
	{
		get
		{
			return numberOfImprovementsField;
		}
		set
		{
			numberOfImprovementsField = value;
			RaisePropertyChanged("numberOfImprovements");
		}
	}

	[XmlAttribute]
	public int usedMachineTime
	{
		get
		{
			return usedMachineTimeField;
		}
		set
		{
			usedMachineTimeField = value;
			RaisePropertyChanged("usedMachineTime");
		}
	}
}
