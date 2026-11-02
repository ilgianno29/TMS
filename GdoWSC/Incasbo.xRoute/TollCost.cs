using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DebuggerStepThrough]
public class TollCost : TransientVO
{
	private int costField;

	private Currency currencyField;

	private string currencyISOCodeField;

	private string currencyNameField;

	private int iuCodeField;

	private TollType typeField;

	[XmlAttribute]
	public int cost
	{
		get
		{
			return costField;
		}
		set
		{
			costField = value;
			RaisePropertyChanged("cost");
		}
	}

	[XmlAttribute]
	public Currency currency
	{
		get
		{
			return currencyField;
		}
		set
		{
			currencyField = value;
			RaisePropertyChanged("currency");
		}
	}

	[XmlAttribute]
	public string currencyISOCode
	{
		get
		{
			return currencyISOCodeField;
		}
		set
		{
			currencyISOCodeField = value;
			RaisePropertyChanged("currencyISOCode");
		}
	}

	[XmlAttribute]
	public string currencyName
	{
		get
		{
			return currencyNameField;
		}
		set
		{
			currencyNameField = value;
			RaisePropertyChanged("currencyName");
		}
	}

	[XmlAttribute]
	public int iuCode
	{
		get
		{
			return iuCodeField;
		}
		set
		{
			iuCodeField = value;
			RaisePropertyChanged("iuCode");
		}
	}

	[XmlAttribute]
	public TollType type
	{
		get
		{
			return typeField;
		}
		set
		{
			typeField = value;
			RaisePropertyChanged("type");
		}
	}
}
