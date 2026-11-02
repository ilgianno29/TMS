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
public class SuggestionResponse : TransientVO
{
	private Suggestion[] wrappedSuggestionListField;

	private string errorDescriptionField;

	private int errorcodeField;

	[XmlArray(IsNullable = true, Order = 0)]
	public Suggestion[] wrappedSuggestionList
	{
		get
		{
			return wrappedSuggestionListField;
		}
		set
		{
			wrappedSuggestionListField = value;
			RaisePropertyChanged("wrappedSuggestionList");
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

	[XmlAttribute]
	public int errorcode
	{
		get
		{
			return errorcodeField;
		}
		set
		{
			errorcodeField = value;
			RaisePropertyChanged("errorcode");
		}
	}
}
