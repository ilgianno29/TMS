using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[Serializable]
[XmlInclude(typeof(PoiResultAddress))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xlocate.xserver.ptvag.com")]
public class ResultAddress : Address
{
	private AdditionalField[] wrappedAdditionalFieldsField;

	private Point coordinatesField;

	private string adminRegionField;

	private string appendixField;

	private ClassificationDescription classificationDescriptionField;

	private string countryCapitalField;

	private DetailLevelDescription detailLevelDescriptionField;

	private int totalScoreField;

	[XmlArray(IsNullable = true, Order = 0)]
	public AdditionalField[] wrappedAdditionalFields
	{
		get
		{
			return wrappedAdditionalFieldsField;
		}
		set
		{
			wrappedAdditionalFieldsField = value;
			RaisePropertyChanged("wrappedAdditionalFields");
		}
	}

	[XmlElement(IsNullable = true, Order = 1)]
	public Point coordinates
	{
		get
		{
			return coordinatesField;
		}
		set
		{
			coordinatesField = value;
			RaisePropertyChanged("coordinates");
		}
	}

	[XmlAttribute]
	public string adminRegion
	{
		get
		{
			return adminRegionField;
		}
		set
		{
			adminRegionField = value;
			RaisePropertyChanged("adminRegion");
		}
	}

	[XmlAttribute]
	public string appendix
	{
		get
		{
			return appendixField;
		}
		set
		{
			appendixField = value;
			RaisePropertyChanged("appendix");
		}
	}

	[XmlAttribute]
	public ClassificationDescription classificationDescription
	{
		get
		{
			return classificationDescriptionField;
		}
		set
		{
			classificationDescriptionField = value;
			RaisePropertyChanged("classificationDescription");
		}
	}

	[XmlAttribute]
	public string countryCapital
	{
		get
		{
			return countryCapitalField;
		}
		set
		{
			countryCapitalField = value;
			RaisePropertyChanged("countryCapital");
		}
	}

	[XmlAttribute]
	public DetailLevelDescription detailLevelDescription
	{
		get
		{
			return detailLevelDescriptionField;
		}
		set
		{
			detailLevelDescriptionField = value;
			RaisePropertyChanged("detailLevelDescription");
		}
	}

	[XmlAttribute]
	public int totalScore
	{
		get
		{
			return totalScoreField;
		}
		set
		{
			totalScoreField = value;
			RaisePropertyChanged("totalScore");
		}
	}
}
