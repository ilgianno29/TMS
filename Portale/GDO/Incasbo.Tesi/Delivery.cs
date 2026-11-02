using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.Tesi;

[Serializable]
[GeneratedCode("System.Xml", "4.8.9221.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://beans.inbound.webservices.cfc.lucart/xsd")]
public class Delivery : BaseBeanViaggio
{
	private Station loading_stationField;

	private string numberField;

	private Parameters parametersField;

	private string scheduling_unitField;

	private string storageposition_countField;

	private Station unloading_stationField;

	private string vehicleField;

	private string volumeField;

	private string volume_unitField;

	private string weightField;

	private string weight_unitField;

	[XmlElement(IsNullable = true)]
	public Station loading_station
	{
		get
		{
			return loading_stationField;
		}
		set
		{
			loading_stationField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string number
	{
		get
		{
			return numberField;
		}
		set
		{
			numberField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public Parameters parameters
	{
		get
		{
			return parametersField;
		}
		set
		{
			parametersField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string scheduling_unit
	{
		get
		{
			return scheduling_unitField;
		}
		set
		{
			scheduling_unitField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string storageposition_count
	{
		get
		{
			return storageposition_countField;
		}
		set
		{
			storageposition_countField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public Station unloading_station
	{
		get
		{
			return unloading_stationField;
		}
		set
		{
			unloading_stationField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string vehicle
	{
		get
		{
			return vehicleField;
		}
		set
		{
			vehicleField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string volume
	{
		get
		{
			return volumeField;
		}
		set
		{
			volumeField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string volume_unit
	{
		get
		{
			return volume_unitField;
		}
		set
		{
			volume_unitField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string weight
	{
		get
		{
			return weightField;
		}
		set
		{
			weightField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string weight_unit
	{
		get
		{
			return weight_unitField;
		}
		set
		{
			weight_unitField = value;
		}
	}
}
