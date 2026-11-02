using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class MaximumTourPeriodRestriction : TransientVO
{
	private int maximumAllowableTourPeriodField;

	private int maximumNetTourPeriodField;

	[XmlAttribute]
	public int maximumAllowableTourPeriod
	{
		get
		{
			return maximumAllowableTourPeriodField;
		}
		set
		{
			maximumAllowableTourPeriodField = value;
			RaisePropertyChanged("maximumAllowableTourPeriod");
		}
	}

	[XmlAttribute]
	public int maximumNetTourPeriod
	{
		get
		{
			return maximumNetTourPeriodField;
		}
		set
		{
			maximumNetTourPeriodField = value;
			RaisePropertyChanged("maximumNetTourPeriod");
		}
	}
}
