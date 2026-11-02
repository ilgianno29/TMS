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
public class Color : TransientVO
{
	private int blueField;

	private int greenField;

	private int redField;

	[XmlAttribute]
	public int blue
	{
		get
		{
			return blueField;
		}
		set
		{
			blueField = value;
			RaisePropertyChanged("blue");
		}
	}

	[XmlAttribute]
	public int green
	{
		get
		{
			return greenField;
		}
		set
		{
			greenField = value;
			RaisePropertyChanged("green");
		}
	}

	[XmlAttribute]
	public int red
	{
		get
		{
			return redField;
		}
		set
		{
			redField = value;
			RaisePropertyChanged("red");
		}
	}
}
