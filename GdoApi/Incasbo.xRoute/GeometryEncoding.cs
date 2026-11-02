using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
public enum GeometryEncoding
{
	PLAIN,
	WKB,
	WKT,
	KML
}
