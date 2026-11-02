using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
public class Plan : TransientVO
{
	private Chain[] wrappedChainsField;

	private PlanResult resultField;

	[XmlArray(IsNullable = true, Order = 0)]
	public Chain[] wrappedChains
	{
		get
		{
			return wrappedChainsField;
		}
		set
		{
			wrappedChainsField = value;
			RaisePropertyChanged("wrappedChains");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public PlanResult result
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
}
