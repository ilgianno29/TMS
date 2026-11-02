using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class IsochroneSegment : TransientVO
{
	private UniqueGeoID[] wrappedSegmentIDField;

	private bool directionField;

	private int distOnSgmField;

	private int kumulDistField;

	private int kumulTimeField;

	private int timeOnSgmField;

	[XmlArray(IsNullable = true, Order = 0)]
	public UniqueGeoID[] wrappedSegmentID
	{
		get
		{
			return wrappedSegmentIDField;
		}
		set
		{
			wrappedSegmentIDField = value;
			RaisePropertyChanged("wrappedSegmentID");
		}
	}

	[XmlAttribute]
	public bool direction
	{
		get
		{
			return directionField;
		}
		set
		{
			directionField = value;
			RaisePropertyChanged("direction");
		}
	}

	[XmlAttribute]
	public int distOnSgm
	{
		get
		{
			return distOnSgmField;
		}
		set
		{
			distOnSgmField = value;
			RaisePropertyChanged("distOnSgm");
		}
	}

	[XmlAttribute]
	public int kumulDist
	{
		get
		{
			return kumulDistField;
		}
		set
		{
			kumulDistField = value;
			RaisePropertyChanged("kumulDist");
		}
	}

	[XmlAttribute]
	public int kumulTime
	{
		get
		{
			return kumulTimeField;
		}
		set
		{
			kumulTimeField = value;
			RaisePropertyChanged("kumulTime");
		}
	}

	[XmlAttribute]
	public int timeOnSgm
	{
		get
		{
			return timeOnSgmField;
		}
		set
		{
			timeOnSgmField = value;
			RaisePropertyChanged("timeOnSgm");
		}
	}
}
