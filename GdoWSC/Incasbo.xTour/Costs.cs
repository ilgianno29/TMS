using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(VehicleCosts))]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class Costs : AbstractCosts
{
	private double costsPerHourDriverOnlyField;

	private double costsPerHourWithCoDriverField;

	[XmlAttribute]
	public double costsPerHourDriverOnly
	{
		get
		{
			return costsPerHourDriverOnlyField;
		}
		set
		{
			costsPerHourDriverOnlyField = value;
			RaisePropertyChanged("costsPerHourDriverOnly");
		}
	}

	[XmlAttribute]
	public double costsPerHourWithCoDriver
	{
		get
		{
			return costsPerHourWithCoDriverField;
		}
		set
		{
			costsPerHourWithCoDriverField = value;
			RaisePropertyChanged("costsPerHourWithCoDriver");
		}
	}
}
