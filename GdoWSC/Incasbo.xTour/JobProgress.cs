using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DesignerCategory("code")]
[XmlInclude(typeof(BulkProgress))]
[XmlInclude(typeof(ZoneLoadingProgress))]
[XmlInclude(typeof(TerritoryProgress))]
[XmlInclude(typeof(ClusterProgress))]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
[XmlInclude(typeof(DistanceMatrixProgress))]
[XmlInclude(typeof(PlanProgress))]
public abstract class JobProgress : TransientVO
{
}
