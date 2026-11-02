using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DesignerCategory("code")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class UnscheduledOrderAnalysisResult : TransientVO
{
	private TourViolations[] wrappedTourViolationsField;

	private VehicleViolations[] wrappedVehicleViolationsField;

	private int orderIdField;

	private UnscheduledStopStatus statusField;

	[XmlArray(IsNullable = true, Order = 0)]
	public TourViolations[] wrappedTourViolations
	{
		get
		{
			return wrappedTourViolationsField;
		}
		set
		{
			wrappedTourViolationsField = value;
			RaisePropertyChanged("wrappedTourViolations");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
	public VehicleViolations[] wrappedVehicleViolations
	{
		get
		{
			return wrappedVehicleViolationsField;
		}
		set
		{
			wrappedVehicleViolationsField = value;
			RaisePropertyChanged("wrappedVehicleViolations");
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
	public UnscheduledStopStatus status
	{
		get
		{
			return statusField;
		}
		set
		{
			statusField = value;
			RaisePropertyChanged("status");
		}
	}
}
