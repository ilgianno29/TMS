using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DebuggerStepThrough]
public class SegmentAttributes : TransientVO
{
	private string additionalInfoField;

	private string additionalREField;

	private BrunnelCode brunnelCodeField;

	private bool hasExtraTollField;

	private bool hasNamedTollField;

	private bool hasNamedTollFieldSpecified;

	private bool hasSeparatorField;

	private bool hasTollCarField;

	private bool hasTollTruckField;

	private bool hasVignetteCarField;

	private bool hasVignetteTruckField;

	private bool isBlockedCarField;

	private bool isBlockedTruckField;

	private bool isFerryField;

	private bool isPedestrianZoneField;

	private bool isPiggybackField;

	private bool isPiggybackFieldSpecified;

	private string lowEmissionZoneTypeField;

	[XmlAttribute]
	public string additionalInfo
	{
		get
		{
			return additionalInfoField;
		}
		set
		{
			additionalInfoField = value;
			RaisePropertyChanged("additionalInfo");
		}
	}

	[XmlAttribute]
	public string additionalRE
	{
		get
		{
			return additionalREField;
		}
		set
		{
			additionalREField = value;
			RaisePropertyChanged("additionalRE");
		}
	}

	[XmlAttribute]
	public BrunnelCode brunnelCode
	{
		get
		{
			return brunnelCodeField;
		}
		set
		{
			brunnelCodeField = value;
			RaisePropertyChanged("brunnelCode");
		}
	}

	[XmlAttribute]
	public bool hasExtraToll
	{
		get
		{
			return hasExtraTollField;
		}
		set
		{
			hasExtraTollField = value;
			RaisePropertyChanged("hasExtraToll");
		}
	}

	[XmlAttribute]
	public bool hasNamedToll
	{
		get
		{
			return hasNamedTollField;
		}
		set
		{
			hasNamedTollField = value;
			RaisePropertyChanged("hasNamedToll");
		}
	}

	[XmlIgnore]
	public bool hasNamedTollSpecified
	{
		get
		{
			return hasNamedTollFieldSpecified;
		}
		set
		{
			hasNamedTollFieldSpecified = value;
			RaisePropertyChanged("hasNamedTollSpecified");
		}
	}

	[XmlAttribute]
	public bool hasSeparator
	{
		get
		{
			return hasSeparatorField;
		}
		set
		{
			hasSeparatorField = value;
			RaisePropertyChanged("hasSeparator");
		}
	}

	[XmlAttribute]
	public bool hasTollCar
	{
		get
		{
			return hasTollCarField;
		}
		set
		{
			hasTollCarField = value;
			RaisePropertyChanged("hasTollCar");
		}
	}

	[XmlAttribute]
	public bool hasTollTruck
	{
		get
		{
			return hasTollTruckField;
		}
		set
		{
			hasTollTruckField = value;
			RaisePropertyChanged("hasTollTruck");
		}
	}

	[XmlAttribute]
	public bool hasVignetteCar
	{
		get
		{
			return hasVignetteCarField;
		}
		set
		{
			hasVignetteCarField = value;
			RaisePropertyChanged("hasVignetteCar");
		}
	}

	[XmlAttribute]
	public bool hasVignetteTruck
	{
		get
		{
			return hasVignetteTruckField;
		}
		set
		{
			hasVignetteTruckField = value;
			RaisePropertyChanged("hasVignetteTruck");
		}
	}

	[XmlAttribute]
	public bool isBlockedCar
	{
		get
		{
			return isBlockedCarField;
		}
		set
		{
			isBlockedCarField = value;
			RaisePropertyChanged("isBlockedCar");
		}
	}

	[XmlAttribute]
	public bool isBlockedTruck
	{
		get
		{
			return isBlockedTruckField;
		}
		set
		{
			isBlockedTruckField = value;
			RaisePropertyChanged("isBlockedTruck");
		}
	}

	[XmlAttribute]
	public bool isFerry
	{
		get
		{
			return isFerryField;
		}
		set
		{
			isFerryField = value;
			RaisePropertyChanged("isFerry");
		}
	}

	[XmlAttribute]
	public bool isPedestrianZone
	{
		get
		{
			return isPedestrianZoneField;
		}
		set
		{
			isPedestrianZoneField = value;
			RaisePropertyChanged("isPedestrianZone");
		}
	}

	[XmlAttribute]
	public bool isPiggyback
	{
		get
		{
			return isPiggybackField;
		}
		set
		{
			isPiggybackField = value;
			RaisePropertyChanged("isPiggyback");
		}
	}

	[XmlIgnore]
	public bool isPiggybackSpecified
	{
		get
		{
			return isPiggybackFieldSpecified;
		}
		set
		{
			isPiggybackFieldSpecified = value;
			RaisePropertyChanged("isPiggybackSpecified");
		}
	}

	[XmlAttribute]
	public string lowEmissionZoneType
	{
		get
		{
			return lowEmissionZoneTypeField;
		}
		set
		{
			lowEmissionZoneTypeField = value;
			RaisePropertyChanged("lowEmissionZoneType");
		}
	}
}
