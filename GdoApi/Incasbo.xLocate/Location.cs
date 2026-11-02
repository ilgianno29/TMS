using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[Serializable]
[XmlInclude(typeof(PoiLocation))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xlocate.xserver.ptvag.com")]
public class Location : TransientVO
{
	private Point coordinateField;

	[XmlElement(IsNullable = true, Order = 0)]
	public Point coordinate
	{
		get
		{
			return coordinateField;
		}
		set
		{
			coordinateField = value;
			RaisePropertyChanged("coordinate");
		}
	}
}
