using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.Tesi;

[Serializable]
[XmlInclude(typeof(BaseBeanViaggio))]
[XmlInclude(typeof(Parameter))]
[XmlInclude(typeof(Parameters))]
[XmlInclude(typeof(Station))]
[XmlInclude(typeof(Delivery))]
[XmlInclude(typeof(Deliveries))]
[XmlInclude(typeof(Transport))]
[XmlInclude(typeof(Transports))]
[XmlInclude(typeof(Return))]
[XmlInclude(typeof(Response))]
[GeneratedCode("System.Xml", "4.8.9221.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://rpc.xml.coldfusion/xsd")]
public abstract class CFComponentSkeleton
{
}
