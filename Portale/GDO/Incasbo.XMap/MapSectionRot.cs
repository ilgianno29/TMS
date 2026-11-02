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
public class MapSectionRot : MapSection
{
	private int angleField;

	[XmlAttribute]
	public int angle
	{
		get
		{
			return angleField;
		}
		set
		{
			angleField = value;
			RaisePropertyChanged("angle");
		}
	}
}
