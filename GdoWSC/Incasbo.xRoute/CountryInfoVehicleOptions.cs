using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DesignerCategory("code")]
[DebuggerStepThrough]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class CountryInfoVehicleOptions : CountryInfoOptions
{
	private VehicleOption[] wrappedOptionsField;

	[XmlArray(IsNullable = true, Order = 0)]
	public VehicleOption[] wrappedOptions
	{
		get
		{
			return wrappedOptionsField;
		}
		set
		{
			wrappedOptionsField = value;
			RaisePropertyChanged("wrappedOptions");
		}
	}
}
