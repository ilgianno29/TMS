using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlInclude(typeof(TourPointDesc))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public class WaypointDesc : TransientVO
{
	private Point[] wrappedCoordsField;

	private UniqueGeoID nodeIDField;

	private RoutingOption[] wrappedRoutingOptionsField;

	private UniqueGeoID[] wrappedSegmentIDField;

	private VehicleOption[] wrappedVehicleOptionsField;

	private ViaType viaTypeField;

	private string combinedTransportIDField;

	private int fuzzyRadiusField;

	private int headingField;

	private bool headingFieldSpecified;

	private LinkType linkTypeField;

	private string streetField;

	[XmlArray(IsNullable = true, Order = 0)]
	[XmlArrayItem(Namespace = "http://common.xserver.ptvag.com")]
	public Point[] wrappedCoords
	{
		get
		{
			return wrappedCoordsField;
		}
		set
		{
			wrappedCoordsField = value;
			RaisePropertyChanged("wrappedCoords");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public UniqueGeoID nodeID
	{
		get
		{
			return nodeIDField;
		}
		set
		{
			nodeIDField = value;
			RaisePropertyChanged("nodeID");
		}
	}

	[XmlArray(IsNullable = true, Order = 2)]
	public RoutingOption[] wrappedRoutingOptions
	{
		get
		{
			return wrappedRoutingOptionsField;
		}
		set
		{
			wrappedRoutingOptionsField = value;
			RaisePropertyChanged("wrappedRoutingOptions");
		}
	}

	[XmlArray(IsNullable = true, Order = 3)]
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

	[XmlArray(IsNullable = true, Order = 4)]
	public VehicleOption[] wrappedVehicleOptions
	{
		get
		{
			return wrappedVehicleOptionsField;
		}
		set
		{
			wrappedVehicleOptionsField = value;
			RaisePropertyChanged("wrappedVehicleOptions");
		}
	}

	[XmlElement(IsNullable = true, Order = 5)]
	public ViaType viaType
	{
		get
		{
			return viaTypeField;
		}
		set
		{
			viaTypeField = value;
			RaisePropertyChanged("viaType");
		}
	}

	[XmlAttribute]
	public string combinedTransportID
	{
		get
		{
			return combinedTransportIDField;
		}
		set
		{
			combinedTransportIDField = value;
			RaisePropertyChanged("combinedTransportID");
		}
	}

	[XmlAttribute]
	public int fuzzyRadius
	{
		get
		{
			return fuzzyRadiusField;
		}
		set
		{
			fuzzyRadiusField = value;
			RaisePropertyChanged("fuzzyRadius");
		}
	}

	[XmlAttribute]
	public int heading
	{
		get
		{
			return headingField;
		}
		set
		{
			headingField = value;
			RaisePropertyChanged("heading");
		}
	}

	[XmlIgnore]
	public bool headingSpecified
	{
		get
		{
			return headingFieldSpecified;
		}
		set
		{
			headingFieldSpecified = value;
			RaisePropertyChanged("headingSpecified");
		}
	}

	[XmlAttribute]
	public LinkType linkType
	{
		get
		{
			return linkTypeField;
		}
		set
		{
			linkTypeField = value;
			RaisePropertyChanged("linkType");
		}
	}

	[XmlAttribute]
	public string street
	{
		get
		{
			return streetField;
		}
		set
		{
			streetField = value;
			RaisePropertyChanged("street");
		}
	}
}
