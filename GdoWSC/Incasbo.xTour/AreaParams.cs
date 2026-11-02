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
public class AreaParams : StandardParams
{
	private bool allowMultipleToursPerAreaField;

	private bool allowMultipleToursPerAreaFieldSpecified;

	private bool ignoreAreaNumbersInImprovementStepField;

	private bool ignoreAreaNumbersInImprovementStepFieldSpecified;

	[XmlAttribute]
	public bool allowMultipleToursPerArea
	{
		get
		{
			return allowMultipleToursPerAreaField;
		}
		set
		{
			allowMultipleToursPerAreaField = value;
			RaisePropertyChanged("allowMultipleToursPerArea");
		}
	}

	[XmlIgnore]
	public bool allowMultipleToursPerAreaSpecified
	{
		get
		{
			return allowMultipleToursPerAreaFieldSpecified;
		}
		set
		{
			allowMultipleToursPerAreaFieldSpecified = value;
			RaisePropertyChanged("allowMultipleToursPerAreaSpecified");
		}
	}

	[XmlAttribute]
	public bool ignoreAreaNumbersInImprovementStep
	{
		get
		{
			return ignoreAreaNumbersInImprovementStepField;
		}
		set
		{
			ignoreAreaNumbersInImprovementStepField = value;
			RaisePropertyChanged("ignoreAreaNumbersInImprovementStep");
		}
	}

	[XmlIgnore]
	public bool ignoreAreaNumbersInImprovementStepSpecified
	{
		get
		{
			return ignoreAreaNumbersInImprovementStepFieldSpecified;
		}
		set
		{
			ignoreAreaNumbersInImprovementStepFieldSpecified = value;
			RaisePropertyChanged("ignoreAreaNumbersInImprovementStepSpecified");
		}
	}
}
