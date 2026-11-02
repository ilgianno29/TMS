using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlInclude(typeof(LinearRing))]
[XmlInclude(typeof(Point))]
[XmlInclude(typeof(MultiPoint))]
[XmlInclude(typeof(EncodedGeometry))]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(Polygon))]
[XmlInclude(typeof(LineString))]
[XmlInclude(typeof(MultiLineString))]
[XmlInclude(typeof(MultiPolygon))]
[XmlInclude(typeof(GeometryCollection))]
public abstract class EncodedGeometryBase : TransientVO
{
}
