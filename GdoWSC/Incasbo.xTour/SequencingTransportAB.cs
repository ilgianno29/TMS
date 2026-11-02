using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class SequencingTransportAB : SequencingTransportOrder
{
	private Quantities quantitiesField;

	private TransportPoint transportPointAField;

	private TransportPoint transportPointBField;

	private int maxTransportPeriodField;

	private bool maxTransportPeriodFieldSpecified;

	[XmlElement(IsNullable = true, Order = 0)]
	public Quantities quantities
	{
		get
		{
			return quantitiesField;
		}
		set
		{
			quantitiesField = value;
			RaisePropertyChanged("quantities");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public TransportPoint transportPointA
	{
		get
		{
			return transportPointAField;
		}
		set
		{
			transportPointAField = value;
			RaisePropertyChanged("transportPointA");
		}
	}

	[XmlElement(IsNullable = true, Order = 2)]
	public TransportPoint transportPointB
	{
		get
		{
			return transportPointBField;
		}
		set
		{
			transportPointBField = value;
			RaisePropertyChanged("transportPointB");
		}
	}

	[XmlAttribute]
	public int maxTransportPeriod
	{
		get
		{
			return maxTransportPeriodField;
		}
		set
		{
			maxTransportPeriodField = value;
			RaisePropertyChanged("maxTransportPeriod");
		}
	}

	[XmlIgnore]
	public bool maxTransportPeriodSpecified
	{
		get
		{
			return maxTransportPeriodFieldSpecified;
		}
		set
		{
			maxTransportPeriodFieldSpecified = value;
			RaisePropertyChanged("maxTransportPeriodSpecified");
		}
	}
}
