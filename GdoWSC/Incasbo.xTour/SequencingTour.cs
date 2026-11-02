using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class SequencingTour : AbstractTour
{
	private SequencingTourResult resultField;

	private SequencingTourPoint[] wrappedTourPointsField;

	[XmlElement(IsNullable = true, Order = 0)]
	public SequencingTourResult result
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

	[XmlArray(IsNullable = true, Order = 1)]
	public SequencingTourPoint[] wrappedTourPoints
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
}
