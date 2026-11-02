using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DesignerCategory("code")]
public class Chain : TransientVO
{
	private ChainResult resultField;

	private Tour[] wrappedToursField;

	private int vehicleIdField;

	[XmlElement(IsNullable = true, Order = 0)]
	public ChainResult result
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
	public Tour[] wrappedTours
	{
		get
		{
			return wrappedToursField;
		}
		set
		{
			wrappedToursField = value;
			RaisePropertyChanged("wrappedTours");
		}
	}

	[XmlAttribute]
	public int vehicleId
	{
		get
		{
			return vehicleIdField;
		}
		set
		{
			vehicleIdField = value;
			RaisePropertyChanged("vehicleId");
		}
	}
}
