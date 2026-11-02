using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class AssignVehicleInstruction : TransientVO
{
	private int chainPositionField;

	private int tourIdField;

	private int trailerIdField;

	private int trainIdField;

	private int truckIdField;

	[XmlAttribute]
	public int chainPosition
	{
		get
		{
			return chainPositionField;
		}
		set
		{
			chainPositionField = value;
			RaisePropertyChanged("chainPosition");
		}
	}

	[XmlAttribute]
	public int tourId
	{
		get
		{
			return tourIdField;
		}
		set
		{
			tourIdField = value;
			RaisePropertyChanged("tourId");
		}
	}

	[XmlAttribute]
	public int trailerId
	{
		get
		{
			return trailerIdField;
		}
		set
		{
			trailerIdField = value;
			RaisePropertyChanged("trailerId");
		}
	}

	[XmlAttribute]
	public int trainId
	{
		get
		{
			return trainIdField;
		}
		set
		{
			trainIdField = value;
			RaisePropertyChanged("trainId");
		}
	}

	[XmlAttribute]
	public int truckId
	{
		get
		{
			return truckIdField;
		}
		set
		{
			truckIdField = value;
			RaisePropertyChanged("truckId");
		}
	}
}
