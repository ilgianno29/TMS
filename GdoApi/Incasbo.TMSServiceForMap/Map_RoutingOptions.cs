using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.TMSServiceForMap;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "Map_RoutingOptions", Namespace = "http://schemas.datacontract.org/2004/07/Incasbo")]
public class Map_RoutingOptions : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private int? Avoid_FerriesField;

	[OptionalField]
	private int? Avoid_HighwaysField;

	[OptionalField]
	private int? Avoid_Low_Emission_ZonesField;

	[OptionalField]
	private int? Avoid_RampsField;

	[OptionalField]
	private int? Avoid_Residents_OnlyField;

	[OptionalField]
	private int? Avoid_TollRoadsField;

	[OptionalField]
	private int? Avoid_Urban_AreasField;

	[OptionalField]
	private int? Avoid_VignetteRoadsField;

	[OptionalField]
	private int? MaximumDistanceToSegmentField;

	[OptionalField]
	private int? OptimizationField;

	[OptionalField]
	private string Route_LanguageField;

	[OptionalField]
	private string Speed_ProfileField;

	[OptionalField]
	private int? TempoCaricoScaricoField;

	[Browsable(false)]
	public ExtensionDataObject ExtensionData
	{
		get
		{
			return extensionDataField;
		}
		set
		{
			extensionDataField = value;
		}
	}

	[DataMember]
	public int? Avoid_Ferries
	{
		get
		{
			return Avoid_FerriesField;
		}
		set
		{
			if (!Avoid_FerriesField.Equals(value))
			{
				Avoid_FerriesField = value;
				RaisePropertyChanged("Avoid_Ferries");
			}
		}
	}

	[DataMember]
	public int? Avoid_Highways
	{
		get
		{
			return Avoid_HighwaysField;
		}
		set
		{
			if (!Avoid_HighwaysField.Equals(value))
			{
				Avoid_HighwaysField = value;
				RaisePropertyChanged("Avoid_Highways");
			}
		}
	}

	[DataMember]
	public int? Avoid_Low_Emission_Zones
	{
		get
		{
			return Avoid_Low_Emission_ZonesField;
		}
		set
		{
			if (!Avoid_Low_Emission_ZonesField.Equals(value))
			{
				Avoid_Low_Emission_ZonesField = value;
				RaisePropertyChanged("Avoid_Low_Emission_Zones");
			}
		}
	}

	[DataMember]
	public int? Avoid_Ramps
	{
		get
		{
			return Avoid_RampsField;
		}
		set
		{
			if (!Avoid_RampsField.Equals(value))
			{
				Avoid_RampsField = value;
				RaisePropertyChanged("Avoid_Ramps");
			}
		}
	}

	[DataMember]
	public int? Avoid_Residents_Only
	{
		get
		{
			return Avoid_Residents_OnlyField;
		}
		set
		{
			if (!Avoid_Residents_OnlyField.Equals(value))
			{
				Avoid_Residents_OnlyField = value;
				RaisePropertyChanged("Avoid_Residents_Only");
			}
		}
	}

	[DataMember]
	public int? Avoid_TollRoads
	{
		get
		{
			return Avoid_TollRoadsField;
		}
		set
		{
			if (!Avoid_TollRoadsField.Equals(value))
			{
				Avoid_TollRoadsField = value;
				RaisePropertyChanged("Avoid_TollRoads");
			}
		}
	}

	[DataMember]
	public int? Avoid_Urban_Areas
	{
		get
		{
			return Avoid_Urban_AreasField;
		}
		set
		{
			if (!Avoid_Urban_AreasField.Equals(value))
			{
				Avoid_Urban_AreasField = value;
				RaisePropertyChanged("Avoid_Urban_Areas");
			}
		}
	}

	[DataMember]
	public int? Avoid_VignetteRoads
	{
		get
		{
			return Avoid_VignetteRoadsField;
		}
		set
		{
			if (!Avoid_VignetteRoadsField.Equals(value))
			{
				Avoid_VignetteRoadsField = value;
				RaisePropertyChanged("Avoid_VignetteRoads");
			}
		}
	}

	[DataMember]
	public int? MaximumDistanceToSegment
	{
		get
		{
			return MaximumDistanceToSegmentField;
		}
		set
		{
			if (!MaximumDistanceToSegmentField.Equals(value))
			{
				MaximumDistanceToSegmentField = value;
				RaisePropertyChanged("MaximumDistanceToSegment");
			}
		}
	}

	[DataMember]
	public int? Optimization
	{
		get
		{
			return OptimizationField;
		}
		set
		{
			if (!OptimizationField.Equals(value))
			{
				OptimizationField = value;
				RaisePropertyChanged("Optimization");
			}
		}
	}

	[DataMember]
	public string Route_Language
	{
		get
		{
			return Route_LanguageField;
		}
		set
		{
			if (!object.ReferenceEquals(Route_LanguageField, value))
			{
				Route_LanguageField = value;
				RaisePropertyChanged("Route_Language");
			}
		}
	}

	[DataMember]
	public string Speed_Profile
	{
		get
		{
			return Speed_ProfileField;
		}
		set
		{
			if (!object.ReferenceEquals(Speed_ProfileField, value))
			{
				Speed_ProfileField = value;
				RaisePropertyChanged("Speed_Profile");
			}
		}
	}

	[DataMember]
	public int? TempoCaricoScarico
	{
		get
		{
			return TempoCaricoScaricoField;
		}
		set
		{
			if (!TempoCaricoScaricoField.Equals(value))
			{
				TempoCaricoScaricoField = value;
				RaisePropertyChanged("TempoCaricoScarico");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
