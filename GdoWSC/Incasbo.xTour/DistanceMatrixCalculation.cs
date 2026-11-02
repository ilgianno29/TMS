using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DesignerCategory("code")]
[XmlInclude(typeof(DistanceMatrixByReference))]
[XmlInclude(typeof(DistanceMatrixByRoad))]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
public abstract class DistanceMatrixCalculation : TransientVO
{
	private int dimaIdField;

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
}
