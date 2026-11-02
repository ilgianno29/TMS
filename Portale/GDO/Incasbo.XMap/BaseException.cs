using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[XmlInclude(typeof(BusinessException))]
[XmlInclude(typeof(IllegalParameterException))]
[XmlInclude(typeof(ParameterNotSetException))]
[XmlInclude(typeof(XServiceException))]
[XmlInclude(typeof(XMapException))]
[XmlInclude(typeof(SystemException))]
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
