using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
public class TransportPoint : LogisticPoint
{
	private bool allowServiceSplitField;

	private int areaNumberPositionField;

	private bool areaNumberPositionFieldSpecified;

	private bool coDriverRequiredField;

	private OpeningIntervalConstraint openingIntervalConstraintField;

	private int servicePeriodField;

	private int tourSectionField;

	private bool useServicePeriodForRecreationField;

	[XmlAttribute]
	public bool allowServiceSplit
	{
		get
		{
			return allowServiceSplitField;
		}
		set
		{
			allowServiceSplitField = value;
			RaisePropertyChanged("allowServiceSplit");
		}
	}

	[XmlAttribute]
	public int areaNumberPosition
	{
		get
		{
			return areaNumberPositionField;
		}
		set
		{
			areaNumberPositionField = value;
			RaisePropertyChanged("areaNumberPosition");
		}
	}

	[XmlIgnore]
	public bool areaNumberPositionSpecified
	{
		get
		{
			return areaNumberPositionFieldSpecified;
		}
		set
		{
			areaNumberPositionFieldSpecified = value;
			RaisePropertyChanged("areaNumberPositionSpecified");
		}
	}

	[XmlAttribute]
	public bool coDriverRequired
	{
		get
		{
			return coDriverRequiredField;
		}
		set
		{
			coDriverRequiredField = value;
			RaisePropertyChanged("coDriverRequired");
		}
	}

	[XmlAttribute]
	public OpeningIntervalConstraint openingIntervalConstraint
	{
		get
		{
			return openingIntervalConstraintField;
		}
		set
		{
			openingIntervalConstraintField = value;
			RaisePropertyChanged("openingIntervalConstraint");
		}
	}

	[XmlAttribute]
	public int servicePeriod
	{
		get
		{
			return servicePeriodField;
		}
		set
		{
			servicePeriodField = value;
			RaisePropertyChanged("servicePeriod");
		}
	}

	[XmlAttribute]
	public int tourSection
	{
		get
		{
			return tourSectionField;
		}
		set
		{
			tourSectionField = value;
			RaisePropertyChanged("tourSection");
		}
	}

	[XmlAttribute]
	public bool useServicePeriodForRecreation
	{
		get
		{
			return useServicePeriodForRecreationField;
		}
		set
		{
			useServicePeriodForRecreationField = value;
			RaisePropertyChanged("useServicePeriodForRecreation");
		}
	}
}
