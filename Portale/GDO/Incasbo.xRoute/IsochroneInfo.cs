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
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public class IsochroneInfo : TransientVO
{
	private IsochroneSegment isoSegmentsField;

	private LineString polysField;

	private int horizonField;

	[XmlElement(IsNullable = true, Order = 0)]
	public IsochroneSegment isoSegments
	{
		get
		{
			return isoSegmentsField;
		}
		set
		{
			isoSegmentsField = value;
			RaisePropertyChanged("isoSegments");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public LineString polys
	{
		get
		{
			return polysField;
		}
		set
		{
			polysField = value;
			RaisePropertyChanged("polys");
		}
	}

	[XmlAttribute]
	public int horizon
	{
		get
		{
			return horizonField;
		}
		set
		{
			horizonField = value;
			RaisePropertyChanged("horizon");
		}
	}
}
