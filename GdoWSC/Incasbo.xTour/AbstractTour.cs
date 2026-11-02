using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlInclude(typeof(SequencingTour))]
[XmlInclude(typeof(Tour))]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DebuggerStepThrough]
public abstract class AbstractTour : TransientVO
{
	private int startTimeEarliestField;

	private bool startTimeEarliestFieldSpecified;

	private bool startTimeFixedField;

	[XmlAttribute]
	public int startTimeEarliest
	{
		get
		{
			return startTimeEarliestField;
		}
		set
		{
			startTimeEarliestField = value;
			RaisePropertyChanged("startTimeEarliest");
		}
	}

	[XmlIgnore]
	public bool startTimeEarliestSpecified
	{
		get
		{
			return startTimeEarliestFieldSpecified;
		}
		set
		{
			startTimeEarliestFieldSpecified = value;
			RaisePropertyChanged("startTimeEarliestSpecified");
		}
	}

	[XmlAttribute]
	public bool startTimeFixed
	{
		get
		{
			return startTimeFixedField;
		}
		set
		{
			startTimeFixedField = value;
			RaisePropertyChanged("startTimeFixed");
		}
	}
}
