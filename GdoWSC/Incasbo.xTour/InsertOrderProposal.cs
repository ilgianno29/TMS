using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DesignerCategory("code")]
public class InsertOrderProposal : TransientVO
{
	private InsertOrderInstruction insertInstructionField;

	private int arrivalTimeField;

	private bool chainPositionChangedField;

	private int departureTimeField;

	private int endServiceTimeField;

	private double insertCostField;

	private int insertTourDistanceField;

	private int insertTourDrivingPeriodField;

	private int insertTourPeriodField;

	private int startServiceTimeField;

	private bool vehicleChangedField;

	[XmlElement(IsNullable = true, Order = 0)]
	public InsertOrderInstruction insertInstruction
	{
		get
		{
			return insertInstructionField;
		}
		set
		{
			insertInstructionField = value;
			RaisePropertyChanged("insertInstruction");
		}
	}

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
	public bool chainPositionChanged
	{
		get
		{
			return chainPositionChangedField;
		}
		set
		{
			chainPositionChangedField = value;
			RaisePropertyChanged("chainPositionChanged");
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
	public int endServiceTime
	{
		get
		{
			return endServiceTimeField;
		}
		set
		{
			endServiceTimeField = value;
			RaisePropertyChanged("endServiceTime");
		}
	}

	[XmlAttribute]
	public double insertCost
	{
		get
		{
			return insertCostField;
		}
		set
		{
			insertCostField = value;
			RaisePropertyChanged("insertCost");
		}
	}

	[XmlAttribute]
	public int insertTourDistance
	{
		get
		{
			return insertTourDistanceField;
		}
		set
		{
			insertTourDistanceField = value;
			RaisePropertyChanged("insertTourDistance");
		}
	}

	[XmlAttribute]
	public int insertTourDrivingPeriod
	{
		get
		{
			return insertTourDrivingPeriodField;
		}
		set
		{
			insertTourDrivingPeriodField = value;
			RaisePropertyChanged("insertTourDrivingPeriod");
		}
	}

	[XmlAttribute]
	public int insertTourPeriod
	{
		get
		{
			return insertTourPeriodField;
		}
		set
		{
			insertTourPeriodField = value;
			RaisePropertyChanged("insertTourPeriod");
		}
	}

	[XmlAttribute]
	public int startServiceTime
	{
		get
		{
			return startServiceTimeField;
		}
		set
		{
			startServiceTimeField = value;
			RaisePropertyChanged("startServiceTime");
		}
	}

	[XmlAttribute]
	public bool vehicleChanged
	{
		get
		{
			return vehicleChangedField;
		}
		set
		{
			vehicleChangedField = value;
			RaisePropertyChanged("vehicleChanged");
		}
	}
}
