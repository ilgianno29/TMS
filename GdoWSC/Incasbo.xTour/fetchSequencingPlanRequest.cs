using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "fetchSequencingPlan", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class fetchSequencingPlanRequest
{
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	[XmlElement(IsNullable = true)]
	public string String_1;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 1)]
	public CallerContext CallerContext_2;

	public fetchSequencingPlanRequest()
	{
	}

	public fetchSequencingPlanRequest(string String_1, CallerContext CallerContext_2)
	{
		this.String_1 = String_1;
		this.CallerContext_2 = CallerContext_2;
	}
}
