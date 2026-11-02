using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class BalancingParams : StandardParams
{
	private string balancingConstructionMethodField;

	private BalancingGoal balancingGoalField;

	private int balancingImportanceField;

	private bool balancingImportanceFieldSpecified;

	[XmlAttribute]
	public string balancingConstructionMethod
	{
		get
		{
			return balancingConstructionMethodField;
		}
		set
		{
			balancingConstructionMethodField = value;
			RaisePropertyChanged("balancingConstructionMethod");
		}
	}

	[XmlAttribute]
	public BalancingGoal balancingGoal
	{
		get
		{
			return balancingGoalField;
		}
		set
		{
			balancingGoalField = value;
			RaisePropertyChanged("balancingGoal");
		}
	}

	[XmlAttribute]
	public int balancingImportance
	{
		get
		{
			return balancingImportanceField;
		}
		set
		{
			balancingImportanceField = value;
			RaisePropertyChanged("balancingImportance");
		}
	}

	[XmlIgnore]
	public bool balancingImportanceSpecified
	{
		get
		{
			return balancingImportanceFieldSpecified;
		}
		set
		{
			balancingImportanceFieldSpecified = value;
			RaisePropertyChanged("balancingImportanceSpecified");
		}
	}
}
