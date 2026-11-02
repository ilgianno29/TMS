using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
public class TimeEvent : TransientVO
{
	private int periodField;

	private int segmentIdxField;

	private int startTimeField;

	private int tourPointIdxField;

	private TimeEventType typeField;

	[XmlAttribute]
	public int period
	{
		get
		{
			return periodField;
		}
		set
		{
			periodField = value;
			RaisePropertyChanged("period");
		}
	}

	[XmlAttribute]
	public int segmentIdx
	{
		get
		{
			return segmentIdxField;
		}
		set
		{
			segmentIdxField = value;
			RaisePropertyChanged("segmentIdx");
		}
	}

	[XmlAttribute]
	public int startTime
	{
		get
		{
			return startTimeField;
		}
		set
		{
			startTimeField = value;
			RaisePropertyChanged("startTime");
		}
	}

	[XmlAttribute]
	public int tourPointIdx
	{
		get
		{
			return tourPointIdxField;
		}
		set
		{
			tourPointIdxField = value;
			RaisePropertyChanged("tourPointIdx");
		}
	}

	[XmlAttribute]
	public TimeEventType type
	{
		get
		{
			return typeField;
		}
		set
		{
			typeField = value;
			RaisePropertyChanged("type");
		}
	}
}
