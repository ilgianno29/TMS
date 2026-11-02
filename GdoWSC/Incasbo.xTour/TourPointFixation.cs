using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public enum TourPointFixation
{
	NONE,
	NO_TOUR_POINT_OUT,
	NO_TOUR_POINT_IN_AND_OUT,
	COMPLETELY_FIXED
}
