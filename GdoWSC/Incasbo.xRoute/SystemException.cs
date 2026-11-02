using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlInclude(typeof(OptimisticRollbackException))]
[XmlInclude(typeof(CreateException))]
[XmlInclude(typeof(RemoveException))]
[XmlInclude(typeof(ObjectNotFoundException))]
[XmlInclude(typeof(FinderException))]
[XmlType(Namespace = "http://exception.core.jabba.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(ConstraintViolationException))]
[XmlInclude(typeof(DuplicateKeyException))]
[XmlInclude(typeof(DatabaseException))]
[XmlInclude(typeof(UnexpectedException))]
[XmlInclude(typeof(TableNotFoundException))]
[XmlInclude(typeof(RemoteAccessException))]
public class SystemException : BaseException
{
}
