using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[XmlInclude(typeof(UnscheduledOrderAnalysisParams))]
public class CalculationParams : PlanningParams
{
}
