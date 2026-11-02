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
public class DynamicInfo : TransientVO
{
	private int distanceDiffField;

	private bool distanceDiffFieldSpecified;

	private int timeBenefitField;

	private int timeLossField;

	private int timeLoss2Field;

	[XmlAttribute]
	public int distanceDiff
	{
		get
		{
			return distanceDiffField;
		}
		set
		{
			distanceDiffField = value;
			RaisePropertyChanged("distanceDiff");
		}
	}

	[XmlIgnore]
	public bool distanceDiffSpecified
	{
		get
		{
			return distanceDiffFieldSpecified;
		}
		set
		{
			distanceDiffFieldSpecified = value;
			RaisePropertyChanged("distanceDiffSpecified");
		}
	}

	[XmlAttribute]
	public int timeBenefit
	{
		get
		{
			return timeBenefitField;
		}
		set
		{
			timeBenefitField = value;
			RaisePropertyChanged("timeBenefit");
		}
	}

	[XmlAttribute]
	public int timeLoss
	{
		get
		{
			return timeLossField;
		}
		set
		{
			timeLossField = value;
			RaisePropertyChanged("timeLoss");
		}
	}

	[XmlAttribute]
	public int timeLoss2
	{
		get
		{
			return timeLoss2Field;
		}
		set
		{
			timeLoss2Field = value;
			RaisePropertyChanged("timeLoss2");
		}
	}
}
