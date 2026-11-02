using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class Restrictions : TransientVO
{
	private TourRestrictions tourRestrictionsField;

	private int maxTourCountField;

	private bool maxTourCountFieldSpecified;

	private int maxTransportPointCountPerTourField;

	private bool maxTransportPointCountPerTourFieldSpecified;

	[XmlElement(IsNullable = true, Order = 0)]
	public TourRestrictions tourRestrictions
	{
		get
		{
			return tourRestrictionsField;
		}
		set
		{
			tourRestrictionsField = value;
			RaisePropertyChanged("tourRestrictions");
		}
	}

	[XmlAttribute]
	public int maxTourCount
	{
		get
		{
			return maxTourCountField;
		}
		set
		{
			maxTourCountField = value;
			RaisePropertyChanged("maxTourCount");
		}
	}

	[XmlIgnore]
	public bool maxTourCountSpecified
	{
		get
		{
			return maxTourCountFieldSpecified;
		}
		set
		{
			maxTourCountFieldSpecified = value;
			RaisePropertyChanged("maxTourCountSpecified");
		}
	}

	[XmlAttribute]
	public int maxTransportPointCountPerTour
	{
		get
		{
			return maxTransportPointCountPerTourField;
		}
		set
		{
			maxTransportPointCountPerTourField = value;
			RaisePropertyChanged("maxTransportPointCountPerTour");
		}
	}

	[XmlIgnore]
	public bool maxTransportPointCountPerTourSpecified
	{
		get
		{
			return maxTransportPointCountPerTourFieldSpecified;
		}
		set
		{
			maxTransportPointCountPerTourFieldSpecified = value;
			RaisePropertyChanged("maxTransportPointCountPerTourSpecified");
		}
	}
}
