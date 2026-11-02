using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
public enum ProductIncompatibilityType
{
	NOT_ON_SAME_TOUR,
	NOT_AT_SAME_TIME
}
