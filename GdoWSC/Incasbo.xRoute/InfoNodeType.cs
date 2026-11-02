using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public enum InfoNodeType
{
	NORMAL,
	AE,
	AS,
	AD,
	AK,
	BORDER,
	BUILT_UP,
	FERRY,
	TOLL_ROAD,
	SIGN
}
