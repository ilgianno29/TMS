using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DebuggerStepThrough]
[XmlInclude(typeof(PlainPoint))]
[XmlInclude(typeof(PlainGeometryCollection))]
[DesignerCategory("code")]
[XmlInclude(typeof(PlainPolygon))]
[XmlInclude(typeof(PlainMultiPolygon))]
[XmlInclude(typeof(PlainLinearRing))]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(PlainLineString))]
[XmlInclude(typeof(PlainMultiPoint))]
[XmlInclude(typeof(PlainMultiLineString))]
public class PlainGeometryBase : TransientVO
{
}
