using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[XmlInclude(typeof(VisibleSectionRot))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xmap.xserver.ptvag.com")]
public class VisibleSection : TransientVO
{
	private BoundingBox boundingBoxField;

	private Point centerField;

	private int scaleField;

	[XmlElement(IsNullable = true, Order = 0)]
	public BoundingBox boundingBox
	{
		get
		{
			return boundingBoxField;
		}
		set
		{
			boundingBoxField = value;
			RaisePropertyChanged("boundingBox");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
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
}
