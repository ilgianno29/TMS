using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[MessageContract(WrapperName = "planBasicTours", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
public class planBasicToursRequest
{
	[XmlArray(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	[XmlArrayItem(Namespace = "http://xtour.xserver.ptvag.com")]
	public TransportOrder[] ArrayOfTransportOrder_1;

	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 1)]
	[XmlArrayItem(Namespace = "http://xtour.xserver.ptvag.com")]
	[XmlArray(IsNullable = true)]
	public Depot[] ArrayOfDepot_2;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 2)]
	public Fleet Fleet_3;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 3)]
	public PlanningParams PlanningParams_4;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 4)]
	public Plan Plan_5;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 5)]
	public CallerContext CallerContext_6;

	public planBasicToursRequest()
	{
	}

	public planBasicToursRequest(TransportOrder[] ArrayOfTransportOrder_1, Depot[] ArrayOfDepot_2, Fleet Fleet_3, PlanningParams PlanningParams_4, Plan Plan_5, CallerContext CallerContext_6)
	{
		this.ArrayOfTransportOrder_1 = ArrayOfTransportOrder_1;
		this.ArrayOfDepot_2 = ArrayOfDepot_2;
		this.Fleet_3 = Fleet_3;
		this.PlanningParams_4 = PlanningParams_4;
		this.Plan_5 = Plan_5;
		this.CallerContext_6 = CallerContext_6;
	}
}
