using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class VehicleOption : TransientVO
{
	private VehicleParameter parameterField;

	private string valueField;

	[XmlAttribute]
	public VehicleParameter parameter
	{
		get
		{
			return parameterField;
		}
		set
		{
			parameterField = value;
			RaisePropertyChanged("parameter");
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
