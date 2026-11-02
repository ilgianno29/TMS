using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xlocate.xserver.ptvag.com")]
public enum ReverseSearchParameter
{
	COUNTRY_CODETYPE,
	RESULT_LANGUAGE,
	ENGINE_TOLERANCE,
	ENGINE_TARGETSIZE,
	ENGINE_FILTERMODE,
	ENGINE_SEARCHRANGE,
	ENGINE_SEARCHDETAILLEVEL,
	ENGINE_MINPOPULATION,
	ENGINE_MINSIZE,
	ENGINE_RETURNALLEQUALDISTANCES
}
