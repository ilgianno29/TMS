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
public class UniqueGeoID : TransientVO
{
	private int iuCodeField;

	private int nField;

	private long tIDField;

	private int xOffField;

	private int yOffField;

	[XmlAttribute]
	public int iuCode
	{
		get
		{
			return iuCodeField;
		}
		set
		{
			iuCodeField = value;
			RaisePropertyChanged("iuCode");
		}
	}

	[XmlAttribute]
	public int n
	{
		get
		{
			return nField;
		}
		set
		{
			nField = value;
			RaisePropertyChanged("n");
		}
	}

	[XmlAttribute]
	public long tID
	{
		get
		{
			return tIDField;
		}
		set
		{
			tIDField = value;
			RaisePropertyChanged("tID");
		}
	}

	[XmlAttribute]
	public int xOff
	{
		get
		{
			return xOffField;
		}
		set
		{
			xOffField = value;
			RaisePropertyChanged("xOff");
		}
	}

	[XmlAttribute]
	public int yOff
	{
		get
		{
			return yOffField;
		}
		set
		{
			yOffField = value;
			RaisePropertyChanged("yOff");
		}
	}
}
