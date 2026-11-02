using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "calculateIsochrones", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
public class calculateIsochronesRequest
{
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	[XmlElement(IsNullable = true)]
	public WaypointDesc WaypointDesc_1;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 1)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	public RoutingOption[] ArrayOfRoutingOption_2;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 2)]
	[XmlElement(IsNullable = true)]
	public IsochroneOptions IsochroneOptions_3;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 3)]
	[XmlElement(IsNullable = true)]
	public CallerContext CallerContext_4;

	public calculateIsochronesRequest()
	{
	}

	public calculateIsochronesRequest(WaypointDesc WaypointDesc_1, RoutingOption[] ArrayOfRoutingOption_2, IsochroneOptions IsochroneOptions_3, CallerContext CallerContext_4)
	{
		this.WaypointDesc_1 = WaypointDesc_1;
		this.ArrayOfRoutingOption_2 = ArrayOfRoutingOption_2;
		this.IsochroneOptions_3 = IsochroneOptions_3;
		this.CallerContext_4 = CallerContext_4;
	}
}
