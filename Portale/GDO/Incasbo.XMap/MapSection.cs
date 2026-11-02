using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[XmlInclude(typeof(MapSectionRot))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xmap.xserver.ptvag.com")]
public class MapSection : TransientVO
{
	private Point centerField;

	private int scaleField;

	private int scrollHorizontalField;

	private int scrollVerticalField;

	private int zoomField;

	[XmlElement(IsNullable = true, Order = 0)]
	public Point center
	{
		get
		{
			return centerField;
		}
		set
		{
			centerField = value;
			RaisePropertyChanged("center");
		}
	}

	[XmlAttribute]
	public int scale
	{
		get
		{
			return scaleField;
		}
		set
		{
			scaleField = value;
			RaisePropertyChanged("scale");
		}
	}

	[XmlAttribute]
	public int scrollHorizontal
	{
		get
		{
			return scrollHorizontalField;
		}
		set
		{
			scrollHorizontalField = value;
			RaisePropertyChanged("scrollHorizontal");
		}
	}

	[XmlAttribute]
	public int scrollVertical
	{
		get
		{
			return scrollVerticalField;
		}
		set
		{
			scrollVerticalField = value;
			RaisePropertyChanged("scrollVertical");
		}
	}

	[XmlAttribute]
	public int zoom
	{
		get
		{
			return zoomField;
		}
		set
		{
			zoomField = value;
			RaisePropertyChanged("zoom");
		}
	}
}
