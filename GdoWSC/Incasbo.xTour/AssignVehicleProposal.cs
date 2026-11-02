using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
public class AssignVehicleProposal : TransientVO
{
	private AssignVehicleInstruction assignVehicleInstructionField;

	private double assignmentCostField;

	private int assignmentTourDistanceField;

	private int assignmentTourDrivingPeriodField;

	private int assignmentTourPeriodField;

	private int endDepotIdField;

	private bool endDepotInsertedField;

	private bool scheduledVehicleField;

	private int startDepotIdField;

	private bool startDepotInsertedField;

	private int startTimeField;

	[XmlElement(IsNullable = true, Order = 0)]
	public AssignVehicleInstruction assignVehicleInstruction
	{
		get
		{
			return assignVehicleInstructionField;
		}
		set
		{
			assignVehicleInstructionField = value;
			RaisePropertyChanged("assignVehicleInstruction");
		}
	}

	[XmlAttribute]
	public double assignmentCost
	{
		get
		{
			return assignmentCostField;
		}
		set
		{
			assignmentCostField = value;
			RaisePropertyChanged("assignmentCost");
		}
	}

	[XmlAttribute]
	public int assignmentTourDistance
	{
		get
		{
			return assignmentTourDistanceField;
		}
		set
		{
			assignmentTourDistanceField = value;
			RaisePropertyChanged("assignmentTourDistance");
		}
	}

	[XmlAttribute]
	public int assignmentTourDrivingPeriod
	{
		get
		{
			return assignmentTourDrivingPeriodField;
		}
		set
		{
			assignmentTourDrivingPeriodField = value;
			RaisePropertyChanged("assignmentTourDrivingPeriod");
		}
	}

	[XmlAttribute]
	public int assignmentTourPeriod
	{
		get
		{
			return assignmentTourPeriodField;
		}
		set
		{
			assignmentTourPeriodField = value;
			RaisePropertyChanged("assignmentTourPeriod");
		}
	}

	[XmlAttribute]
	public int endDepotId
	{
		get
		{
			return endDepotIdField;
		}
		set
		{
			endDepotIdField = value;
			RaisePropertyChanged("endDepotId");
		}
	}

	[XmlAttribute]
	public bool endDepotInserted
	{
		get
		{
			return endDepotInsertedField;
		}
		set
		{
			endDepotInsertedField = value;
			RaisePropertyChanged("endDepotInserted");
		}
	}

	[XmlAttribute]
	public bool scheduledVehicle
	{
		get
		{
			return scheduledVehicleField;
		}
		set
		{
			scheduledVehicleField = value;
			RaisePropertyChanged("scheduledVehicle");
		}
	}

	[XmlAttribute]
	public int startDepotId
	{
		get
		{
			return startDepotIdField;
		}
		set
		{
			startDepotIdField = value;
			RaisePropertyChanged("startDepotId");
		}
	}

	[XmlAttribute]
	public bool startDepotInserted
	{
		get
		{
			return startDepotInsertedField;
		}
		set
		{
			startDepotInsertedField = value;
			RaisePropertyChanged("startDepotInserted");
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
}
