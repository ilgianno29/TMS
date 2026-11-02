using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class PlainGeometryCollection : PlainGeometryBase
{
	private PlainGeometryBase[] wrappedGeometriesField;

	[XmlArray(IsNullable = true, Order = 0)]
	public PlainGeometryBase[] wrappedGeometries
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
}
