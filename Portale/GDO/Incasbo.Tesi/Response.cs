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
public class Response : CFComponentSkeleton
{
	private Return returnField;

	[XmlElement(IsNullable = true)]
	public Return @return
	{
		get
		{
			return returnField;
		}
		set
		{
			returnField = value;
		}
	}
}
