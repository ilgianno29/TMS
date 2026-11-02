using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
public class TransportPeriodRestriction : TransientVO
{
	private int destinationTourPointIndexField;

	private int maxPeriodBetweenServicesField;

	private int startTourPointIndexField;

	[XmlAttribute]
	public int destinationTourPointIndex
	{
		get
		{
			return destinationTourPointIndexField;
		}
		set
		{
			destinationTourPointIndexField = value;
			RaisePropertyChanged("destinationTourPointIndex");
		}
	}

	[XmlAttribute]
	public int maxPeriodBetweenServices
	{
		get
		{
			return maxPeriodBetweenServicesField;
		}
		set
		{
			maxPeriodBetweenServicesField = value;
			RaisePropertyChanged("maxPeriodBetweenServices");
		}
	}

	[XmlAttribute]
	public int startTourPointIndex
	{
		get
		{
			return startTourPointIndexField;
		}
		set
		{
			startTourPointIndexField = value;
			RaisePropertyChanged("startTourPointIndex");
		}
	}
}
