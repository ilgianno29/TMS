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
public class CombinedTransportResponse : TransientVO
{
	private ResultCombinedTransport[] wrappedResultListField;

	private int errorCodeField;

	private string errorDescriptionField;

	[XmlArray(IsNullable = true, Order = 0)]
	public ResultCombinedTransport[] wrappedResultList
	{
		get
		{
			return wrappedResultListField;
		}
		set
		{
			wrappedResultListField = value;
			RaisePropertyChanged("wrappedResultList");
		}
	}

	[XmlAttribute]
	public int errorCode
	{
		get
		{
			return errorCodeField;
		}
		set
		{
			errorCodeField = value;
			RaisePropertyChanged("errorCode");
		}
	}

	[XmlAttribute]
	public string errorDescription
	{
		get
		{
			return errorDescriptionField;
		}
		set
		{
			errorDescriptionField = value;
			RaisePropertyChanged("errorDescription");
		}
	}
}
