using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
public enum CoordFormat
{
	OG_GEODECIMAL,
	PTV_MERCATOR,
	PTV_GEOMINSEC,
	PTV_GEODECIMAL,
	PTV_CONFORM,
	PTV_SUPERCONFORM,
	PTV_SMARTUNITS,
	OG_SRID
}
