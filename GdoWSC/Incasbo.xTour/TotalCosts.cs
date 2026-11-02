using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
public class TotalCosts : AbstractCosts
{
	private double costsPerHourField;

	private double totalCostsField;

	[XmlAttribute]
	public double costsPerHour
	{
		get
		{
			return costsPerHourField;
		}
		set
		{
			costsPerHourField = value;
			RaisePropertyChanged("costsPerHour");
		}
	}

	[XmlAttribute]
	public double totalCosts
	{
		get
		{
			return totalCostsField;
		}
		set
		{
			totalCostsField = value;
			RaisePropertyChanged("totalCosts");
		}
	}
}
