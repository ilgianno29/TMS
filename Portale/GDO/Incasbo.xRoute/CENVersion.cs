using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public enum CENVersion
{
	CEN_2011,
	CEN_2012,
	CO2_DECREE_FRANCE_2011,
	AUSTRALIA_NGA_2011,
	UK_DEFRA_2014,
	AUSTRALIA_NGA_2015
}
