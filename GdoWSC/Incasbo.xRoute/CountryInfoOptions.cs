using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlInclude(typeof(CountryInfoVehicleOptions))]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
public class CountryInfoOptions : TransientVO
{
	private int[] wrappedReductionIDsField;

	private TollScenario[] wrappedTollScenariosField;

	private bool allEuroField;

	private bool calculatePartTollCostsField;

	private bool costsPercentageToPassOnField;

	private bool costsPercentageToPassOnFieldSpecified;

	private bool currencyDescriptionField;

	private bool currencyDescriptionFieldSpecified;

	private bool detailedTollCostsField;

	private bool namedTollField;

	private bool namedTollFieldSpecified;

	private DateTime tollDateField;

	private bool tollDateFieldSpecified;

	private bool tollTotalsField;

	private bool tollTotalsFieldSpecified;

	private bool waypointIndexInTollCostInfoField;

	private bool waypointIndexInTollCostInfoFieldSpecified;

	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	[XmlArray(IsNullable = true, Order = 0)]
	public int[] wrappedReductionIDs
	{
		get
		{
			return wrappedReductionIDsField;
		}
		set
		{
			wrappedReductionIDsField = value;
			RaisePropertyChanged("wrappedReductionIDs");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
	public TollScenario[] wrappedTollScenarios
	{
		get
		{
			return wrappedTollScenariosField;
		}
		set
		{
			wrappedTollScenariosField = value;
			RaisePropertyChanged("wrappedTollScenarios");
		}
	}

	[XmlAttribute]
	public bool allEuro
	{
		get
		{
			return allEuroField;
		}
		set
		{
			allEuroField = value;
			RaisePropertyChanged("allEuro");
		}
	}

	[XmlAttribute]
	public bool calculatePartTollCosts
	{
		get
		{
			return calculatePartTollCostsField;
		}
		set
		{
			calculatePartTollCostsField = value;
			RaisePropertyChanged("calculatePartTollCosts");
		}
	}

	[XmlAttribute]
	public bool costsPercentageToPassOn
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
	public bool currencyDescription
	{
		get
		{
			return currencyDescriptionField;
		}
		set
		{
			currencyDescriptionField = value;
			RaisePropertyChanged("currencyDescription");
		}
	}

	[XmlIgnore]
	public bool currencyDescriptionSpecified
	{
		get
		{
			return currencyDescriptionFieldSpecified;
		}
		set
		{
			currencyDescriptionFieldSpecified = value;
			RaisePropertyChanged("currencyDescriptionSpecified");
		}
	}

	[XmlAttribute]
	public bool detailedTollCosts
	{
		get
		{
			return detailedTollCostsField;
		}
		set
		{
			detailedTollCostsField = value;
			RaisePropertyChanged("detailedTollCosts");
		}
	}

	[XmlAttribute]
	public bool namedToll
	{
		get
		{
			return namedTollField;
		}
		set
		{
			namedTollField = value;
			RaisePropertyChanged("namedToll");
		}
	}

	[XmlIgnore]
	public bool namedTollSpecified
	{
		get
		{
			return namedTollFieldSpecified;
		}
		set
		{
			namedTollFieldSpecified = value;
			RaisePropertyChanged("namedTollSpecified");
		}
	}

	[XmlAttribute]
	public DateTime tollDate
	{
		get
		{
			return tollDateField;
		}
		set
		{
			tollDateField = value;
			RaisePropertyChanged("tollDate");
		}
	}

	[XmlIgnore]
	public bool tollDateSpecified
	{
		get
		{
			return tollDateFieldSpecified;
		}
		set
		{
			tollDateFieldSpecified = value;
			RaisePropertyChanged("tollDateSpecified");
		}
	}

	[XmlAttribute]
	public bool tollTotals
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

	[XmlIgnore]
	public bool tollTotalsSpecified
	{
		get
		{
			return tollTotalsFieldSpecified;
		}
		set
		{
			tollTotalsFieldSpecified = value;
			RaisePropertyChanged("tollTotalsSpecified");
		}
	}

	[XmlAttribute]
	public bool waypointIndexInTollCostInfo
	{
		get
		{
			return waypointIndexInTollCostInfoField;
		}
		set
		{
			waypointIndexInTollCostInfoField = value;
			RaisePropertyChanged("waypointIndexInTollCostInfo");
		}
	}

	[XmlIgnore]
	public bool waypointIndexInTollCostInfoSpecified
	{
		get
		{
			return waypointIndexInTollCostInfoFieldSpecified;
		}
		set
		{
			waypointIndexInTollCostInfoFieldSpecified = value;
			RaisePropertyChanged("waypointIndexInTollCostInfoSpecified");
		}
	}
}
