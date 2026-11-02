using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DesignerCategory("code")]
public class DriverSettings : TransientVO
{
	private MaximumTourPeriodRestriction maximumTourPeriodRestrictionField;

	private bool breakRuleActiveField;

	private bool dailyRestRuleActiveField;

	private int regulationsIdField;

	private string remainingPeriodsField;

	private bool weeklyRestRuleActiveField;

	private bool workingRuleActiveField;

	[XmlElement(IsNullable = true, Order = 0)]
	public MaximumTourPeriodRestriction maximumTourPeriodRestriction
	{
		get
		{
			return maximumTourPeriodRestrictionField;
		}
		set
		{
			maximumTourPeriodRestrictionField = value;
			RaisePropertyChanged("maximumTourPeriodRestriction");
		}
	}

	[XmlAttribute]
	public bool breakRuleActive
	{
		get
		{
			return breakRuleActiveField;
		}
		set
		{
			breakRuleActiveField = value;
			RaisePropertyChanged("breakRuleActive");
		}
	}

	[XmlAttribute]
	public bool dailyRestRuleActive
	{
		get
		{
			return dailyRestRuleActiveField;
		}
		set
		{
			dailyRestRuleActiveField = value;
			RaisePropertyChanged("dailyRestRuleActive");
		}
	}

	[XmlAttribute]
	public int regulationsId
	{
		get
		{
			return regulationsIdField;
		}
		set
		{
			regulationsIdField = value;
			RaisePropertyChanged("regulationsId");
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

	[XmlAttribute]
	public bool weeklyRestRuleActive
	{
		get
		{
			return weeklyRestRuleActiveField;
		}
		set
		{
			weeklyRestRuleActiveField = value;
			RaisePropertyChanged("weeklyRestRuleActive");
		}
	}

	[XmlAttribute]
	public bool workingRuleActive
	{
		get
		{
			return workingRuleActiveField;
		}
		set
		{
			workingRuleActiveField = value;
			RaisePropertyChanged("workingRuleActive");
		}
	}
}
