using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
public class RouteListSegment : TransientVO
{
	private CENEmissionScenarios cenEmissionsField;

	private Emissions emissionsField;

	private FeatureDescription[] wrappedFeatureDescriptionsField;

	private NormSpeed normSpeedField;

	private SegmentAttributes segmentAttrField;

	private SpeedLimits speedLimitsField;

	private string[] wrappedViolationsField;

	private int accDistField;

	private int accTimeField;

	private string countryCodeField;

	private int dirInfoIdxField;

	private int firstNodeIdxField;

	private int firstPolyIdxField;

	private int iuCodeField;

	private NetworkClass ncField;

	private int nodeCField;

	private int polyCField;

	private int streetNameIdxField;

	private int streetNoIdxField;

	private int utcOffsetField;

	private bool utcOffsetFieldSpecified;

	private int vCalcField;

	private bool vCalcFieldSpecified;

	private int vNormField;

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

	[XmlArray(IsNullable = true, Order = 2)]
	public FeatureDescription[] wrappedFeatureDescriptions
	{
		get
		{
			return wrappedFeatureDescriptionsField;
		}
		set
		{
			wrappedFeatureDescriptionsField = value;
			RaisePropertyChanged("wrappedFeatureDescriptions");
		}
	}

	[XmlElement(IsNullable = true, Order = 3)]
	public NormSpeed normSpeed
	{
		get
		{
			return normSpeedField;
		}
		set
		{
			normSpeedField = value;
			RaisePropertyChanged("normSpeed");
		}
	}

	[XmlElement(IsNullable = true, Order = 4)]
	public SegmentAttributes segmentAttr
	{
		get
		{
			return segmentAttrField;
		}
		set
		{
			segmentAttrField = value;
			RaisePropertyChanged("segmentAttr");
		}
	}

	[XmlElement(IsNullable = true, Order = 5)]
	public SpeedLimits speedLimits
	{
		get
		{
			return speedLimitsField;
		}
		set
		{
			speedLimitsField = value;
			RaisePropertyChanged("speedLimits");
		}
	}

	[XmlArrayItem("String", Namespace = "http://wrappertypes.service.jabba.ptvag.com")]
	[XmlArray(IsNullable = true, Order = 6)]
	public string[] wrappedViolations
	{
		get
		{
			return wrappedViolationsField;
		}
		set
		{
			wrappedViolationsField = value;
			RaisePropertyChanged("wrappedViolations");
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
	public int dirInfoIdx
	{
		get
		{
			return dirInfoIdxField;
		}
		set
		{
			dirInfoIdxField = value;
			RaisePropertyChanged("dirInfoIdx");
		}
	}

	[XmlAttribute]
	public int firstNodeIdx
	{
		get
		{
			return firstNodeIdxField;
		}
		set
		{
			firstNodeIdxField = value;
			RaisePropertyChanged("firstNodeIdx");
		}
	}

	[XmlAttribute]
	public int firstPolyIdx
	{
		get
		{
			return firstPolyIdxField;
		}
		set
		{
			firstPolyIdxField = value;
			RaisePropertyChanged("firstPolyIdx");
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
	public NetworkClass nC
	{
		get
		{
			return ncField;
		}
		set
		{
			ncField = value;
			RaisePropertyChanged("nC");
		}
	}

	[XmlAttribute]
	public int nodeC
	{
		get
		{
			return nodeCField;
		}
		set
		{
			nodeCField = value;
			RaisePropertyChanged("nodeC");
		}
	}

	[XmlAttribute]
	public int polyC
	{
		get
		{
			return polyCField;
		}
		set
		{
			polyCField = value;
			RaisePropertyChanged("polyC");
		}
	}

	[XmlAttribute]
	public int streetNameIdx
	{
		get
		{
			return streetNameIdxField;
		}
		set
		{
			streetNameIdxField = value;
			RaisePropertyChanged("streetNameIdx");
		}
	}

	[XmlAttribute]
	public int streetNoIdx
	{
		get
		{
			return streetNoIdxField;
		}
		set
		{
			streetNoIdxField = value;
			RaisePropertyChanged("streetNoIdx");
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
	public int vCalc
	{
		get
		{
			return vCalcField;
		}
		set
		{
			vCalcField = value;
			RaisePropertyChanged("vCalc");
		}
	}

	[XmlIgnore]
	public bool vCalcSpecified
	{
		get
		{
			return vCalcFieldSpecified;
		}
		set
		{
			vCalcFieldSpecified = value;
			RaisePropertyChanged("vCalcSpecified");
		}
	}

	[XmlAttribute]
	public int vNorm
	{
		get
		{
			return vNormField;
		}
		set
		{
			vNormField = value;
			RaisePropertyChanged("vNorm");
		}
	}
}
