using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(OvernightParams))]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlInclude(typeof(BalancingParams))]
[XmlInclude(typeof(AreaParams))]
[XmlInclude(typeof(AmendingParams))]
public class StandardParams : PlanningParams
{
	private GoalImportance goalImportanceField;

	private int availableMachineTimeField;

	private bool availableMachineTimeFieldSpecified;

	private string basicConstructionMethodField;

	private bool constructionStepField;

	private bool constructionStepFieldSpecified;

	private bool endSequencingStepField;

	private bool endSequencingStepFieldSpecified;

	private string improvementMethodField;

	private bool improvementStepField;

	private bool improvementStepFieldSpecified;

	private int maximumNumberOfUnscheduledOrdersToBeAnalyzedField;

	private bool maximumNumberOfUnscheduledOrdersToBeAnalyzedFieldSpecified;

	private bool middleSequencingStepField;

	private bool middleSequencingStepFieldSpecified;

	private string sequencingMethodField;

	private bool startSequencingStepField;

	private bool startSequencingStepFieldSpecified;

	private bool tourReductionStepField;

	private bool tourReductionStepFieldSpecified;

	[XmlElement(IsNullable = true, Order = 0)]
	public GoalImportance goalImportance
	{
		get
		{
			return goalImportanceField;
		}
		set
		{
			goalImportanceField = value;
			RaisePropertyChanged("goalImportance");
		}
	}

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
	public string basicConstructionMethod
	{
		get
		{
			return basicConstructionMethodField;
		}
		set
		{
			basicConstructionMethodField = value;
			RaisePropertyChanged("basicConstructionMethod");
		}
	}

	[XmlAttribute]
	public bool constructionStep
	{
		get
		{
			return constructionStepField;
		}
		set
		{
			constructionStepField = value;
			RaisePropertyChanged("constructionStep");
		}
	}

	[XmlIgnore]
	public bool constructionStepSpecified
	{
		get
		{
			return constructionStepFieldSpecified;
		}
		set
		{
			constructionStepFieldSpecified = value;
			RaisePropertyChanged("constructionStepSpecified");
		}
	}

	[XmlAttribute]
	public bool endSequencingStep
	{
		get
		{
			return endSequencingStepField;
		}
		set
		{
			endSequencingStepField = value;
			RaisePropertyChanged("endSequencingStep");
		}
	}

	[XmlIgnore]
	public bool endSequencingStepSpecified
	{
		get
		{
			return endSequencingStepFieldSpecified;
		}
		set
		{
			endSequencingStepFieldSpecified = value;
			RaisePropertyChanged("endSequencingStepSpecified");
		}
	}

	[XmlAttribute]
	public string improvementMethod
	{
		get
		{
			return improvementMethodField;
		}
		set
		{
			improvementMethodField = value;
			RaisePropertyChanged("improvementMethod");
		}
	}

	[XmlAttribute]
	public bool improvementStep
	{
		get
		{
			return improvementStepField;
		}
		set
		{
			improvementStepField = value;
			RaisePropertyChanged("improvementStep");
		}
	}

	[XmlIgnore]
	public bool improvementStepSpecified
	{
		get
		{
			return improvementStepFieldSpecified;
		}
		set
		{
			improvementStepFieldSpecified = value;
			RaisePropertyChanged("improvementStepSpecified");
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

	[XmlAttribute]
	public bool middleSequencingStep
	{
		get
		{
			return middleSequencingStepField;
		}
		set
		{
			middleSequencingStepField = value;
			RaisePropertyChanged("middleSequencingStep");
		}
	}

	[XmlIgnore]
	public bool middleSequencingStepSpecified
	{
		get
		{
			return middleSequencingStepFieldSpecified;
		}
		set
		{
			middleSequencingStepFieldSpecified = value;
			RaisePropertyChanged("middleSequencingStepSpecified");
		}
	}

	[XmlAttribute]
	public string sequencingMethod
	{
		get
		{
			return sequencingMethodField;
		}
		set
		{
			sequencingMethodField = value;
			RaisePropertyChanged("sequencingMethod");
		}
	}

	[XmlAttribute]
	public bool startSequencingStep
	{
		get
		{
			return startSequencingStepField;
		}
		set
		{
			startSequencingStepField = value;
			RaisePropertyChanged("startSequencingStep");
		}
	}

	[XmlIgnore]
	public bool startSequencingStepSpecified
	{
		get
		{
			return startSequencingStepFieldSpecified;
		}
		set
		{
			startSequencingStepFieldSpecified = value;
			RaisePropertyChanged("startSequencingStepSpecified");
		}
	}

	[XmlAttribute]
	public bool tourReductionStep
	{
		get
		{
			return tourReductionStepField;
		}
		set
		{
			tourReductionStepField = value;
			RaisePropertyChanged("tourReductionStep");
		}
	}

	[XmlIgnore]
	public bool tourReductionStepSpecified
	{
		get
		{
			return tourReductionStepFieldSpecified;
		}
		set
		{
			tourReductionStepFieldSpecified = value;
			RaisePropertyChanged("tourReductionStepSpecified");
		}
	}
}
