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
public class RouteInfo : TransientVO
{
	private CommuterTravelTrend[] wrappedTravelTrendField;

	private int costField;

	private int distanceField;

	private bool hasViolationsField;

	private bool hasViolationsFieldSpecified;

	private int timeField;

	[XmlArray(IsNullable = true, Order = 0)]
	public CommuterTravelTrend[] wrappedTravelTrend
	{
		get
		{
			return wrappedTravelTrendField;
		}
		set
		{
			wrappedTravelTrendField = value;
			RaisePropertyChanged("wrappedTravelTrend");
		}
	}

	[XmlAttribute]
	public int cost
	{
		get
		{
			return costField;
		}
		set
		{
			costField = value;
			RaisePropertyChanged("cost");
		}
	}

	[XmlAttribute]
	public int distance
	{
		get
		{
			return distanceField;
		}
		set
		{
			distanceField = value;
			RaisePropertyChanged("distance");
		}
	}

	[XmlAttribute]
	public bool hasViolations
	{
		get
		{
			return hasViolationsField;
		}
		set
		{
			hasViolationsField = value;
			RaisePropertyChanged("hasViolations");
		}
	}

	[XmlIgnore]
	public bool hasViolationsSpecified
	{
		get
		{
			return hasViolationsFieldSpecified;
		}
		set
		{
			hasViolationsFieldSpecified = value;
			RaisePropertyChanged("hasViolationsSpecified");
		}
	}

	[XmlAttribute]
	public int time
	{
		get
		{
			return timeField;
		}
		set
		{
			timeField = value;
			RaisePropertyChanged("time");
		}
	}
}
