using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.WMSService;

[Serializable]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "ConcludiImportazioneOrdineArgs", Namespace = "http://schemas.datacontract.org/2004/07/Incas.EasyStor.Host.Tms")]
[DebuggerStepThrough]
public class ConcludiImportazioneOrdineArgs : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private string InErroreImportTmsField;

	[OptionalField]
	private bool InGestioneWmsField;

	[OptionalField]
	private TestataOrdine InOrdineField;

	[OptionalField]
	private int InTransmissionRecordIdField;

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
	public string InErroreImportTms
	{
		get
		{
			return InErroreImportTmsField;
		}
		set
		{
			if (!object.ReferenceEquals(InErroreImportTmsField, value))
			{
				InErroreImportTmsField = value;
				RaisePropertyChanged("InErroreImportTms");
			}
		}
	}

	[DataMember]
	public bool InGestioneWms
	{
		get
		{
			return InGestioneWmsField;
		}
		set
		{
			if (!InGestioneWmsField.Equals(value))
			{
				InGestioneWmsField = value;
				RaisePropertyChanged("InGestioneWms");
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
	public int InTransmissionRecordId
	{
		get
		{
			return InTransmissionRecordIdField;
		}
		set
		{
			if (!InTransmissionRecordIdField.Equals(value))
			{
				InTransmissionRecordIdField = value;
				RaisePropertyChanged("InTransmissionRecordId");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
