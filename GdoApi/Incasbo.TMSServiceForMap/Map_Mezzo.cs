using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.TMSServiceForMap;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "Map_Mezzo", Namespace = "http://schemas.datacontract.org/2004/07/Incasbo")]
public class Map_Mezzo : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private int IdDimaField;

	[OptionalField]
	private string ProfiloVelocitaField;

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
	public int IdDima
	{
		get
		{
			return IdDimaField;
		}
		set
		{
			if (!IdDimaField.Equals(value))
			{
				IdDimaField = value;
				RaisePropertyChanged("IdDima");
			}
		}
	}

	[DataMember]
	public string ProfiloVelocita
	{
		get
		{
			return ProfiloVelocitaField;
		}
		set
		{
			if (!object.ReferenceEquals(ProfiloVelocitaField, value))
			{
				ProfiloVelocitaField = value;
				RaisePropertyChanged("ProfiloVelocita");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
