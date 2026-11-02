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
public class Station : BaseBeanViaggio
{
	private string avisField;

	private string cityField;

	private string commentField;

	private string company_nameField;

	private string countryField;

	private string fromField;

	private string nameField;

	private string streetField;

	private string untilField;

	private string zipField;

	[XmlElement(IsNullable = true)]
	public string avis
	{
		get
		{
			return avisField;
		}
		set
		{
			avisField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string city
	{
		get
		{
			return cityField;
		}
		set
		{
			cityField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string comment
	{
		get
		{
			return commentField;
		}
		set
		{
			commentField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string company_name
	{
		get
		{
			return company_nameField;
		}
		set
		{
			company_nameField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string country
	{
		get
		{
			return countryField;
		}
		set
		{
			countryField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string from
	{
		get
		{
			return fromField;
		}
		set
		{
			fromField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string name
	{
		get
		{
			return nameField;
		}
		set
		{
			nameField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string street
	{
		get
		{
			return streetField;
		}
		set
		{
			streetField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string until
	{
		get
		{
			return untilField;
		}
		set
		{
			untilField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string zip
	{
		get
		{
			return zipField;
		}
		set
		{
			zipField = value;
		}
	}
}
