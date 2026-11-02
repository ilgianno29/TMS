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
public class LineOptions : TransientVO
{
	private BasicDrawingOptions arrowsField;

	private LinePartOptions mainLineField;

	private LinePartOptions sideLineField;

	private bool showFlagsField;

	private bool transparentField;

	[XmlElement(IsNullable = true, Order = 0)]
	public BasicDrawingOptions arrows
	{
		get
		{
			return arrowsField;
		}
		set
		{
			arrowsField = value;
			RaisePropertyChanged("arrows");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public LinePartOptions mainLine
	{
		get
		{
			return mainLineField;
		}
		set
		{
			mainLineField = value;
			RaisePropertyChanged("mainLine");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public LinePartOptions sideLine
	{
		get
		{
			return sideLineField;
		}
		set
		{
			sideLineField = value;
			RaisePropertyChanged("sideLine");
		}
	}

	[XmlAttribute]
	public bool showFlags
	{
		get
		{
			return showFlagsField;
		}
		set
		{
			showFlagsField = value;
			RaisePropertyChanged("showFlags");
		}
	}

	[XmlAttribute]
	public bool transparent
	{
		get
		{
			return transparentField;
		}
		set
		{
			transparentField = value;
			RaisePropertyChanged("transparent");
		}
	}
}
