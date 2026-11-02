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
public class BitmapOptions : TransientVO
{
	private PlainPoint referencePointField;

	private Color transparencyColorField;

	[XmlElement(IsNullable = true, Order = 0)]
	public PlainPoint referencePoint
	{
		get
		{
			return referencePointField;
		}
		set
		{
			referencePointField = value;
			RaisePropertyChanged("referencePoint");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public Color transparencyColor
	{
		get
		{
			return transparencyColorField;
		}
		set
		{
			transparencyColorField = value;
			RaisePropertyChanged("transparencyColor");
		}
	}
}
