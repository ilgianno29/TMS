using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlInclude(typeof(CreateException))]
[XmlInclude(typeof(FinderException))]
[XmlInclude(typeof(DatabaseException))]
[XmlInclude(typeof(ObjectNotFoundException))]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(ConstraintViolationException))]
[XmlInclude(typeof(TableNotFoundException))]
[XmlType(Namespace = "http://exception.core.jabba.ptvag.com")]
[XmlInclude(typeof(UnexpectedException))]
[XmlInclude(typeof(OptimisticRollbackException))]
[XmlInclude(typeof(RemoteAccessException))]
[XmlInclude(typeof(DuplicateKeyException))]
[XmlInclude(typeof(RemoveException))]
public class SystemException : BaseException
{
}
