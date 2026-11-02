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
public class ExceptionPath : TransientVO
{
	private LineString intersectingLineField;

	private UniqueGeoID[] wrappedNodesField;

	private LineString polylineField;

	private int absTimeMalusField;

	private bool absTimeMalusFieldSpecified;

	private string binaryPathDescField;

	private string extSegmentsField;

	private int relMalusField;

	private string streetField;

	[XmlElement(IsNullable = true, Order = 0)]
	public LineString intersectingLine
	{
		get
		{
			return intersectingLineField;
		}
		set
		{
			intersectingLineField = value;
			RaisePropertyChanged("intersectingLine");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
	public UniqueGeoID[] wrappedNodes
	{
		get
		{
			return wrappedNodesField;
		}
		set
		{
			wrappedNodesField = value;
			RaisePropertyChanged("wrappedNodes");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public LineString polyline
	{
		get
		{
			return polylineField;
		}
		set
		{
			polylineField = value;
			RaisePropertyChanged("polyline");
		}
	}

	[XmlAttribute]
	public int absTimeMalus
	{
		get
		{
			return absTimeMalusField;
		}
		set
		{
			absTimeMalusField = value;
			RaisePropertyChanged("absTimeMalus");
		}
	}

	[XmlIgnore]
	public bool absTimeMalusSpecified
	{
		get
		{
			return absTimeMalusFieldSpecified;
		}
		set
		{
			absTimeMalusFieldSpecified = value;
			RaisePropertyChanged("absTimeMalusSpecified");
		}
	}

	[XmlAttribute]
	public string binaryPathDesc
	{
		get
		{
			return binaryPathDescField;
		}
		set
		{
			binaryPathDescField = value;
			RaisePropertyChanged("binaryPathDesc");
		}
	}

	[XmlAttribute]
	public string extSegments
	{
		get
		{
			return extSegmentsField;
		}
		set
		{
			extSegmentsField = value;
			RaisePropertyChanged("extSegments");
		}
	}

	[XmlAttribute]
	public int relMalus
	{
		get
		{
			return relMalusField;
		}
		set
		{
			relMalusField = value;
			RaisePropertyChanged("relMalus");
		}
	}

	[XmlAttribute]
	public string street
	{
		get
		{
			return streetField;
		}
		set
		{
			streetField = value;
			RaisePropertyChanged("street");
		}
	}
}
