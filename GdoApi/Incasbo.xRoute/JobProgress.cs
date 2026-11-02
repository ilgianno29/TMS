using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlInclude(typeof(ZoneLoadingProgress))]
[XmlInclude(typeof(TerritoryProgress))]
[XmlInclude(typeof(ClusterProgress))]
[XmlInclude(typeof(PlanProgress))]
[XmlInclude(typeof(DistanceMatrixProgress))]
[XmlInclude(typeof(BulkProgress))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
public abstract class JobProgress : TransientVO
{
}
