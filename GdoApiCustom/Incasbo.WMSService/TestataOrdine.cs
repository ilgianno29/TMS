using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.WMSService;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "TestataOrdine", Namespace = "http://schemas.datacontract.org/2004/07/Incas.EasyStor.Host.Tms")]
public class TestataOrdine : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private string CommittenteField;

	[OptionalField]
	private DateTime DataField;

	[OptionalField]
	private string OrdineField;

	[OptionalField]
	private string SkidField;

	[OptionalField]
	private string VersioneField;

	[OptionalField]
	private string VettoreField;

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
	public string Committente
	{
		get
		{
			return CommittenteField;
		}
		set
		{
			if (!object.ReferenceEquals(CommittenteField, value))
			{
				CommittenteField = value;
				RaisePropertyChanged("Committente");
			}
		}
	}

	[DataMember]
	public DateTime Data
	{
		get
		{
			return DataField;
		}
		set
		{
			if (!DataField.Equals(value))
			{
				DataField = value;
				RaisePropertyChanged("Data");
			}
		}
	}

	[DataMember]
	public string Ordine
	{
		get
		{
			return OrdineField;
		}
		set
		{
			if (!object.ReferenceEquals(OrdineField, value))
			{
				OrdineField = value;
				RaisePropertyChanged("Ordine");
			}
		}
	}

	[DataMember]
	public string Skid
	{
		get
		{
			return SkidField;
		}
		set
		{
			if (!object.ReferenceEquals(SkidField, value))
			{
				SkidField = value;
				RaisePropertyChanged("Skid");
			}
		}
	}

	[DataMember]
	public string Versione
	{
		get
		{
			return VersioneField;
		}
		set
		{
			if (!object.ReferenceEquals(VersioneField, value))
			{
				VersioneField = value;
				RaisePropertyChanged("Versione");
			}
		}
	}

	[DataMember]
	public string Vettore
	{
		get
		{
			return VettoreField;
		}
		set
		{
			if (!object.ReferenceEquals(VettoreField, value))
			{
				VettoreField = value;
				RaisePropertyChanged("Vettore");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
