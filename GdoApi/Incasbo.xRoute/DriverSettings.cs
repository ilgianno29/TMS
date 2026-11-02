using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public class DriverSettings : TransientVO
{
	private bool breakRuleAUSDisabledField;

	private bool breakRuleAUSDisabledFieldSpecified;

	private bool breakRuleDisabledField;

	private bool breakRuleDisabledFieldSpecified;

	private bool dailyRestRuleAUSDisabledField;

	private bool dailyRestRuleAUSDisabledFieldSpecified;

	private bool dailyRestRuleDisabledField;

	private bool dailyRestRuleDisabledFieldSpecified;

	private string remainingPeriodsField;

	private bool weeklyRestRuleAUSDisabledField;

	private bool weeklyRestRuleAUSDisabledFieldSpecified;

	private bool weeklyRestRuleDisabledField;

	private bool weeklyRestRuleDisabledFieldSpecified;

	private bool workingRuleDisabledField;

	private bool workingRuleDisabledFieldSpecified;

	[XmlAttribute]
	public bool breakRuleAUSDisabled
	{
		get
		{
			return breakRuleAUSDisabledField;
		}
		set
		{
			breakRuleAUSDisabledField = value;
			RaisePropertyChanged("breakRuleAUSDisabled");
		}
	}

	[XmlIgnore]
	public bool breakRuleAUSDisabledSpecified
	{
		get
		{
			return breakRuleAUSDisabledFieldSpecified;
		}
		set
		{
			breakRuleAUSDisabledFieldSpecified = value;
			RaisePropertyChanged("breakRuleAUSDisabledSpecified");
		}
	}

	[XmlAttribute]
	public bool breakRuleDisabled
	{
		get
		{
			return breakRuleDisabledField;
		}
		set
		{
			breakRuleDisabledField = value;
			RaisePropertyChanged("breakRuleDisabled");
		}
	}

	[XmlIgnore]
	public bool breakRuleDisabledSpecified
	{
		get
		{
			return breakRuleDisabledFieldSpecified;
		}
		set
		{
			breakRuleDisabledFieldSpecified = value;
			RaisePropertyChanged("breakRuleDisabledSpecified");
		}
	}

	[XmlAttribute]
	public bool dailyRestRuleAUSDisabled
	{
		get
		{
			return dailyRestRuleAUSDisabledField;
		}
		set
		{
			dailyRestRuleAUSDisabledField = value;
			RaisePropertyChanged("dailyRestRuleAUSDisabled");
		}
	}

	[XmlIgnore]
	public bool dailyRestRuleAUSDisabledSpecified
	{
		get
		{
			return dailyRestRuleAUSDisabledFieldSpecified;
		}
		set
		{
			dailyRestRuleAUSDisabledFieldSpecified = value;
			RaisePropertyChanged("dailyRestRuleAUSDisabledSpecified");
		}
	}

	[XmlAttribute]
	public bool dailyRestRuleDisabled
	{
		get
		{
			return dailyRestRuleDisabledField;
		}
		set
		{
			dailyRestRuleDisabledField = value;
			RaisePropertyChanged("dailyRestRuleDisabled");
		}
	}

	[XmlIgnore]
	public bool dailyRestRuleDisabledSpecified
	{
		get
		{
			return dailyRestRuleDisabledFieldSpecified;
		}
		set
		{
			dailyRestRuleDisabledFieldSpecified = value;
			RaisePropertyChanged("dailyRestRuleDisabledSpecified");
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
	public bool weeklyRestRuleAUSDisabled
	{
		get
		{
			return weeklyRestRuleAUSDisabledField;
		}
		set
		{
			weeklyRestRuleAUSDisabledField = value;
			RaisePropertyChanged("weeklyRestRuleAUSDisabled");
		}
	}

	[XmlIgnore]
	public bool weeklyRestRuleAUSDisabledSpecified
	{
		get
		{
			return weeklyRestRuleAUSDisabledFieldSpecified;
		}
		set
		{
			weeklyRestRuleAUSDisabledFieldSpecified = value;
			RaisePropertyChanged("weeklyRestRuleAUSDisabledSpecified");
		}
	}

	[XmlAttribute]
	public bool weeklyRestRuleDisabled
	{
		get
		{
			return weeklyRestRuleDisabledField;
		}
		set
		{
			weeklyRestRuleDisabledField = value;
			RaisePropertyChanged("weeklyRestRuleDisabled");
		}
	}

	[XmlIgnore]
	public bool weeklyRestRuleDisabledSpecified
	{
		get
		{
			return weeklyRestRuleDisabledFieldSpecified;
		}
		set
		{
			weeklyRestRuleDisabledFieldSpecified = value;
			RaisePropertyChanged("weeklyRestRuleDisabledSpecified");
		}
	}

	[XmlAttribute]
	public bool workingRuleDisabled
	{
		get
		{
			return workingRuleDisabledField;
		}
		set
		{
			workingRuleDisabledField = value;
			RaisePropertyChanged("workingRuleDisabled");
		}
	}

	[XmlIgnore]
	public bool workingRuleDisabledSpecified
	{
		get
		{
			return workingRuleDisabledFieldSpecified;
		}
		set
		{
			workingRuleDisabledFieldSpecified = value;
			RaisePropertyChanged("workingRuleDisabledSpecified");
		}
	}
}
