using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class FindToursForOrderParams : PlanningParams
{
	private int maximumAdditionalDistanceField;

	private bool maximumAdditionalDistanceFieldSpecified;

	private bool newTourAllowedField;

	private double newTourCostFactorField;

	private bool vehicleChangeAllowedField;

	[XmlAttribute]
	public int maximumAdditionalDistance
	{
		get
		{
			return maximumAdditionalDistanceField;
		}
		set
		{
			maximumAdditionalDistanceField = value;
			RaisePropertyChanged("maximumAdditionalDistance");
		}
	}

	[XmlIgnore]
	public bool maximumAdditionalDistanceSpecified
	{
		get
		{
			return maximumAdditionalDistanceFieldSpecified;
		}
		set
		{
			maximumAdditionalDistanceFieldSpecified = value;
			RaisePropertyChanged("maximumAdditionalDistanceSpecified");
		}
	}

	[XmlAttribute]
	public bool newTourAllowed
	{
		get
		{
			return newTourAllowedField;
		}
		set
		{
			newTourAllowedField = value;
			RaisePropertyChanged("newTourAllowed");
		}
	}

	[XmlAttribute]
	public double newTourCostFactor
	{
		get
		{
			return newTourCostFactorField;
		}
		set
		{
			newTourCostFactorField = value;
			RaisePropertyChanged("newTourCostFactor");
		}
	}

	[XmlAttribute]
	public bool vehicleChangeAllowed
	{
		get
		{
			return vehicleChangeAllowedField;
		}
		set
		{
			vehicleChangeAllowedField = value;
			RaisePropertyChanged("vehicleChangeAllowed");
		}
	}
}
