using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[MessageContract(WrapperName = "fetchBulkRouteInfo", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
[DebuggerStepThrough]
public class fetchBulkRouteInfoRequest
{
	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	public string String_1;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 1)]
	[XmlElement(IsNullable = true)]
	public CallerContext CallerContext_2;

	public fetchBulkRouteInfoRequest()
	{
	}

	public fetchBulkRouteInfoRequest(string String_1, CallerContext CallerContext_2)
	{
		this.String_1 = String_1;
		this.CallerContext_2 = CallerContext_2;
	}
}
