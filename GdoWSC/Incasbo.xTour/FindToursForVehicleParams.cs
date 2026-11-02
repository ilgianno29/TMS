using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
public class FindToursForVehicleParams : PlanningParams
{
	private bool depotInsertionAllowedField;

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
}
