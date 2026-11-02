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
public class CENEmissions2012 : CENEmissions
{
	private double co2eTank2WheelField;

	private double co2eWell2TankField;

	private double co2eWell2WheelField;

	private double energyUseTank2WheelField;

	private double energyUseWell2TankField;

	private double energyUseWell2WheelField;

	private double fuelConsumptionField;

	[XmlAttribute]
	public double co2eTank2Wheel
	{
		get
		{
			return co2eTank2WheelField;
		}
		set
		{
			co2eTank2WheelField = value;
			RaisePropertyChanged("co2eTank2Wheel");
		}
	}

	[XmlAttribute]
	public double co2eWell2Tank
	{
		get
		{
			return co2eWell2TankField;
		}
		set
		{
			co2eWell2TankField = value;
			RaisePropertyChanged("co2eWell2Tank");
		}
	}

	[XmlAttribute]
	public double co2eWell2Wheel
	{
		get
		{
			return co2eWell2WheelField;
		}
		set
		{
			co2eWell2WheelField = value;
			RaisePropertyChanged("co2eWell2Wheel");
		}
	}

	[XmlAttribute]
	public double energyUseTank2Wheel
	{
		get
		{
			return energyUseTank2WheelField;
		}
		set
		{
			energyUseTank2WheelField = value;
			RaisePropertyChanged("energyUseTank2Wheel");
		}
	}

	[XmlAttribute]
	public double energyUseWell2Tank
	{
		get
		{
			return energyUseWell2TankField;
		}
		set
		{
			energyUseWell2TankField = value;
			RaisePropertyChanged("energyUseWell2Tank");
		}
	}

	[XmlAttribute]
	public double energyUseWell2Wheel
	{
		get
		{
			return energyUseWell2WheelField;
		}
		set
		{
			energyUseWell2WheelField = value;
			RaisePropertyChanged("energyUseWell2Wheel");
		}
	}

	[XmlAttribute]
	public double fuelConsumption
	{
		get
		{
			return fuelConsumptionField;
		}
		set
		{
			fuelConsumptionField = value;
			RaisePropertyChanged("fuelConsumption");
		}
	}
}
