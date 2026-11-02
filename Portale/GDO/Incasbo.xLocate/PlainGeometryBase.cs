using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[Serializable]
[XmlInclude(typeof(PlainGeometryCollection))]
[XmlInclude(typeof(PlainMultiPolygon))]
[XmlInclude(typeof(PlainMultiLineString))]
[XmlInclude(typeof(PlainMultiPoint))]
[XmlInclude(typeof(PlainLineString))]
[XmlInclude(typeof(PlainPolygon))]
[XmlInclude(typeof(PlainPoint))]
[XmlInclude(typeof(PlainLinearRing))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
public class PlainGeometryBase : TransientVO
{
}
