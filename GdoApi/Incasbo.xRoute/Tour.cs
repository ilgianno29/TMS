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
public class Tour : ExtendedRoute
{
	private TimeEvent[] wrappedTimeEventsField;

	private TourPoint[] wrappedTourPointsField;

	private TourSummary tourSummaryField;

	[XmlArray(IsNullable = true, Order = 0)]
	public TimeEvent[] wrappedTimeEvents
	{
		get
		{
			return wrappedTimeEventsField;
		}
		set
		{
			wrappedTimeEventsField = value;
			RaisePropertyChanged("wrappedTimeEvents");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
	public TourPoint[] wrappedTourPoints
	{
		get
		{
			return wrappedTourPointsField;
		}
		set
		{
			wrappedTourPointsField = value;
			RaisePropertyChanged("wrappedTourPoints");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public TourSummary tourSummary
	{
		get
		{
			return tourSummaryField;
		}
		set
		{
			tourSummaryField = value;
			RaisePropertyChanged("tourSummary");
		}
	}
}
