using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[DebuggerStepThrough]
[MessageContract(WrapperName = "deleteJobResponse", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
public class deleteJobResponse
{
	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	public Job result;

	public deleteJobResponse()
	{
	}

	public deleteJobResponse(Job result)
	{
		this.result = result;
	}
}
