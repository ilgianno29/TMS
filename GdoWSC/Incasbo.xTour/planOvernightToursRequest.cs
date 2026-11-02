using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[MessageContract(WrapperName = "planOvernightTours", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[DebuggerStepThrough]
public class planOvernightToursRequest
{
	[XmlArrayItem(Namespace = "http://xtour.xserver.ptvag.com")]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	[XmlArray(IsNullable = true)]
	public TransportOrder[] ArrayOfTransportOrder_1;

	[XmlArray(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 1)]
	[XmlArrayItem(Namespace = "http://xtour.xserver.ptvag.com")]
	public Depot[] ArrayOfDepot_2;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 2)]
	public Vehicle Vehicle_3;

	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 3)]
	[XmlElement(IsNullable = true)]
	public OvernightParams OvernightParams_4;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 4)]
	public Plan Plan_5;

	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 5)]
	[XmlElement(IsNullable = true)]
	public CallerContext CallerContext_6;

	public planOvernightToursRequest()
	{
	}

	public planOvernightToursRequest(TransportOrder[] ArrayOfTransportOrder_1, Depot[] ArrayOfDepot_2, Vehicle Vehicle_3, OvernightParams OvernightParams_4, Plan Plan_5, CallerContext CallerContext_6)
	{
		this.ArrayOfTransportOrder_1 = ArrayOfTransportOrder_1;
		this.ArrayOfDepot_2 = ArrayOfDepot_2;
		this.Vehicle_3 = Vehicle_3;
		this.OvernightParams_4 = OvernightParams_4;
		this.Plan_5 = Plan_5;
		this.CallerContext_6 = CallerContext_6;
	}
}
