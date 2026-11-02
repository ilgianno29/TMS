using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(XServiceException))]
[XmlInclude(typeof(IllegalParameterException))]
[XmlInclude(typeof(ParameterNotSetException))]
[XmlInclude(typeof(XRouteException))]
[XmlType(Namespace = "http://exception.core.jabba.ptvag.com")]
[DesignerCategory("code")]
public class BusinessException : BaseException
{
}
