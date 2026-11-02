using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
public class TourEvent : TransientVO
{
	private string[] wrappedDescriptionsField;

	private string[] wrappedViolationsField;

	private int periodField;

	private int segmentIndexField;

	private DateTime startTimeField;

	private bool startTimeFieldSpecified;

	private int tourPointIndexField;

	[XmlArray(IsNullable = true, Order = 0)]
	[XmlArrayItem("String", Namespace = "http://wrappertypes.service.jabba.ptvag.com")]
	public string[] wrappedDescriptions
	{
		get
		{
			return wrappedDescriptionsField;
		}
		set
		{
			wrappedDescriptionsField = value;
			RaisePropertyChanged("wrappedDescriptions");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
	[XmlArrayItem("String", Namespace = "http://wrappertypes.service.jabba.ptvag.com")]
	public string[] wrappedViolations
	{
		get
		{
			return wrappedViolationsField;
		}
		set
		{
			wrappedViolationsField = value;
			RaisePropertyChanged("wrappedViolations");
		}
	}

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
	public int segmentIndex
	{
		get
		{
			return segmentIndexField;
		}
		set
		{
			segmentIndexField = value;
			RaisePropertyChanged("segmentIndex");
		}
	}

	[XmlAttribute]
	public DateTime startTime
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

	[XmlIgnore]
	public bool startTimeSpecified
	{
		get
		{
			return startTimeFieldSpecified;
		}
		set
		{
			startTimeFieldSpecified = value;
			RaisePropertyChanged("startTimeSpecified");
		}
	}

	[XmlAttribute]
	public int tourPointIndex
	{
		get
		{
			return tourPointIndexField;
		}
		set
		{
			tourPointIndexField = value;
			RaisePropertyChanged("tourPointIndex");
		}
	}
}
