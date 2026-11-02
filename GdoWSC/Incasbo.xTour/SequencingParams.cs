using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
public class SequencingParams : PlanningParams
{
	private int availableMachineTimeField;

	private bool availableMachineTimeFieldSpecified;

	private int fixedEndTransportPointsField;

	private bool fixedEndTransportPointsFieldSpecified;

	private int fixedStartTransportPointsField;

	private bool fixedStartTransportPointsFieldSpecified;

	private int maximumNumberOfUnscheduledOrdersToBeAnalyzedField;

	private bool maximumNumberOfUnscheduledOrdersToBeAnalyzedFieldSpecified;

	[XmlAttribute]
	public int availableMachineTime
	{
		get
		{
			return availableMachineTimeField;
		}
		set
		{
			availableMachineTimeField = value;
			RaisePropertyChanged("availableMachineTime");
		}
	}

	[XmlIgnore]
	public bool availableMachineTimeSpecified
	{
		get
		{
			return availableMachineTimeFieldSpecified;
		}
		set
		{
			availableMachineTimeFieldSpecified = value;
			RaisePropertyChanged("availableMachineTimeSpecified");
		}
	}

	[XmlAttribute]
	public int fixedEndTransportPoints
	{
		get
		{
			return fixedEndTransportPointsField;
		}
		set
		{
			fixedEndTransportPointsField = value;
			RaisePropertyChanged("fixedEndTransportPoints");
		}
	}

	[XmlIgnore]
	public bool fixedEndTransportPointsSpecified
	{
		get
		{
			return fixedEndTransportPointsFieldSpecified;
		}
		set
		{
			fixedEndTransportPointsFieldSpecified = value;
			RaisePropertyChanged("fixedEndTransportPointsSpecified");
		}
	}

	[XmlAttribute]
	public int fixedStartTransportPoints
	{
		get
		{
			return fixedStartTransportPointsField;
		}
		set
		{
			fixedStartTransportPointsField = value;
			RaisePropertyChanged("fixedStartTransportPoints");
		}
	}

	[XmlIgnore]
	public bool fixedStartTransportPointsSpecified
	{
		get
		{
			return fixedStartTransportPointsFieldSpecified;
		}
		set
		{
			fixedStartTransportPointsFieldSpecified = value;
			RaisePropertyChanged("fixedStartTransportPointsSpecified");
		}
	}

	[XmlAttribute]
	public int maximumNumberOfUnscheduledOrdersToBeAnalyzed
	{
		get
		{
			return maximumNumberOfUnscheduledOrdersToBeAnalyzedField;
		}
		set
		{
			maximumNumberOfUnscheduledOrdersToBeAnalyzedField = value;
			RaisePropertyChanged("maximumNumberOfUnscheduledOrdersToBeAnalyzed");
		}
	}

	[XmlIgnore]
	public bool maximumNumberOfUnscheduledOrdersToBeAnalyzedSpecified
	{
		get
		{
			return maximumNumberOfUnscheduledOrdersToBeAnalyzedFieldSpecified;
		}
		set
		{
			maximumNumberOfUnscheduledOrdersToBeAnalyzedFieldSpecified = value;
			RaisePropertyChanged("maximumNumberOfUnscheduledOrdersToBeAnalyzedSpecified");
		}
	}
}
