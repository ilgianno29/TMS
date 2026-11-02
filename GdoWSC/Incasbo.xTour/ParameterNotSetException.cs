using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://exception.core.jabba.ptvag.com")]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
public class ParameterNotSetException : IllegalParameterException
{
}
