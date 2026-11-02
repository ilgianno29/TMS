using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[DebuggerStepThrough]
[MessageContract(WrapperName = "startPlanBasicTours", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
[EditorBrowsable(EditorBrowsableState.Advanced)]
public class startPlanBasicToursRequest
{
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xtour.xserver.ptvag.com")]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	public TransportOrder[] ArrayOfTransportOrder_1;

	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xtour.xserver.ptvag.com")]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 1)]
	public Depot[] ArrayOfDepot_2;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 2)]
	public Fleet Fleet_3;

	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 3)]
	[XmlElement(IsNullable = true)]
	public PlanningParams PlanningParams_4;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 4)]
	public Plan Plan_5;

	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 5)]
	[XmlElement(IsNullable = true)]
	public CallerContext CallerContext_6;

	public startPlanBasicToursRequest()
	{
	}

	public startPlanBasicToursRequest(TransportOrder[] ArrayOfTransportOrder_1, Depot[] ArrayOfDepot_2, Fleet Fleet_3, PlanningParams PlanningParams_4, Plan Plan_5, CallerContext CallerContext_6)
	{
		this.ArrayOfTransportOrder_1 = ArrayOfTransportOrder_1;
		this.ArrayOfDepot_2 = ArrayOfDepot_2;
		this.Fleet_3 = Fleet_3;
		this.PlanningParams_4 = PlanningParams_4;
		this.Plan_5 = Plan_5;
		this.CallerContext_6 = CallerContext_6;
	}
}
