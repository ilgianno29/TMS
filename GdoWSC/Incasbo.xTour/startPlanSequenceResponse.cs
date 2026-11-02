using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[DebuggerStepThrough]
[MessageContract(WrapperName = "startPlanSequenceResponse", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class startPlanSequenceResponse
{
	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	public Job result;

	public startPlanSequenceResponse()
	{
	}

	public startPlanSequenceResponse(Job result)
	{
		this.result = result;
	}
}
