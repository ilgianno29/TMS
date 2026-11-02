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
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
public class WatchOptions : TransientVO
{
	private int maximumPollingPeriodField;

	private bool maximumPollingPeriodFieldSpecified;

	private int progressUpdatePeriodField;

	private bool progressUpdatePeriodFieldSpecified;

	[XmlAttribute]
	public int maximumPollingPeriod
	{
		get
		{
			return maximumPollingPeriodField;
		}
		set
		{
			maximumPollingPeriodField = value;
			RaisePropertyChanged("maximumPollingPeriod");
		}
	}

	[XmlIgnore]
	public bool maximumPollingPeriodSpecified
	{
		get
		{
			return maximumPollingPeriodFieldSpecified;
		}
		set
		{
			maximumPollingPeriodFieldSpecified = value;
			RaisePropertyChanged("maximumPollingPeriodSpecified");
		}
	}

	[XmlAttribute]
	public int progressUpdatePeriod
	{
		get
		{
			return progressUpdatePeriodField;
		}
		set
		{
			progressUpdatePeriodField = value;
			RaisePropertyChanged("progressUpdatePeriod");
		}
	}

	[XmlIgnore]
	public bool progressUpdatePeriodSpecified
	{
		get
		{
			return progressUpdatePeriodFieldSpecified;
		}
		set
		{
			progressUpdatePeriodFieldSpecified = value;
			RaisePropertyChanged("progressUpdatePeriodSpecified");
		}
	}
}
