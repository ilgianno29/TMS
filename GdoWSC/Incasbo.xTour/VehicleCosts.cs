using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
public class VehicleCosts : Costs
{
	private double costsPerChainField;

	[XmlAttribute]
	public double costsPerChain
	{
		get
		{
			return costsPerChainField;
		}
		set
		{
			costsPerChainField = value;
			RaisePropertyChanged("costsPerChain");
		}
	}
}
