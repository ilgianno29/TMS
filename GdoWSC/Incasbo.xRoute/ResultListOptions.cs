using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class ResultListOptions : TransientVO
{
	private CENEmissionConfiguration cenEmissionConfigurationField;

	private DetailDescriptionOption destDetailField;

	private EmissionType emissionsField;

	private HBEFAType hbefaTypeField;

	private DetailDescriptionOption startDetailField;

	private bool binaryPathDescField;

	private int boundingRectanglesCField;

	private int boundingRectanglesOffsetField;

	private bool brunnelManoeuvresField;

	private DetailLevel detailLevelField;

	private bool dynamicInfoField;

	private bool extSegmentsField;

	private bool extSegmentsFieldSpecified;

	private bool featureDescriptionsField;

	private bool featureDescriptionsFieldSpecified;

	private bool manoeuvreAttributesField;

	private double manoeuvreGroupRatioField;

	private bool manoeuvreGroupRatioFieldSpecified;

	private bool manoeuvreGroupsField;

	private bool manoeuvresField;

	private bool nodesField;

	private bool polygonField;

	private bool polygonElevationsField;

	private bool polygonElevationsFieldSpecified;

	private bool segmentAttributeNamedTollField;

	private bool segmentAttributeNamedTollFieldSpecified;

	private bool segmentAttributePiggybackField;

	private bool segmentAttributePiggybackFieldSpecified;

	private bool segmentAttributesField;

	private bool segmentsField;

	private bool speedLimitsField;

	private bool speedLimitsFieldSpecified;

	private bool textsField;

	private bool tollManoeuvresField;

	private bool totalRectangleField;

	private bool urbanManoeuvresField;

	private bool utcOffsetsField;

	private bool utcOffsetsFieldSpecified;

	[XmlElement(IsNullable = true, Order = 0)]
	public CENEmissionConfiguration cenEmissionConfiguration
	{
		get
		{
			return cenEmissionConfigurationField;
		}
		set
		{
			cenEmissionConfigurationField = value;
			RaisePropertyChanged("cenEmissionConfiguration");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public DetailDescriptionOption destDetail
	{
		get
		{
			return destDetailField;
		}
		set
		{
			destDetailField = value;
			RaisePropertyChanged("destDetail");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public EmissionType emissions
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

	[XmlElement(IsNullable = true, Order = 3)]
	public HBEFAType hbefaType
	{
		get
		{
			return hbefaTypeField;
		}
		set
		{
			hbefaTypeField = value;
			RaisePropertyChanged("hbefaType");
		}
	}

	[XmlElement(IsNullable = true, Order = 4)]
	public DetailDescriptionOption startDetail
	{
		get
		{
			return startDetailField;
		}
		set
		{
			startDetailField = value;
			RaisePropertyChanged("startDetail");
		}
	}

	[XmlAttribute]
	public bool binaryPathDesc
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
	public int boundingRectanglesC
	{
		get
		{
			return boundingRectanglesCField;
		}
		set
		{
			boundingRectanglesCField = value;
			RaisePropertyChanged("boundingRectanglesC");
		}
	}

	[XmlAttribute]
	public int boundingRectanglesOffset
	{
		get
		{
			return boundingRectanglesOffsetField;
		}
		set
		{
			boundingRectanglesOffsetField = value;
			RaisePropertyChanged("boundingRectanglesOffset");
		}
	}

	[XmlAttribute]
	public bool brunnelManoeuvres
	{
		get
		{
			return brunnelManoeuvresField;
		}
		set
		{
			brunnelManoeuvresField = value;
			RaisePropertyChanged("brunnelManoeuvres");
		}
	}

	[XmlAttribute]
	public DetailLevel detailLevel
	{
		get
		{
			return detailLevelField;
		}
		set
		{
			detailLevelField = value;
			RaisePropertyChanged("detailLevel");
		}
	}

	[XmlAttribute]
	public bool dynamicInfo
	{
		get
		{
			return dynamicInfoField;
		}
		set
		{
			dynamicInfoField = value;
			RaisePropertyChanged("dynamicInfo");
		}
	}

	[XmlAttribute]
	public bool extSegments
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

	[XmlIgnore]
	public bool extSegmentsSpecified
	{
		get
		{
			return extSegmentsFieldSpecified;
		}
		set
		{
			extSegmentsFieldSpecified = value;
			RaisePropertyChanged("extSegmentsSpecified");
		}
	}

	[XmlAttribute]
	public bool featureDescriptions
	{
		get
		{
			return featureDescriptionsField;
		}
		set
		{
			featureDescriptionsField = value;
			RaisePropertyChanged("featureDescriptions");
		}
	}

	[XmlIgnore]
	public bool featureDescriptionsSpecified
	{
		get
		{
			return featureDescriptionsFieldSpecified;
		}
		set
		{
			featureDescriptionsFieldSpecified = value;
			RaisePropertyChanged("featureDescriptionsSpecified");
		}
	}

	[XmlAttribute]
	public bool manoeuvreAttributes
	{
		get
		{
			return manoeuvreAttributesField;
		}
		set
		{
			manoeuvreAttributesField = value;
			RaisePropertyChanged("manoeuvreAttributes");
		}
	}

	[XmlAttribute]
	public double manoeuvreGroupRatio
	{
		get
		{
			return manoeuvreGroupRatioField;
		}
		set
		{
			manoeuvreGroupRatioField = value;
			RaisePropertyChanged("manoeuvreGroupRatio");
		}
	}

	[XmlIgnore]
	public bool manoeuvreGroupRatioSpecified
	{
		get
		{
			return manoeuvreGroupRatioFieldSpecified;
		}
		set
		{
			manoeuvreGroupRatioFieldSpecified = value;
			RaisePropertyChanged("manoeuvreGroupRatioSpecified");
		}
	}

	[XmlAttribute]
	public bool manoeuvreGroups
	{
		get
		{
			return manoeuvreGroupsField;
		}
		set
		{
			manoeuvreGroupsField = value;
			RaisePropertyChanged("manoeuvreGroups");
		}
	}

	[XmlAttribute]
	public bool manoeuvres
	{
		get
		{
			return manoeuvresField;
		}
		set
		{
			manoeuvresField = value;
			RaisePropertyChanged("manoeuvres");
		}
	}

	[XmlAttribute]
	public bool nodes
	{
		get
		{
			return nodesField;
		}
		set
		{
			nodesField = value;
			RaisePropertyChanged("nodes");
		}
	}

	[XmlAttribute]
	public bool polygon
	{
		get
		{
			return polygonField;
		}
		set
		{
			polygonField = value;
			RaisePropertyChanged("polygon");
		}
	}

	[XmlAttribute]
	public bool polygonElevations
	{
		get
		{
			return polygonElevationsField;
		}
		set
		{
			polygonElevationsField = value;
			RaisePropertyChanged("polygonElevations");
		}
	}

	[XmlIgnore]
	public bool polygonElevationsSpecified
	{
		get
		{
			return polygonElevationsFieldSpecified;
		}
		set
		{
			polygonElevationsFieldSpecified = value;
			RaisePropertyChanged("polygonElevationsSpecified");
		}
	}

	[XmlAttribute]
	public bool segmentAttributeNamedToll
	{
		get
		{
			return segmentAttributeNamedTollField;
		}
		set
		{
			segmentAttributeNamedTollField = value;
			RaisePropertyChanged("segmentAttributeNamedToll");
		}
	}

	[XmlIgnore]
	public bool segmentAttributeNamedTollSpecified
	{
		get
		{
			return segmentAttributeNamedTollFieldSpecified;
		}
		set
		{
			segmentAttributeNamedTollFieldSpecified = value;
			RaisePropertyChanged("segmentAttributeNamedTollSpecified");
		}
	}

	[XmlAttribute]
	public bool segmentAttributePiggyback
	{
		get
		{
			return segmentAttributePiggybackField;
		}
		set
		{
			segmentAttributePiggybackField = value;
			RaisePropertyChanged("segmentAttributePiggyback");
		}
	}

	[XmlIgnore]
	public bool segmentAttributePiggybackSpecified
	{
		get
		{
			return segmentAttributePiggybackFieldSpecified;
		}
		set
		{
			segmentAttributePiggybackFieldSpecified = value;
			RaisePropertyChanged("segmentAttributePiggybackSpecified");
		}
	}

	[XmlAttribute]
	public bool segmentAttributes
	{
		get
		{
			return segmentAttributesField;
		}
		set
		{
			segmentAttributesField = value;
			RaisePropertyChanged("segmentAttributes");
		}
	}

	[XmlAttribute]
	public bool segments
	{
		get
		{
			return segmentsField;
		}
		set
		{
			segmentsField = value;
			RaisePropertyChanged("segments");
		}
	}

	[XmlAttribute]
	public bool speedLimits
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

	[XmlIgnore]
	public bool speedLimitsSpecified
	{
		get
		{
			return speedLimitsFieldSpecified;
		}
		set
		{
			speedLimitsFieldSpecified = value;
			RaisePropertyChanged("speedLimitsSpecified");
		}
	}

	[XmlAttribute]
	public bool texts
	{
		get
		{
			return textsField;
		}
		set
		{
			textsField = value;
			RaisePropertyChanged("texts");
		}
	}

	[XmlAttribute]
	public bool tollManoeuvres
	{
		get
		{
			return tollManoeuvresField;
		}
		set
		{
			tollManoeuvresField = value;
			RaisePropertyChanged("tollManoeuvres");
		}
	}

	[XmlAttribute]
	public bool totalRectangle
	{
		get
		{
			return totalRectangleField;
		}
		set
		{
			totalRectangleField = value;
			RaisePropertyChanged("totalRectangle");
		}
	}

	[XmlAttribute]
	public bool urbanManoeuvres
	{
		get
		{
			return urbanManoeuvresField;
		}
		set
		{
			urbanManoeuvresField = value;
			RaisePropertyChanged("urbanManoeuvres");
		}
	}

	[XmlAttribute]
	public bool utcOffsets
	{
		get
		{
			return utcOffsetsField;
		}
		set
		{
			utcOffsetsField = value;
			RaisePropertyChanged("utcOffsets");
		}
	}

	[XmlIgnore]
	public bool utcOffsetsSpecified
	{
		get
		{
			return utcOffsetsFieldSpecified;
		}
		set
		{
			utcOffsetsFieldSpecified = value;
			RaisePropertyChanged("utcOffsetsSpecified");
		}
	}
}
