using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class TourEvent : TransientVO
{
	private string[] wrappedDescriptionsField;

	private string[] wrappedViolationsField;

	private int logisticPointIdField;

	private int periodField;

	private int startTimeField;

	private int tourIndexField;

	[XmlArrayItem("String", Namespace = "http://wrappertypes.service.jabba.ptvag.com")]
	[XmlArray(IsNullable = true, Order = 0)]
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

	[XmlArrayItem("String", Namespace = "http://wrappertypes.service.jabba.ptvag.com")]
	[XmlArray(IsNullable = true, Order = 1)]
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
	public int logisticPointId
	{
		get
		{
			return logisticPointIdField;
		}
		set
		{
			logisticPointIdField = value;
			RaisePropertyChanged("logisticPointId");
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
	public int tourIndex
	{
		get
		{
			return tourIndexField;
		}
		set
		{
			tourIndexField = value;
			RaisePropertyChanged("tourIndex");
		}
	}
}
