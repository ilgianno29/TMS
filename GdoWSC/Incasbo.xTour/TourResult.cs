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
public class TourResult : AbstractTourResult
{
	private LoadingArea maxLoadingAreaField;

	private LoadingArea minLoadingAreaField;

	private int[] wrappedVehicleExclusionsField;

	private int[] wrappedVehicleRequirementsField;

	private string trailerDescriptionField;

	private string trainDescriptionField;

	[XmlElement(IsNullable = true, Order = 0)]
	public LoadingArea maxLoadingArea
	{
		get
		{
			return maxLoadingAreaField;
		}
		set
		{
			maxLoadingAreaField = value;
			RaisePropertyChanged("maxLoadingArea");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public LoadingArea minLoadingArea
	{
		get
		{
			return minLoadingAreaField;
		}
		set
		{
			minLoadingAreaField = value;
			RaisePropertyChanged("minLoadingArea");
		}
	}

	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	[XmlArray(IsNullable = true, Order = 2)]
	public int[] wrappedVehicleExclusions
	{
		get
		{
			return wrappedVehicleExclusionsField;
		}
		set
		{
			wrappedVehicleExclusionsField = value;
			RaisePropertyChanged("wrappedVehicleExclusions");
		}
	}

	[XmlArrayItem("Int", Namespace = "http://wrappertypes.service.jabba.ptvag.com", IsNullable = false)]
	[XmlArray(IsNullable = true, Order = 3)]
	public int[] wrappedVehicleRequirements
	{
		get
		{
			return wrappedVehicleRequirementsField;
		}
		set
		{
			wrappedVehicleRequirementsField = value;
			RaisePropertyChanged("wrappedVehicleRequirements");
		}
	}

	[XmlAttribute]
	public string trailerDescription
	{
		get
		{
			return trailerDescriptionField;
		}
		set
		{
			trailerDescriptionField = value;
			RaisePropertyChanged("trailerDescription");
		}
	}

	[XmlAttribute]
	public string trainDescription
	{
		get
		{
			return trainDescriptionField;
		}
		set
		{
			trainDescriptionField = value;
			RaisePropertyChanged("trainDescription");
		}
	}
}
