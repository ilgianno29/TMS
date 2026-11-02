using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
public class BoundingBox : TransientVO
{
	private Point leftTopField;

	private Point rightBottomField;

	[XmlElement(IsNullable = true, Order = 0)]
	public Point leftTop
	{
		get
		{
			return leftTopField;
		}
		set
		{
			leftTopField = value;
			RaisePropertyChanged("leftTop");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public Point rightBottom
	{
		get
		{
			return rightBottomField;
		}
		set
		{
			rightBottomField = value;
			RaisePropertyChanged("rightBottom");
		}
	}
}
