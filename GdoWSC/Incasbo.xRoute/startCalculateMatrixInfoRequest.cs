using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[MessageContract(WrapperName = "startCalculateMatrixInfo", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class startCalculateMatrixInfoRequest
{
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	[XmlArray(IsNullable = true)]
	public WaypointDesc[] ArrayOfWaypointDesc_1;

	[XmlArray(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 1)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	public WaypointDesc[] ArrayOfWaypointDesc_2;

	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	[XmlArray(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 2)]
	public RoutingOption[] ArrayOfRoutingOption_3;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 3)]
	[XmlElement(IsNullable = true)]
	public MatrixOptions MatrixOptions_4;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 4)]
	public CallerContext CallerContext_5;

	public startCalculateMatrixInfoRequest()
	{
	}

	public startCalculateMatrixInfoRequest(WaypointDesc[] ArrayOfWaypointDesc_1, WaypointDesc[] ArrayOfWaypointDesc_2, RoutingOption[] ArrayOfRoutingOption_3, MatrixOptions MatrixOptions_4, CallerContext CallerContext_5)
	{
		this.ArrayOfWaypointDesc_1 = ArrayOfWaypointDesc_1;
		this.ArrayOfWaypointDesc_2 = ArrayOfWaypointDesc_2;
		this.ArrayOfRoutingOption_3 = ArrayOfRoutingOption_3;
		this.MatrixOptions_4 = MatrixOptions_4;
		this.CallerContext_5 = CallerContext_5;
	}
}
