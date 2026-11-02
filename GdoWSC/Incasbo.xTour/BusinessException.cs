using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[XmlInclude(typeof(XTourException))]
[DesignerCategory("code")]
[XmlInclude(typeof(IllegalParameterException))]
[XmlType(Namespace = "http://exception.core.jabba.ptvag.com")]
[XmlInclude(typeof(XServiceException))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(ParameterNotSetException))]
public class BusinessException : BaseException
{
}
