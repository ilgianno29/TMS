using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public enum LinkType
{
	NEXT_NODE,
	NEXT_SEGMENT,
	NEXT_MAIN_NODE,
	FUZZY_LINKING,
	AUTO_LINKING,
	NEXT_MAIN_TOLL_NODE,
	TOLL_STATION,
	TI_LINKING
}
