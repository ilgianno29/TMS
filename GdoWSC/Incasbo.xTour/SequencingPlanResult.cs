using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
public class SequencingPlanResult : TransientVO
{
	private int[] wrappedScheduledOrderIdsField;

	private TourEvent[] wrappedTourEventsField;

	private UnscheduledOrderAnalysisResult[] wrappedUnscheduledOrderAnalysisResultsField;

	private int[] wrappedUnscheduledOrderIdsField;

	private string remainingPeriodsField;

	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	[XmlArray(IsNullable = true, Order = 0)]
	public int[] wrappedScheduledOrderIds
	{
		get
		{
			return wrappedScheduledOrderIdsField;
		}
		set
		{
			wrappedScheduledOrderIdsField = value;
			RaisePropertyChanged("wrappedScheduledOrderIds");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
	public TourEvent[] wrappedTourEvents
	{
		get
		{
			return wrappedTourEventsField;
		}
		set
		{
			wrappedTourEventsField = value;
			RaisePropertyChanged("wrappedTourEvents");
		}
	}

	[XmlArray(IsNullable = true, Order = 2)]
	public UnscheduledOrderAnalysisResult[] wrappedUnscheduledOrderAnalysisResults
	{
		get
		{
			return wrappedUnscheduledOrderAnalysisResultsField;
		}
		set
		{
			wrappedUnscheduledOrderAnalysisResultsField = value;
			RaisePropertyChanged("wrappedUnscheduledOrderAnalysisResults");
		}
	}

	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	[XmlArray(IsNullable = true, Order = 3)]
	public int[] wrappedUnscheduledOrderIds
	{
		get
		{
			return wrappedUnscheduledOrderIdsField;
		}
		set
		{
			wrappedUnscheduledOrderIdsField = value;
			RaisePropertyChanged("wrappedUnscheduledOrderIds");
		}
	}

	[XmlAttribute]
	public string remainingPeriods
	{
		get
		{
			return remainingPeriodsField;
		}
		set
		{
			remainingPeriodsField = value;
			RaisePropertyChanged("remainingPeriods");
		}
	}
}
