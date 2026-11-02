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
public class TextOptions : TransientVO
{
	private Color bgColorField;

	private Font fontField;

	private Color frameColorField;

	private Color textColorField;

	private TextAlignment alignmentField;

	private bool fillBgField;

	private int pixelXField;

	private int pixelYField;

	private int relXField;

	private int relYField;

	private bool showFrameField;

	[XmlElement(IsNullable = true, Order = 0)]
	public Color bgColor
	{
		get
		{
			return bgColorField;
		}
		set
		{
			bgColorField = value;
			RaisePropertyChanged("bgColor");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public Font font
	{
		get
		{
			return fontField;
		}
		set
		{
			fontField = value;
			RaisePropertyChanged("font");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public Color frameColor
	{
		get
		{
			return frameColorField;
		}
		set
		{
			frameColorField = value;
			RaisePropertyChanged("frameColor");
		}
	}

	[XmlElement(IsNullable = true, Order = 3)]
	public Color textColor
	{
		get
		{
			return textColorField;
		}
		set
		{
			textColorField = value;
			RaisePropertyChanged("textColor");
		}
	}

	[XmlAttribute]
	public TextAlignment alignment
	{
		get
		{
			return alignmentField;
		}
		set
		{
			alignmentField = value;
			RaisePropertyChanged("alignment");
		}
	}

	[XmlAttribute]
	public bool fillBg
	{
		get
		{
			return fillBgField;
		}
		set
		{
			fillBgField = value;
			RaisePropertyChanged("fillBg");
		}
	}

	[XmlAttribute]
	public int pixelX
	{
		get
		{
			return pixelXField;
		}
		set
		{
			pixelXField = value;
			RaisePropertyChanged("pixelX");
		}
	}

	[XmlAttribute]
	public int pixelY
	{
		get
		{
			return pixelYField;
		}
		set
		{
			pixelYField = value;
			RaisePropertyChanged("pixelY");
		}
	}

	[XmlAttribute]
	public int relX
	{
		get
		{
			return relXField;
		}
		set
		{
			relXField = value;
			RaisePropertyChanged("relX");
		}
	}

	[XmlAttribute]
	public int relY
	{
		get
		{
			return relYField;
		}
		set
		{
			relYField = value;
			RaisePropertyChanged("relY");
		}
	}

	[XmlAttribute]
	public bool showFrame
	{
		get
		{
			return showFrameField;
		}
		set
		{
			showFrameField = value;
			RaisePropertyChanged("showFrame");
		}
	}
}
