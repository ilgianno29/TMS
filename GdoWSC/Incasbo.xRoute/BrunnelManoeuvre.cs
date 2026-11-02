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
public class BrunnelManoeuvre : TransientVO
{
	private int brunnelDistField;

	private int brunnelEndIdxField;

	private int brunnelIdxField;

	[XmlAttribute]
	public int brunnelDist
	{
		get
		{
			return brunnelDistField;
		}
		set
		{
			brunnelDistField = value;
			RaisePropertyChanged("brunnelDist");
		}
	}

	[XmlAttribute]
	public int brunnelEndIdx
	{
		get
		{
			return brunnelEndIdxField;
		}
		set
		{
			brunnelEndIdxField = value;
			RaisePropertyChanged("brunnelEndIdx");
		}
	}

	[XmlAttribute]
	public int brunnelIdx
	{
		get
		{
			return brunnelIdxField;
		}
		set
		{
			brunnelIdxField = value;
			RaisePropertyChanged("brunnelIdx");
		}
	}
}
