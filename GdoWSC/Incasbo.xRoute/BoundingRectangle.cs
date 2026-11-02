using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
public class BoundingRectangle : TransientVO
{
	private Point leftBottomField;

	private Point rightTopField;

	[XmlElement(IsNullable = true, Order = 0)]
	public Point leftBottom
	{
		get
		{
			return leftBottomField;
		}
		set
		{
			leftBottomField = value;
			RaisePropertyChanged("leftBottom");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public Point rightTop
	{
		get
		{
			return rightTopField;
		}
		set
		{
			rightTopField = value;
			RaisePropertyChanged("rightTop");
		}
	}
}
