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
public class GeometryOption : TransientVO
{
	private GeometryOptions optionField;

	private string valueField;

	[XmlAttribute]
	public GeometryOptions option
	{
		get
		{
			return optionField;
		}
		set
		{
			optionField = value;
			RaisePropertyChanged("option");
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
