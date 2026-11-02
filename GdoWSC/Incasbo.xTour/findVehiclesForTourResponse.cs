using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[MessageContract(WrapperName = "findVehiclesForTourResponse", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState.Advanced)]
public class findVehiclesForTourResponse
{
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xtour.xserver.ptvag.com")]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	public AssignVehicleProposal[] result;

	public findVehiclesForTourResponse()
	{
	}

	public findVehiclesForTourResponse(AssignVehicleProposal[] result)
	{
		this.result = result;
	}
}
