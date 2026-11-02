using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[XmlInclude(typeof(LineString))]
[XmlInclude(typeof(GeometryCollection))]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(LinearRing))]
[XmlInclude(typeof(Polygon))]
[XmlInclude(typeof(Point))]
[XmlInclude(typeof(MultiPoint))]
[XmlInclude(typeof(MultiLineString))]
[XmlInclude(typeof(MultiPolygon))]
public abstract class EncodedGeometry : EncodedGeometryBase
{
	private KML kmlField;

	private byte[] wkbField;

	private string wktField;

	[XmlElement(IsNullable = true, Order = 0)]
	public KML kml
	{
		get
		{
			return kmlField;
		}
		set
		{
			kmlField = value;
			RaisePropertyChanged("kml");
		}
	}

	[XmlAttribute(DataType = "base64Binary")]
	public byte[] wkb
	{
		get
		{
			return wkbField;
		}
		set
		{
			wkbField = value;
			RaisePropertyChanged("wkb");
		}
	}

	[XmlAttribute]
	public string wkt
	{
		get
		{
			return wktField;
		}
		set
		{
			wktField = value;
			RaisePropertyChanged("wkt");
		}
	}
}
