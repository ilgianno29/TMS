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
public class Suggestion : TransientVO
{
	private AdditionalField[] wrappedAdditionalFieldsField;

	private string textField;

	[XmlArray(IsNullable = true, Order = 0)]
	public AdditionalField[] wrappedAdditionalFields
	{
		get
		{
			return wrappedAdditionalFieldsField;
		}
		set
		{
			wrappedAdditionalFieldsField = value;
			RaisePropertyChanged("wrappedAdditionalFields");
		}
	}

	[XmlAttribute]
	public string text
	{
		get
		{
			return textField;
		}
		set
		{
			textField = value;
			RaisePropertyChanged("text");
		}
	}
}
