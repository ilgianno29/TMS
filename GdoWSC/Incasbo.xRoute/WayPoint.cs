using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlInclude(typeof(ExtWayPoint))]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
public class WayPoint : TransientVO
{
	private CENEmissionScenarios cenEmissionsField;

	private Emissions emissionsField;

	private Point locationCoordField;

	private Point matchCoordField;

	private int accDistField;

	private int accTimeField;

	private string countryCodeField;

	private int iuCodeField;

	private int manoeuvreIdxField;

	private int nodeIdxField;

	private int polyIdxField;

	private int segmentIdxField;

	private int utcOffsetField;

	private bool utcOffsetFieldSpecified;

	private WayPointType wayPointTypeField;

	[XmlElement(IsNullable = true, Order = 0)]
	public CENEmissionScenarios cenEmissions
	{
		get
		{
			return cenEmissionsField;
		}
		set
		{
			cenEmissionsField = value;
			RaisePropertyChanged("cenEmissions");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public Emissions emissions
	{
		get
		{
			return emissionsField;
		}
		set
		{
			emissionsField = value;
			RaisePropertyChanged("emissions");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public Point locationCoord
	{
		get
		{
			return locationCoordField;
		}
		set
		{
			locationCoordField = value;
			RaisePropertyChanged("locationCoord");
		}
	}

	[XmlElement(IsNullable = true, Order = 3)]
	public Point matchCoord
	{
		get
		{
			return matchCoordField;
		}
		set
		{
			matchCoordField = value;
			RaisePropertyChanged("matchCoord");
		}
	}

	[XmlAttribute]
	public int accDist
	{
		get
		{
			return accDistField;
		}
		set
		{
			accDistField = value;
			RaisePropertyChanged("accDist");
		}
	}

	[XmlAttribute]
	public int accTime
	{
		get
		{
			return accTimeField;
		}
		set
		{
			accTimeField = value;
			RaisePropertyChanged("accTime");
		}
	}

	[XmlAttribute]
	public string countryCode
	{
		get
		{
			return countryCodeField;
		}
		set
		{
			countryCodeField = value;
			RaisePropertyChanged("countryCode");
		}
	}

	[XmlAttribute]
	public int iuCode
	{
		get
		{
			return iuCodeField;
		}
		set
		{
			iuCodeField = value;
			RaisePropertyChanged("iuCode");
		}
	}

	[XmlAttribute]
	public int manoeuvreIdx
	{
		get
		{
			return manoeuvreIdxField;
		}
		set
		{
			manoeuvreIdxField = value;
			RaisePropertyChanged("manoeuvreIdx");
		}
	}

	[XmlAttribute]
	public int nodeIdx
	{
		get
		{
			return nodeIdxField;
		}
		set
		{
			nodeIdxField = value;
			RaisePropertyChanged("nodeIdx");
		}
	}

	[XmlAttribute]
	public int polyIdx
	{
		get
		{
			return polyIdxField;
		}
		set
		{
			polyIdxField = value;
			RaisePropertyChanged("polyIdx");
		}
	}

	[XmlAttribute]
	public int segmentIdx
	{
		get
		{
			return segmentIdxField;
		}
		set
		{
			segmentIdxField = value;
			RaisePropertyChanged("segmentIdx");
		}
	}

	[XmlAttribute]
	public int utcOffset
	{
		get
		{
			return utcOffsetField;
		}
		set
		{
			utcOffsetField = value;
			RaisePropertyChanged("utcOffset");
		}
	}

	[XmlIgnore]
	public bool utcOffsetSpecified
	{
		get
		{
			return utcOffsetFieldSpecified;
		}
		set
		{
			utcOffsetFieldSpecified = value;
			RaisePropertyChanged("utcOffsetSpecified");
		}
	}

	[XmlAttribute]
	public WayPointType wayPointType
	{
		get
		{
			return wayPointTypeField;
		}
		set
		{
			wayPointTypeField = value;
			RaisePropertyChanged("wayPointType");
		}
	}
}
