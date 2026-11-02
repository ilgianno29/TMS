using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class SpeedLimit : TransientVO
{
	private string conditionField;

	private int limitVelocityField;

	[XmlAttribute]
	public string condition
	{
		get
		{
			return conditionField;
		}
		set
		{
			conditionField = value;
			RaisePropertyChanged("condition");
		}
	}

	[XmlAttribute]
	public int limitVelocity
	{
		get
		{
			return limitVelocityField;
		}
		set
		{
			limitVelocityField = value;
			RaisePropertyChanged("limitVelocity");
		}
	}
}
