using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[MessageContract(WrapperName = "fetchPlan", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
public class fetchPlanRequest
{
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	[XmlElement(IsNullable = true)]
	public string String_1;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 1)]
	public CallerContext CallerContext_2;

	public fetchPlanRequest()
	{
	}

	public fetchPlanRequest(string String_1, CallerContext CallerContext_2)
	{
		this.String_1 = String_1;
		this.CallerContext_2 = CallerContext_2;
	}
}
