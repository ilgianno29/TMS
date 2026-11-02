using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
public enum OpeningIntervalConstraint
{
	START_OF_SERVICE,
	COMPLETE_SERVICE
}
