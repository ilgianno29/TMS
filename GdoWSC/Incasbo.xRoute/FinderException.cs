using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlInclude(typeof(ObjectNotFoundException))]
[DesignerCategory("code")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://exception.core.jabba.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class FinderException : SystemException
{
}
