using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.WMSService;

[Serializable]
[DataContract(Name = "AggregazioneOrdineBatchArgs", Namespace = "http://schemas.datacontract.org/2004/07/Incas.EasyStor.Host.Tms")]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DebuggerStepThrough]
public class AggregazioneOrdineBatchArgs : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private Batch InBatchField;

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
	public Batch InBatch
	{
		get
		{
			return InBatchField;
		}
		set
		{
			if (!object.ReferenceEquals(InBatchField, value))
			{
				InBatchField = value;
				RaisePropertyChanged("InBatch");
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
