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
public class Return : CFComponentSkeleton
{
	private string esitoField;

	private string messaggioField;

	[XmlElement(IsNullable = true)]
	public string esito
	{
		get
		{
			return esitoField;
		}
		set
		{
			esitoField = value;
		}
	}

	[XmlElement(IsNullable = true)]
	public string messaggio
	{
		get
		{
			return messaggioField;
		}
		set
		{
			messaggioField = value;
		}
	}
}
