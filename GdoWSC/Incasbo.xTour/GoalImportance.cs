using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class GoalImportance : TransientVO
{
	private int chainPeriodRankField;

	private int tourCountRankField;

	private int tourDistanceRankField;

	private int tourDrivingPeriodRankField;

	private int tourPeriodRankField;

	private int unplannedOrdersRankField;

	private int vehicleCountRankField;

	[XmlAttribute]
	public int chainPeriodRank
	{
		get
		{
			return chainPeriodRankField;
		}
		set
		{
			chainPeriodRankField = value;
			RaisePropertyChanged("chainPeriodRank");
		}
	}

	[XmlAttribute]
	public int tourCountRank
	{
		get
		{
			return tourCountRankField;
		}
		set
		{
			tourCountRankField = value;
			RaisePropertyChanged("tourCountRank");
		}
	}

	[XmlAttribute]
	public int tourDistanceRank
	{
		get
		{
			return tourDistanceRankField;
		}
		set
		{
			tourDistanceRankField = value;
			RaisePropertyChanged("tourDistanceRank");
		}
	}

	[XmlAttribute]
	public int tourDrivingPeriodRank
	{
		get
		{
			return tourDrivingPeriodRankField;
		}
		set
		{
			tourDrivingPeriodRankField = value;
			RaisePropertyChanged("tourDrivingPeriodRank");
		}
	}

	[XmlAttribute]
	public int tourPeriodRank
	{
		get
		{
			return tourPeriodRankField;
		}
		set
		{
			tourPeriodRankField = value;
			RaisePropertyChanged("tourPeriodRank");
		}
	}

	[XmlAttribute]
	public int unplannedOrdersRank
	{
		get
		{
			return unplannedOrdersRankField;
		}
		set
		{
			unplannedOrdersRankField = value;
			RaisePropertyChanged("unplannedOrdersRank");
		}
	}

	[XmlAttribute]
	public int vehicleCountRank
	{
		get
		{
			return vehicleCountRankField;
		}
		set
		{
			vehicleCountRankField = value;
			RaisePropertyChanged("vehicleCountRank");
		}
	}
}
