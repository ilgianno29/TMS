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
public class VehicleRestrictions : TransientVO
{
	private int maxDrivingPeriodPerChainField;

	private bool maxDrivingPeriodPerChainFieldSpecified;

	private int maxTourCountPerChainField;

	private bool maxTourCountPerChainFieldSpecified;

	private int maxTransportPointCountPerTourField;

	private bool maxTransportPointCountPerTourFieldSpecified;

	[XmlAttribute]
	public int maxDrivingPeriodPerChain
	{
		get
		{
			return maxDrivingPeriodPerChainField;
		}
		set
		{
			maxDrivingPeriodPerChainField = value;
			RaisePropertyChanged("maxDrivingPeriodPerChain");
		}
	}

	[XmlIgnore]
	public bool maxDrivingPeriodPerChainSpecified
	{
		get
		{
			return maxDrivingPeriodPerChainFieldSpecified;
		}
		set
		{
			maxDrivingPeriodPerChainFieldSpecified = value;
			RaisePropertyChanged("maxDrivingPeriodPerChainSpecified");
		}
	}

	[XmlAttribute]
	public int maxTourCountPerChain
	{
		get
		{
			return maxTourCountPerChainField;
		}
		set
		{
			maxTourCountPerChainField = value;
			RaisePropertyChanged("maxTourCountPerChain");
		}
	}

	[XmlIgnore]
	public bool maxTourCountPerChainSpecified
	{
		get
		{
			return maxTourCountPerChainFieldSpecified;
		}
		set
		{
			maxTourCountPerChainFieldSpecified = value;
			RaisePropertyChanged("maxTourCountPerChainSpecified");
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
