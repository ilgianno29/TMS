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
public class TourPoint : AbstractTourPoint
{
	private bool remainPlannedField;

	private bool tourFixedField;

	[XmlAttribute]
	public bool remainPlanned
	{
		get
		{
			return remainPlannedField;
		}
		set
		{
			remainPlannedField = value;
			RaisePropertyChanged("remainPlanned");
		}
	}

	[XmlAttribute]
	public bool tourFixed
	{
		get
		{
			return tourFixedField;
		}
		set
		{
			tourFixedField = value;
			RaisePropertyChanged("tourFixed");
		}
	}
}
