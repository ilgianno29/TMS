using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[XmlInclude(typeof(FeatureLayer))]
[XmlInclude(typeof(RoadEditorLayer))]
[XmlInclude(typeof(GeometryLayer))]
[XmlInclude(typeof(SMOLayer))]
[XmlInclude(typeof(CustomLayer))]
[XmlInclude(typeof(StaticLayer))]
[XmlInclude(typeof(StaticRasterLayer))]
[XmlInclude(typeof(StaticPoiLayer))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xmap.xserver.ptvag.com")]
public abstract class Layer : TransientVO
{
	private string nameField;

	private bool visibleField;

	[XmlAttribute]
	public string name
	{
		get
		{
			return nameField;
		}
		set
		{
			nameField = value;
			RaisePropertyChanged("name");
		}
	}

	[XmlAttribute]
	public bool visible
	{
		get
		{
			return visibleField;
		}
		set
		{
			visibleField = value;
			RaisePropertyChanged("visible");
		}
	}
}
