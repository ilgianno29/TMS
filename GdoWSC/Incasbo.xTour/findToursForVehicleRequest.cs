using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "findToursForVehicle", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class findToursForVehicleRequest
{
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	public int int_1;

	[XmlArrayItem(Namespace = "http://xtour.xserver.ptvag.com")]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 1)]
	[XmlArray(IsNullable = true)]
	public TransportOrder[] ArrayOfTransportOrder_2;

	[XmlArray(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 2)]
	[XmlArrayItem(Namespace = "http://xtour.xserver.ptvag.com")]
	public Depot[] ArrayOfDepot_3;

	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 3)]
	[XmlElement(IsNullable = true)]
	public Fleet Fleet_4;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 4)]
	public FindToursForVehicleParams FindToursForVehicleParams_5;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 5)]
	public Plan Plan_6;

	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 6)]
	[XmlElement(IsNullable = true)]
	public CallerContext CallerContext_7;

	public findToursForVehicleRequest()
	{
	}

	public findToursForVehicleRequest(int int_1, TransportOrder[] ArrayOfTransportOrder_2, Depot[] ArrayOfDepot_3, Fleet Fleet_4, FindToursForVehicleParams FindToursForVehicleParams_5, Plan Plan_6, CallerContext CallerContext_7)
	{
		this.int_1 = int_1;
		this.ArrayOfTransportOrder_2 = ArrayOfTransportOrder_2;
		this.ArrayOfDepot_3 = ArrayOfDepot_3;
		this.Fleet_4 = Fleet_4;
		this.FindToursForVehicleParams_5 = FindToursForVehicleParams_5;
		this.Plan_6 = Plan_6;
		this.CallerContext_7 = CallerContext_7;
	}
}
