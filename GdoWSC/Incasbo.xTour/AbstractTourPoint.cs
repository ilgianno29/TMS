using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[XmlInclude(typeof(TourPoint))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[XmlInclude(typeof(SequencingTourPoint))]
[DesignerCategory("code")]
public abstract class AbstractTourPoint : TransientVO
{
	private TourPointResult resultField;

	private string descriptionField;

	private int idField;

	private TourPointType typeField;

	[XmlElement(IsNullable = true, Order = 0)]
	public TourPointResult result
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
	public TourPointType type
	{
		get
		{
			return typeField;
		}
		set
		{
			typeField = value;
			RaisePropertyChanged("type");
		}
	}
}
