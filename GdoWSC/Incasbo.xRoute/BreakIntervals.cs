using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DebuggerStepThrough]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class BreakIntervals : TransientVO
{
	private Interval[] wrappedIntervalsField;

	private int breakPeriodField;

	[XmlArray(IsNullable = true, Order = 0)]
	public Interval[] wrappedIntervals
	{
		get
		{
			return wrappedIntervalsField;
		}
		set
		{
			wrappedIntervalsField = value;
			RaisePropertyChanged("wrappedIntervals");
		}
	}

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
}
