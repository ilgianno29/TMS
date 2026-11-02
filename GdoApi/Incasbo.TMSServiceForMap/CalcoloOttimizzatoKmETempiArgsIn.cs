using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.TMSServiceForMap;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "CalcoloOttimizzatoKmETempiArgsIn", Namespace = "http://schemas.datacontract.org/2004/07/Incasbo")]
public class CalcoloOttimizzatoKmETempiArgsIn : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private Map_GPSPoint[] GPSPointsField;

	[OptionalField]
	private Map_GPSPoint GPSPoints_ArrivoField;

	[OptionalField]
	private Map_GPSPoint GPSPoints_PartenzaField;

	[OptionalField]
	private int IdViaggioField;

	[OptionalField]
	private Map_Mezzo VeicoloField;

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
	public Map_GPSPoint[] GPSPoints
	{
		get
		{
			return GPSPointsField;
		}
		set
		{
			if (!object.ReferenceEquals(GPSPointsField, value))
			{
				GPSPointsField = value;
				RaisePropertyChanged("GPSPoints");
			}
		}
	}

	[DataMember]
	public Map_GPSPoint GPSPoints_Arrivo
	{
		get
		{
			return GPSPoints_ArrivoField;
		}
		set
		{
			if (!object.ReferenceEquals(GPSPoints_ArrivoField, value))
			{
				GPSPoints_ArrivoField = value;
				RaisePropertyChanged("GPSPoints_Arrivo");
			}
		}
	}

	[DataMember]
	public Map_GPSPoint GPSPoints_Partenza
	{
		get
		{
			return GPSPoints_PartenzaField;
		}
		set
		{
			if (!object.ReferenceEquals(GPSPoints_PartenzaField, value))
			{
				GPSPoints_PartenzaField = value;
				RaisePropertyChanged("GPSPoints_Partenza");
			}
		}
	}

	[DataMember]
	public int IdViaggio
	{
		get
		{
			return IdViaggioField;
		}
		set
		{
			if (!IdViaggioField.Equals(value))
			{
				IdViaggioField = value;
				RaisePropertyChanged("IdViaggio");
			}
		}
	}

	[DataMember]
	public Map_Mezzo Veicolo
	{
		get
		{
			return VeicoloField;
		}
		set
		{
			if (!object.ReferenceEquals(VeicoloField, value))
			{
				VeicoloField = value;
				RaisePropertyChanged("Veicolo");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
