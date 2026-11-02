using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class ManoeuvreAttributes : TransientVO
{
	private bool isBlockingEndField;

	private bool isBlockingStartField;

	private bool isBorderField;

	private bool isBrunnelEndField;

	private bool isBrunnelStartField;

	private bool isUrbanEndField;

	private bool isUrbanStartField;

	private bool tollRoadEndField;

	private bool tollRoadStartField;

	[XmlAttribute]
	public bool isBlockingEnd
	{
		get
		{
			return isBlockingEndField;
		}
		set
		{
			isBlockingEndField = value;
			RaisePropertyChanged("isBlockingEnd");
		}
	}

	[XmlAttribute]
	public bool isBlockingStart
	{
		get
		{
			return isBlockingStartField;
		}
		set
		{
			isBlockingStartField = value;
			RaisePropertyChanged("isBlockingStart");
		}
	}

	[XmlAttribute]
	public bool isBorder
	{
		get
		{
			return isBorderField;
		}
		set
		{
			isBorderField = value;
			RaisePropertyChanged("isBorder");
		}
	}

	[XmlAttribute]
	public bool isBrunnelEnd
	{
		get
		{
			return isBrunnelEndField;
		}
		set
		{
			isBrunnelEndField = value;
			RaisePropertyChanged("isBrunnelEnd");
		}
	}

	[XmlAttribute]
	public bool isBrunnelStart
	{
		get
		{
			return isBrunnelStartField;
		}
		set
		{
			isBrunnelStartField = value;
			RaisePropertyChanged("isBrunnelStart");
		}
	}

	[XmlAttribute]
	public bool isUrbanEnd
	{
		get
		{
			return isUrbanEndField;
		}
		set
		{
			isUrbanEndField = value;
			RaisePropertyChanged("isUrbanEnd");
		}
	}

	[XmlAttribute]
	public bool isUrbanStart
	{
		get
		{
			return isUrbanStartField;
		}
		set
		{
			isUrbanStartField = value;
			RaisePropertyChanged("isUrbanStart");
		}
	}

	[XmlAttribute]
	public bool tollRoadEnd
	{
		get
		{
			return tollRoadEndField;
		}
		set
		{
			tollRoadEndField = value;
			RaisePropertyChanged("tollRoadEnd");
		}
	}

	[XmlAttribute]
	public bool tollRoadStart
	{
		get
		{
			return tollRoadStartField;
		}
		set
		{
			tollRoadStartField = value;
			RaisePropertyChanged("tollRoadStart");
		}
	}
}
