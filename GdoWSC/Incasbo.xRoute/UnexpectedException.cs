using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DebuggerStepThrough]
[XmlType(Namespace = "http://exception.core.jabba.ptvag.com")]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class UnexpectedException : SystemException
{
}
