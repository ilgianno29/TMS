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
public class Text : TransientVO
{
	private Point positionField;

	private string textField;

	[XmlElement(IsNullable = true, Order = 0)]
	public Point position
	{
		get
		{
			return positionField;
		}
		set
		{
			positionField = value;
			RaisePropertyChanged("position");
		}
	}

	[XmlAttribute]
	public string text
	{
		get
		{
			return textField;
		}
		set
		{
			textField = value;
			RaisePropertyChanged("text");
		}
	}
}
