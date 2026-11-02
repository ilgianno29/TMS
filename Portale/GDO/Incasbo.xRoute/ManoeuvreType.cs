using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public enum ManoeuvreType
{
	FURTHER,
	KEEP,
	TURN,
	UTURN,
	ENTER,
	EXIT,
	ENTER_RA,
	STAY_RA,
	EXIT_RA,
	CHANGE,
	ENTER_FERRY,
	EXIT_FERRY,
	EXIT_RA_ENTER,
	EXIT_RA_ENTER_FERRY
}
