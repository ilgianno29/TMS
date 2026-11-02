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
public class ExtWayPoint : WayPoint
{
	private int exitAngleField;

	private int exitAngleNorthField;

	private int linkingDistanceField;

	private int linkingRouteListSegmentIdxField;

	private int linkingTimeField;

	private string manoeuvreDescField;

	private ManoeuvreType manoeuvreTypeField;

	private TurnOrient turnOrientField;

	private TurnWeight turnWeightField;

	[XmlAttribute]
	public int exitAngle
	{
		get
		{
			return exitAngleField;
		}
		set
		{
			exitAngleField = value;
			RaisePropertyChanged("exitAngle");
		}
	}

	[XmlAttribute]
	public int exitAngleNorth
	{
		get
		{
			return exitAngleNorthField;
		}
		set
		{
			exitAngleNorthField = value;
			RaisePropertyChanged("exitAngleNorth");
		}
	}

	[XmlAttribute]
	public int linkingDistance
	{
		get
		{
			return linkingDistanceField;
		}
		set
		{
			linkingDistanceField = value;
			RaisePropertyChanged("linkingDistance");
		}
	}

	[XmlAttribute]
	public int linkingRouteListSegmentIdx
	{
		get
		{
			return linkingRouteListSegmentIdxField;
		}
		set
		{
			linkingRouteListSegmentIdxField = value;
			RaisePropertyChanged("linkingRouteListSegmentIdx");
		}
	}

	[XmlAttribute]
	public int linkingTime
	{
		get
		{
			return linkingTimeField;
		}
		set
		{
			linkingTimeField = value;
			RaisePropertyChanged("linkingTime");
		}
	}

	[XmlAttribute]
	public string manoeuvreDesc
	{
		get
		{
			return manoeuvreDescField;
		}
		set
		{
			manoeuvreDescField = value;
			RaisePropertyChanged("manoeuvreDesc");
		}
	}

	[XmlAttribute]
	public ManoeuvreType manoeuvreType
	{
		get
		{
			return manoeuvreTypeField;
		}
		set
		{
			manoeuvreTypeField = value;
			RaisePropertyChanged("manoeuvreType");
		}
	}

	[XmlAttribute]
	public TurnOrient turnOrient
	{
		get
		{
			return turnOrientField;
		}
		set
		{
			turnOrientField = value;
			RaisePropertyChanged("turnOrient");
		}
	}

	[XmlAttribute]
	public TurnWeight turnWeight
	{
		get
		{
			return turnWeightField;
		}
		set
		{
			turnWeightField = value;
			RaisePropertyChanged("turnWeight");
		}
	}
}
