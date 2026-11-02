using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[Serializable]
[XmlInclude(typeof(ResultAddress))]
[XmlInclude(typeof(PoiResultAddress))]
[XmlInclude(typeof(PoiAddress))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xlocate.xserver.ptvag.com")]
public class Address : TransientVO
{
	private string cityField;

	private string city2Field;

	private string countryField;

	private string houseNumberField;

	private string postCodeField;

	private string stateField;

	private string streetField;

	[XmlAttribute]
	public string city
	{
		get
		{
			return cityField;
		}
		set
		{
			cityField = value;
			RaisePropertyChanged("city");
		}
	}

	[XmlAttribute]
	public string city2
	{
		get
		{
			return city2Field;
		}
		set
		{
			city2Field = value;
			RaisePropertyChanged("city2");
		}
	}

	[XmlAttribute]
	public string country
	{
		get
		{
			return countryField;
		}
		set
		{
			countryField = value;
			RaisePropertyChanged("country");
		}
	}

	[XmlAttribute]
	public string houseNumber
	{
		get
		{
			return houseNumberField;
		}
		set
		{
			houseNumberField = value;
			RaisePropertyChanged("houseNumber");
		}
	}

	[XmlAttribute]
	public string postCode
	{
		get
		{
			return postCodeField;
		}
		set
		{
			postCodeField = value;
			RaisePropertyChanged("postCode");
		}
	}

	[XmlAttribute]
	public string state
	{
		get
		{
			return stateField;
		}
		set
		{
			stateField = value;
			RaisePropertyChanged("state");
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
