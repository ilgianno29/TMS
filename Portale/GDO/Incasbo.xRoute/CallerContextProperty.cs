using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://baseservices.service.jabba.ptvag.com")]
public class CallerContextProperty : TransientVO
{
	private string keyField;

	private string valueField;

	[XmlAttribute]
	public string key
	{
		get
		{
			return keyField;
		}
		set
		{
			keyField = value;
			RaisePropertyChanged("key");
		}
	}

	[XmlAttribute]
	public string value
	{
		get
		{
			return valueField;
		}
		set
		{
			valueField = value;
			RaisePropertyChanged("value");
		}
	}
}
