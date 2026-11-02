using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "calculateBulkRouteInfo", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
public class calculateBulkRouteInfoRequest
{
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem("ArrayOfWaypointDesc", Namespace = "http://xroute.xserver.ptvag.com")]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com", NestingLevel = 1)]
	public WaypointDesc[][] ArrayOfArrayOfWaypointDesc_1;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 1)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	public RoutingOption[] ArrayOfRoutingOption_2;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 2)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	public ExceptionPath[] ArrayOfExceptionPath_3;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 3)]
	[XmlElement(IsNullable = true)]
	public CallerContext CallerContext_4;

	public calculateBulkRouteInfoRequest()
	{
	}

	public calculateBulkRouteInfoRequest(WaypointDesc[][] ArrayOfArrayOfWaypointDesc_1, RoutingOption[] ArrayOfRoutingOption_2, ExceptionPath[] ArrayOfExceptionPath_3, CallerContext CallerContext_4)
	{
		this.ArrayOfArrayOfWaypointDesc_1 = ArrayOfArrayOfWaypointDesc_1;
		this.ArrayOfRoutingOption_2 = ArrayOfRoutingOption_2;
		this.ArrayOfExceptionPath_3 = ArrayOfExceptionPath_3;
		this.CallerContext_4 = CallerContext_4;
	}
}
