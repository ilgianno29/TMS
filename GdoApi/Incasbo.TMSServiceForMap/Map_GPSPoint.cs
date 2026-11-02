using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.TMSServiceForMap;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "Map_GPSPoint", Namespace = "http://schemas.datacontract.org/2004/07/Incasbo")]
public class Map_GPSPoint : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private string CodiceField;

	[OptionalField]
	private DateTime? DataArrivoField;

	[OptionalField]
	private DateTime? DataPartenzaField;

	[OptionalField]
	private string DescrizioneField;

	[OptionalField]
	private string IdOrdineField;

	[OptionalField]
	private decimal KmField;

	[OptionalField]
	private string LatitudineField;

	[OptionalField]
	private string LongitudineField;

	[OptionalField]
	private int SecondiCaricoScaricoField;

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
	public DateTime? DataArrivo
	{
		get
		{
			return DataArrivoField;
		}
		set
		{
			if (!DataArrivoField.Equals(value))
			{
				DataArrivoField = value;
				RaisePropertyChanged("DataArrivo");
			}
		}
	}

	[DataMember]
	public DateTime? DataPartenza
	{
		get
		{
			return DataPartenzaField;
		}
		set
		{
			if (!DataPartenzaField.Equals(value))
			{
				DataPartenzaField = value;
				RaisePropertyChanged("DataPartenza");
			}
		}
	}

	[DataMember]
	public string Descrizione
	{
		get
		{
			return DescrizioneField;
		}
		set
		{
			if (!object.ReferenceEquals(DescrizioneField, value))
			{
				DescrizioneField = value;
				RaisePropertyChanged("Descrizione");
			}
		}
	}

	[DataMember]
	public string IdOrdine
	{
		get
		{
			return IdOrdineField;
		}
		set
		{
			if (!object.ReferenceEquals(IdOrdineField, value))
			{
				IdOrdineField = value;
				RaisePropertyChanged("IdOrdine");
			}
		}
	}

	[DataMember]
	public decimal Km
	{
		get
		{
			return KmField;
		}
		set
		{
			if (!KmField.Equals(value))
			{
				KmField = value;
				RaisePropertyChanged("Km");
			}
		}
	}

	[DataMember]
	public string Latitudine
	{
		get
		{
			return LatitudineField;
		}
		set
		{
			if (!object.ReferenceEquals(LatitudineField, value))
			{
				LatitudineField = value;
				RaisePropertyChanged("Latitudine");
			}
		}
	}

	[DataMember]
	public string Longitudine
	{
		get
		{
			return LongitudineField;
		}
		set
		{
			if (!object.ReferenceEquals(LongitudineField, value))
			{
				LongitudineField = value;
				RaisePropertyChanged("Longitudine");
			}
		}
	}

	[DataMember]
	public int SecondiCaricoScarico
	{
		get
		{
			return SecondiCaricoScaricoField;
		}
		set
		{
			if (!SecondiCaricoScaricoField.Equals(value))
			{
				SecondiCaricoScaricoField = value;
				RaisePropertyChanged("SecondiCaricoScarico");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
