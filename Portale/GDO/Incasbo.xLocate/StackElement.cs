using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://exception.core.jabba.ptvag.com")]
public class StackElement : INotifyPropertyChanged
{
	private StackElement causeField;

	private string[] wrappedContextField;

	private string classNameField;

	private string errorKeyField;

	private string messageField;

	[XmlElement(IsNullable = true, Order = 0)]
	public StackElement cause
	{
		get
		{
			return causeField;
		}
		set
		{
			causeField = value;
			RaisePropertyChanged("cause");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
	[XmlArrayItem("String", Namespace = "http://wrappertypes.service.jabba.ptvag.com")]
	public string[] wrappedContext
	{
		get
		{
			return wrappedContextField;
		}
		set
		{
			wrappedContextField = value;
			RaisePropertyChanged("wrappedContext");
		}
	}

	[XmlAttribute]
	public string className
	{
		get
		{
			return classNameField;
		}
		set
		{
			classNameField = value;
			RaisePropertyChanged("className");
		}
	}

	[XmlAttribute]
	public string errorKey
	{
		get
		{
			return errorKeyField;
		}
		set
		{
			errorKeyField = value;
			RaisePropertyChanged("errorKey");
		}
	}

	[XmlAttribute]
	public string message
	{
		get
		{
			return messageField;
		}
		set
		{
			messageField = value;
			RaisePropertyChanged("message");
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
