using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
public class Train : TransientVO
{
	private Capacities capacitiesField;

	private Costs costsField;

	private LoadingArea maxLoadingAreaField;

	private LoadingArea minLoadingAreaField;

	private int[] wrappedTrailerIdsField;

	private int[] wrappedTransportEquipmentsField;

	private int[] wrappedVehicleIdsField;

	private int categoryField;

	private bool categoryFieldSpecified;

	private string descriptionField;

	private int dimaIdField;

	private bool dimaIdFieldSpecified;

	private double drivingPeriodFactorField;

	private bool drivingPeriodFactorFieldSpecified;

	private int idField;

	private int maxTransportPointCountPerTourField;

	private bool maxTransportPointCountPerTourFieldSpecified;

	[XmlElement(IsNullable = true, Order = 0)]
	public Capacities capacities
	{
		get
		{
			return capacitiesField;
		}
		set
		{
			capacitiesField = value;
			RaisePropertyChanged("capacities");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public Costs costs
	{
		get
		{
			return costsField;
		}
		set
		{
			costsField = value;
			RaisePropertyChanged("costs");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public LoadingArea maxLoadingArea
	{
		get
		{
			return maxLoadingAreaField;
		}
		set
		{
			maxLoadingAreaField = value;
			RaisePropertyChanged("maxLoadingArea");
		}
	}

	[XmlElement(IsNullable = true, Order = 3)]
	public LoadingArea minLoadingArea
	{
		get
		{
			return minLoadingAreaField;
		}
		set
		{
			minLoadingAreaField = value;
			RaisePropertyChanged("minLoadingArea");
		}
	}

	[XmlArray(IsNullable = true, Order = 4)]
	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	public int[] wrappedTrailerIds
	{
		get
		{
			return wrappedTrailerIdsField;
		}
		set
		{
			wrappedTrailerIdsField = value;
			RaisePropertyChanged("wrappedTrailerIds");
		}
	}

	[XmlArray(IsNullable = true, Order = 5)]
	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	public int[] wrappedTransportEquipments
	{
		get
		{
			return wrappedTransportEquipmentsField;
		}
		set
		{
			wrappedTransportEquipmentsField = value;
			RaisePropertyChanged("wrappedTransportEquipments");
		}
	}

	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	[XmlArray(IsNullable = true, Order = 6)]
	public int[] wrappedVehicleIds
	{
		get
		{
			return wrappedVehicleIdsField;
		}
		set
		{
			wrappedVehicleIdsField = value;
			RaisePropertyChanged("wrappedVehicleIds");
		}
	}

	[XmlAttribute]
	public int category
	{
		get
		{
			return categoryField;
		}
		set
		{
			categoryField = value;
			RaisePropertyChanged("category");
		}
	}

	[XmlIgnore]
	public bool categorySpecified
	{
		get
		{
			return categoryFieldSpecified;
		}
		set
		{
			categoryFieldSpecified = value;
			RaisePropertyChanged("categorySpecified");
		}
	}

	[XmlAttribute]
	public string description
	{
		get
		{
			return descriptionField;
		}
		set
		{
			descriptionField = value;
			RaisePropertyChanged("description");
		}
	}

	[XmlAttribute]
	public int dimaId
	{
		get
		{
			return dimaIdField;
		}
		set
		{
			dimaIdField = value;
			RaisePropertyChanged("dimaId");
		}
	}

	[XmlIgnore]
	public bool dimaIdSpecified
	{
		get
		{
			return dimaIdFieldSpecified;
		}
		set
		{
			dimaIdFieldSpecified = value;
			RaisePropertyChanged("dimaIdSpecified");
		}
	}

	[XmlAttribute]
	public double drivingPeriodFactor
	{
		get
		{
			return drivingPeriodFactorField;
		}
		set
		{
			drivingPeriodFactorField = value;
			RaisePropertyChanged("drivingPeriodFactor");
		}
	}

	[XmlIgnore]
	public bool drivingPeriodFactorSpecified
	{
		get
		{
			return drivingPeriodFactorFieldSpecified;
		}
		set
		{
			drivingPeriodFactorFieldSpecified = value;
			RaisePropertyChanged("drivingPeriodFactorSpecified");
		}
	}

	[XmlAttribute]
	public int id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
			RaisePropertyChanged("id");
		}
	}

	[XmlAttribute]
	public int maxTransportPointCountPerTour
	{
		get
		{
			return maxTransportPointCountPerTourField;
		}
		set
		{
			maxTransportPointCountPerTourField = value;
			RaisePropertyChanged("maxTransportPointCountPerTour");
		}
	}

	[XmlIgnore]
	public bool maxTransportPointCountPerTourSpecified
	{
		get
		{
			return maxTransportPointCountPerTourFieldSpecified;
		}
		set
		{
			maxTransportPointCountPerTourFieldSpecified = value;
			RaisePropertyChanged("maxTransportPointCountPerTourSpecified");
		}
	}
}
