using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class TourRestrictions : TransientVO
{
	private int maxDistanceField;

	private bool maxDistanceFieldSpecified;

	private int maxDistanceBetweenTransportPointsField;

	private bool maxDistanceBetweenTransportPointsFieldSpecified;

	private int maxDistanceFromFirstToLastTransportPointField;

	private bool maxDistanceFromFirstToLastTransportPointFieldSpecified;

	private int maxDrivingPeriodField;

	private bool maxDrivingPeriodFieldSpecified;

	private int maxPeriodField;

	private bool maxPeriodFieldSpecified;

	[XmlAttribute]
	public int maxDistance
	{
		get
		{
			return maxDistanceField;
		}
		set
		{
			maxDistanceField = value;
			RaisePropertyChanged("maxDistance");
		}
	}

	[XmlIgnore]
	public bool maxDistanceSpecified
	{
		get
		{
			return maxDistanceFieldSpecified;
		}
		set
		{
			maxDistanceFieldSpecified = value;
			RaisePropertyChanged("maxDistanceSpecified");
		}
	}

	[XmlAttribute]
	public int maxDistanceBetweenTransportPoints
	{
		get
		{
			return maxDistanceBetweenTransportPointsField;
		}
		set
		{
			maxDistanceBetweenTransportPointsField = value;
			RaisePropertyChanged("maxDistanceBetweenTransportPoints");
		}
	}

	[XmlIgnore]
	public bool maxDistanceBetweenTransportPointsSpecified
	{
		get
		{
			return maxDistanceBetweenTransportPointsFieldSpecified;
		}
		set
		{
			maxDistanceBetweenTransportPointsFieldSpecified = value;
			RaisePropertyChanged("maxDistanceBetweenTransportPointsSpecified");
		}
	}

	[XmlAttribute]
	public int maxDistanceFromFirstToLastTransportPoint
	{
		get
		{
			return maxDistanceFromFirstToLastTransportPointField;
		}
		set
		{
			maxDistanceFromFirstToLastTransportPointField = value;
			RaisePropertyChanged("maxDistanceFromFirstToLastTransportPoint");
		}
	}

	[XmlIgnore]
	public bool maxDistanceFromFirstToLastTransportPointSpecified
	{
		get
		{
			return maxDistanceFromFirstToLastTransportPointFieldSpecified;
		}
		set
		{
			maxDistanceFromFirstToLastTransportPointFieldSpecified = value;
			RaisePropertyChanged("maxDistanceFromFirstToLastTransportPointSpecified");
		}
	}

	[XmlAttribute]
	public int maxDrivingPeriod
	{
		get
		{
			return maxDrivingPeriodField;
		}
		set
		{
			maxDrivingPeriodField = value;
			RaisePropertyChanged("maxDrivingPeriod");
		}
	}

	[XmlIgnore]
	public bool maxDrivingPeriodSpecified
	{
		get
		{
			return maxDrivingPeriodFieldSpecified;
		}
		set
		{
			maxDrivingPeriodFieldSpecified = value;
			RaisePropertyChanged("maxDrivingPeriodSpecified");
		}
	}

	[XmlAttribute]
	public int maxPeriod
	{
		get
		{
			return maxPeriodField;
		}
		set
		{
			maxPeriodField = value;
			RaisePropertyChanged("maxPeriod");
		}
	}

	[XmlIgnore]
	public bool maxPeriodSpecified
	{
		get
		{
			return maxPeriodFieldSpecified;
		}
		set
		{
			maxPeriodFieldSpecified = value;
			RaisePropertyChanged("maxPeriodSpecified");
		}
	}
}
