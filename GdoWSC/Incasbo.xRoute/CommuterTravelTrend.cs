using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DebuggerStepThrough]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class CommuterTravelTrend : TransientVO
{
	private DateTime departureTimeField;

	private bool departureTimeFieldSpecified;

	private int travelTimeField;

	[XmlAttribute]
	public DateTime departureTime
	{
		get
		{
			return departureTimeField;
		}
		set
		{
			departureTimeField = value;
			RaisePropertyChanged("departureTime");
		}
	}

	[XmlIgnore]
	public bool departureTimeSpecified
	{
		get
		{
			return departureTimeFieldSpecified;
		}
		set
		{
			departureTimeFieldSpecified = value;
			RaisePropertyChanged("departureTimeSpecified");
		}
	}

	[XmlAttribute]
	public int travelTime
	{
		get
		{
			return travelTimeField;
		}
		set
		{
			travelTimeField = value;
			RaisePropertyChanged("travelTime");
		}
	}
}
