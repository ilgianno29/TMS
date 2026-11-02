using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DesignerCategory("code")]
[XmlInclude(typeof(ConstraintViolationException))]
[XmlInclude(typeof(TableNotFoundException))]
[XmlType(Namespace = "http://exception.core.jabba.ptvag.com")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class DatabaseException : SystemException
{
}
