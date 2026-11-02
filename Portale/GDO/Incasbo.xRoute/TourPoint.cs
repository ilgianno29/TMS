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
public class TourPoint : TransientVO
{
	private int arrivalTimeField;

	private int departureTimeField;

	private int endOfServiceField;

	private bool serviceViolationField;

	private int startOfServiceField;

	private int stationIdxField;

	private bool timeWindowViolationField;

	[XmlAttribute]
	public int arrivalTime
	{
		get
		{
			return arrivalTimeField;
		}
		set
		{
			arrivalTimeField = value;
			RaisePropertyChanged("arrivalTime");
		}
	}

	[XmlAttribute]
	public int departureTime
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

	[XmlAttribute]
	public int endOfService
	{
		get
		{
			return endOfServiceField;
		}
		set
		{
			endOfServiceField = value;
			RaisePropertyChanged("endOfService");
		}
	}

	[XmlAttribute]
	public bool serviceViolation
	{
		get
		{
			return serviceViolationField;
		}
		set
		{
			serviceViolationField = value;
			RaisePropertyChanged("serviceViolation");
		}
	}

	[XmlAttribute]
	public int startOfService
	{
		get
		{
			return startOfServiceField;
		}
		set
		{
			startOfServiceField = value;
			RaisePropertyChanged("startOfService");
		}
	}

	[XmlAttribute]
	public int stationIdx
	{
		get
		{
			return stationIdxField;
		}
		set
		{
			stationIdxField = value;
			RaisePropertyChanged("stationIdx");
		}
	}

	[XmlAttribute]
	public bool timeWindowViolation
	{
		get
		{
			return timeWindowViolationField;
		}
		set
		{
			timeWindowViolationField = value;
			RaisePropertyChanged("timeWindowViolation");
		}
	}
}
