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
public class UKDefra2014 : CENEmissions
{
	private double ch4Tank2WheelField;

	private double co2Tank2WheelField;

	private double co2eTank2WheelField;

	private double co2eWell2WheelField;

	private bool co2eWell2WheelFieldSpecified;

	private double energyUseTank2WheelField;

	private double n2oTank2WheelField;

	[XmlAttribute]
	public double ch4Tank2Wheel
	{
		get
		{
			return ch4Tank2WheelField;
		}
		set
		{
			ch4Tank2WheelField = value;
			RaisePropertyChanged("ch4Tank2Wheel");
		}
	}

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

	[XmlIgnore]
	public bool co2eWell2WheelSpecified
	{
		get
		{
			return co2eWell2WheelFieldSpecified;
		}
		set
		{
			co2eWell2WheelFieldSpecified = value;
			RaisePropertyChanged("co2eWell2WheelSpecified");
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
	public double n2oTank2Wheel
	{
		get
		{
			return n2oTank2WheelField;
		}
		set
		{
			n2oTank2WheelField = value;
			RaisePropertyChanged("n2oTank2Wheel");
		}
	}
}
