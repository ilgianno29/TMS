using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
public class Point : EncodedGeometry
{
	private PlainPoint pointField;

	[XmlElement(IsNullable = true, Order = 0)]
	public PlainPoint point
	{
		get
		{
			return pointField;
		}
		set
		{
			pointField = value;
			RaisePropertyChanged("point");
		}
	}
}
