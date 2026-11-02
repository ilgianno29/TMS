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
public class Transport : BaseBeanViaggio
{
	private string autistaField;

	private string carrier_creditor_numberField;

	private Deliveries deliveriesField;

	private string distanceField;

	private string distance_unitField;

	private string numberField;

	private Parameters parametersField;

	private string scheduling_unitField;

	private string statusField;

	private string storageposition_countField;

	private string targaField;

	private string transport_typeField;

	private string vehicleField;

	private string volumeField;

	private string volume_unitField;

	private string weightField;

	private string weight_unitField;

	[XmlElement(IsNullable = true)]
	public string autista
	{
		get
		{
			return autistaField;
		}
		set
		{
			autistaField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string carrier_creditor_number
	{
		get
		{
			return carrier_creditor_numberField;
		}
		set
		{
			carrier_creditor_numberField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public Deliveries deliveries
	{
		get
		{
			return deliveriesField;
		}
		set
		{
			deliveriesField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string distance
	{
		get
		{
			return distanceField;
		}
		set
		{
			distanceField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string distance_unit
	{
		get
		{
			return distance_unitField;
		}
		set
		{
			distance_unitField = value;
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
	public string status
	{
		get
		{
			return statusField;
		}
		set
		{
			statusField = value;
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
	public string targa
	{
		get
		{
			return targaField;
		}
		set
		{
			targaField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string transport_type
	{
		get
		{
			return transport_typeField;
		}
		set
		{
			transport_typeField = value;
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
