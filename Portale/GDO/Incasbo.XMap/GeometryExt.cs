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
public class GeometryExt : Geometry
{
	private string geometryStringField;

	[XmlAttribute]
	public string geometryString
	{
		get
		{
			return geometryStringField;
		}
		set
		{
			geometryStringField = value;
			RaisePropertyChanged("geometryString");
		}
	}
}
