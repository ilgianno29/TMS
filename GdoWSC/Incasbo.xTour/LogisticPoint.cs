using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlInclude(typeof(Depot))]
[DesignerCategory("code")]
[XmlInclude(typeof(TransportPoint))]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public abstract class LogisticPoint : TransientVO
{
	private Point locationField;

	private Interval[] wrappedOpeningIntervalsField;

	private string descriptionField;

	private int extraSitePeriodField;

	private bool extraSitePeriodFieldSpecified;

	private int idField;

	private int siteIdField;

	private bool siteIdFieldSpecified;

	private int unloadingFunctionIdField;

	private bool unloadingFunctionIdFieldSpecified;

	private int uploadingFunctionIdField;

	private bool uploadingFunctionIdFieldSpecified;

	[XmlElement(IsNullable = true, Order = 0)]
	public Point location
	{
		get
		{
			return locationField;
		}
		set
		{
			locationField = value;
			RaisePropertyChanged("location");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
	public Interval[] wrappedOpeningIntervals
	{
		get
		{
			return wrappedOpeningIntervalsField;
		}
		set
		{
			wrappedOpeningIntervalsField = value;
			RaisePropertyChanged("wrappedOpeningIntervals");
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
	public int extraSitePeriod
	{
		get
		{
			return extraSitePeriodField;
		}
		set
		{
			extraSitePeriodField = value;
			RaisePropertyChanged("extraSitePeriod");
		}
	}

	[XmlIgnore]
	public bool extraSitePeriodSpecified
	{
		get
		{
			return extraSitePeriodFieldSpecified;
		}
		set
		{
			extraSitePeriodFieldSpecified = value;
			RaisePropertyChanged("extraSitePeriodSpecified");
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
	public int siteId
	{
		get
		{
			return siteIdField;
		}
		set
		{
			siteIdField = value;
			RaisePropertyChanged("siteId");
		}
	}

	[XmlIgnore]
	public bool siteIdSpecified
	{
		get
		{
			return siteIdFieldSpecified;
		}
		set
		{
			siteIdFieldSpecified = value;
			RaisePropertyChanged("siteIdSpecified");
		}
	}

	[XmlAttribute]
	public int unloadingFunctionId
	{
		get
		{
			return unloadingFunctionIdField;
		}
		set
		{
			unloadingFunctionIdField = value;
			RaisePropertyChanged("unloadingFunctionId");
		}
	}

	[XmlIgnore]
	public bool unloadingFunctionIdSpecified
	{
		get
		{
			return unloadingFunctionIdFieldSpecified;
		}
		set
		{
			unloadingFunctionIdFieldSpecified = value;
			RaisePropertyChanged("unloadingFunctionIdSpecified");
		}
	}

	[XmlAttribute]
	public int uploadingFunctionId
	{
		get
		{
			return uploadingFunctionIdField;
		}
		set
		{
			uploadingFunctionIdField = value;
			RaisePropertyChanged("uploadingFunctionId");
		}
	}

	[XmlIgnore]
	public bool uploadingFunctionIdSpecified
	{
		get
		{
			return uploadingFunctionIdFieldSpecified;
		}
		set
		{
			uploadingFunctionIdFieldSpecified = value;
			RaisePropertyChanged("uploadingFunctionIdSpecified");
		}
	}
}
