using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
public class TerritoryProgress : JobProgress
{
	private DistanceMatrixProgress distanceMatrixProgressField;

	private string actionField;

	private int optimizationProgressField;

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

	[XmlAttribute]
	public int optimizationProgress
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
}
