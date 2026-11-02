using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
[DesignerCategory("code")]
public class MultiPolygon : EncodedGeometry
{
	private PlainMultiPolygon multiPolygonField;

	[XmlElement(IsNullable = true, Order = 0)]
	public PlainMultiPolygon multiPolygon
	{
		get
		{
			return multiPolygonField;
		}
		set
		{
			multiPolygonField = value;
			RaisePropertyChanged("multiPolygon");
		}
	}
}
