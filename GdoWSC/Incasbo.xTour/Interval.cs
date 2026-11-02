using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class Interval : TransientVO
{
	private int fromField;

	private int tillField;

	[XmlAttribute]
	public int from
	{
		get
		{
			return fromField;
		}
		set
		{
			fromField = value;
			RaisePropertyChanged("from");
		}
	}

	[XmlAttribute]
	public int till
	{
		get
		{
			return tillField;
		}
		set
		{
			tillField = value;
			RaisePropertyChanged("till");
		}
	}
}
