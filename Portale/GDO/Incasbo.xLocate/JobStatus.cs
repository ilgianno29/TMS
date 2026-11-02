using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
public enum JobStatus
{
	QUEUING,
	RUNNING,
	STOPPING,
	SUCCEEDED,
	FAILED,
	DELETED,
	UNKNOWN
}
