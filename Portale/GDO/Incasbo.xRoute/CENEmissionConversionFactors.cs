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
public class CENEmissionConversionFactors : TransientVO
{
	private CENEmissions conversionFactorsField;

	private int biofuelPercentField;

	[XmlElement(IsNullable = true, Order = 0)]
	public CENEmissions conversionFactors
	{
		get
		{
			return conversionFactorsField;
		}
		set
		{
			conversionFactorsField = value;
			RaisePropertyChanged("conversionFactors");
		}
	}

	[XmlAttribute]
	public int biofuelPercent
	{
		get
		{
			return biofuelPercentField;
		}
		set
		{
			biofuelPercentField = value;
			RaisePropertyChanged("biofuelPercent");
		}
	}
}
