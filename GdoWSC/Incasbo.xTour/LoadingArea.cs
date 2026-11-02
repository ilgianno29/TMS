using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class LoadingArea : TransientVO
{
	private int heightField;

	private int lengthField;

	private int weightField;

	private int widthField;

	[XmlAttribute]
	public int height
	{
		get
		{
			return heightField;
		}
		set
		{
			heightField = value;
			RaisePropertyChanged("height");
		}
	}

	[XmlAttribute]
	public int length
	{
		get
		{
			return lengthField;
		}
		set
		{
			lengthField = value;
			RaisePropertyChanged("length");
		}
	}

	[XmlAttribute]
	public int weight
	{
		get
		{
			return weightField;
		}
		set
		{
			weightField = value;
			RaisePropertyChanged("weight");
		}
	}

	[XmlAttribute]
	public int width
	{
		get
		{
			return widthField;
		}
		set
		{
			widthField = value;
			RaisePropertyChanged("width");
		}
	}
}
