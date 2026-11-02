using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class HBEFAType : TransientVO
{
	private HBEFAVersion versionField;

	[XmlAttribute]
	public HBEFAVersion version
	{
		get
		{
			return versionField;
		}
		set
		{
			versionField = value;
			RaisePropertyChanged("version");
		}
	}
}
