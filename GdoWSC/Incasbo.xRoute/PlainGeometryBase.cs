using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(PlainPolygon))]
[XmlInclude(typeof(PlainGeometryCollection))]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[XmlInclude(typeof(PlainLinearRing))]
[XmlInclude(typeof(PlainPoint))]
[XmlInclude(typeof(PlainLineString))]
[XmlInclude(typeof(PlainMultiPoint))]
[XmlInclude(typeof(PlainMultiLineString))]
[XmlInclude(typeof(PlainMultiPolygon))]
public class PlainGeometryBase : TransientVO
{
}
