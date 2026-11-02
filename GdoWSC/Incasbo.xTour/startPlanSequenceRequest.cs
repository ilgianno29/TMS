using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xTour;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "startPlanSequence", WrapperNamespace = "http://types.xtour.xserver.ptvag.com", IsWrapped = true)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[DebuggerStepThrough]
public class startPlanSequenceRequest
{
	[XmlArray(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 0)]
	[XmlArrayItem(Namespace = "http://xtour.xserver.ptvag.com")]
	public SequencingTransportOrder[] ArrayOfSequencingTransportOrder_1;

	[XmlArrayItem(Namespace = "http://xtour.xserver.ptvag.com")]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 1)]
	[XmlArray(IsNullable = true)]
	public Depot[] ArrayOfDepot_2;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 2)]
	public SequencingVehicle SequencingVehicle_3;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 3)]
	public SequencingParams SequencingParams_4;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 4)]
	public SequencingPlan SequencingPlan_5;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xtour.xserver.ptvag.com", Order = 5)]
	public CallerContext CallerContext_6;

	public startPlanSequenceRequest()
	{
	}

	public startPlanSequenceRequest(SequencingTransportOrder[] ArrayOfSequencingTransportOrder_1, Depot[] ArrayOfDepot_2, SequencingVehicle SequencingVehicle_3, SequencingParams SequencingParams_4, SequencingPlan SequencingPlan_5, CallerContext CallerContext_6)
	{
		this.ArrayOfSequencingTransportOrder_1 = ArrayOfSequencingTransportOrder_1;
		this.ArrayOfDepot_2 = ArrayOfDepot_2;
		this.SequencingVehicle_3 = SequencingVehicle_3;
		this.SequencingParams_4 = SequencingParams_4;
		this.SequencingPlan_5 = SequencingPlan_5;
		this.CallerContext_6 = CallerContext_6;
	}
}
