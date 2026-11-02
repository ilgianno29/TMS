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
public class DistanceMatrixCalculationProgress : TransientVO
{
	private DistanceMatrixProgress currentDistanceMatrixProgressField;

	private int currentDimaIndexField;

	private int dimaIdField;

	private int lastDimaIndexField;

	[XmlElement(IsNullable = true, Order = 0)]
	public DistanceMatrixProgress currentDistanceMatrixProgress
	{
		get
		{
			return currentDistanceMatrixProgressField;
		}
		set
		{
			currentDistanceMatrixProgressField = value;
			RaisePropertyChanged("currentDistanceMatrixProgress");
		}
	}

	[XmlAttribute]
	public int currentDimaIndex
	{
		get
		{
			return currentDimaIndexField;
		}
		set
		{
			currentDimaIndexField = value;
			RaisePropertyChanged("currentDimaIndex");
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

	[XmlAttribute]
	public int lastDimaIndex
	{
		get
		{
			return lastDimaIndexField;
		}
		set
		{
			lastDimaIndexField = value;
			RaisePropertyChanged("lastDimaIndex");
		}
	}
}
