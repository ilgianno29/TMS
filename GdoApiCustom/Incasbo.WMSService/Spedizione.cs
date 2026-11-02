using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.WMSService;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "Spedizione", Namespace = "http://schemas.datacontract.org/2004/07/Incas.EasyStor.Host.Tms")]
public class Spedizione : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private double AltezzaMezzoField;

	[OptionalField]
	private string CodiceField;

	[OptionalField]
	private DateTime DataRiferimentoField;

	[OptionalField]
	private string MagazzinoField;

	[OptionalField]
	private int PrioritàField;

	[OptionalField]
	private string TipoField;

	[OptionalField]
	private string VanoField;

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
	public double AltezzaMezzo
	{
		get
		{
			return AltezzaMezzoField;
		}
		set
		{
			if (!AltezzaMezzoField.Equals(value))
			{
				AltezzaMezzoField = value;
				RaisePropertyChanged("AltezzaMezzo");
			}
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
	public DateTime DataRiferimento
	{
		get
		{
			return DataRiferimentoField;
		}
		set
		{
			if (!DataRiferimentoField.Equals(value))
			{
				DataRiferimentoField = value;
				RaisePropertyChanged("DataRiferimento");
			}
		}
	}

	[DataMember]
	public string Magazzino
	{
		get
		{
			return MagazzinoField;
		}
		set
		{
			if (!object.ReferenceEquals(MagazzinoField, value))
			{
				MagazzinoField = value;
				RaisePropertyChanged("Magazzino");
			}
		}
	}

	[DataMember]
	public int Priorità
	{
		get
		{
			return PrioritàField;
		}
		set
		{
			if (!PrioritàField.Equals(value))
			{
				PrioritàField = value;
				RaisePropertyChanged("Priorità");
			}
		}
	}

	[DataMember]
	public string Tipo
	{
		get
		{
			return TipoField;
		}
		set
		{
			if (!object.ReferenceEquals(TipoField, value))
			{
				TipoField = value;
				RaisePropertyChanged("Tipo");
			}
		}
	}

	[DataMember]
	public string Vano
	{
		get
		{
			return VanoField;
		}
		set
		{
			if (!object.ReferenceEquals(VanoField, value))
			{
				VanoField = value;
				RaisePropertyChanged("Vano");
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
