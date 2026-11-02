using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public class CountryInfo : TransientVO
{
	private RouteInfo partRouteInfoField;

	private RouteInfo[] wrappedPerNCRouteInfoField;

	private int[] wrappedPerTypeTollDistanceField;

	private int[] wrappedPerTypeTollPriceField;

	private TollCostInfo[] wrappedTollCostInfosField;

	private TollTotals tollTotalsField;

	private string additionalInfoField;

	private double costsPercentageToPassOnField;

	private bool costsPercentageToPassOnFieldSpecified;

	private string countryCodeField;

	private Currency currencyField;

	private string currencyISOCodeField;

	private string currencyNameField;

	private int iuCodeField;

	private int scenarioIdField;

	private bool scenarioIdFieldSpecified;

	private string tollNameField;

	[XmlElement(IsNullable = true, Order = 0)]
	public RouteInfo partRouteInfo
	{
		get
		{
			return partRouteInfoField;
		}
		set
		{
			partRouteInfoField = value;
			RaisePropertyChanged("partRouteInfo");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
	public RouteInfo[] wrappedPerNCRouteInfo
	{
		get
		{
			return wrappedPerNCRouteInfoField;
		}
		set
		{
			wrappedPerNCRouteInfoField = value;
			RaisePropertyChanged("wrappedPerNCRouteInfo");
		}
	}

	[XmlArray(IsNullable = true, Order = 2)]
	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	public int[] wrappedPerTypeTollDistance
	{
		get
		{
			return wrappedPerTypeTollDistanceField;
		}
		set
		{
			wrappedPerTypeTollDistanceField = value;
			RaisePropertyChanged("wrappedPerTypeTollDistance");
		}
	}

	[XmlArray(IsNullable = true, Order = 3)]
	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	public int[] wrappedPerTypeTollPrice
	{
		get
		{
			return wrappedPerTypeTollPriceField;
		}
		set
		{
			wrappedPerTypeTollPriceField = value;
			RaisePropertyChanged("wrappedPerTypeTollPrice");
		}
	}

	[XmlArray(IsNullable = true, Order = 4)]
	public TollCostInfo[] wrappedTollCostInfos
	{
		get
		{
			return wrappedTollCostInfosField;
		}
		set
		{
			wrappedTollCostInfosField = value;
			RaisePropertyChanged("wrappedTollCostInfos");
		}
	}

	[XmlElement(IsNullable = true, Order = 5)]
	public TollTotals tollTotals
	{
		get
		{
			return tollTotalsField;
		}
		set
		{
			tollTotalsField = value;
			RaisePropertyChanged("tollTotals");
		}
	}

	[XmlAttribute]
	public string additionalInfo
	{
		get
		{
			return additionalInfoField;
		}
		set
		{
			additionalInfoField = value;
			RaisePropertyChanged("additionalInfo");
		}
	}

	[XmlAttribute]
	public double costsPercentageToPassOn
	{
		get
		{
			return costsPercentageToPassOnField;
		}
		set
		{
			costsPercentageToPassOnField = value;
			RaisePropertyChanged("costsPercentageToPassOn");
		}
	}

	[XmlIgnore]
	public bool costsPercentageToPassOnSpecified
	{
		get
		{
			return costsPercentageToPassOnFieldSpecified;
		}
		set
		{
			costsPercentageToPassOnFieldSpecified = value;
			RaisePropertyChanged("costsPercentageToPassOnSpecified");
		}
	}

	[XmlAttribute]
	public string countryCode
	{
		get
		{
			return countryCodeField;
		}
		set
		{
			countryCodeField = value;
			RaisePropertyChanged("countryCode");
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
	public int scenarioId
	{
		get
		{
			return scenarioIdField;
		}
		set
		{
			scenarioIdField = value;
			RaisePropertyChanged("scenarioId");
		}
	}

	[XmlIgnore]
	public bool scenarioIdSpecified
	{
		get
		{
			return scenarioIdFieldSpecified;
		}
		set
		{
			scenarioIdFieldSpecified = value;
			RaisePropertyChanged("scenarioIdSpecified");
		}
	}

	[XmlAttribute]
	public string tollName
	{
		get
		{
			return tollNameField;
		}
		set
		{
			tollNameField = value;
			RaisePropertyChanged("tollName");
		}
	}
}
