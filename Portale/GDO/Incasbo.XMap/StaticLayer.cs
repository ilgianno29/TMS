using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[XmlInclude(typeof(StaticRasterLayer))]
[XmlInclude(typeof(StaticPoiLayer))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xmap.xserver.ptvag.com")]
public class StaticLayer : Layer
{
	private int categoryField;

	private int detailLevelField;

	[XmlAttribute]
	public int category
	{
		get
		{
			return categoryField;
		}
		set
		{
			categoryField = value;
			RaisePropertyChanged("category");
		}
	}

	[XmlAttribute]
	public int detailLevel
	{
		get
		{
			return detailLevelField;
		}
		set
		{
			detailLevelField = value;
			RaisePropertyChanged("detailLevel");
		}
	}
}
