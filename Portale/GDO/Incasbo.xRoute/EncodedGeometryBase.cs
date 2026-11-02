using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[Serializable]
[XmlInclude(typeof(EncodedGeometry))]
[XmlInclude(typeof(GeometryCollection))]
[XmlInclude(typeof(MultiPolygon))]
[XmlInclude(typeof(MultiLineString))]
[XmlInclude(typeof(MultiPoint))]
[XmlInclude(typeof(Point))]
[XmlInclude(typeof(LineString))]
[XmlInclude(typeof(Polygon))]
[XmlInclude(typeof(LinearRing))]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://common.xserver.ptvag.com")]
public abstract class EncodedGeometryBase : TransientVO
{
}
