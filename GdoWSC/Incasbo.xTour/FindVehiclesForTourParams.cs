using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
public class FindVehiclesForTourParams : PlanningParams
{
	private bool depotInsertionAllowedField;

	private bool scheduledVehiclesAllowedField;

	[XmlAttribute]
	public bool depotInsertionAllowed
	{
		get
		{
			return depotInsertionAllowedField;
		}
		set
		{
			depotInsertionAllowedField = value;
			RaisePropertyChanged("depotInsertionAllowed");
		}
	}

	[XmlAttribute]
	public bool scheduledVehiclesAllowed
	{
		get
		{
			return scheduledVehiclesAllowedField;
		}
		set
		{
			scheduledVehiclesAllowedField = value;
			RaisePropertyChanged("scheduledVehiclesAllowed");
		}
	}
}
