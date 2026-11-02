using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.WMSService;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "Batch", Namespace = "http://schemas.datacontract.org/2004/07/Incas.EasyStor.Host.Tms")]
public class Batch : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private string CodiceField;

	[OptionalField]
	private DateTime DataeOraPreparazioneField;

	[OptionalField]
	private string DescrizioneBatchField;

	[OptionalField]
	private string DescrizioneZonaSpedizioneField;

	[OptionalField]
	private string ZonaSpedizioneField;

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
	public string Codice
	{
		get
		{
			return CodiceField;
		}
		set
		{
			if (!object.ReferenceEquals(CodiceField, value))
			{
				CodiceField = value;
				RaisePropertyChanged("Codice");
			}
		}
	}

	[DataMember]
	public DateTime DataeOraPreparazione
	{
		get
		{
			return DataeOraPreparazioneField;
		}
		set
		{
			if (!DataeOraPreparazioneField.Equals(value))
			{
				DataeOraPreparazioneField = value;
				RaisePropertyChanged("DataeOraPreparazione");
			}
		}
	}

	[DataMember]
	public string DescrizioneBatch
	{
		get
		{
			return DescrizioneBatchField;
		}
		set
		{
			if (!object.ReferenceEquals(DescrizioneBatchField, value))
			{
				DescrizioneBatchField = value;
				RaisePropertyChanged("DescrizioneBatch");
			}
		}
	}

	[DataMember]
	public string DescrizioneZonaSpedizione
	{
		get
		{
			return DescrizioneZonaSpedizioneField;
		}
		set
		{
			if (!object.ReferenceEquals(DescrizioneZonaSpedizioneField, value))
			{
				DescrizioneZonaSpedizioneField = value;
				RaisePropertyChanged("DescrizioneZonaSpedizione");
			}
		}
	}

	[DataMember]
	public string ZonaSpedizione
	{
		get
		{
			return ZonaSpedizioneField;
		}
		set
		{
			if (!object.ReferenceEquals(ZonaSpedizioneField, value))
			{
				ZonaSpedizioneField = value;
				RaisePropertyChanged("ZonaSpedizione");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
