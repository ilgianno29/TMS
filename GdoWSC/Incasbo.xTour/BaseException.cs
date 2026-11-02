using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(OptimisticRollbackException))]
[XmlInclude(typeof(RemoteAccessException))]
[XmlInclude(typeof(DuplicateKeyException))]
[XmlInclude(typeof(XTourException))]
[XmlType(Namespace = "http://exception.core.jabba.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[XmlInclude(typeof(ConstraintViolationException))]
[XmlInclude(typeof(TableNotFoundException))]
[XmlInclude(typeof(DatabaseException))]
[XmlInclude(typeof(UnexpectedException))]
[XmlInclude(typeof(BusinessException))]
[XmlInclude(typeof(CreateException))]
[XmlInclude(typeof(RemoveException))]
[XmlInclude(typeof(ObjectNotFoundException))]
[XmlInclude(typeof(FinderException))]
[XmlInclude(typeof(SystemException))]
[XmlInclude(typeof(ParameterNotSetException))]
[XmlInclude(typeof(IllegalParameterException))]
[XmlInclude(typeof(XServiceException))]
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
