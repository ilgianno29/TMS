using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.Tesi;

[Serializable]
[XmlInclude(typeof(Parameter))]
[XmlInclude(typeof(Parameters))]
[XmlInclude(typeof(Station))]
[XmlInclude(typeof(Delivery))]
[XmlInclude(typeof(Deliveries))]
[XmlInclude(typeof(Transport))]
[XmlInclude(typeof(Transports))]
[GeneratedCode("System.Xml", "4.8.9221.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://beans.inbound.webservices.cfc.lucart/xsd")]
public class BaseBeanViaggio : CFComponentSkeleton
{
}
