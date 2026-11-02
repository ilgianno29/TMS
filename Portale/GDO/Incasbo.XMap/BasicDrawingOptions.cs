using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[XmlInclude(typeof(LinePartOptions))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xmap.xserver.ptvag.com")]
public class BasicDrawingOptions : TransientVO
{
	private Color colorField;

	private bool visibleField;

	[XmlElement(IsNullable = true, Order = 0)]
	public Color color
	{
		get
		{
			return colorField;
		}
		set
		{
			colorField = value;
			RaisePropertyChanged("color");
		}
	}

	[XmlAttribute]
	public bool visible
	{
		get
		{
			return visibleField;
		}
		set
		{
			visibleField = value;
			RaisePropertyChanged("visible");
		}
	}
}
