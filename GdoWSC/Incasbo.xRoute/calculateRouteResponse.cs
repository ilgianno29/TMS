using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[DebuggerStepThrough]
[MessageContract(WrapperName = "calculateRouteResponse", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class calculateRouteResponse
{
	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	public Route result;

	public calculateRouteResponse()
	{
	}

	public calculateRouteResponse(Route result)
	{
		this.result = result;
	}
}
