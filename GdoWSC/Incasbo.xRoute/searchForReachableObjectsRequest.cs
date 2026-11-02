using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[MessageContract(WrapperName = "searchForReachableObjects", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[DebuggerStepThrough]
public class searchForReachableObjectsRequest
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
	public RoutingOption[] ArrayOfRoutingOption_3;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 3)]
	[XmlElement(IsNullable = true)]
	public ReachableObjectsOptions ReachableObjectsOptions_4;

	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 4)]
	public ExceptionPath[] ArrayOfExceptionPath_5;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 5)]
	[XmlElement(IsNullable = true)]
	public CallerContext CallerContext_6;

	public searchForReachableObjectsRequest()
	{
	}

	public searchForReachableObjectsRequest(WaypointDesc WaypointDesc_1, string String_2, RoutingOption[] ArrayOfRoutingOption_3, ReachableObjectsOptions ReachableObjectsOptions_4, ExceptionPath[] ArrayOfExceptionPath_5, CallerContext CallerContext_6)
	{
		this.WaypointDesc_1 = WaypointDesc_1;
		this.String_2 = String_2;
		this.ArrayOfRoutingOption_3 = ArrayOfRoutingOption_3;
		this.ReachableObjectsOptions_4 = ReachableObjectsOptions_4;
		this.ArrayOfExceptionPath_5 = ArrayOfExceptionPath_5;
		this.CallerContext_6 = CallerContext_6;
	}
}
