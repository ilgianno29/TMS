using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public class CENEmissionScenarios : TransientVO
{
	private CENEmissions actualFuelConsumptionField;

	private CENEmissions basedOnHBEFAField;

	private CENEmissions fleetSpecificField;

	private CENEmissions routeSpecificField;

	private CENEmissions vehicleSpecificField;

	private CENEmissionConversionFactors[] wrappedVehicleSpecificConversionFactorsField;

	[XmlElement(IsNullable = true, Order = 0)]
	public CENEmissions actualFuelConsumption
	{
		get
		{
			return actualFuelConsumptionField;
		}
		set
		{
			actualFuelConsumptionField = value;
			RaisePropertyChanged("actualFuelConsumption");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public CENEmissions basedOnHBEFA
	{
		get
		{
			return basedOnHBEFAField;
		}
		set
		{
			basedOnHBEFAField = value;
			RaisePropertyChanged("basedOnHBEFA");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public CENEmissions fleetSpecific
	{
		get
		{
			return fleetSpecificField;
		}
		set
		{
			fleetSpecificField = value;
			RaisePropertyChanged("fleetSpecific");
		}
	}

	[XmlElement(IsNullable = true, Order = 3)]
	public CENEmissions routeSpecific
	{
		get
		{
			return routeSpecificField;
		}
		set
		{
			routeSpecificField = value;
			RaisePropertyChanged("routeSpecific");
		}
	}

	[XmlElement(IsNullable = true, Order = 4)]
	public CENEmissions vehicleSpecific
	{
		get
		{
			return vehicleSpecificField;
		}
		set
		{
			vehicleSpecificField = value;
			RaisePropertyChanged("vehicleSpecific");
		}
	}

	[XmlArray(IsNullable = true, Order = 5)]
	public CENEmissionConversionFactors[] wrappedVehicleSpecificConversionFactors
	{
		get
		{
			return wrappedVehicleSpecificConversionFactorsField;
		}
		set
		{
			wrappedVehicleSpecificConversionFactorsField = value;
			RaisePropertyChanged("wrappedVehicleSpecificConversionFactors");
		}
	}
}
