using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlType(Namespace = "http://xroute.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
public enum Currency
{
	NONE,
	EUR,
	GBP,
	DKK,
	NOK,
	SEK,
	CHF,
	PLN,
	SIT,
	SKK,
	SK,
	TRY,
	USD,
	CAD,
	JPY,
	ROL,
	BGN,
	HUF,
	HRK,
	MKD,
	ALL,
	BAM,
	EEK,
	CSD,
	LVL,
	LTL,
	MTL,
	MDL,
	CYP,
	ZAR,
	CZK
}
