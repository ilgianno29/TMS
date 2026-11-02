using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[MessageContract(WrapperName = "fetchBulkRouteInfoResponse", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class fetchBulkRouteInfoResponse
{
	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	public BulkRouteInfo result;

	public fetchBulkRouteInfoResponse()
	{
	}

	public fetchBulkRouteInfoResponse(BulkRouteInfo result)
	{
		this.result = result;
	}
}
