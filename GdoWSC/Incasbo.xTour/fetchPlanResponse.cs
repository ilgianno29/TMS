using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[MessageContract(WrapperName = "fetchPlanResponse", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[DebuggerStepThrough]
public class fetchPlanResponse
{
	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	public Plan result;

	public fetchPlanResponse()
	{
	}

	public fetchPlanResponse(Plan result)
	{
		this.result = result;
	}
}
