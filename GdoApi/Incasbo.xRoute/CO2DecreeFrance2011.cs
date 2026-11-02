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
public class CO2DecreeFrance2011 : CENEmissions
{
	private double co2Well2TankField;

	private double co2Well2WheelField;

	[XmlAttribute]
	public double co2Well2Tank
	{
		get
		{
			return co2Well2TankField;
		}
		set
		{
			co2Well2TankField = value;
			RaisePropertyChanged("co2Well2Tank");
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
}
