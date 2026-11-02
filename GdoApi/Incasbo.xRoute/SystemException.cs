using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlInclude(typeof(FinderException))]
[XmlInclude(typeof(ObjectNotFoundException))]
[XmlInclude(typeof(RemoveException))]
[XmlInclude(typeof(CreateException))]
[XmlInclude(typeof(DuplicateKeyException))]
[XmlInclude(typeof(RemoteAccessException))]
[XmlInclude(typeof(OptimisticRollbackException))]
[XmlInclude(typeof(UnexpectedException))]
[XmlInclude(typeof(DatabaseException))]
[XmlInclude(typeof(TableNotFoundException))]
[XmlInclude(typeof(ConstraintViolationException))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://exception.core.jabba.ptvag.com")]
public class SystemException : BaseException
{
}
