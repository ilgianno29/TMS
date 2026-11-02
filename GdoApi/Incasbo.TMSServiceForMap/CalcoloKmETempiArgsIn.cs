using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.TMSServiceForMap;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "CalcoloKmETempiArgsIn", Namespace = "http://schemas.datacontract.org/2004/07/Incasbo")]
public class CalcoloKmETempiArgsIn : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private Map_GPSPoint[] GPSPointsField;

	[OptionalField]
	private Map_RoutingOptions RoutingOptionsField;

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
	public Map_RoutingOptions RoutingOptions
	{
		get
		{
			return RoutingOptionsField;
		}
		set
		{
			if (!object.ReferenceEquals(RoutingOptionsField, value))
			{
				RoutingOptionsField = value;
				RaisePropertyChanged("RoutingOptions");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
