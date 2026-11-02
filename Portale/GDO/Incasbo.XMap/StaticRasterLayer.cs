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
public class StaticRasterLayer : StaticLayer
{
	private DrawPositions drawPositionField;

	[XmlAttribute]
	public DrawPositions drawPosition
	{
		get
		{
			return drawPositionField;
		}
		set
		{
			drawPositionField = value;
			RaisePropertyChanged("drawPosition");
		}
	}
}
