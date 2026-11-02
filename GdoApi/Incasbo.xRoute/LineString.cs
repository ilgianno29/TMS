using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
public class LineString : EncodedGeometry
{
	private PlainLineString lineStringField;

	[XmlElement(IsNullable = true, Order = 0)]
	public PlainLineString lineString
	{
		get
		{
			return lineStringField;
		}
		set
		{
			lineStringField = value;
			RaisePropertyChanged("lineString");
		}
	}
}
