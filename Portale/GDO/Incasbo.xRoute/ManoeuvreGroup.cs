using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public class ManoeuvreGroup : TransientVO
{
	private BoundingRectangle extendField;

	private int fromIdxField;

	private int toIdxField;

	private ManoeuvreGroupType typeField;

	[XmlElement(IsNullable = true, Order = 0)]
	public BoundingRectangle extend
	{
		get
		{
			return extendField;
		}
		set
		{
			extendField = value;
			RaisePropertyChanged("extend");
		}
	}

	[XmlAttribute]
	public int fromIdx
	{
		get
		{
			return fromIdxField;
		}
		set
		{
			fromIdxField = value;
			RaisePropertyChanged("fromIdx");
		}
	}

	[XmlAttribute]
	public int toIdx
	{
		get
		{
			return toIdxField;
		}
		set
		{
			toIdxField = value;
			RaisePropertyChanged("toIdx");
		}
	}

	[XmlAttribute]
	public ManoeuvreGroupType type
	{
		get
		{
			return typeField;
		}
		set
		{
			typeField = value;
			RaisePropertyChanged("type");
		}
	}
}
