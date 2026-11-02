using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "calculateTourResponse", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
public class calculateTourResponse
{
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	[XmlElement(IsNullable = true)]
	public Tour result;

	public calculateTourResponse()
	{
	}

	public calculateTourResponse(Tour result)
	{
		this.result = result;
	}
}
