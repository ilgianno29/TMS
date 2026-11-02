using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
public class SequencingTransportDepot : SequencingTransportOrder
{
	private Quantities deliveryQuantitiesField;

	private Quantities pickupQuantitiesField;

	private TransportPoint transportPointField;

	private int depotAvailabilityForDeliveriesField;

	private bool depotAvailabilityForDeliveriesFieldSpecified;

	private int depotAvailabilityForPickupsField;

	private bool depotAvailabilityForPickupsFieldSpecified;

	private int maxTransportPeriodForDeliveriesField;

	private bool maxTransportPeriodForDeliveriesFieldSpecified;

	private int maxTransportPeriodForPickupsField;

	private bool maxTransportPeriodForPickupsFieldSpecified;

	[XmlElement(IsNullable = true, Order = 0)]
	public Quantities deliveryQuantities
	{
		get
		{
			return deliveryQuantitiesField;
		}
		set
		{
			deliveryQuantitiesField = value;
			RaisePropertyChanged("deliveryQuantities");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public Quantities pickupQuantities
	{
		get
		{
			return pickupQuantitiesField;
		}
		set
		{
			pickupQuantitiesField = value;
			RaisePropertyChanged("pickupQuantities");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public TransportPoint transportPoint
	{
		get
		{
			return transportPointField;
		}
		set
		{
			transportPointField = value;
			RaisePropertyChanged("transportPoint");
		}
	}

	[XmlAttribute]
	public int depotAvailabilityForDeliveries
	{
		get
		{
			return depotAvailabilityForDeliveriesField;
		}
		set
		{
			depotAvailabilityForDeliveriesField = value;
			RaisePropertyChanged("depotAvailabilityForDeliveries");
		}
	}

	[XmlIgnore]
	public bool depotAvailabilityForDeliveriesSpecified
	{
		get
		{
			return depotAvailabilityForDeliveriesFieldSpecified;
		}
		set
		{
			depotAvailabilityForDeliveriesFieldSpecified = value;
			RaisePropertyChanged("depotAvailabilityForDeliveriesSpecified");
		}
	}

	[XmlAttribute]
	public int depotAvailabilityForPickups
	{
		get
		{
			return depotAvailabilityForPickupsField;
		}
		set
		{
			depotAvailabilityForPickupsField = value;
			RaisePropertyChanged("depotAvailabilityForPickups");
		}
	}

	[XmlIgnore]
	public bool depotAvailabilityForPickupsSpecified
	{
		get
		{
			return depotAvailabilityForPickupsFieldSpecified;
		}
		set
		{
			depotAvailabilityForPickupsFieldSpecified = value;
			RaisePropertyChanged("depotAvailabilityForPickupsSpecified");
		}
	}

	[XmlAttribute]
	public int maxTransportPeriodForDeliveries
	{
		get
		{
			return maxTransportPeriodForDeliveriesField;
		}
		set
		{
			maxTransportPeriodForDeliveriesField = value;
			RaisePropertyChanged("maxTransportPeriodForDeliveries");
		}
	}

	[XmlIgnore]
	public bool maxTransportPeriodForDeliveriesSpecified
	{
		get
		{
			return maxTransportPeriodForDeliveriesFieldSpecified;
		}
		set
		{
			maxTransportPeriodForDeliveriesFieldSpecified = value;
			RaisePropertyChanged("maxTransportPeriodForDeliveriesSpecified");
		}
	}

	[XmlAttribute]
	public int maxTransportPeriodForPickups
	{
		get
		{
			return maxTransportPeriodForPickupsField;
		}
		set
		{
			maxTransportPeriodForPickupsField = value;
			RaisePropertyChanged("maxTransportPeriodForPickups");
		}
	}

	[XmlIgnore]
	public bool maxTransportPeriodForPickupsSpecified
	{
		get
		{
			return maxTransportPeriodForPickupsFieldSpecified;
		}
		set
		{
			maxTransportPeriodForPickupsFieldSpecified = value;
			RaisePropertyChanged("maxTransportPeriodForPickupsSpecified");
		}
	}
}
