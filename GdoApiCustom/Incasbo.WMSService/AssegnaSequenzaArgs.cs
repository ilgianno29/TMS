using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.WMSService;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "AssegnaSequenzaArgs", Namespace = "http://schemas.datacontract.org/2004/07/Incas.EasyStor.Host.Tms")]
public class AssegnaSequenzaArgs : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private TestataOrdine InOrdineField;

	[OptionalField]
	private int InSequenzaConsegnaField;

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
	public TestataOrdine InOrdine
	{
		get
		{
			return InOrdineField;
		}
		set
		{
			if (!object.ReferenceEquals(InOrdineField, value))
			{
				InOrdineField = value;
				RaisePropertyChanged("InOrdine");
			}
		}
	}

	[DataMember]
	public int InSequenzaConsegna
	{
		get
		{
			return InSequenzaConsegnaField;
		}
		set
		{
			if (!InSequenzaConsegnaField.Equals(value))
			{
				InSequenzaConsegnaField = value;
				RaisePropertyChanged("InSequenzaConsegna");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
