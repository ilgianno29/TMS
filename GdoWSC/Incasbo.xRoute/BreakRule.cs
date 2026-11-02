using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class BreakRule : TransientVO
{
	private int breakPeriod1Field;

	private int breakPeriod2Field;

	private int drivingPeriodField;

	[XmlAttribute]
	public int breakPeriod1
	{
		get
		{
			return breakPeriod1Field;
		}
		set
		{
			breakPeriod1Field = value;
			RaisePropertyChanged("breakPeriod1");
		}
	}

	[XmlAttribute]
	public int breakPeriod2
	{
		get
		{
			return breakPeriod2Field;
		}
		set
		{
			breakPeriod2Field = value;
			RaisePropertyChanged("breakPeriod2");
		}
	}

	[XmlAttribute]
	public int drivingPeriod
	{
		get
		{
			return drivingPeriodField;
		}
		set
		{
			drivingPeriodField = value;
			RaisePropertyChanged("drivingPeriod");
		}
	}
}
