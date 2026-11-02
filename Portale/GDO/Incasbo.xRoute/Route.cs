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
public class Route : TransientVO
{
	private BoundingRectangle[] wrappedBoundingRectanglesField;

	private CENEmissionScenarios cenEmissionsField;

	private DynamicInfo dynamicInfoField;

	private Emissions emissionsField;

	private RouteInfo infoField;

	private ManoeuvreGroup[] wrappedManoeuvreGroupField;

	private RouteManoeuvre[] wrappedManoeuvresField;

	private UniqueGeoID[] wrappedNodesField;

	private LineString polygonField;

	private RouteListSegment[] wrappedSegmentsField;

	private WayPoint[] wrappedStationsField;

	private string[] wrappedTextsField;

	private BoundingRectangle totalRectangleField;

	private Emissions vehicleRelatedEmissionsField;

	private string binaryPathDescField;

	private string extSegmentsField;

	[XmlArray(IsNullable = true, Order = 0)]
	public BoundingRectangle[] wrappedBoundingRectangles
	{
		get
		{
			return wrappedBoundingRectanglesField;
		}
		set
		{
			wrappedBoundingRectanglesField = value;
			RaisePropertyChanged("wrappedBoundingRectangles");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
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

	[XmlElement(IsNullable = true, Order = 2)]
	public DynamicInfo dynamicInfo
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

	[XmlElement(IsNullable = true, Order = 3)]
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

	[XmlElement(IsNullable = true, Order = 4)]
	public RouteInfo info
	{
		get
		{
			return infoField;
		}
		set
		{
			infoField = value;
			RaisePropertyChanged("info");
		}
	}

	[XmlArray(IsNullable = true, Order = 5)]
	public ManoeuvreGroup[] wrappedManoeuvreGroup
	{
		get
		{
			return wrappedManoeuvreGroupField;
		}
		set
		{
			wrappedManoeuvreGroupField = value;
			RaisePropertyChanged("wrappedManoeuvreGroup");
		}
	}

	[XmlArray(IsNullable = true, Order = 6)]
	public RouteManoeuvre[] wrappedManoeuvres
	{
		get
		{
			return wrappedManoeuvresField;
		}
		set
		{
			wrappedManoeuvresField = value;
			RaisePropertyChanged("wrappedManoeuvres");
		}
	}

	[XmlArray(IsNullable = true, Order = 7)]
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

	[XmlElement(IsNullable = true, Order = 8)]
	public LineString polygon
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

	[XmlArray(IsNullable = true, Order = 9)]
	public RouteListSegment[] wrappedSegments
	{
		get
		{
			return wrappedSegmentsField;
		}
		set
		{
			wrappedSegmentsField = value;
			RaisePropertyChanged("wrappedSegments");
		}
	}

	[XmlArray(IsNullable = true, Order = 10)]
	public WayPoint[] wrappedStations
	{
		get
		{
			return wrappedStationsField;
		}
		set
		{
			wrappedStationsField = value;
			RaisePropertyChanged("wrappedStations");
		}
	}

	[XmlArray(IsNullable = true, Order = 11)]
	[XmlArrayItem("String", Namespace = "http://wrappertypes.service.jabba.ptvag.com")]
	public string[] wrappedTexts
	{
		get
		{
			return wrappedTextsField;
		}
		set
		{
			wrappedTextsField = value;
			RaisePropertyChanged("wrappedTexts");
		}
	}

	[XmlElement(IsNullable = true, Order = 12)]
	public BoundingRectangle totalRectangle
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

	[XmlElement(IsNullable = true, Order = 13)]
	public Emissions vehicleRelatedEmissions
	{
		get
		{
			return vehicleRelatedEmissionsField;
		}
		set
		{
			vehicleRelatedEmissionsField = value;
			RaisePropertyChanged("vehicleRelatedEmissions");
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
}
