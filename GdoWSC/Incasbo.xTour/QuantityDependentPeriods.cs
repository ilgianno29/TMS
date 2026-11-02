using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
public class QuantityDependentPeriods : TransientVO
{
	private double[] wrappedSecondsPerQuantityUnitField;

	[XmlArray(IsNullable = true, Order = 0)]
	[XmlArrayItem("Double", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	public double[] wrappedSecondsPerQuantityUnit
	{
		get
		{
			return wrappedSecondsPerQuantityUnitField;
		}
		set
		{
			wrappedSecondsPerQuantityUnitField = value;
			RaisePropertyChanged("wrappedSecondsPerQuantityUnit");
		}
	}
}
