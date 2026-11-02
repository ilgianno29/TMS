using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
public class InsertOrderInstruction : TransientVO
{
	private int chainPositionField;

	private int orderIdField;

	private int partnerPositionNumberField;

	private bool partnerPositionNumberFieldSpecified;

	private int positionNumberField;

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
	public int orderId
	{
		get
		{
			return orderIdField;
		}
		set
		{
			orderIdField = value;
			RaisePropertyChanged("orderId");
		}
	}

	[XmlAttribute]
	public int partnerPositionNumber
	{
		get
		{
			return partnerPositionNumberField;
		}
		set
		{
			partnerPositionNumberField = value;
			RaisePropertyChanged("partnerPositionNumber");
		}
	}

	[XmlIgnore]
	public bool partnerPositionNumberSpecified
	{
		get
		{
			return partnerPositionNumberFieldSpecified;
		}
		set
		{
			partnerPositionNumberFieldSpecified = value;
			RaisePropertyChanged("partnerPositionNumberSpecified");
		}
	}

	[XmlAttribute]
	public int positionNumber
	{
		get
		{
			return positionNumberField;
		}
		set
		{
			positionNumberField = value;
			RaisePropertyChanged("positionNumber");
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
