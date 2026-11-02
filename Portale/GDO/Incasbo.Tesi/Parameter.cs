using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.Tesi;

[Serializable]
[GeneratedCode("System.Xml", "4.8.9221.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://beans.inbound.webservices.cfc.lucart/xsd")]
public class Parameter : BaseBeanViaggio
{
	private string qualifierField;

	private string valueField;

	[XmlElement(IsNullable = true)]
	public string qualifier
	{
		get
		{
			return qualifierField;
		}
		set
		{
			qualifierField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string value
	{
		get
		{
			return valueField;
		}
		set
		{
			valueField = value;
		}
	}
}
