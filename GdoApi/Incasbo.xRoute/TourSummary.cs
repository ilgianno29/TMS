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
public class TourSummary : TransientVO
{
	private int drivingPeriodField;

	private int earlinessField;

	private int idlePeriodField;

	private DateTime latestTourStartField;

	private bool latestTourStartFieldSpecified;

	private int remainingBreakPeriodField;

	private bool remainingBreakPeriodFieldSpecified;

	private int remainingDrivingTimeBeforeNextBreakField;

	private bool remainingDrivingTimeBeforeNextBreakFieldSpecified;

	private int remainingShiftPeriodField;

	private bool remainingShiftPeriodFieldSpecified;

	private int remainingWorkingHoursDuringShiftField;

	private bool remainingWorkingHoursDuringShiftFieldSpecified;

	private int servicePeriodField;

	private int totalPeriodField;

	private int waitingPeriodField;

	[XmlAttribute]
	public int drivingPeriod
	{
		get
		{
			return drivingPeriodField;
		}
		set
		{
			drivingPeriodField = value;
			RaisePropertyChanged("drivingPeriod");
		}
	}

	[XmlAttribute]
	public int earliness
	{
		get
		{
			return earlinessField;
		}
		set
		{
			earlinessField = value;
			RaisePropertyChanged("earliness");
		}
	}

	[XmlAttribute]
	public int idlePeriod
	{
		get
		{
			return idlePeriodField;
		}
		set
		{
			idlePeriodField = value;
			RaisePropertyChanged("idlePeriod");
		}
	}

	[XmlAttribute]
	public DateTime latestTourStart
	{
		get
		{
			return latestTourStartField;
		}
		set
		{
			latestTourStartField = value;
			RaisePropertyChanged("latestTourStart");
		}
	}

	[XmlIgnore]
	public bool latestTourStartSpecified
	{
		get
		{
			return latestTourStartFieldSpecified;
		}
		set
		{
			latestTourStartFieldSpecified = value;
			RaisePropertyChanged("latestTourStartSpecified");
		}
	}

	[XmlAttribute]
	public int remainingBreakPeriod
	{
		get
		{
			return remainingBreakPeriodField;
		}
		set
		{
			remainingBreakPeriodField = value;
			RaisePropertyChanged("remainingBreakPeriod");
		}
	}

	[XmlIgnore]
	public bool remainingBreakPeriodSpecified
	{
		get
		{
			return remainingBreakPeriodFieldSpecified;
		}
		set
		{
			remainingBreakPeriodFieldSpecified = value;
			RaisePropertyChanged("remainingBreakPeriodSpecified");
		}
	}

	[XmlAttribute]
	public int remainingDrivingTimeBeforeNextBreak
	{
		get
		{
			return remainingDrivingTimeBeforeNextBreakField;
		}
		set
		{
			remainingDrivingTimeBeforeNextBreakField = value;
			RaisePropertyChanged("remainingDrivingTimeBeforeNextBreak");
		}
	}

	[XmlIgnore]
	public bool remainingDrivingTimeBeforeNextBreakSpecified
	{
		get
		{
			return remainingDrivingTimeBeforeNextBreakFieldSpecified;
		}
		set
		{
			remainingDrivingTimeBeforeNextBreakFieldSpecified = value;
			RaisePropertyChanged("remainingDrivingTimeBeforeNextBreakSpecified");
		}
	}

	[XmlAttribute]
	public int remainingShiftPeriod
	{
		get
		{
			return remainingShiftPeriodField;
		}
		set
		{
			remainingShiftPeriodField = value;
			RaisePropertyChanged("remainingShiftPeriod");
		}
	}

	[XmlIgnore]
	public bool remainingShiftPeriodSpecified
	{
		get
		{
			return remainingShiftPeriodFieldSpecified;
		}
		set
		{
			remainingShiftPeriodFieldSpecified = value;
			RaisePropertyChanged("remainingShiftPeriodSpecified");
		}
	}

	[XmlAttribute]
	public int remainingWorkingHoursDuringShift
	{
		get
		{
			return remainingWorkingHoursDuringShiftField;
		}
		set
		{
			remainingWorkingHoursDuringShiftField = value;
			RaisePropertyChanged("remainingWorkingHoursDuringShift");
		}
	}

	[XmlIgnore]
	public bool remainingWorkingHoursDuringShiftSpecified
	{
		get
		{
			return remainingWorkingHoursDuringShiftFieldSpecified;
		}
		set
		{
			remainingWorkingHoursDuringShiftFieldSpecified = value;
			RaisePropertyChanged("remainingWorkingHoursDuringShiftSpecified");
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
	public int totalPeriod
	{
		get
		{
			return totalPeriodField;
		}
		set
		{
			totalPeriodField = value;
			RaisePropertyChanged("totalPeriod");
		}
	}

	[XmlAttribute]
	public int waitingPeriod
	{
		get
		{
			return waitingPeriodField;
		}
		set
		{
			waitingPeriodField = value;
			RaisePropertyChanged("waitingPeriod");
		}
	}
}
