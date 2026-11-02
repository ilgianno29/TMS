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
public class RouteManoeuvre : TransientVO
{
	private BrunnelManoeuvre brunnelManoeuvreField;

	private ManoeuvreAttributes manoeuvreAttrField;

	private UrbanManoeuvre urbanlManoeuvreField;

	private DetailLevel detailLevelField;

	private int dirInfoIdxField;

	private InfoNodeType dirInfoNodeTypeField;

	private int exitAngleField;

	private int exitAngleNorthField;

	private int exitNrField;

	private int locInfoIdxField;

	private InfoNodeType locInfoNodeTypeField;

	private string manoeuvreDescField;

	private int manoeuvreGroupIdxField;

	private ManoeuvreType manoeuvreTypeField;

	private int predSegmentIdxField;

	private int routeListSegmentIdxField;

	private int succSegmentIdxField;

	private TurnOrient turnOrientField;

	private TurnWeight turnWeightField;

	private int viaIdxField;

	[XmlElement(IsNullable = true, Order = 0)]
	public BrunnelManoeuvre brunnelManoeuvre
	{
		get
		{
			return brunnelManoeuvreField;
		}
		set
		{
			brunnelManoeuvreField = value;
			RaisePropertyChanged("brunnelManoeuvre");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public ManoeuvreAttributes manoeuvreAttr
	{
		get
		{
			return manoeuvreAttrField;
		}
		set
		{
			manoeuvreAttrField = value;
			RaisePropertyChanged("manoeuvreAttr");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public UrbanManoeuvre urbanlManoeuvre
	{
		get
		{
			return urbanlManoeuvreField;
		}
		set
		{
			urbanlManoeuvreField = value;
			RaisePropertyChanged("urbanlManoeuvre");
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
	public InfoNodeType dirInfoNodeType
	{
		get
		{
			return dirInfoNodeTypeField;
		}
		set
		{
			dirInfoNodeTypeField = value;
			RaisePropertyChanged("dirInfoNodeType");
		}
	}

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
	public int exitNr
	{
		get
		{
			return exitNrField;
		}
		set
		{
			exitNrField = value;
			RaisePropertyChanged("exitNr");
		}
	}

	[XmlAttribute]
	public int locInfoIdx
	{
		get
		{
			return locInfoIdxField;
		}
		set
		{
			locInfoIdxField = value;
			RaisePropertyChanged("locInfoIdx");
		}
	}

	[XmlAttribute]
	public InfoNodeType locInfoNodeType
	{
		get
		{
			return locInfoNodeTypeField;
		}
		set
		{
			locInfoNodeTypeField = value;
			RaisePropertyChanged("locInfoNodeType");
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
	public int manoeuvreGroupIdx
	{
		get
		{
			return manoeuvreGroupIdxField;
		}
		set
		{
			manoeuvreGroupIdxField = value;
			RaisePropertyChanged("manoeuvreGroupIdx");
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
	public int predSegmentIdx
	{
		get
		{
			return predSegmentIdxField;
		}
		set
		{
			predSegmentIdxField = value;
			RaisePropertyChanged("predSegmentIdx");
		}
	}

	[XmlAttribute]
	public int routeListSegmentIdx
	{
		get
		{
			return routeListSegmentIdxField;
		}
		set
		{
			routeListSegmentIdxField = value;
			RaisePropertyChanged("routeListSegmentIdx");
		}
	}

	[XmlAttribute]
	public int succSegmentIdx
	{
		get
		{
			return succSegmentIdxField;
		}
		set
		{
			succSegmentIdxField = value;
			RaisePropertyChanged("succSegmentIdx");
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

	[XmlAttribute]
	public int viaIdx
	{
		get
		{
			return viaIdxField;
		}
		set
		{
			viaIdxField = value;
			RaisePropertyChanged("viaIdx");
		}
	}
}
