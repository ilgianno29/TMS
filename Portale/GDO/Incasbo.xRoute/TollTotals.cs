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
public class TollTotals : TransientVO
{
	private int costField;

	private int distanceField;

	[XmlAttribute]
	public int cost
	{
		get
		{
			return costField;
		}
		set
		{
			costField = value;
			RaisePropertyChanged("cost");
		}
	}

	[XmlAttribute]
	public int distance
	{
		get
		{
			return distanceField;
		}
		set
		{
			distanceField = value;
			RaisePropertyChanged("distance");
		}
	}
}
