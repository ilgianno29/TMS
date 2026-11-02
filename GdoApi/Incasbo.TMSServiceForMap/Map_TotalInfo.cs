using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.TMSServiceForMap;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "Map_TotalInfo", Namespace = "http://schemas.datacontract.org/2004/07/Incasbo")]
public class Map_TotalInfo : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private int? DurataGuidaField;

	[OptionalField]
	private int? DurataTotaleField;

	[OptionalField]
	private decimal? KmTotaliField;

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
	public int? DurataGuida
	{
		get
		{
			return DurataGuidaField;
		}
		set
		{
			if (!DurataGuidaField.Equals(value))
			{
				DurataGuidaField = value;
				RaisePropertyChanged("DurataGuida");
			}
		}
	}

	[DataMember]
	public int? DurataTotale
	{
		get
		{
			return DurataTotaleField;
		}
		set
		{
			if (!DurataTotaleField.Equals(value))
			{
				DurataTotaleField = value;
				RaisePropertyChanged("DurataTotale");
			}
		}
	}

	[DataMember]
	public decimal? KmTotali
	{
		get
		{
			return KmTotaliField;
		}
		set
		{
			if (!KmTotaliField.Equals(value))
			{
				KmTotaliField = value;
				RaisePropertyChanged("KmTotali");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
