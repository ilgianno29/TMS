using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DesignerCategory("code")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
[DebuggerStepThrough]
public class PlainPoint : PlainGeometryBase
{
	private double xField;

	private double yField;

	private double zField;

	private bool zFieldSpecified;

	[XmlAttribute]
	public double x
	{
		get
		{
			return xField;
		}
		set
		{
			xField = value;
			RaisePropertyChanged("x");
		}
	}

	[XmlAttribute]
	public double y
	{
		get
		{
			return yField;
		}
		set
		{
			yField = value;
			RaisePropertyChanged("y");
		}
	}

	[XmlAttribute]
	public double z
	{
		get
		{
			return zField;
		}
		set
		{
			zField = value;
			RaisePropertyChanged("z");
		}
	}

	[XmlIgnore]
	public bool zSpecified
	{
		get
		{
			return zFieldSpecified;
		}
		set
		{
			zFieldSpecified = value;
			RaisePropertyChanged("zSpecified");
		}
	}
}
