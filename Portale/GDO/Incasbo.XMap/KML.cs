using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
public class KML : TransientVO
{
	private string[] wrappedPlacemarksField;

	private string kmlField;

	[XmlArray(IsNullable = true, Order = 0)]
	[XmlArrayItem("String", Namespace = "http://wrappertypes.service.jabba.ptvag.com")]
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
