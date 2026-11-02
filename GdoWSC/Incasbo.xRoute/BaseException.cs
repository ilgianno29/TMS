using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DesignerCategory("code")]
[XmlInclude(typeof(DuplicateKeyException))]
[XmlInclude(typeof(RemoveException))]
[XmlInclude(typeof(ObjectNotFoundException))]
[XmlInclude(typeof(FinderException))]
[XmlInclude(typeof(RemoteAccessException))]
[XmlInclude(typeof(XServiceException))]
[XmlInclude(typeof(ParameterNotSetException))]
[XmlInclude(typeof(IllegalParameterException))]
[XmlInclude(typeof(XRouteException))]
[XmlInclude(typeof(BusinessException))]
[XmlInclude(typeof(CreateException))]
[XmlType(Namespace = "http://exception.core.jabba.ptvag.com")]
[XmlInclude(typeof(SystemException))]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(ConstraintViolationException))]
[XmlInclude(typeof(TableNotFoundException))]
[XmlInclude(typeof(DatabaseException))]
[XmlInclude(typeof(UnexpectedException))]
[XmlInclude(typeof(OptimisticRollbackException))]
public class BaseException : INotifyPropertyChanged
{
	private StackElement stackElementField;

	private string transactionIdField;

	[XmlElement(IsNullable = true, Order = 0)]
	public StackElement stackElement
	{
		get
		{
			return stackElementField;
		}
		set
		{
			stackElementField = value;
			RaisePropertyChanged("stackElement");
		}
	}

	[XmlAttribute]
	public string transactionId
	{
		get
		{
			return transactionIdField;
		}
		set
		{
			transactionIdField = value;
			RaisePropertyChanged("transactionId");
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
