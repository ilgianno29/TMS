using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
public class Fleet : TransientVO
{
	private Trailer[] wrappedTrailersField;

	private Train[] wrappedTrainsField;

	private Vehicle[] wrappedVehiclesField;

	[XmlArray(IsNullable = true, Order = 0)]
	public Trailer[] wrappedTrailers
	{
		get
		{
			return wrappedTrailersField;
		}
		set
		{
			wrappedTrailersField = value;
			RaisePropertyChanged("wrappedTrailers");
		}
	}

	[XmlArray(IsNullable = true, Order = 1)]
	public Train[] wrappedTrains
	{
		get
		{
			return wrappedTrainsField;
		}
		set
		{
			wrappedTrainsField = value;
			RaisePropertyChanged("wrappedTrains");
		}
	}

	[XmlArray(IsNullable = true, Order = 2)]
	public Vehicle[] wrappedVehicles
	{
		get
		{
			return wrappedVehiclesField;
		}
		set
		{
			wrappedVehiclesField = value;
			RaisePropertyChanged("wrappedVehicles");
		}
	}
}
