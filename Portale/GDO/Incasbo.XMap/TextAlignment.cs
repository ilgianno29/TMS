using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xmap.xserver.ptvag.com")]
public enum TextAlignment
{
	TOP_LEFT,
	TOP_MID,
	TOP_RIGHT,
	MID_LEFT,
	CENTER,
	MID_RIGHT,
	BOTTOM_LEFT,
	BOTTOM_MID,
	BOTTOM_RIGHT
}
