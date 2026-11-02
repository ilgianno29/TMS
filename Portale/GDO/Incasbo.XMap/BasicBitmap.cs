using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[XmlInclude(typeof(RawBitmap))]
[XmlInclude(typeof(Bitmap))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xmap.xserver.ptvag.com")]
public abstract class BasicBitmap : TransientVO
{
	private Point positionField;

	private string descrField;

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
	public string descr
	{
		get
		{
			return descrField;
		}
		set
		{
			descrField = value;
			RaisePropertyChanged("descr");
		}
	}
}
