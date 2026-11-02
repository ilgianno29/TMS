using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[XmlInclude(typeof(SequencingVehicle))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(Vehicle))]
[XmlInclude(typeof(Trailer))]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[XmlInclude(typeof(BaseVehicle))]
public abstract class AbstractVehicle : TransientVO
{
	private Interval[] wrappedOperatingIntervalsField;

	private int depotIdEndField;

	private int depotIdStartField;

	[XmlArray(IsNullable = true, Order = 0)]
	public Interval[] wrappedOperatingIntervals
	{
		get
		{
			return wrappedOperatingIntervalsField;
		}
		set
		{
			wrappedOperatingIntervalsField = value;
			RaisePropertyChanged("wrappedOperatingIntervals");
		}
	}

	[XmlAttribute]
	public int depotIdEnd
	{
		get
		{
			return depotIdEndField;
		}
		set
		{
			depotIdEndField = value;
			RaisePropertyChanged("depotIdEnd");
		}
	}

	[XmlAttribute]
	public int depotIdStart
	{
		get
		{
			return depotIdStartField;
		}
		set
		{
			depotIdStartField = value;
			RaisePropertyChanged("depotIdStart");
		}
	}
}
