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
public class TourOptions : TransientVO
{
	private DriverSettings driverSettingsField;

	private Interval[] wrappedOperatingIntervalsField;

	private RegulationsBase regulationsField;

	private TourRestrictions tourRestrictionsField;

	private bool restrictToSingleOperatingIntervalField;

	private int startIntervalLengthField;

	private bool startIntervalLengthFieldSpecified;

	private string useCaseField;

	[XmlElement(IsNullable = true, Order = 0)]
	public DriverSettings driverSettings
	{
		get
		{
			return driverSettingsField;
		}
		set
		{
			driverSettingsField = value;
			RaisePropertyChanged("driverSettings");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
	public Interval[] wrappedOperatingIntervals
	{
		get
		{
			return wrappedOperatingIntervalsField;
		}
		set
		{
			wrappedOperatingIntervalsField = value;
			RaisePropertyChanged("wrappedOperatingIntervals");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public RegulationsBase regulations
	{
		get
		{
			return regulationsField;
		}
		set
		{
			regulationsField = value;
			RaisePropertyChanged("regulations");
		}
	}

	[XmlElement(IsNullable = true, Order = 3)]
	public TourRestrictions tourRestrictions
	{
		get
		{
			return tourRestrictionsField;
		}
		set
		{
			tourRestrictionsField = value;
			RaisePropertyChanged("tourRestrictions");
		}
	}

	[XmlAttribute]
	public bool restrictToSingleOperatingInterval
	{
		get
		{
			return restrictToSingleOperatingIntervalField;
		}
		set
		{
			restrictToSingleOperatingIntervalField = value;
			RaisePropertyChanged("restrictToSingleOperatingInterval");
		}
	}

	[XmlAttribute]
	public int startIntervalLength
	{
		get
		{
			return startIntervalLengthField;
		}
		set
		{
			startIntervalLengthField = value;
			RaisePropertyChanged("startIntervalLength");
		}
	}

	[XmlIgnore]
	public bool startIntervalLengthSpecified
	{
		get
		{
			return startIntervalLengthFieldSpecified;
		}
		set
		{
			startIntervalLengthFieldSpecified = value;
			RaisePropertyChanged("startIntervalLengthSpecified");
		}
	}

	[XmlAttribute]
	public string useCase
	{
		get
		{
			return useCaseField;
		}
		set
		{
			useCaseField = value;
			RaisePropertyChanged("useCase");
		}
	}
}
