using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.WMSService;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "AssociaOrdineASpedizioneArgs", Namespace = "http://schemas.datacontract.org/2004/07/Incas.EasyStor.Host.Tms")]
public class AssociaOrdineASpedizioneArgs : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private bool ForzaDeAssociazioneField;

	[OptionalField]
	private TestataOrdine InOrdineField;

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
	public bool ForzaDeAssociazione
	{
		get
		{
			return ForzaDeAssociazioneField;
		}
		set
		{
			if (!ForzaDeAssociazioneField.Equals(value))
			{
				ForzaDeAssociazioneField = value;
				RaisePropertyChanged("ForzaDeAssociazione");
			}
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
