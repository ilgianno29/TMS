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
public class TourPointDesc : WaypointDesc
{
	private Interval[] wrappedOpeningIntervalsField;

	private bool completeServiceInIntervalsField;

	private int minUninterruptedServicePeriodField;

	private bool minUninterruptedServicePeriodFieldSpecified;

	private int servicePeriodField;

	private int siteIDField;

	private bool siteIDFieldSpecified;

	private bool useServicePeriodForRecreationField;

	[XmlArray(IsNullable = true, Order = 0)]
	public Interval[] wrappedOpeningIntervals
	{
		get
		{
			return wrappedOpeningIntervalsField;
		}
		set
		{
			wrappedOpeningIntervalsField = value;
			RaisePropertyChanged("wrappedOpeningIntervals");
		}
	}

	[XmlAttribute]
	public bool completeServiceInIntervals
	{
		get
		{
			return completeServiceInIntervalsField;
		}
		set
		{
			completeServiceInIntervalsField = value;
			RaisePropertyChanged("completeServiceInIntervals");
		}
	}

	[XmlAttribute]
	public int minUninterruptedServicePeriod
	{
		get
		{
			return minUninterruptedServicePeriodField;
		}
		set
		{
			minUninterruptedServicePeriodField = value;
			RaisePropertyChanged("minUninterruptedServicePeriod");
		}
	}

	[XmlIgnore]
	public bool minUninterruptedServicePeriodSpecified
	{
		get
		{
			return minUninterruptedServicePeriodFieldSpecified;
		}
		set
		{
			minUninterruptedServicePeriodFieldSpecified = value;
			RaisePropertyChanged("minUninterruptedServicePeriodSpecified");
		}
	}

	[XmlAttribute]
	public int servicePeriod
	{
		get
		{
			return servicePeriodField;
		}
		set
		{
			servicePeriodField = value;
			RaisePropertyChanged("servicePeriod");
		}
	}

	[XmlAttribute]
	public int siteID
	{
		get
		{
			return siteIDField;
		}
		set
		{
			siteIDField = value;
			RaisePropertyChanged("siteID");
		}
	}

	[XmlIgnore]
	public bool siteIDSpecified
	{
		get
		{
			return siteIDFieldSpecified;
		}
		set
		{
			siteIDFieldSpecified = value;
			RaisePropertyChanged("siteIDSpecified");
		}
	}

	[XmlAttribute]
	public bool useServicePeriodForRecreation
	{
		get
		{
			return useServicePeriodForRecreationField;
		}
		set
		{
			useServicePeriodForRecreationField = value;
			RaisePropertyChanged("useServicePeriodForRecreation");
		}
	}
}
