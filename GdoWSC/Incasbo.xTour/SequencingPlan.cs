using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
public class SequencingPlan : TransientVO
{
	private SequencingPlanResult resultField;

	private SequencingTour tourField;

	[XmlElement(IsNullable = true, Order = 0)]
	public SequencingPlanResult result
	{
		get
		{
			return resultField;
		}
		set
		{
			resultField = value;
			RaisePropertyChanged("result");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public SequencingTour tour
	{
		get
		{
			return tourField;
		}
		set
		{
			tourField = value;
			RaisePropertyChanged("tour");
		}
	}
}
