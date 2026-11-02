using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[DebuggerStepThrough]
[MessageContract(WrapperName = "findToursForUnscheduledOrder", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
public class findToursForUnscheduledOrderRequest
{
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	public int int_1;

	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 1)]
	[XmlArrayItem(Namespace = "http://xtour.xserver.ptvag.com")]
	[XmlArray(IsNullable = true)]
	public TransportOrder[] ArrayOfTransportOrder_2;

	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xtour.xserver.ptvag.com")]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 2)]
	public Depot[] ArrayOfDepot_3;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 3)]
	public Fleet Fleet_4;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 4)]
	public FindToursForOrderParams FindToursForOrderParams_5;

	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 5)]
	[XmlElement(IsNullable = true)]
	public Plan Plan_6;

	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 6)]
	[XmlElement(IsNullable = true)]
	public CallerContext CallerContext_7;

	public findToursForUnscheduledOrderRequest()
	{
	}

	public findToursForUnscheduledOrderRequest(int int_1, TransportOrder[] ArrayOfTransportOrder_2, Depot[] ArrayOfDepot_3, Fleet Fleet_4, FindToursForOrderParams FindToursForOrderParams_5, Plan Plan_6, CallerContext CallerContext_7)
	{
		this.int_1 = int_1;
		this.ArrayOfTransportOrder_2 = ArrayOfTransportOrder_2;
		this.ArrayOfDepot_3 = ArrayOfDepot_3;
		this.Fleet_4 = Fleet_4;
		this.FindToursForOrderParams_5 = FindToursForOrderParams_5;
		this.Plan_6 = Plan_6;
		this.CallerContext_7 = CallerContext_7;
	}
}
