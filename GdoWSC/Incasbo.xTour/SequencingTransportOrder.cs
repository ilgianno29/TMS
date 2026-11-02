using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[Serializable]
[DesignerCategory("code")]
[XmlInclude(typeof(SequencingTransportDepot))]
[XmlType(Namespace = "http://xtour.xserver.ptvag.com")]
[DebuggerStepThrough]
[GeneratedCode("System.Xml", "4.0.30319.34234")]
[XmlInclude(typeof(SequencingTransportAB))]
public abstract class SequencingTransportOrder : AbstractTransportOrder
{
}
