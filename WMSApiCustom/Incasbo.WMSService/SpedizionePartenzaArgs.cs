using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.WMSService;

[Serializable]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "SpedizionePartenzaArgs", Namespace = "http://schemas.datacontract.org/2004/07/Incas.EasyStor.Host.Tms")]
[DebuggerStepThrough]
public class SpedizionePartenzaArgs : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private string InOptionsField;

	[OptionalField]
	private Spedizione InSpedizioneField;

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
	public string InOptions
	{
		get
		{
			return InOptionsField;
		}
		set
		{
			if (!object.ReferenceEquals(InOptionsField, value))
			{
				InOptionsField = value;
				RaisePropertyChanged("InOptions");
			}
		}
	}

	[DataMember]
	public Spedizione InSpedizione
	{
		get
		{
			return InSpedizioneField;
		}
		set
		{
			if (!object.ReferenceEquals(InSpedizioneField, value))
			{
				InSpedizioneField = value;
				RaisePropertyChanged("InSpedizione");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
