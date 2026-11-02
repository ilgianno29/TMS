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
public class BreakRuleAUS : TransientVO
{
	private int breakPeriodField;

	private int observationPeriodForFourBreaksField;

	private int observationPeriodForOneBreakField;

	private int observationPeriodForTwoBreaksField;

	[XmlAttribute]
	public int breakPeriod
	{
		get
		{
			return breakPeriodField;
		}
		set
		{
			breakPeriodField = value;
			RaisePropertyChanged("breakPeriod");
		}
	}

	[XmlAttribute]
	public int observationPeriodForFourBreaks
	{
		get
		{
			return observationPeriodForFourBreaksField;
		}
		set
		{
			observationPeriodForFourBreaksField = value;
			RaisePropertyChanged("observationPeriodForFourBreaks");
		}
	}

	[XmlAttribute]
	public int observationPeriodForOneBreak
	{
		get
		{
			return observationPeriodForOneBreakField;
		}
		set
		{
			observationPeriodForOneBreakField = value;
			RaisePropertyChanged("observationPeriodForOneBreak");
		}
	}

	[XmlAttribute]
	public int observationPeriodForTwoBreaks
	{
		get
		{
			return observationPeriodForTwoBreaksField;
		}
		set
		{
			observationPeriodForTwoBreaksField = value;
			RaisePropertyChanged("observationPeriodForTwoBreaks");
		}
	}
}
