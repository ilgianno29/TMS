using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[DebuggerStepThrough]
[MessageContract(WrapperName = "findToursForUnscheduledOrderResponse", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class findToursForUnscheduledOrderResponse
{
	[XmlArray(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	[XmlArrayItem(Namespace = "http://xtour.xserver.ptvag.com")]
	public InsertOrderProposal[] result;

	public findToursForUnscheduledOrderResponse()
	{
	}

	public findToursForUnscheduledOrderResponse(InsertOrderProposal[] result)
	{
		this.result = result;
	}
}
