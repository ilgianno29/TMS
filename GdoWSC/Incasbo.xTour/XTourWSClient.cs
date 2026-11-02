using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Incasbo.xTour;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[DebuggerStepThrough]
public class XTourWSClient : ClientBase<XTourWS>, XTourWS
{
	public XTourWSClient()
	{
	}

	public XTourWSClient(string endpointConfigurationName)
		: base(endpointConfigurationName)
	{
	}

	public XTourWSClient(string endpointConfigurationName, string remoteAddress)
		: base(endpointConfigurationName, remoteAddress)
	{
	}

	public XTourWSClient(string endpointConfigurationName, EndpointAddress remoteAddress)
		: base(endpointConfigurationName, remoteAddress)
	{
	}

	public XTourWSClient(Binding binding, EndpointAddress remoteAddress)
		: base(binding, remoteAddress)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public fetchPlanResponse xTour_XTourWS_fetchPlan(fetchPlanRequest request)
	{
		return base.Channel.fetchPlan(request);
	}

	fetchPlanResponse XTourWS.fetchPlan(fetchPlanRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xTour_XTourWS_fetchPlan
		return this.xTour_XTourWS_fetchPlan(request);
	}

	public Plan fetchPlan(string String_1, CallerContext CallerContext_2)
	{
		fetchPlanRequest fetchPlanRequest2 = new fetchPlanRequest();
		fetchPlanRequest2.String_1 = String_1;
		fetchPlanRequest2.CallerContext_2 = CallerContext_2;
		fetchPlanResponse fetchPlanResponse2 = ((XTourWS)this).fetchPlan(fetchPlanRequest2);
		return fetchPlanResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public fetchSequencingPlanResponse xTour_XTourWS_fetchSequencingPlan(fetchSequencingPlanRequest request)
	{
		return base.Channel.fetchSequencingPlan(request);
	}

	fetchSequencingPlanResponse XTourWS.fetchSequencingPlan(fetchSequencingPlanRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xTour_XTourWS_fetchSequencingPlan
		return this.xTour_XTourWS_fetchSequencingPlan(request);
	}

	public SequencingPlan fetchSequencingPlan(string String_1, CallerContext CallerContext_2)
	{
		fetchSequencingPlanRequest fetchSequencingPlanRequest2 = new fetchSequencingPlanRequest();
		fetchSequencingPlanRequest2.String_1 = String_1;
		fetchSequencingPlanRequest2.CallerContext_2 = CallerContext_2;
		fetchSequencingPlanResponse fetchSequencingPlanResponse2 = ((XTourWS)this).fetchSequencingPlan(fetchSequencingPlanRequest2);
		return fetchSequencingPlanResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public findToursForUnscheduledOrderResponse xTour_XTourWS_findToursForUnscheduledOrder(findToursForUnscheduledOrderRequest request)
	{
		return base.Channel.findToursForUnscheduledOrder(request);
	}

	findToursForUnscheduledOrderResponse XTourWS.findToursForUnscheduledOrder(findToursForUnscheduledOrderRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xTour_XTourWS_findToursForUnscheduledOrder
		return this.xTour_XTourWS_findToursForUnscheduledOrder(request);
	}

	public InsertOrderProposal[] findToursForUnscheduledOrder(int int_1, TransportOrder[] ArrayOfTransportOrder_2, Depot[] ArrayOfDepot_3, Fleet Fleet_4, FindToursForOrderParams FindToursForOrderParams_5, Plan Plan_6, CallerContext CallerContext_7)
	{
		findToursForUnscheduledOrderRequest findToursForUnscheduledOrderRequest2 = new findToursForUnscheduledOrderRequest();
		findToursForUnscheduledOrderRequest2.int_1 = int_1;
		findToursForUnscheduledOrderRequest2.ArrayOfTransportOrder_2 = ArrayOfTransportOrder_2;
		findToursForUnscheduledOrderRequest2.ArrayOfDepot_3 = ArrayOfDepot_3;
		findToursForUnscheduledOrderRequest2.Fleet_4 = Fleet_4;
		findToursForUnscheduledOrderRequest2.FindToursForOrderParams_5 = FindToursForOrderParams_5;
		findToursForUnscheduledOrderRequest2.Plan_6 = Plan_6;
		findToursForUnscheduledOrderRequest2.CallerContext_7 = CallerContext_7;
		findToursForUnscheduledOrderResponse findToursForUnscheduledOrderResponse2 = ((XTourWS)this).findToursForUnscheduledOrder(findToursForUnscheduledOrderRequest2);
		return findToursForUnscheduledOrderResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public findToursForVehicleResponse xTour_XTourWS_findToursForVehicle(findToursForVehicleRequest request)
	{
		return base.Channel.findToursForVehicle(request);
	}

	findToursForVehicleResponse XTourWS.findToursForVehicle(findToursForVehicleRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xTour_XTourWS_findToursForVehicle
		return this.xTour_XTourWS_findToursForVehicle(request);
	}

	public AssignVehicleProposal[] findToursForVehicle(int int_1, TransportOrder[] ArrayOfTransportOrder_2, Depot[] ArrayOfDepot_3, Fleet Fleet_4, FindToursForVehicleParams FindToursForVehicleParams_5, Plan Plan_6, CallerContext CallerContext_7)
	{
		findToursForVehicleRequest findToursForVehicleRequest2 = new findToursForVehicleRequest();
		findToursForVehicleRequest2.int_1 = int_1;
		findToursForVehicleRequest2.ArrayOfTransportOrder_2 = ArrayOfTransportOrder_2;
		findToursForVehicleRequest2.ArrayOfDepot_3 = ArrayOfDepot_3;
		findToursForVehicleRequest2.Fleet_4 = Fleet_4;
		findToursForVehicleRequest2.FindToursForVehicleParams_5 = FindToursForVehicleParams_5;
		findToursForVehicleRequest2.Plan_6 = Plan_6;
		findToursForVehicleRequest2.CallerContext_7 = CallerContext_7;
		findToursForVehicleResponse findToursForVehicleResponse2 = ((XTourWS)this).findToursForVehicle(findToursForVehicleRequest2);
		return findToursForVehicleResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public findUnscheduledOrdersForTourResponse xTour_XTourWS_findUnscheduledOrdersForTour(findUnscheduledOrdersForTourRequest request)
	{
		return base.Channel.findUnscheduledOrdersForTour(request);
	}

	findUnscheduledOrdersForTourResponse XTourWS.findUnscheduledOrdersForTour(findUnscheduledOrdersForTourRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xTour_XTourWS_findUnscheduledOrdersForTour
		return this.xTour_XTourWS_findUnscheduledOrdersForTour(request);
	}

	public InsertOrderProposal[] findUnscheduledOrdersForTour(int int_1, TransportOrder[] ArrayOfTransportOrder_2, Depot[] ArrayOfDepot_3, Fleet Fleet_4, FindOrdersForTourParams FindOrdersForTourParams_5, Plan Plan_6, CallerContext CallerContext_7)
	{
		findUnscheduledOrdersForTourRequest findUnscheduledOrdersForTourRequest2 = new findUnscheduledOrdersForTourRequest();
		findUnscheduledOrdersForTourRequest2.int_1 = int_1;
		findUnscheduledOrdersForTourRequest2.ArrayOfTransportOrder_2 = ArrayOfTransportOrder_2;
		findUnscheduledOrdersForTourRequest2.ArrayOfDepot_3 = ArrayOfDepot_3;
		findUnscheduledOrdersForTourRequest2.Fleet_4 = Fleet_4;
		findUnscheduledOrdersForTourRequest2.FindOrdersForTourParams_5 = FindOrdersForTourParams_5;
		findUnscheduledOrdersForTourRequest2.Plan_6 = Plan_6;
		findUnscheduledOrdersForTourRequest2.CallerContext_7 = CallerContext_7;
		findUnscheduledOrdersForTourResponse findUnscheduledOrdersForTourResponse2 = ((XTourWS)this).findUnscheduledOrdersForTour(findUnscheduledOrdersForTourRequest2);
		return findUnscheduledOrdersForTourResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public findVehiclesForTourResponse xTour_XTourWS_findVehiclesForTour(findVehiclesForTourRequest request)
	{
		return base.Channel.findVehiclesForTour(request);
	}

	findVehiclesForTourResponse XTourWS.findVehiclesForTour(findVehiclesForTourRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xTour_XTourWS_findVehiclesForTour
		return this.xTour_XTourWS_findVehiclesForTour(request);
	}

	public AssignVehicleProposal[] findVehiclesForTour(int int_1, TransportOrder[] ArrayOfTransportOrder_2, Depot[] ArrayOfDepot_3, Fleet Fleet_4, FindVehiclesForTourParams FindVehiclesForTourParams_5, Plan Plan_6, CallerContext CallerContext_7)
	{
		findVehiclesForTourRequest findVehiclesForTourRequest2 = new findVehiclesForTourRequest();
		findVehiclesForTourRequest2.int_1 = int_1;
		findVehiclesForTourRequest2.ArrayOfTransportOrder_2 = ArrayOfTransportOrder_2;
		findVehiclesForTourRequest2.ArrayOfDepot_3 = ArrayOfDepot_3;
		findVehiclesForTourRequest2.Fleet_4 = Fleet_4;
		findVehiclesForTourRequest2.FindVehiclesForTourParams_5 = FindVehiclesForTourParams_5;
		findVehiclesForTourRequest2.Plan_6 = Plan_6;
		findVehiclesForTourRequest2.CallerContext_7 = CallerContext_7;
		findVehiclesForTourResponse findVehiclesForTourResponse2 = ((XTourWS)this).findVehiclesForTour(findVehiclesForTourRequest2);
		return findVehiclesForTourResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public planBasicToursResponse xTour_XTourWS_planBasicTours(planBasicToursRequest request)
	{
		return base.Channel.planBasicTours(request);
	}

	planBasicToursResponse XTourWS.planBasicTours(planBasicToursRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xTour_XTourWS_planBasicTours
		return this.xTour_XTourWS_planBasicTours(request);
	}

	public Plan planBasicTours(TransportOrder[] ArrayOfTransportOrder_1, Depot[] ArrayOfDepot_2, Fleet Fleet_3, PlanningParams PlanningParams_4, Plan Plan_5, CallerContext CallerContext_6)
	{
		planBasicToursRequest planBasicToursRequest2 = new planBasicToursRequest();
		planBasicToursRequest2.ArrayOfTransportOrder_1 = ArrayOfTransportOrder_1;
		planBasicToursRequest2.ArrayOfDepot_2 = ArrayOfDepot_2;
		planBasicToursRequest2.Fleet_3 = Fleet_3;
		planBasicToursRequest2.PlanningParams_4 = PlanningParams_4;
		planBasicToursRequest2.Plan_5 = Plan_5;
		planBasicToursRequest2.CallerContext_6 = CallerContext_6;
		planBasicToursResponse planBasicToursResponse2 = ((XTourWS)this).planBasicTours(planBasicToursRequest2);
		return planBasicToursResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public planOvernightToursResponse xTour_XTourWS_planOvernightTours(planOvernightToursRequest request)
	{
		return base.Channel.planOvernightTours(request);
	}

	planOvernightToursResponse XTourWS.planOvernightTours(planOvernightToursRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xTour_XTourWS_planOvernightTours
		return this.xTour_XTourWS_planOvernightTours(request);
	}

	public Plan planOvernightTours(TransportOrder[] ArrayOfTransportOrder_1, Depot[] ArrayOfDepot_2, Vehicle Vehicle_3, OvernightParams OvernightParams_4, Plan Plan_5, CallerContext CallerContext_6)
	{
		planOvernightToursRequest planOvernightToursRequest2 = new planOvernightToursRequest();
		planOvernightToursRequest2.ArrayOfTransportOrder_1 = ArrayOfTransportOrder_1;
		planOvernightToursRequest2.ArrayOfDepot_2 = ArrayOfDepot_2;
		planOvernightToursRequest2.Vehicle_3 = Vehicle_3;
		planOvernightToursRequest2.OvernightParams_4 = OvernightParams_4;
		planOvernightToursRequest2.Plan_5 = Plan_5;
		planOvernightToursRequest2.CallerContext_6 = CallerContext_6;
		planOvernightToursResponse planOvernightToursResponse2 = ((XTourWS)this).planOvernightTours(planOvernightToursRequest2);
		return planOvernightToursResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public planSequenceResponse xTour_XTourWS_planSequence(planSequenceRequest request)
	{
		return base.Channel.planSequence(request);
	}

	planSequenceResponse XTourWS.planSequence(planSequenceRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xTour_XTourWS_planSequence
		return this.xTour_XTourWS_planSequence(request);
	}

	public SequencingPlan planSequence(SequencingTransportOrder[] ArrayOfSequencingTransportOrder_1, Depot[] ArrayOfDepot_2, SequencingVehicle SequencingVehicle_3, SequencingParams SequencingParams_4, SequencingPlan SequencingPlan_5, CallerContext CallerContext_6)
	{
		planSequenceRequest planSequenceRequest2 = new planSequenceRequest();
		planSequenceRequest2.ArrayOfSequencingTransportOrder_1 = ArrayOfSequencingTransportOrder_1;
		planSequenceRequest2.ArrayOfDepot_2 = ArrayOfDepot_2;
		planSequenceRequest2.SequencingVehicle_3 = SequencingVehicle_3;
		planSequenceRequest2.SequencingParams_4 = SequencingParams_4;
		planSequenceRequest2.SequencingPlan_5 = SequencingPlan_5;
		planSequenceRequest2.CallerContext_6 = CallerContext_6;
		planSequenceResponse planSequenceResponse2 = ((XTourWS)this).planSequence(planSequenceRequest2);
		return planSequenceResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public startPlanBasicToursResponse xTour_XTourWS_startPlanBasicTours(startPlanBasicToursRequest request)
	{
		return base.Channel.startPlanBasicTours(request);
	}

	startPlanBasicToursResponse XTourWS.startPlanBasicTours(startPlanBasicToursRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xTour_XTourWS_startPlanBasicTours
		return this.xTour_XTourWS_startPlanBasicTours(request);
	}

	public Job startPlanBasicTours(TransportOrder[] ArrayOfTransportOrder_1, Depot[] ArrayOfDepot_2, Fleet Fleet_3, PlanningParams PlanningParams_4, Plan Plan_5, CallerContext CallerContext_6)
	{
		startPlanBasicToursRequest startPlanBasicToursRequest2 = new startPlanBasicToursRequest();
		startPlanBasicToursRequest2.ArrayOfTransportOrder_1 = ArrayOfTransportOrder_1;
		startPlanBasicToursRequest2.ArrayOfDepot_2 = ArrayOfDepot_2;
		startPlanBasicToursRequest2.Fleet_3 = Fleet_3;
		startPlanBasicToursRequest2.PlanningParams_4 = PlanningParams_4;
		startPlanBasicToursRequest2.Plan_5 = Plan_5;
		startPlanBasicToursRequest2.CallerContext_6 = CallerContext_6;
		startPlanBasicToursResponse startPlanBasicToursResponse2 = ((XTourWS)this).startPlanBasicTours(startPlanBasicToursRequest2);
		return startPlanBasicToursResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public startPlanOvernightToursResponse xTour_XTourWS_startPlanOvernightTours(startPlanOvernightToursRequest request)
	{
		return base.Channel.startPlanOvernightTours(request);
	}

	startPlanOvernightToursResponse XTourWS.startPlanOvernightTours(startPlanOvernightToursRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xTour_XTourWS_startPlanOvernightTours
		return this.xTour_XTourWS_startPlanOvernightTours(request);
	}

	public Job startPlanOvernightTours(TransportOrder[] ArrayOfTransportOrder_1, Depot[] ArrayOfDepot_2, Vehicle Vehicle_3, OvernightParams OvernightParams_4, Plan Plan_5, CallerContext CallerContext_6)
	{
		startPlanOvernightToursRequest startPlanOvernightToursRequest2 = new startPlanOvernightToursRequest();
		startPlanOvernightToursRequest2.ArrayOfTransportOrder_1 = ArrayOfTransportOrder_1;
		startPlanOvernightToursRequest2.ArrayOfDepot_2 = ArrayOfDepot_2;
		startPlanOvernightToursRequest2.Vehicle_3 = Vehicle_3;
		startPlanOvernightToursRequest2.OvernightParams_4 = OvernightParams_4;
		startPlanOvernightToursRequest2.Plan_5 = Plan_5;
		startPlanOvernightToursRequest2.CallerContext_6 = CallerContext_6;
		startPlanOvernightToursResponse startPlanOvernightToursResponse2 = ((XTourWS)this).startPlanOvernightTours(startPlanOvernightToursRequest2);
		return startPlanOvernightToursResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public startPlanSequenceResponse xTour_XTourWS_startPlanSequence(startPlanSequenceRequest request)
	{
		return base.Channel.startPlanSequence(request);
	}

	startPlanSequenceResponse XTourWS.startPlanSequence(startPlanSequenceRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xTour_XTourWS_startPlanSequence
		return this.xTour_XTourWS_startPlanSequence(request);
	}

	public Job startPlanSequence(SequencingTransportOrder[] ArrayOfSequencingTransportOrder_1, Depot[] ArrayOfDepot_2, SequencingVehicle SequencingVehicle_3, SequencingParams SequencingParams_4, SequencingPlan SequencingPlan_5, CallerContext CallerContext_6)
	{
		startPlanSequenceRequest startPlanSequenceRequest2 = new startPlanSequenceRequest();
		startPlanSequenceRequest2.ArrayOfSequencingTransportOrder_1 = ArrayOfSequencingTransportOrder_1;
		startPlanSequenceRequest2.ArrayOfDepot_2 = ArrayOfDepot_2;
		startPlanSequenceRequest2.SequencingVehicle_3 = SequencingVehicle_3;
		startPlanSequenceRequest2.SequencingParams_4 = SequencingParams_4;
		startPlanSequenceRequest2.SequencingPlan_5 = SequencingPlan_5;
		startPlanSequenceRequest2.CallerContext_6 = CallerContext_6;
		startPlanSequenceResponse startPlanSequenceResponse2 = ((XTourWS)this).startPlanSequence(startPlanSequenceRequest2);
		return startPlanSequenceResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public watchJobResponse xTour_XTourWS_watchJob(watchJobRequest request)
	{
		return base.Channel.watchJob(request);
	}

	watchJobResponse XTourWS.watchJob(watchJobRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xTour_XTourWS_watchJob
		return this.xTour_XTourWS_watchJob(request);
	}

	public Job watchJob(string String_1, WatchOptions WatchOptions_2, CallerContext CallerContext_3)
	{
		watchJobRequest watchJobRequest2 = new watchJobRequest();
		watchJobRequest2.String_1 = String_1;
		watchJobRequest2.WatchOptions_2 = WatchOptions_2;
		watchJobRequest2.CallerContext_3 = CallerContext_3;
		watchJobResponse watchJobResponse2 = ((XTourWS)this).watchJob(watchJobRequest2);
		return watchJobResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public deleteJobResponse xTour_XTourWS_deleteJob(deleteJobRequest request)
	{
		return base.Channel.deleteJob(request);
	}

	deleteJobResponse XTourWS.deleteJob(deleteJobRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xTour_XTourWS_deleteJob
		return this.xTour_XTourWS_deleteJob(request);
	}

	public Job deleteJob(string String_1, CallerContext CallerContext_2)
	{
		deleteJobRequest deleteJobRequest2 = new deleteJobRequest();
		deleteJobRequest2.String_1 = String_1;
		deleteJobRequest2.CallerContext_2 = CallerContext_2;
		deleteJobResponse deleteJobResponse2 = ((XTourWS)this).deleteJob(deleteJobRequest2);
		return deleteJobResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public stopJobResponse xTour_XTourWS_stopJob(stopJobRequest request)
	{
		return base.Channel.stopJob(request);
	}

	stopJobResponse XTourWS.stopJob(stopJobRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xTour_XTourWS_stopJob
		return this.xTour_XTourWS_stopJob(request);
	}

	public Job stopJob(string String_1, CallerContext CallerContext_2)
	{
		stopJobRequest stopJobRequest2 = new stopJobRequest();
		stopJobRequest2.String_1 = String_1;
		stopJobRequest2.CallerContext_2 = CallerContext_2;
		stopJobResponse stopJobResponse2 = ((XTourWS)this).stopJob(stopJobRequest2);
		return stopJobResponse2.result;
	}
}
