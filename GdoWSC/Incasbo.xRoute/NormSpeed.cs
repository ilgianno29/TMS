using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public class NormSpeed : TransientVO
{
	private int normSpeedField;

	private NormSpeedType normSpeedTypeField;

	[XmlAttribute]
	public int normSpeed
	{
		get
		{
			return normSpeedField;
		}
		set
		{
			normSpeedField = value;
			RaisePropertyChanged("normSpeed");
		}
	}

	[XmlAttribute]
	public NormSpeedType normSpeedType
	{
		get
		{
			return normSpeedTypeField;
		}
		set
		{
			normSpeedTypeField = value;
			RaisePropertyChanged("normSpeedType");
		}
	}
}
