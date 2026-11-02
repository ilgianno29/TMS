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
public class ClusterProgress : JobProgress
{
	private DistanceMatrixProgress distanceMatrixProgressField;

	private OptimizationProgress optimizationProgressField;

	private string actionField;

	[XmlElement(IsNullable = true, Order = 0)]
	public DistanceMatrixProgress distanceMatrixProgress
	{
		get
		{
			return distanceMatrixProgressField;
		}
		set
		{
			distanceMatrixProgressField = value;
			RaisePropertyChanged("distanceMatrixProgress");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public OptimizationProgress optimizationProgress
	{
		get
		{
			return optimizationProgressField;
		}
		set
		{
			optimizationProgressField = value;
			RaisePropertyChanged("optimizationProgress");
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
