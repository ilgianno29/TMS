using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[DebuggerStepThrough]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[MessageContract(WrapperName = "findUnscheduledOrdersForTourResponse", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
public class findUnscheduledOrdersForTourResponse
{
	[XmlArrayItem(Namespace = "http://xtour.xserver.ptvag.com")]
	[XmlArray(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	public InsertOrderProposal[] result;

	public findUnscheduledOrdersForTourResponse()
	{
	}

	public findUnscheduledOrdersForTourResponse(InsertOrderProposal[] result)
	{
		this.result = result;
	}
}
