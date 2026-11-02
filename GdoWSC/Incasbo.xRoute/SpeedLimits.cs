using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public class SpeedLimits : TransientVO
{
	private SpeedLimit[] wrappedSpeedLimitField;

	[XmlArray(IsNullable = true, Order = 0)]
	public SpeedLimit[] wrappedSpeedLimit
	{
		get
		{
			return wrappedSpeedLimitField;
		}
		set
		{
			wrappedSpeedLimitField = value;
			RaisePropertyChanged("wrappedSpeedLimit");
		}
	}
}
