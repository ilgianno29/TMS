using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
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
