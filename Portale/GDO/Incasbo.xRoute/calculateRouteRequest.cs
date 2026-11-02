using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "calculateRoute", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
public class calculateRouteRequest
{
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	public WaypointDesc[] ArrayOfWaypointDesc_1;

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
	public ResultListOptions ResultListOptions_4;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 4)]
	[XmlElement(IsNullable = true)]
	public CallerContext CallerContext_5;

	public calculateRouteRequest()
	{
	}

	public calculateRouteRequest(WaypointDesc[] ArrayOfWaypointDesc_1, RoutingOption[] ArrayOfRoutingOption_2, ExceptionPath[] ArrayOfExceptionPath_3, ResultListOptions ResultListOptions_4, CallerContext CallerContext_5)
	{
		this.ArrayOfWaypointDesc_1 = ArrayOfWaypointDesc_1;
		this.ArrayOfRoutingOption_2 = ArrayOfRoutingOption_2;
		this.ArrayOfExceptionPath_3 = ArrayOfExceptionPath_3;
		this.ResultListOptions_4 = ResultListOptions_4;
		this.CallerContext_5 = CallerContext_5;
	}
}
