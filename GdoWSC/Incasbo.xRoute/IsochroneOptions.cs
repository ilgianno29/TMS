using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[DesignerCategory("code")]
public class IsochroneOptions : TransientVO
{
	private ExpansionDescription expansionDescField;

	private IsochroneDetail isoDetailField;

	private PolygonCalculationMode polygonCalculationModeField;

	[XmlElement(IsNullable = true, Order = 0)]
	public ExpansionDescription expansionDesc
	{
		get
		{
			return expansionDescField;
		}
		set
		{
			expansionDescField = value;
			RaisePropertyChanged("expansionDesc");
		}
	}

	[XmlAttribute]
	public IsochroneDetail isoDetail
	{
		get
		{
			return isoDetailField;
		}
		set
		{
			isoDetailField = value;
			RaisePropertyChanged("isoDetail");
		}
	}

	[XmlAttribute]
	public PolygonCalculationMode polygonCalculationMode
	{
		get
		{
			return polygonCalculationModeField;
		}
		set
		{
			polygonCalculationModeField = value;
			RaisePropertyChanged("polygonCalculationMode");
		}
	}
}
