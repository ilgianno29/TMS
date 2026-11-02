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
public class Geometries : TransientVO
{
	private Geometry[] wrappedGeometriesField;

	private GeometryOption[] wrappedOptionsField;

	[XmlArray(IsNullable = true, Order = 0)]
	public Geometry[] wrappedGeometries
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

	[XmlArray(IsNullable = true, Order = 1)]
	public GeometryOption[] wrappedOptions
	{
		get
		{
			return wrappedOptionsField;
		}
		set
		{
			wrappedOptionsField = value;
			RaisePropertyChanged("wrappedOptions");
		}
	}
}
