using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public class ReachableObjectDescr : TransientVO
{
	private Point coordField;

	private string idField;

	[XmlElement(IsNullable = true, Order = 0)]
	public Point coord
	{
		get
		{
			return coordField;
		}
		set
		{
			coordField = value;
			RaisePropertyChanged("coord");
		}
	}

	[XmlAttribute]
	public string id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
			RaisePropertyChanged("id");
		}
	}
}
