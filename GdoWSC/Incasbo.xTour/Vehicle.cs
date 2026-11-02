using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class Vehicle : BaseVehicle
{
	private int[] wrappedAreaNumbersField;

	private Point endLocationField;

	private LoadingArea maxLoadingAreaField;

	private LoadingArea minLoadingAreaField;

	private VehicleRestrictions restrictionsField;

	private Point startLocationField;

	private int[] wrappedTransportEquipmentsField;

	private int categoryField;

	private bool categoryFieldSpecified;

	private string descriptionField;

	private int idField;

	private bool ignoreIntermediatePeriodBeforeFirstTourField;

	private int intermediatePeriodField;

	private bool intermediatePeriodFieldSpecified;

	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	[XmlArray(IsNullable = true, Order = 0)]
	public int[] wrappedAreaNumbers
	{
		get
		{
			return wrappedAreaNumbersField;
		}
		set
		{
			wrappedAreaNumbersField = value;
			RaisePropertyChanged("wrappedAreaNumbers");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public Point endLocation
	{
		get
		{
			return endLocationField;
		}
		set
		{
			endLocationField = value;
			RaisePropertyChanged("endLocation");
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

	[XmlElement(IsNullable = true, Order = 4)]
	public VehicleRestrictions restrictions
	{
		get
		{
			return restrictionsField;
		}
		set
		{
			restrictionsField = value;
			RaisePropertyChanged("restrictions");
		}
	}

	[XmlElement(IsNullable = true, Order = 5)]
	public Point startLocation
	{
		get
		{
			return startLocationField;
		}
		set
		{
			startLocationField = value;
			RaisePropertyChanged("startLocation");
		}
	}

	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	[XmlArray(IsNullable = true, Order = 6)]
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
	public bool ignoreIntermediatePeriodBeforeFirstTour
	{
		get
		{
			return ignoreIntermediatePeriodBeforeFirstTourField;
		}
		set
		{
			ignoreIntermediatePeriodBeforeFirstTourField = value;
			RaisePropertyChanged("ignoreIntermediatePeriodBeforeFirstTour");
		}
	}

	[XmlAttribute]
	public int intermediatePeriod
	{
		get
		{
			return intermediatePeriodField;
		}
		set
		{
			intermediatePeriodField = value;
			RaisePropertyChanged("intermediatePeriod");
		}
	}

	[XmlIgnore]
	public bool intermediatePeriodSpecified
	{
		get
		{
			return intermediatePeriodFieldSpecified;
		}
		set
		{
			intermediatePeriodFieldSpecified = value;
			RaisePropertyChanged("intermediatePeriodSpecified");
		}
	}
}
