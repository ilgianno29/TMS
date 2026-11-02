using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class UnscheduledOrderAnalysisParams : CalculationParams
{
	private int[] wrappedUnscheduledOrderIdsToBeAnalyzedField;

	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	[XmlArray(IsNullable = true, Order = 0)]
	public int[] wrappedUnscheduledOrderIdsToBeAnalyzed
	{
		get
		{
			return wrappedUnscheduledOrderIdsToBeAnalyzedField;
		}
		set
		{
			wrappedUnscheduledOrderIdsToBeAnalyzedField = value;
			RaisePropertyChanged("wrappedUnscheduledOrderIdsToBeAnalyzed");
		}
	}
}
