using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public enum HBEFAVersion
{
	HBEFA_2_1,
	HBEFA_3_1,
	NO_HBEFA,
	HBEFA_3_2,
	COPERT_AUS_1_2
}
