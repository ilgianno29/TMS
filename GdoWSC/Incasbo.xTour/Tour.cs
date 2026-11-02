using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DesignerCategory("code")]
public class Tour : AbstractTour
{
	private TourRestrictions restrictionsField;

	private TourResult resultField;

	private TourPoint[] wrappedTourPointsField;

	private int areaNumberField;

	private bool areaNumberFieldSpecified;

	private string descriptionField;

	private int idField;

	private bool ignoreIntermediatePeriodOfPreviousTourField;

	private TourPointFixation tourPointFixationField;

	private bool trailerFixedField;

	private bool trailerFixedFieldSpecified;

	private int trailerIdField;

	private bool trailerIdFieldSpecified;

	private int trainIdField;

	private bool trainIdFieldSpecified;

	private bool vehicleFixedField;

	[XmlElement(IsNullable = true, Order = 0)]
	public TourRestrictions restrictions
	{
		get
		{
			return restrictionsField;
		}
		set
		{
			restrictionsField = value;
			RaisePropertyChanged("restrictions");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public TourResult result
	{
		get
		{
			return resultField;
		}
		set
		{
			resultField = value;
			RaisePropertyChanged("result");
		}
	}

	[XmlArray(IsNullable = true, Order = 2)]
	public TourPoint[] wrappedTourPoints
	{
		get
		{
			return wrappedTourPointsField;
		}
		set
		{
			wrappedTourPointsField = value;
			RaisePropertyChanged("wrappedTourPoints");
		}
	}

	[XmlAttribute]
	public int areaNumber
	{
		get
		{
			return areaNumberField;
		}
		set
		{
			areaNumberField = value;
			RaisePropertyChanged("areaNumber");
		}
	}

	[XmlIgnore]
	public bool areaNumberSpecified
	{
		get
		{
			return areaNumberFieldSpecified;
		}
		set
		{
			areaNumberFieldSpecified = value;
			RaisePropertyChanged("areaNumberSpecified");
		}
	}

	[XmlAttribute]
	public string description
	{
		get
		{
			return descriptionField;
		}
		set
		{
			descriptionField = value;
			RaisePropertyChanged("description");
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
	public bool ignoreIntermediatePeriodOfPreviousTour
	{
		get
		{
			return ignoreIntermediatePeriodOfPreviousTourField;
		}
		set
		{
			ignoreIntermediatePeriodOfPreviousTourField = value;
			RaisePropertyChanged("ignoreIntermediatePeriodOfPreviousTour");
		}
	}

	[XmlAttribute]
	public TourPointFixation tourPointFixation
	{
		get
		{
			return tourPointFixationField;
		}
		set
		{
			tourPointFixationField = value;
			RaisePropertyChanged("tourPointFixation");
		}
	}

	[XmlAttribute]
	public bool trailerFixed
	{
		get
		{
			return trailerFixedField;
		}
		set
		{
			trailerFixedField = value;
			RaisePropertyChanged("trailerFixed");
		}
	}

	[XmlIgnore]
	public bool trailerFixedSpecified
	{
		get
		{
			return trailerFixedFieldSpecified;
		}
		set
		{
			trailerFixedFieldSpecified = value;
			RaisePropertyChanged("trailerFixedSpecified");
		}
	}

	[XmlAttribute]
	public int trailerId
	{
		get
		{
			return trailerIdField;
		}
		set
		{
			trailerIdField = value;
			RaisePropertyChanged("trailerId");
		}
	}

	[XmlIgnore]
	public bool trailerIdSpecified
	{
		get
		{
			return trailerIdFieldSpecified;
		}
		set
		{
			trailerIdFieldSpecified = value;
			RaisePropertyChanged("trailerIdSpecified");
		}
	}

	[XmlAttribute]
	public int trainId
	{
		get
		{
			return trainIdField;
		}
		set
		{
			trainIdField = value;
			RaisePropertyChanged("trainId");
		}
	}

	[XmlIgnore]
	public bool trainIdSpecified
	{
		get
		{
			return trainIdFieldSpecified;
		}
		set
		{
			trainIdFieldSpecified = value;
			RaisePropertyChanged("trainIdSpecified");
		}
	}

	[XmlAttribute]
	public bool vehicleFixed
	{
		get
		{
			return vehicleFixedField;
		}
		set
		{
			vehicleFixedField = value;
			RaisePropertyChanged("vehicleFixed");
		}
	}
}
