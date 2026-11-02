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
public class LoadingFunction : TransientVO
{
	private QuantityDependentPeriods quantityDependentPeriodsField;

	private int exponentField;

	private bool exponentFieldSpecified;

	private int fixedPeriodField;

	private int fixedSitePeriodField;

	private bool fixedSitePeriodFieldSpecified;

	private int idField;

	private int maxPeriodField;

	private bool maxPeriodFieldSpecified;

	[XmlElement(IsNullable = true, Order = 0)]
	public QuantityDependentPeriods quantityDependentPeriods
	{
		get
		{
			return quantityDependentPeriodsField;
		}
		set
		{
			quantityDependentPeriodsField = value;
			RaisePropertyChanged("quantityDependentPeriods");
		}
	}

	[XmlAttribute]
	public int exponent
	{
		get
		{
			return exponentField;
		}
		set
		{
			exponentField = value;
			RaisePropertyChanged("exponent");
		}
	}

	[XmlIgnore]
	public bool exponentSpecified
	{
		get
		{
			return exponentFieldSpecified;
		}
		set
		{
			exponentFieldSpecified = value;
			RaisePropertyChanged("exponentSpecified");
		}
	}

	[XmlAttribute]
	public int fixedPeriod
	{
		get
		{
			return fixedPeriodField;
		}
		set
		{
			fixedPeriodField = value;
			RaisePropertyChanged("fixedPeriod");
		}
	}

	[XmlAttribute]
	public int fixedSitePeriod
	{
		get
		{
			return fixedSitePeriodField;
		}
		set
		{
			fixedSitePeriodField = value;
			RaisePropertyChanged("fixedSitePeriod");
		}
	}

	[XmlIgnore]
	public bool fixedSitePeriodSpecified
	{
		get
		{
			return fixedSitePeriodFieldSpecified;
		}
		set
		{
			fixedSitePeriodFieldSpecified = value;
			RaisePropertyChanged("fixedSitePeriodSpecified");
		}
	}

	[XmlAttribute]
	public int id
	{
		get
		{
			return idField;
		}
		set
		{
			idField = value;
			RaisePropertyChanged("id");
		}
	}

	[XmlAttribute]
	public int maxPeriod
	{
		get
		{
			return maxPeriodField;
		}
		set
		{
			maxPeriodField = value;
			RaisePropertyChanged("maxPeriod");
		}
	}

	[XmlIgnore]
	public bool maxPeriodSpecified
	{
		get
		{
			return maxPeriodFieldSpecified;
		}
		set
		{
			maxPeriodFieldSpecified = value;
			RaisePropertyChanged("maxPeriodSpecified");
		}
	}
}
