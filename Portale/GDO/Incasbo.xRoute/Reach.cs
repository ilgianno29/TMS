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
public class Reach : TransientVO
{
	private ReachInfo[] wrappedReachInfoField;

	private string additionalField;

	[XmlArray(IsNullable = true, Order = 0)]
	public ReachInfo[] wrappedReachInfo
	{
		get
		{
			return wrappedReachInfoField;
		}
		set
		{
			wrappedReachInfoField = value;
			RaisePropertyChanged("wrappedReachInfo");
		}
	}

	[XmlAttribute]
	public string additional
	{
		get
		{
			return additionalField;
		}
		set
		{
			additionalField = value;
			RaisePropertyChanged("additional");
		}
	}
}
