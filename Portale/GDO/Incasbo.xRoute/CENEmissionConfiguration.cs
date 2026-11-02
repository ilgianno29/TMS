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
public class CENEmissionConfiguration : TransientVO
{
	private double actualFuelConsumptionForThisRouteField;

	private bool actualFuelConsumptionForThisRouteFieldSpecified;

	private CENVersion cenVersionField;

	private double fleetSpecificAverageFuelConsumptionField;

	private bool fleetSpecificAverageFuelConsumptionFieldSpecified;

	private double routeSpecificAverageFuelConsumptionField;

	private bool routeSpecificAverageFuelConsumptionFieldSpecified;

	[XmlAttribute]
	public double actualFuelConsumptionForThisRoute
	{
		get
		{
			return actualFuelConsumptionForThisRouteField;
		}
		set
		{
			actualFuelConsumptionForThisRouteField = value;
			RaisePropertyChanged("actualFuelConsumptionForThisRoute");
		}
	}

	[XmlIgnore]
	public bool actualFuelConsumptionForThisRouteSpecified
	{
		get
		{
			return actualFuelConsumptionForThisRouteFieldSpecified;
		}
		set
		{
			actualFuelConsumptionForThisRouteFieldSpecified = value;
			RaisePropertyChanged("actualFuelConsumptionForThisRouteSpecified");
		}
	}

	[XmlAttribute]
	public CENVersion cenVersion
	{
		get
		{
			return cenVersionField;
		}
		set
		{
			cenVersionField = value;
			RaisePropertyChanged("cenVersion");
		}
	}

	[XmlAttribute]
	public double fleetSpecificAverageFuelConsumption
	{
		get
		{
			return fleetSpecificAverageFuelConsumptionField;
		}
		set
		{
			fleetSpecificAverageFuelConsumptionField = value;
			RaisePropertyChanged("fleetSpecificAverageFuelConsumption");
		}
	}

	[XmlIgnore]
	public bool fleetSpecificAverageFuelConsumptionSpecified
	{
		get
		{
			return fleetSpecificAverageFuelConsumptionFieldSpecified;
		}
		set
		{
			fleetSpecificAverageFuelConsumptionFieldSpecified = value;
			RaisePropertyChanged("fleetSpecificAverageFuelConsumptionSpecified");
		}
	}

	[XmlAttribute]
	public double routeSpecificAverageFuelConsumption
	{
		get
		{
			return routeSpecificAverageFuelConsumptionField;
		}
		set
		{
			routeSpecificAverageFuelConsumptionField = value;
			RaisePropertyChanged("routeSpecificAverageFuelConsumption");
		}
	}

	[XmlIgnore]
	public bool routeSpecificAverageFuelConsumptionSpecified
	{
		get
		{
			return routeSpecificAverageFuelConsumptionFieldSpecified;
		}
		set
		{
			routeSpecificAverageFuelConsumptionFieldSpecified = value;
			RaisePropertyChanged("routeSpecificAverageFuelConsumptionSpecified");
		}
	}
}
