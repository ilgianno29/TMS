using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[DebuggerStepThrough]
[MessageContract(WrapperName = "calculateBulkRouteInfo", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
[EditorBrowsable(EditorBrowsableState.Advanced)]
public class calculateBulkRouteInfoRequest
{
	[XmlArray(IsNullable = true)]
	[XmlArrayItem("ArrayOfWaypointDesc", Namespace = "http://xroute.xserver.ptvag.com")]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com", NestingLevel = 1)]
	public WaypointDesc[][] ArrayOfArrayOfWaypointDesc_1;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 1)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	[XmlArray(IsNullable = true)]
	public RoutingOption[] ArrayOfRoutingOption_2;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 2)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	[XmlArray(IsNullable = true)]
	public ExceptionPath[] ArrayOfExceptionPath_3;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 3)]
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
