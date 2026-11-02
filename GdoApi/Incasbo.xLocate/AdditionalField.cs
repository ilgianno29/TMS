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
public class AdditionalField : TransientVO
{
	private ResultField fieldField;

	private string valueField;

	[XmlAttribute]
	public ResultField field
	{
		get
		{
			return fieldField;
		}
		set
		{
			fieldField = value;
			RaisePropertyChanged("field");
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
