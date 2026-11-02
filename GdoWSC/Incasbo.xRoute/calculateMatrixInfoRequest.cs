using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[DebuggerStepThrough]
[MessageContract(WrapperName = "calculateMatrixInfo", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class calculateMatrixInfoRequest
{
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	[XmlArray(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	public WaypointDesc[] ArrayOfWaypointDesc_1;

	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 1)]
	[XmlArray(IsNullable = true)]
	public WaypointDesc[] ArrayOfWaypointDesc_2;

	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 2)]
	[XmlArray(IsNullable = true)]
	public RoutingOption[] ArrayOfRoutingOption_3;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 3)]
	public MatrixOptions MatrixOptions_4;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 4)]
	[XmlElement(IsNullable = true)]
	public CallerContext CallerContext_5;

	public calculateMatrixInfoRequest()
	{
	}

	public calculateMatrixInfoRequest(WaypointDesc[] ArrayOfWaypointDesc_1, WaypointDesc[] ArrayOfWaypointDesc_2, RoutingOption[] ArrayOfRoutingOption_3, MatrixOptions MatrixOptions_4, CallerContext CallerContext_5)
	{
		this.ArrayOfWaypointDesc_1 = ArrayOfWaypointDesc_1;
		this.ArrayOfWaypointDesc_2 = ArrayOfWaypointDesc_2;
		this.ArrayOfRoutingOption_3 = ArrayOfRoutingOption_3;
		this.MatrixOptions_4 = MatrixOptions_4;
		this.CallerContext_5 = CallerContext_5;
	}
}
