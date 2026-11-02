using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
[DesignerCategory("code")]
public class GeometryCollection : EncodedGeometry
{
	private PlainGeometryCollection geometryCollectionField;

	[XmlElement(IsNullable = true, Order = 0)]
	public PlainGeometryCollection geometryCollection
	{
		get
		{
			return geometryCollectionField;
		}
		set
		{
			geometryCollectionField = value;
			RaisePropertyChanged("geometryCollection");
		}
	}
}
