using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xmap.xserver.ptvag.com")]
public enum ObjectInfoType
{
	NONE,
	REFERENCEPOINT,
	GEOMETRY,
	GEOMETRYCLIPPED,
	FULLGEOMETRY,
	FULLGEOMETRYCLIPPED,
	TILEGEOMETRY,
	TILEGEOMETRYCLIPPED
}
