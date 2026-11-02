using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public enum TimeEventType
{
	DRIVING,
	WAITING,
	SERVICE,
	IDLE,
	EXTENDED_IDLE,
	BREAK_ON_ROAD,
	BREAK_AT_STOP,
	BREAK_AT_STOP_WHILE_SERVICE,
	BREAK_AT_STOP_SERVICE_ON_IDLE,
	BREAK_ON_IDLE,
	SERVICE_ON_IDLE,
	REST_ON_ROAD,
	REST_AT_STOP,
	REST_AT_STOP_WHILE_SERVICE,
	INTERMEDIATE,
	BREAK_AT_INTERMEDIATE,
	TOUR_START,
	TOUR_END,
	DISTURBANCE,
	REST_AT_INTERMEDIATE
}
