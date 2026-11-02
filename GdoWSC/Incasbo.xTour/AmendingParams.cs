using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class AmendingParams : StandardParams
{
	private int maximumAdditionalDistanceField;

	private bool maximumAdditionalDistanceFieldSpecified;

	private bool vehicleChangeAllowedField;

	private bool vehicleChangeAllowedFieldSpecified;

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

	[XmlIgnore]
	public bool vehicleChangeAllowedSpecified
	{
		get
		{
			return vehicleChangeAllowedFieldSpecified;
		}
		set
		{
			vehicleChangeAllowedFieldSpecified = value;
			RaisePropertyChanged("vehicleChangeAllowedSpecified");
		}
	}
}
