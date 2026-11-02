using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.WMSService;

[Serializable]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "Result", Namespace = "http://schemas.datacontract.org/2004/07/Incas.EasyStor.Host.Tms")]
[DebuggerStepThrough]
public class Result : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private bool GoodField;

	[OptionalField]
	private string ReasonField;

	[Browsable(false)]
	public ExtensionDataObject ExtensionData
	{
		get
		{
			return extensionDataField;
		}
		set
		{
			extensionDataField = value;
		}
	}

	[DataMember]
	public bool Good
	{
		get
		{
			return GoodField;
		}
		set
		{
			if (!GoodField.Equals(value))
			{
				GoodField = value;
				RaisePropertyChanged("Good");
			}
		}
	}

	[DataMember]
	public string Reason
	{
		get
		{
			return ReasonField;
		}
		set
		{
			if (!object.ReferenceEquals(ReasonField, value))
			{
				ReasonField = value;
				RaisePropertyChanged("Reason");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
