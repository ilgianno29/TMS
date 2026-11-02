using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[MessageContract(WrapperName = "fetchSequencingPlanResponse", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState.Advanced)]
public class fetchSequencingPlanResponse
{
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	[XmlElement(IsNullable = true)]
	public SequencingPlan result;

	public fetchSequencingPlanResponse()
	{
	}

	public fetchSequencingPlanResponse(SequencingPlan result)
	{
		this.result = result;
	}
}
