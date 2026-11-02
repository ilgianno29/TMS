using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlInclude(typeof(AdvancedTour))]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(Tour))]
[DebuggerStepThrough]
public class ExtendedRoute : TransientVO
{
	private CountryInfo[] wrappedCountryInfosField;

	private PartTollCosts[] wrappedPartTollCostsField;

	private Route routeField;

	[XmlArray(IsNullable = true, Order = 0)]
	public CountryInfo[] wrappedCountryInfos
	{
		get
		{
			return wrappedCountryInfosField;
		}
		set
		{
			wrappedCountryInfosField = value;
			RaisePropertyChanged("wrappedCountryInfos");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
	public PartTollCosts[] wrappedPartTollCosts
	{
		get
		{
			return wrappedPartTollCostsField;
		}
		set
		{
			wrappedPartTollCostsField = value;
			RaisePropertyChanged("wrappedPartTollCosts");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public Route route
	{
		get
		{
			return routeField;
		}
		set
		{
			routeField = value;
			RaisePropertyChanged("route");
		}
	}
}
