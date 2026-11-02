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
public class ObjectGeometry : TransientVO
{
	private PlainGeometryBase pixelGeometryField;

	private EncodedGeometry refGeometryField;

	[XmlElement(IsNullable = true, Order = 0)]
	public PlainGeometryBase pixelGeometry
	{
		get
		{
			return pixelGeometryField;
		}
		set
		{
			pixelGeometryField = value;
			RaisePropertyChanged("pixelGeometry");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public EncodedGeometry refGeometry
	{
		get
		{
			return refGeometryField;
		}
		set
		{
			refGeometryField = value;
			RaisePropertyChanged("refGeometry");
		}
	}
}
