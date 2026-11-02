using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(TransportDepot))]
[DesignerCategory("code")]
[DebuggerStepThrough]
[XmlInclude(typeof(TransportAB))]
public abstract class TransportOrder : AbstractTransportOrder
{
	private LoadingArea maxLoadingAreaField;

	private LoadingArea minLoadingAreaField;

	private int[] wrappedVehicleCategoriesField;

	private int[] wrappedVehicleExclusionsField;

	private int[] wrappedVehicleRequirementsField;

	private int areaNumberField;

	private bool areaNumberFieldSpecified;

	private bool trailerLoadingForbiddenField;

	private int vehicleIdField;

	private bool vehicleIdFieldSpecified;

	[XmlElement(IsNullable = true, Order = 0)]
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

	[XmlElement(IsNullable = true, Order = 1)]
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

	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	[XmlArray(IsNullable = true, Order = 2)]
	public int[] wrappedVehicleCategories
	{
		get
		{
			return wrappedVehicleCategoriesField;
		}
		set
		{
			wrappedVehicleCategoriesField = value;
			RaisePropertyChanged("wrappedVehicleCategories");
		}
	}

	[XmlArray(IsNullable = true, Order = 3)]
	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	public int[] wrappedVehicleExclusions
	{
		get
		{
			return wrappedVehicleExclusionsField;
		}
		set
		{
			wrappedVehicleExclusionsField = value;
			RaisePropertyChanged("wrappedVehicleExclusions");
		}
	}

	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	[XmlArray(IsNullable = true, Order = 4)]
	public int[] wrappedVehicleRequirements
	{
		get
		{
			return wrappedVehicleRequirementsField;
		}
		set
		{
			wrappedVehicleRequirementsField = value;
			RaisePropertyChanged("wrappedVehicleRequirements");
		}
	}

	[XmlAttribute]
	public int areaNumber
	{
		get
		{
			return areaNumberField;
		}
		set
		{
			areaNumberField = value;
			RaisePropertyChanged("areaNumber");
		}
	}

	[XmlIgnore]
	public bool areaNumberSpecified
	{
		get
		{
			return areaNumberFieldSpecified;
		}
		set
		{
			areaNumberFieldSpecified = value;
			RaisePropertyChanged("areaNumberSpecified");
		}
	}

	[XmlAttribute]
	public bool trailerLoadingForbidden
	{
		get
		{
			return trailerLoadingForbiddenField;
		}
		set
		{
			trailerLoadingForbiddenField = value;
			RaisePropertyChanged("trailerLoadingForbidden");
		}
	}

	[XmlAttribute]
	public int vehicleId
	{
		get
		{
			return vehicleIdField;
		}
		set
		{
			vehicleIdField = value;
			RaisePropertyChanged("vehicleId");
		}
	}

	[XmlIgnore]
	public bool vehicleIdSpecified
	{
		get
		{
			return vehicleIdFieldSpecified;
		}
		set
		{
			vehicleIdFieldSpecified = value;
			RaisePropertyChanged("vehicleIdSpecified");
		}
	}
}
