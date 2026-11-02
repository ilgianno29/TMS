using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xlocate.xserver.ptvag.com")]
public class ResultObject : TransientVO
{
	private ResultAddress addressField;

	private ResultCombinedTransport combinedTransportField;

	[XmlElement(IsNullable = true, Order = 0)]
	public ResultAddress address
	{
		get
		{
			return addressField;
		}
		set
		{
			addressField = value;
			RaisePropertyChanged("address");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public ResultCombinedTransport combinedTransport
	{
		get
		{
			return combinedTransportField;
		}
		set
		{
			combinedTransportField = value;
			RaisePropertyChanged("combinedTransport");
		}
	}
}
