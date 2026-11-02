using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[DebuggerStepThrough]
[MessageContract(WrapperName = "startPlanOvernightToursResponse", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
public class startPlanOvernightToursResponse
{
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	[XmlElement(IsNullable = true)]
	public Job result;

	public startPlanOvernightToursResponse()
	{
	}

	public startPlanOvernightToursResponse(Job result)
	{
		this.result = result;
	}
}
