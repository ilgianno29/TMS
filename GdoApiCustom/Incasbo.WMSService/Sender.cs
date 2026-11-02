using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Incasbo.WMSService;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "Sender", Namespace = "http://schemas.datacontract.org/2004/07/Incas.EasyStor.Host.Tms")]
public class Sender : IExtensibleDataObject, INotifyPropertyChanged
{
	[NonSerialized]
	private ExtensionDataObject extensionDataField;

	[OptionalField]
	private string NameField;

	[OptionalField]
	private string ProfileField;

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
	public string Name
	{
		get
		{
			return NameField;
		}
		set
		{
			if (!object.ReferenceEquals(NameField, value))
			{
				NameField = value;
				RaisePropertyChanged("Name");
			}
		}
	}

	[DataMember(EmitDefaultValue = false)]
	public string Profile
	{
		get
		{
			return ProfileField;
		}
		set
		{
			if (!object.ReferenceEquals(ProfileField, value))
			{
				ProfileField = value;
				RaisePropertyChanged("Profile");
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void RaisePropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
