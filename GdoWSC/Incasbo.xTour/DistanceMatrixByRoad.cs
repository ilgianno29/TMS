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
public class DistanceMatrixByRoad : DistanceMatrixCalculation
{
	private bool deleteAfterUsageField;

	private bool deleteBeforeUsageField;

	private string profileNameField;

	private DateTime referenceTimeField;

	private bool referenceTimeFieldSpecified;

	[XmlAttribute]
	public bool deleteAfterUsage
	{
		get
		{
			return deleteAfterUsageField;
		}
		set
		{
			deleteAfterUsageField = value;
			RaisePropertyChanged("deleteAfterUsage");
		}
	}

	[XmlAttribute]
	public bool deleteBeforeUsage
	{
		get
		{
			return deleteBeforeUsageField;
		}
		set
		{
			deleteBeforeUsageField = value;
			RaisePropertyChanged("deleteBeforeUsage");
		}
	}

	[XmlAttribute]
	public string profileName
	{
		get
		{
			return profileNameField;
		}
		set
		{
			profileNameField = value;
			RaisePropertyChanged("profileName");
		}
	}

	[XmlAttribute]
	public DateTime referenceTime
	{
		get
		{
			return referenceTimeField;
		}
		set
		{
			referenceTimeField = value;
			RaisePropertyChanged("referenceTime");
		}
	}

	[XmlIgnore]
	public bool referenceTimeSpecified
	{
		get
		{
			return referenceTimeFieldSpecified;
		}
		set
		{
			referenceTimeFieldSpecified = value;
			RaisePropertyChanged("referenceTimeSpecified");
		}
	}
}
