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
public class GeometryLayer : Layer
{
	private Geometries[] wrappedGeometriesField;

	private int drawPriorityField;

	private ObjectInfoType objectInfosField;

	[XmlArray(IsNullable = true, Order = 0)]
	public Geometries[] wrappedGeometries
	{
		get
		{
			return wrappedGeometriesField;
		}
		set
		{
			wrappedGeometriesField = value;
			RaisePropertyChanged("wrappedGeometries");
		}
	}

	[XmlAttribute]
	public int drawPriority
	{
		get
		{
			return drawPriorityField;
		}
		set
		{
			drawPriorityField = value;
			RaisePropertyChanged("drawPriority");
		}
	}

	[XmlAttribute]
	public ObjectInfoType objectInfos
	{
		get
		{
			return objectInfosField;
		}
		set
		{
			objectInfosField = value;
			RaisePropertyChanged("objectInfos");
		}
	}
}
