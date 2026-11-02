using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[DebuggerStepThrough]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
[DesignerCategory("code")]
[XmlInclude(typeof(ZoneLoadingProgress))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(PlanProgress))]
[XmlInclude(typeof(DistanceMatrixProgress))]
[XmlInclude(typeof(ClusterProgress))]
[XmlInclude(typeof(TerritoryProgress))]
[XmlInclude(typeof(BulkProgress))]
public abstract class JobProgress : TransientVO
{
}
