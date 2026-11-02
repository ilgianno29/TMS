using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[Serializable]
[XmlInclude(typeof(XLocateException))]
[XmlInclude(typeof(XServiceException))]
[XmlInclude(typeof(IllegalParameterException))]
[XmlInclude(typeof(ParameterNotSetException))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://exception.core.jabba.ptvag.com")]
public class BusinessException : BaseException
{
}
