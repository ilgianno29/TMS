using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[DebuggerStepThrough]
[MessageContract(WrapperName = "calculateReachableObjects", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
public class calculateReachableObjectsRequest
{
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	[XmlElement(IsNullable = true)]
	public WaypointDesc WaypointDesc_1;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 1)]
	public string String_2;

	[XmlArray(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 2)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	public WaypointDesc[] ArrayOfWaypointDesc_3;

	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 3)]
	public RoutingOption[] ArrayOfRoutingOption_4;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 4)]
	[XmlElement(IsNullable = true)]
	public ExpansionDescription ExpansionDescription_5;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 5)]
	[XmlElement(IsNullable = true)]
	public CallerContext CallerContext_6;

	public calculateReachableObjectsRequest()
	{
	}

	public calculateReachableObjectsRequest(WaypointDesc WaypointDesc_1, string String_2, WaypointDesc[] ArrayOfWaypointDesc_3, RoutingOption[] ArrayOfRoutingOption_4, ExpansionDescription ExpansionDescription_5, CallerContext CallerContext_6)
	{
		this.WaypointDesc_1 = WaypointDesc_1;
		this.String_2 = String_2;
		this.ArrayOfWaypointDesc_3 = ArrayOfWaypointDesc_3;
		this.ArrayOfRoutingOption_4 = ArrayOfRoutingOption_4;
		this.ExpansionDescription_5 = ExpansionDescription_5;
		this.CallerContext_6 = CallerContext_6;
	}
}
