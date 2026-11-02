using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public enum NetworkClass
{
	MOTORWAY,
	HIGHWAY,
	TRUNK_ROAD,
	COUNTRY_ROAD,
	CITY_ROAD,
	RESIDENTIAL_ROAD,
	SPECIAL_ROAD,
	CYCLE_AND_WALKWAY
}
