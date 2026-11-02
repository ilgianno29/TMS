using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[XmlInclude(typeof(GeometryExt))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xmap.xserver.ptvag.com")]
public class Geometry : TransientVO
{
	private EncodedGeometry geometryField;

	private Point referencePointField;

	private string descriptionField;

	private int idField;

	[XmlElement(IsNullable = true, Order = 0)]
	public EncodedGeometry geometry
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
	public Point referencePoint
	{
		get
		{
			return referencePointField;
		}
		set
		{
			referencePointField = value;
			RaisePropertyChanged("referencePoint");
		}
	}

	[XmlAttribute]
	public string description
	{
		get
		{
			return descriptionField;
		}
		set
		{
			descriptionField = value;
			RaisePropertyChanged("description");
		}
	}

	[XmlAttribute]
	public int id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
			RaisePropertyChanged("id");
		}
	}
}
