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
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
public class LinearRing : EncodedGeometry
{
	private PlainLinearRing linearRingField;

	[XmlElement(IsNullable = true, Order = 0)]
	public PlainLinearRing linearRing
	{
		get
		{
			return linearRingField;
		}
		set
		{
			linearRingField = value;
			RaisePropertyChanged("linearRing");
		}
	}
}
