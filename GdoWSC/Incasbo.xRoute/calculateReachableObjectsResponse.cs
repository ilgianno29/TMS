using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[DebuggerStepThrough]
[MessageContract(WrapperName = "calculateReachableObjectsResponse", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
public class calculateReachableObjectsResponse
{
	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	public Reach result;

	public calculateReachableObjectsResponse()
	{
	}

	public calculateReachableObjectsResponse(Reach result)
	{
		this.result = result;
	}
}
