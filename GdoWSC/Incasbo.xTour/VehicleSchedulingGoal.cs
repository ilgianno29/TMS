using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public enum VehicleSchedulingGoal
{
	MINIMUM_CHAIN_COUNT,
	MINIMUM_COST
}
