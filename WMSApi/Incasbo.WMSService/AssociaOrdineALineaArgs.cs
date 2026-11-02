using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.WMSService;

[Serializable]
[DataContract(Name = "AssociaOrdineALineaArgs", Namespace = "http://schemas.datacontract.org/2004/07/Incas.EasyStor.Host.Tms")]
[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
public class AssociaOrdineALineaArgs : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private Linea InLineaField;

	[OptionalField]
	private TestataOrdine InOrdineField;

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
	public Linea InLinea
	{
		get
		{
			return InLineaField;
		}
		set
		{
			if (!object.ReferenceEquals(InLineaField, value))
			{
				InLineaField = value;
				RaisePropertyChanged("InLinea");
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

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
