using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[XmlInclude(typeof(TotalCosts))]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
[XmlInclude(typeof(VehicleCosts))]
[XmlInclude(typeof(Costs))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public abstract class AbstractCosts : TransientVO
{
	private double costsPerKmField;

	private double fixedCostsField;

	[XmlAttribute]
	public double costsPerKm
	{
		get
		{
			return costsPerKmField;
		}
		set
		{
			costsPerKmField = value;
			RaisePropertyChanged("costsPerKm");
		}
	}

	[XmlAttribute]
	public double fixedCosts
	{
		get
		{
			return fixedCostsField;
		}
		set
		{
			fixedCostsField = value;
			RaisePropertyChanged("fixedCosts");
		}
	}
}
