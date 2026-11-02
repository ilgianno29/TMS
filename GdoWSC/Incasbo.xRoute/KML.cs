using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DesignerCategory("code")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public class KML : TransientVO
{
	private string[] wrappedPlacemarksField;

	private string kmlField;

	[XmlArrayItem("String", Namespace = "http://wrappertypes.service.jabba.ptvag.com")]
	[XmlArray(IsNullable = true, Order = 0)]
	public string[] wrappedPlacemarks
	{
		get
		{
			return wrappedPlacemarksField;
		}
		set
		{
			wrappedPlacemarksField = value;
			RaisePropertyChanged("wrappedPlacemarks");
		}
	}

	[XmlAttribute]
	public string kml
	{
		get
		{
			return kmlField;
		}
		set
		{
			kmlField = value;
			RaisePropertyChanged("kml");
		}
	}
}
