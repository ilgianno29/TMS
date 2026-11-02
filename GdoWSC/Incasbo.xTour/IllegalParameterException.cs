using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlInclude(typeof(ParameterNotSetException))]
[XmlType(Namespace = "http://exception.core.jabba.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class IllegalParameterException : BusinessException
{
}
