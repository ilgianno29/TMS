using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
public class PlainPolygon : PlainGeometryBase
{
	private PlainLinearRing[] wrappedLinearRingsField;

	[XmlArray(IsNullable = true, Order = 0)]
	public PlainLinearRing[] wrappedLinearRings
	{
		get
		{
			return wrappedLinearRingsField;
		}
		set
		{
			wrappedLinearRingsField = value;
			RaisePropertyChanged("wrappedLinearRings");
		}
	}
}
