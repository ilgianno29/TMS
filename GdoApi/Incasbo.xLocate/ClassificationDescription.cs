using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xlocate.xserver.ptvag.com")]
public enum ClassificationDescription
{
	NOT_CLASSIFIED,
	LOW,
	MEDIUM,
	HIGH,
	EXACT,
	UNIQUE
}
