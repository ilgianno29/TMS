using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlInclude(typeof(UKDefra2014))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(AustraliaNGA2015))]
[XmlInclude(typeof(CENEmissions2012))]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[XmlInclude(typeof(CENEmissions2011))]
[XmlInclude(typeof(CO2DecreeFrance2011))]
[XmlInclude(typeof(AustraliaNGA2011))]
public abstract class CENEmissions : TransientVO
{
}
