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
public class ReachableObjects : TransientVO
{
	private ReachableObject[] wrappedReachableObjectField;

	[XmlArray(IsNullable = true, Order = 0)]
	public ReachableObject[] wrappedReachableObject
	{
		get
		{
			return wrappedReachableObjectField;
		}
		set
		{
			wrappedReachableObjectField = value;
			RaisePropertyChanged("wrappedReachableObject");
		}
	}
}
