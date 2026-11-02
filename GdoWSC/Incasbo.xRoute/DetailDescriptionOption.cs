using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DesignerCategory("code")]
public class DetailDescriptionOption : TransientVO
{
	private DetailLevel minLevelField;

	private int radiusField;

	[XmlAttribute]
	public DetailLevel minLevel
	{
		get
		{
			return minLevelField;
		}
		set
		{
			minLevelField = value;
			RaisePropertyChanged("minLevel");
		}
	}

	[XmlAttribute]
	public int radius
	{
		get
		{
			return radiusField;
		}
		set
		{
			radiusField = value;
			RaisePropertyChanged("radius");
		}
	}
}
