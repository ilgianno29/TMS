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
public class Isochrone : TransientVO
{
	private IsochroneInfo[] wrappedIsochronesField;

	private string additionalField;

	[XmlArray(IsNullable = true, Order = 0)]
	public IsochroneInfo[] wrappedIsochrones
	{
		get
		{
			return wrappedIsochronesField;
		}
		set
		{
			wrappedIsochronesField = value;
			RaisePropertyChanged("wrappedIsochrones");
		}
	}

	[XmlAttribute]
	public string additional
	{
		get
		{
			return additionalField;
		}
		set
		{
			additionalField = value;
			RaisePropertyChanged("additional");
		}
	}
}
