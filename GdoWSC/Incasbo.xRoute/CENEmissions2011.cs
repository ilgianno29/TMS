using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DebuggerStepThrough]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class CENEmissions2011 : CENEmissions
{
	private double co2Tank2WheelField;

	private double co2Well2WheelField;

	private double energyUseTank2WheelField;

	private double energyUseWell2WheelField;

	[XmlAttribute]
	public double co2Tank2Wheel
	{
		get
		{
			return co2Tank2WheelField;
		}
		set
		{
			co2Tank2WheelField = value;
			RaisePropertyChanged("co2Tank2Wheel");
		}
	}

	[XmlAttribute]
	public double co2Well2Wheel
	{
		get
		{
			return co2Well2WheelField;
		}
		set
		{
			co2Well2WheelField = value;
			RaisePropertyChanged("co2Well2Wheel");
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
}
