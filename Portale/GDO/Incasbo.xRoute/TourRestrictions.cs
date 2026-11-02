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
public class TourRestrictions : TransientVO
{
	private TransportPeriodRestriction[] wrappedTransportPeriodRestrictionsField;

	private int maxTourPeriodField;

	private bool maxTourPeriodFieldSpecified;

	[XmlArray(IsNullable = true, Order = 0)]
	public TransportPeriodRestriction[] wrappedTransportPeriodRestrictions
	{
		get
		{
			return wrappedTransportPeriodRestrictionsField;
		}
		set
		{
			wrappedTransportPeriodRestrictionsField = value;
			RaisePropertyChanged("wrappedTransportPeriodRestrictions");
		}
	}

	[XmlAttribute]
	public int maxTourPeriod
	{
		get
		{
			return maxTourPeriodField;
		}
		set
		{
			maxTourPeriodField = value;
			RaisePropertyChanged("maxTourPeriod");
		}
	}

	[XmlIgnore]
	public bool maxTourPeriodSpecified
	{
		get
		{
			return maxTourPeriodFieldSpecified;
		}
		set
		{
			maxTourPeriodFieldSpecified = value;
			RaisePropertyChanged("maxTourPeriodSpecified");
		}
	}
}
