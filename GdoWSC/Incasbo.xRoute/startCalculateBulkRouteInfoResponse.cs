using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[MessageContract(WrapperName = "startCalculateBulkRouteInfoResponse", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[DebuggerStepThrough]
public class startCalculateBulkRouteInfoResponse
{
	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	public Job result;

	public startCalculateBulkRouteInfoResponse()
	{
	}

	public startCalculateBulkRouteInfoResponse(Job result)
	{
		this.result = result;
	}
}
