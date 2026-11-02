using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[DebuggerStepThrough]
[MessageContract(WrapperName = "startPlanBasicToursResponse", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
public class startPlanBasicToursResponse
{
	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	public Job result;

	public startPlanBasicToursResponse()
	{
	}

	public startPlanBasicToursResponse(Job result)
	{
		this.result = result;
	}
}
