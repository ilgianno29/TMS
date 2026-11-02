using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.MiocNew;

[Serializable]
[XmlInclude(typeof(Return))]
[XmlInclude(typeof(Response))]
[XmlInclude(typeof(PrenotazioneOutbound))]
[GeneratedCode("System.Xml", "4.8.4084.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://rpc.xml.coldfusion/xsd")]
public abstract class CFComponentSkeleton
{
}
