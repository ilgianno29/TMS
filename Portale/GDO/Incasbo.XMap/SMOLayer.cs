using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xmap.xserver.ptvag.com")]
public class SMOLayer : Layer
{
	private string configurationField;

	private ObjectInfoType objectInfosField;

	private byte[] smoDataField;

	[XmlAttribute]
	public string configuration
	{
		get
		{
			return configurationField;
		}
		set
		{
			configurationField = value;
			RaisePropertyChanged("configuration");
		}
	}

	[XmlAttribute]
	public ObjectInfoType objectInfos
	{
		get
		{
			return objectInfosField;
		}
		set
		{
			objectInfosField = value;
			RaisePropertyChanged("objectInfos");
		}
	}

	[XmlAttribute(DataType = "base64Binary")]
	public byte[] smoData
	{
		get
		{
			return smoDataField;
		}
		set
		{
			smoDataField = value;
			RaisePropertyChanged("smoData");
		}
	}
}
