using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.WMSService;

[Serializable]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "RaggruppamentoOrdiniArgs", Namespace = "http://schemas.datacontract.org/2004/07/Incas.EasyStor.Host.Tms")]
[DebuggerStepThrough]
public class RaggruppamentoOrdiniArgs : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private int? AltezzaMezzoField;

	[OptionalField]
	private string CodiceRaggruppamentoField;

	[OptionalField]
	private TestataOrdine[] InOrdiniField;

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
	public int? AltezzaMezzo
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
	public string CodiceRaggruppamento
	{
		get
		{
			return CodiceRaggruppamentoField;
		}
		set
		{
			if (!object.ReferenceEquals(CodiceRaggruppamentoField, value))
			{
				CodiceRaggruppamentoField = value;
				RaisePropertyChanged("CodiceRaggruppamento");
			}
		}
	}

	[DataMember]
	public TestataOrdine[] InOrdini
	{
		get
		{
			return InOrdiniField;
		}
		set
		{
			if (!object.ReferenceEquals(InOrdiniField, value))
			{
				InOrdiniField = value;
				RaisePropertyChanged("InOrdini");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
