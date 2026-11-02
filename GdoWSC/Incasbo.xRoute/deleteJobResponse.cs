using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[DebuggerStepThrough]
[MessageContract(WrapperName = "deleteJobResponse", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class deleteJobResponse
{
	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	public Job result;

	public deleteJobResponse()
	{
	}

	public deleteJobResponse(Job result)
	{
		this.result = result;
	}
}
