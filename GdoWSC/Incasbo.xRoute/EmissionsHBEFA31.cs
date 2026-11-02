using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class EmissionsHBEFA31 : Emissions
{
	private double fossilCarbonDioxideField;

	private double nitrogenDioxideField;

	private double particleNumberField;

	[XmlAttribute]
	public double fossilCarbonDioxide
	{
		get
		{
			return fossilCarbonDioxideField;
		}
		set
		{
			fossilCarbonDioxideField = value;
			RaisePropertyChanged("fossilCarbonDioxide");
		}
	}

	[XmlAttribute]
	public double nitrogenDioxide
	{
		get
		{
			return nitrogenDioxideField;
		}
		set
		{
			nitrogenDioxideField = value;
			RaisePropertyChanged("nitrogenDioxide");
		}
	}

	[XmlAttribute]
	public double particleNumber
	{
		get
		{
			return particleNumberField;
		}
		set
		{
			particleNumberField = value;
			RaisePropertyChanged("particleNumber");
		}
	}
}
