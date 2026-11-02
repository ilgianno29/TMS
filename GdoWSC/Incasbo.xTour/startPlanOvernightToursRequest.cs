using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[MessageContract(WrapperName = "startPlanOvernightTours", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[DebuggerStepThrough]
public class startPlanOvernightToursRequest
{
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xtour.xserver.ptvag.com")]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	public TransportOrder[] ArrayOfTransportOrder_1;

	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 1)]
	[XmlArrayItem(Namespace = "http://xtour.xserver.ptvag.com")]
	[XmlArray(IsNullable = true)]
	public Depot[] ArrayOfDepot_2;

	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 2)]
	[XmlElement(IsNullable = true)]
	public Vehicle Vehicle_3;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 3)]
	public OvernightParams OvernightParams_4;

	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 4)]
	[XmlElement(IsNullable = true)]
	public Plan Plan_5;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 5)]
	public CallerContext CallerContext_6;

	public startPlanOvernightToursRequest()
	{
	}

	public startPlanOvernightToursRequest(TransportOrder[] ArrayOfTransportOrder_1, Depot[] ArrayOfDepot_2, Vehicle Vehicle_3, OvernightParams OvernightParams_4, Plan Plan_5, CallerContext CallerContext_6)
	{
		this.ArrayOfTransportOrder_1 = ArrayOfTransportOrder_1;
		this.ArrayOfDepot_2 = ArrayOfDepot_2;
		this.Vehicle_3 = Vehicle_3;
		this.OvernightParams_4 = OvernightParams_4;
		this.Plan_5 = Plan_5;
		this.CallerContext_6 = CallerContext_6;
	}
}
