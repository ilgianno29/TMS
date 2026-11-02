using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xmap.xserver.ptvag.com")]
public class VisibleSectionRot : VisibleSection
{
	private Point leftBottomField;

	private Point leftTopField;

	private Point rightBottomField;

	private Point rightTopField;

	private int angleField;

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

	[XmlElement(IsNullable = true, Order = 2)]
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

	[XmlElement(IsNullable = true, Order = 3)]
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

	[XmlAttribute]
	public int angle
	{
		get
		{
			return angleField;
		}
		set
		{
			angleField = value;
			RaisePropertyChanged("angle");
		}
	}
}
