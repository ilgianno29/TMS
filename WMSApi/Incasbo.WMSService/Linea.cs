using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.WMSService;

[Serializable]
[DataContract(Name = "Linea", Namespace = "http://schemas.datacontract.org/2004/07/Incas.EasyStor.Host.Tms")]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DebuggerStepThrough]
public class Linea : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private int CodiceField;

	[OptionalField]
	private DateTime DataPreparazioneField;

	[OptionalField]
	private string GiroField;

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
	public int Codice
	{
		get
		{
			return CodiceField;
		}
		set
		{
			if (!CodiceField.Equals(value))
			{
				CodiceField = value;
				RaisePropertyChanged("Codice");
			}
		}
	}

	[DataMember]
	public DateTime DataPreparazione
	{
		get
		{
			return DataPreparazioneField;
		}
		set
		{
			if (!DataPreparazioneField.Equals(value))
			{
				DataPreparazioneField = value;
				RaisePropertyChanged("DataPreparazione");
			}
		}
	}

	[DataMember]
	public string Giro
	{
		get
		{
			return GiroField;
		}
		set
		{
			if (!object.ReferenceEquals(GiroField, value))
			{
				GiroField = value;
				RaisePropertyChanged("Giro");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
