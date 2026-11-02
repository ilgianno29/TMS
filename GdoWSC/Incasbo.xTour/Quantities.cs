using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class Quantities : TransientVO
{
	private int[] wrappedQuantitiesField;

	[XmlArray(IsNullable = true, Order = 0)]
	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	public int[] wrappedQuantities
	{
		get
		{
			return wrappedQuantitiesField;
		}
		set
		{
			wrappedQuantitiesField = value;
			RaisePropertyChanged("wrappedQuantities");
		}
	}
}
