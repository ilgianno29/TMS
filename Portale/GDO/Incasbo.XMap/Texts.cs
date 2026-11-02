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
public class Texts : TransientVO
{
	private TextOptions optionsField;

	private Text[] wrappedTextsField;

	[XmlElement(IsNullable = true, Order = 0)]
	public TextOptions options
	{
		get
		{
			return optionsField;
		}
		set
		{
			optionsField = value;
			RaisePropertyChanged("options");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
	public Text[] wrappedTexts
	{
		get
		{
			return wrappedTextsField;
		}
		set
		{
			wrappedTextsField = value;
			RaisePropertyChanged("wrappedTexts");
		}
	}
}
