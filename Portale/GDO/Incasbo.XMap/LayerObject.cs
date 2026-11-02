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
public class LayerObject : TransientVO
{
	private ObjectGeometry geometryField;

	private PlainPoint pixelField;

	private Point refField;

	private string descrField;

	private int hiIdField;

	private int loIdField;

	[XmlElement(IsNullable = true, Order = 0)]
	public ObjectGeometry geometry
	{
		get
		{
			return geometryField;
		}
		set
		{
			geometryField = value;
			RaisePropertyChanged("geometry");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public PlainPoint pixel
	{
		get
		{
			return pixelField;
		}
		set
		{
			pixelField = value;
			RaisePropertyChanged("pixel");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public Point @ref
	{
		get
		{
			return refField;
		}
		set
		{
			refField = value;
			RaisePropertyChanged("ref");
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

	[XmlAttribute]
	public int hiId
	{
		get
		{
			return hiIdField;
		}
		set
		{
			hiIdField = value;
			RaisePropertyChanged("hiId");
		}
	}

	[XmlAttribute]
	public int loId
	{
		get
		{
			return loIdField;
		}
		set
		{
			loIdField = value;
			RaisePropertyChanged("loId");
		}
	}
}
