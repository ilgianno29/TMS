using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DebuggerStepThrough]
public class PartTollCosts : TransientVO
{
	private TollCost[] wrappedCostsField;

	private int distanceField;

	[XmlArray(IsNullable = true, Order = 0)]
	public TollCost[] wrappedCosts
	{
		get
		{
			return wrappedCostsField;
		}
		set
		{
			wrappedCostsField = value;
			RaisePropertyChanged("wrappedCosts");
		}
	}

	[XmlAttribute]
	public int distance
	{
		get
		{
			return distanceField;
		}
		set
		{
			distanceField = value;
			RaisePropertyChanged("distance");
		}
	}
}
