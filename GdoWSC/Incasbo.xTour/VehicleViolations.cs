using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
public class VehicleViolations : TransientVO
{
	private string[] wrappedViolationsField;

	private int trailerIdField;

	private int trainIdField;

	private int vehicleIdField;

	[XmlArray(IsNullable = true, Order = 0)]
	[XmlArrayItem("String", Namespace = "http://wrappertypes.service.jabba.ptvag.com")]
	public string[] wrappedViolations
	{
		get
		{
			return wrappedViolationsField;
		}
		set
		{
			wrappedViolationsField = value;
			RaisePropertyChanged("wrappedViolations");
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
	public int vehicleId
	{
		get
		{
			return vehicleIdField;
		}
		set
		{
			vehicleIdField = value;
			RaisePropertyChanged("vehicleId");
		}
	}
}
