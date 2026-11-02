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
public class PlanProgress : JobProgress
{
	private DistanceMatrixCalculationProgress distanceMatrixCalculationProgressField;

	private ImprovementProgress improvementProgressField;

	private string actionField;

	[XmlElement(IsNullable = true, Order = 0)]
	public DistanceMatrixCalculationProgress distanceMatrixCalculationProgress
	{
		get
		{
			return distanceMatrixCalculationProgressField;
		}
		set
		{
			distanceMatrixCalculationProgressField = value;
			RaisePropertyChanged("distanceMatrixCalculationProgress");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public ImprovementProgress improvementProgress
	{
		get
		{
			return improvementProgressField;
		}
		set
		{
			improvementProgressField = value;
			RaisePropertyChanged("improvementProgress");
		}
	}

	[XmlAttribute]
	public string action
	{
		get
		{
			return actionField;
		}
		set
		{
			actionField = value;
			RaisePropertyChanged("action");
		}
	}
}
