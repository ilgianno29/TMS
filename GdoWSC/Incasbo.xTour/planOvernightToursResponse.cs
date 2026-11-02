using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[MessageContract(WrapperName = "planOvernightToursResponse", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState.Advanced)]
public class planOvernightToursResponse
{
	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	public Plan result;

	public planOvernightToursResponse()
	{
	}

	public planOvernightToursResponse(Plan result)
	{
		this.result = result;
	}
}
