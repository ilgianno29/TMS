using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.WMSService;

[Serializable]
[DataContract(Name = "AssociaOrdiniASpedizioneArgs", Namespace = "http://schemas.datacontract.org/2004/07/Incas.EasyStor.Host.Tms")]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DebuggerStepThrough]
public class AssociaOrdiniASpedizioneArgs : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private TestataOrdine[] InOrdiniField;

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
	public TestataOrdine[] InOrdini
	{
		get
		{
			return InOrdiniField;
		}
		set
		{
			if (!object.ReferenceEquals(InOrdiniField, value))
			{
				InOrdiniField = value;
				RaisePropertyChanged("InOrdini");
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
