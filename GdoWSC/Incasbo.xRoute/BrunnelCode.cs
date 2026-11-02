using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public enum BrunnelCode
{
	NOTHING,
	OVER_WATER,
	UNDER_WATER,
	OVER_TRAIN,
	UNDER_TRAIN,
	OVER_STREET,
	UNDER_STREET,
	BRIDGE,
	TUNNEL
}
