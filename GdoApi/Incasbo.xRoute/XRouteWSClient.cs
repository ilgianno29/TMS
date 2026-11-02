using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Incasbo.xRoute;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class XRouteWSClient : ClientBase<XRouteWS>, XRouteWS
{
	public XRouteWSClient()
	{
	}

	public XRouteWSClient(string endpointConfigurationName)
		: base(endpointConfigurationName)
	{
	}

	public XRouteWSClient(string endpointConfigurationName, string remoteAddress)
		: base(endpointConfigurationName, remoteAddress)
	{
	}

	public XRouteWSClient(string endpointConfigurationName, EndpointAddress remoteAddress)
		: base(endpointConfigurationName, remoteAddress)
	{
	}

	public XRouteWSClient(Binding binding, EndpointAddress remoteAddress)
		: base(binding, remoteAddress)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public calculateAdvancedTourResponse xRoute_XRouteWS_calculateAdvancedTour(calculateAdvancedTourRequest request)
	{
		return base.Channel.calculateAdvancedTour(request);
	}

	calculateAdvancedTourResponse XRouteWS.calculateAdvancedTour(calculateAdvancedTourRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xRoute_XRouteWS_calculateAdvancedTour
		return this.xRoute_XRouteWS_calculateAdvancedTour(request);
	}

	public AdvancedTour calculateAdvancedTour(WaypointDesc[] ArrayOfWaypointDesc_1, TourOptions TourOptions_2, RoutingOption[] ArrayOfRoutingOption_3, ExceptionPath[] ArrayOfExceptionPath_4, ResultListOptions ResultListOptions_5, CountryInfoOptions CountryInfoOptions_6, CallerContext CallerContext_7)
	{
		calculateAdvancedTourRequest calculateAdvancedTourRequest2 = new calculateAdvancedTourRequest();
		calculateAdvancedTourRequest2.ArrayOfWaypointDesc_1 = ArrayOfWaypointDesc_1;
		calculateAdvancedTourRequest2.TourOptions_2 = TourOptions_2;
		calculateAdvancedTourRequest2.ArrayOfRoutingOption_3 = ArrayOfRoutingOption_3;
		calculateAdvancedTourRequest2.ArrayOfExceptionPath_4 = ArrayOfExceptionPath_4;
		calculateAdvancedTourRequest2.ResultListOptions_5 = ResultListOptions_5;
		calculateAdvancedTourRequest2.CountryInfoOptions_6 = CountryInfoOptions_6;
		calculateAdvancedTourRequest2.CallerContext_7 = CallerContext_7;
		calculateAdvancedTourResponse calculateAdvancedTourResponse2 = ((XRouteWS)this).calculateAdvancedTour(calculateAdvancedTourRequest2);
		return calculateAdvancedTourResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public calculateBulkRouteInfoResponse xRoute_XRouteWS_calculateBulkRouteInfo(calculateBulkRouteInfoRequest request)
	{
		return base.Channel.calculateBulkRouteInfo(request);
	}

	calculateBulkRouteInfoResponse XRouteWS.calculateBulkRouteInfo(calculateBulkRouteInfoRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xRoute_XRouteWS_calculateBulkRouteInfo
		return this.xRoute_XRouteWS_calculateBulkRouteInfo(request);
	}

	public BulkRouteInfo calculateBulkRouteInfo(WaypointDesc[][] ArrayOfArrayOfWaypointDesc_1, RoutingOption[] ArrayOfRoutingOption_2, ExceptionPath[] ArrayOfExceptionPath_3, CallerContext CallerContext_4)
	{
		calculateBulkRouteInfoRequest calculateBulkRouteInfoRequest2 = new calculateBulkRouteInfoRequest();
		calculateBulkRouteInfoRequest2.ArrayOfArrayOfWaypointDesc_1 = ArrayOfArrayOfWaypointDesc_1;
		calculateBulkRouteInfoRequest2.ArrayOfRoutingOption_2 = ArrayOfRoutingOption_2;
		calculateBulkRouteInfoRequest2.ArrayOfExceptionPath_3 = ArrayOfExceptionPath_3;
		calculateBulkRouteInfoRequest2.CallerContext_4 = CallerContext_4;
		calculateBulkRouteInfoResponse calculateBulkRouteInfoResponse2 = ((XRouteWS)this).calculateBulkRouteInfo(calculateBulkRouteInfoRequest2);
		return calculateBulkRouteInfoResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public calculateExtendedRouteResponse xRoute_XRouteWS_calculateExtendedRoute(calculateExtendedRouteRequest request)
	{
		return base.Channel.calculateExtendedRoute(request);
	}

	calculateExtendedRouteResponse XRouteWS.calculateExtendedRoute(calculateExtendedRouteRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xRoute_XRouteWS_calculateExtendedRoute
		return this.xRoute_XRouteWS_calculateExtendedRoute(request);
	}

	public ExtendedRoute calculateExtendedRoute(WaypointDesc[] ArrayOfWaypointDesc_1, RoutingOption[] ArrayOfRoutingOption_2, ExceptionPath[] ArrayOfExceptionPath_3, ResultListOptions ResultListOptions_4, CountryInfoOptions CountryInfoOptions_5, CallerContext CallerContext_6)
	{
		calculateExtendedRouteRequest calculateExtendedRouteRequest2 = new calculateExtendedRouteRequest();
		calculateExtendedRouteRequest2.ArrayOfWaypointDesc_1 = ArrayOfWaypointDesc_1;
		calculateExtendedRouteRequest2.ArrayOfRoutingOption_2 = ArrayOfRoutingOption_2;
		calculateExtendedRouteRequest2.ArrayOfExceptionPath_3 = ArrayOfExceptionPath_3;
		calculateExtendedRouteRequest2.ResultListOptions_4 = ResultListOptions_4;
		calculateExtendedRouteRequest2.CountryInfoOptions_5 = CountryInfoOptions_5;
		calculateExtendedRouteRequest2.CallerContext_6 = CallerContext_6;
		calculateExtendedRouteResponse calculateExtendedRouteResponse2 = ((XRouteWS)this).calculateExtendedRoute(calculateExtendedRouteRequest2);
		return calculateExtendedRouteResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public calculateIsochronesResponse xRoute_XRouteWS_calculateIsochrones(calculateIsochronesRequest request)
	{
		return base.Channel.calculateIsochrones(request);
	}

	calculateIsochronesResponse XRouteWS.calculateIsochrones(calculateIsochronesRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xRoute_XRouteWS_calculateIsochrones
		return this.xRoute_XRouteWS_calculateIsochrones(request);
	}

	public Isochrone calculateIsochrones(WaypointDesc WaypointDesc_1, RoutingOption[] ArrayOfRoutingOption_2, IsochroneOptions IsochroneOptions_3, CallerContext CallerContext_4)
	{
		calculateIsochronesRequest calculateIsochronesRequest2 = new calculateIsochronesRequest();
		calculateIsochronesRequest2.WaypointDesc_1 = WaypointDesc_1;
		calculateIsochronesRequest2.ArrayOfRoutingOption_2 = ArrayOfRoutingOption_2;
		calculateIsochronesRequest2.IsochroneOptions_3 = IsochroneOptions_3;
		calculateIsochronesRequest2.CallerContext_4 = CallerContext_4;
		calculateIsochronesResponse calculateIsochronesResponse2 = ((XRouteWS)this).calculateIsochrones(calculateIsochronesRequest2);
		return calculateIsochronesResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public calculateMatrixInfoResponse xRoute_XRouteWS_calculateMatrixInfo(calculateMatrixInfoRequest request)
	{
		return base.Channel.calculateMatrixInfo(request);
	}

	calculateMatrixInfoResponse XRouteWS.calculateMatrixInfo(calculateMatrixInfoRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xRoute_XRouteWS_calculateMatrixInfo
		return this.xRoute_XRouteWS_calculateMatrixInfo(request);
	}

	public MatrixInfo calculateMatrixInfo(WaypointDesc[] ArrayOfWaypointDesc_1, WaypointDesc[] ArrayOfWaypointDesc_2, RoutingOption[] ArrayOfRoutingOption_3, MatrixOptions MatrixOptions_4, CallerContext CallerContext_5)
	{
		calculateMatrixInfoRequest calculateMatrixInfoRequest2 = new calculateMatrixInfoRequest();
		calculateMatrixInfoRequest2.ArrayOfWaypointDesc_1 = ArrayOfWaypointDesc_1;
		calculateMatrixInfoRequest2.ArrayOfWaypointDesc_2 = ArrayOfWaypointDesc_2;
		calculateMatrixInfoRequest2.ArrayOfRoutingOption_3 = ArrayOfRoutingOption_3;
		calculateMatrixInfoRequest2.MatrixOptions_4 = MatrixOptions_4;
		calculateMatrixInfoRequest2.CallerContext_5 = CallerContext_5;
		calculateMatrixInfoResponse calculateMatrixInfoResponse2 = ((XRouteWS)this).calculateMatrixInfo(calculateMatrixInfoRequest2);
		return calculateMatrixInfoResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public calculateReachableObjectsResponse xRoute_XRouteWS_calculateReachableObjects(calculateReachableObjectsRequest request)
	{
		return base.Channel.calculateReachableObjects(request);
	}

	calculateReachableObjectsResponse XRouteWS.calculateReachableObjects(calculateReachableObjectsRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xRoute_XRouteWS_calculateReachableObjects
		return this.xRoute_XRouteWS_calculateReachableObjects(request);
	}

	public Reach calculateReachableObjects(WaypointDesc WaypointDesc_1, string String_2, WaypointDesc[] ArrayOfWaypointDesc_3, RoutingOption[] ArrayOfRoutingOption_4, ExpansionDescription ExpansionDescription_5, CallerContext CallerContext_6)
	{
		calculateReachableObjectsRequest calculateReachableObjectsRequest2 = new calculateReachableObjectsRequest();
		calculateReachableObjectsRequest2.WaypointDesc_1 = WaypointDesc_1;
		calculateReachableObjectsRequest2.String_2 = String_2;
		calculateReachableObjectsRequest2.ArrayOfWaypointDesc_3 = ArrayOfWaypointDesc_3;
		calculateReachableObjectsRequest2.ArrayOfRoutingOption_4 = ArrayOfRoutingOption_4;
		calculateReachableObjectsRequest2.ExpansionDescription_5 = ExpansionDescription_5;
		calculateReachableObjectsRequest2.CallerContext_6 = CallerContext_6;
		calculateReachableObjectsResponse calculateReachableObjectsResponse2 = ((XRouteWS)this).calculateReachableObjects(calculateReachableObjectsRequest2);
		return calculateReachableObjectsResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public calculateRouteResponse xRoute_XRouteWS_calculateRoute(calculateRouteRequest request)
	{
		return base.Channel.calculateRoute(request);
	}

	calculateRouteResponse XRouteWS.calculateRoute(calculateRouteRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xRoute_XRouteWS_calculateRoute
		return this.xRoute_XRouteWS_calculateRoute(request);
	}

	public Route calculateRoute(WaypointDesc[] ArrayOfWaypointDesc_1, RoutingOption[] ArrayOfRoutingOption_2, ExceptionPath[] ArrayOfExceptionPath_3, ResultListOptions ResultListOptions_4, CallerContext CallerContext_5)
	{
		calculateRouteRequest calculateRouteRequest2 = new calculateRouteRequest();
		calculateRouteRequest2.ArrayOfWaypointDesc_1 = ArrayOfWaypointDesc_1;
		calculateRouteRequest2.ArrayOfRoutingOption_2 = ArrayOfRoutingOption_2;
		calculateRouteRequest2.ArrayOfExceptionPath_3 = ArrayOfExceptionPath_3;
		calculateRouteRequest2.ResultListOptions_4 = ResultListOptions_4;
		calculateRouteRequest2.CallerContext_5 = CallerContext_5;
		calculateRouteResponse calculateRouteResponse2 = ((XRouteWS)this).calculateRoute(calculateRouteRequest2);
		return calculateRouteResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public calculateRouteInfoResponse xRoute_XRouteWS_calculateRouteInfo(calculateRouteInfoRequest request)
	{
		return base.Channel.calculateRouteInfo(request);
	}

	calculateRouteInfoResponse XRouteWS.calculateRouteInfo(calculateRouteInfoRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xRoute_XRouteWS_calculateRouteInfo
		return this.xRoute_XRouteWS_calculateRouteInfo(request);
	}

	public RouteInfo calculateRouteInfo(WaypointDesc[] ArrayOfWaypointDesc_1, RoutingOption[] ArrayOfRoutingOption_2, ExceptionPath[] ArrayOfExceptionPath_3, CallerContext CallerContext_4)
	{
		calculateRouteInfoRequest calculateRouteInfoRequest2 = new calculateRouteInfoRequest();
		calculateRouteInfoRequest2.ArrayOfWaypointDesc_1 = ArrayOfWaypointDesc_1;
		calculateRouteInfoRequest2.ArrayOfRoutingOption_2 = ArrayOfRoutingOption_2;
		calculateRouteInfoRequest2.ArrayOfExceptionPath_3 = ArrayOfExceptionPath_3;
		calculateRouteInfoRequest2.CallerContext_4 = CallerContext_4;
		calculateRouteInfoResponse calculateRouteInfoResponse2 = ((XRouteWS)this).calculateRouteInfo(calculateRouteInfoRequest2);
		return calculateRouteInfoResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public calculateTourResponse xRoute_XRouteWS_calculateTour(calculateTourRequest request)
	{
		return base.Channel.calculateTour(request);
	}

	calculateTourResponse XRouteWS.calculateTour(calculateTourRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xRoute_XRouteWS_calculateTour
		return this.xRoute_XRouteWS_calculateTour(request);
	}

	public Tour calculateTour(WaypointDesc[] ArrayOfWaypointDesc_1, RoutingOption[] ArrayOfRoutingOption_2, ExceptionPath[] ArrayOfExceptionPath_3, ResultListOptions ResultListOptions_4, CountryInfoOptions CountryInfoOptions_5, CallerContext CallerContext_6)
	{
		calculateTourRequest calculateTourRequest2 = new calculateTourRequest();
		calculateTourRequest2.ArrayOfWaypointDesc_1 = ArrayOfWaypointDesc_1;
		calculateTourRequest2.ArrayOfRoutingOption_2 = ArrayOfRoutingOption_2;
		calculateTourRequest2.ArrayOfExceptionPath_3 = ArrayOfExceptionPath_3;
		calculateTourRequest2.ResultListOptions_4 = ResultListOptions_4;
		calculateTourRequest2.CountryInfoOptions_5 = CountryInfoOptions_5;
		calculateTourRequest2.CallerContext_6 = CallerContext_6;
		calculateTourResponse calculateTourResponse2 = ((XRouteWS)this).calculateTour(calculateTourRequest2);
		return calculateTourResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public fetchBulkRouteInfoResponse xRoute_XRouteWS_fetchBulkRouteInfo(fetchBulkRouteInfoRequest request)
	{
		return base.Channel.fetchBulkRouteInfo(request);
	}

	fetchBulkRouteInfoResponse XRouteWS.fetchBulkRouteInfo(fetchBulkRouteInfoRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xRoute_XRouteWS_fetchBulkRouteInfo
		return this.xRoute_XRouteWS_fetchBulkRouteInfo(request);
	}

	public BulkRouteInfo fetchBulkRouteInfo(string String_1, CallerContext CallerContext_2)
	{
		fetchBulkRouteInfoRequest fetchBulkRouteInfoRequest2 = new fetchBulkRouteInfoRequest();
		fetchBulkRouteInfoRequest2.String_1 = String_1;
		fetchBulkRouteInfoRequest2.CallerContext_2 = CallerContext_2;
		fetchBulkRouteInfoResponse fetchBulkRouteInfoResponse2 = ((XRouteWS)this).fetchBulkRouteInfo(fetchBulkRouteInfoRequest2);
		return fetchBulkRouteInfoResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public fetchMatrixInfoResponse xRoute_XRouteWS_fetchMatrixInfo(fetchMatrixInfoRequest request)
	{
		return base.Channel.fetchMatrixInfo(request);
	}

	fetchMatrixInfoResponse XRouteWS.fetchMatrixInfo(fetchMatrixInfoRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xRoute_XRouteWS_fetchMatrixInfo
		return this.xRoute_XRouteWS_fetchMatrixInfo(request);
	}

	public MatrixInfo fetchMatrixInfo(string String_1, CallerContext CallerContext_2)
	{
		fetchMatrixInfoRequest fetchMatrixInfoRequest2 = new fetchMatrixInfoRequest();
		fetchMatrixInfoRequest2.String_1 = String_1;
		fetchMatrixInfoRequest2.CallerContext_2 = CallerContext_2;
		fetchMatrixInfoResponse fetchMatrixInfoResponse2 = ((XRouteWS)this).fetchMatrixInfo(fetchMatrixInfoRequest2);
		return fetchMatrixInfoResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public searchForReachableObjectsResponse xRoute_XRouteWS_searchForReachableObjects(searchForReachableObjectsRequest request)
	{
		return base.Channel.searchForReachableObjects(request);
	}

	searchForReachableObjectsResponse XRouteWS.searchForReachableObjects(searchForReachableObjectsRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xRoute_XRouteWS_searchForReachableObjects
		return this.xRoute_XRouteWS_searchForReachableObjects(request);
	}

	public ReachableObjects searchForReachableObjects(WaypointDesc WaypointDesc_1, string String_2, RoutingOption[] ArrayOfRoutingOption_3, ReachableObjectsOptions ReachableObjectsOptions_4, ExceptionPath[] ArrayOfExceptionPath_5, CallerContext CallerContext_6)
	{
		searchForReachableObjectsRequest searchForReachableObjectsRequest2 = new searchForReachableObjectsRequest();
		searchForReachableObjectsRequest2.WaypointDesc_1 = WaypointDesc_1;
		searchForReachableObjectsRequest2.String_2 = String_2;
		searchForReachableObjectsRequest2.ArrayOfRoutingOption_3 = ArrayOfRoutingOption_3;
		searchForReachableObjectsRequest2.ReachableObjectsOptions_4 = ReachableObjectsOptions_4;
		searchForReachableObjectsRequest2.ArrayOfExceptionPath_5 = ArrayOfExceptionPath_5;
		searchForReachableObjectsRequest2.CallerContext_6 = CallerContext_6;
		searchForReachableObjectsResponse searchForReachableObjectsResponse2 = ((XRouteWS)this).searchForReachableObjects(searchForReachableObjectsRequest2);
		return searchForReachableObjectsResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public startCalculateBulkRouteInfoResponse xRoute_XRouteWS_startCalculateBulkRouteInfo(startCalculateBulkRouteInfoRequest request)
	{
		return base.Channel.startCalculateBulkRouteInfo(request);
	}

	startCalculateBulkRouteInfoResponse XRouteWS.startCalculateBulkRouteInfo(startCalculateBulkRouteInfoRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xRoute_XRouteWS_startCalculateBulkRouteInfo
		return this.xRoute_XRouteWS_startCalculateBulkRouteInfo(request);
	}

	public Job startCalculateBulkRouteInfo(WaypointDesc[][] ArrayOfArrayOfWaypointDesc_1, RoutingOption[] ArrayOfRoutingOption_2, ExceptionPath[] ArrayOfExceptionPath_3, CallerContext CallerContext_4)
	{
		startCalculateBulkRouteInfoRequest startCalculateBulkRouteInfoRequest2 = new startCalculateBulkRouteInfoRequest();
		startCalculateBulkRouteInfoRequest2.ArrayOfArrayOfWaypointDesc_1 = ArrayOfArrayOfWaypointDesc_1;
		startCalculateBulkRouteInfoRequest2.ArrayOfRoutingOption_2 = ArrayOfRoutingOption_2;
		startCalculateBulkRouteInfoRequest2.ArrayOfExceptionPath_3 = ArrayOfExceptionPath_3;
		startCalculateBulkRouteInfoRequest2.CallerContext_4 = CallerContext_4;
		startCalculateBulkRouteInfoResponse startCalculateBulkRouteInfoResponse2 = ((XRouteWS)this).startCalculateBulkRouteInfo(startCalculateBulkRouteInfoRequest2);
		return startCalculateBulkRouteInfoResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public startCalculateMatrixInfoResponse xRoute_XRouteWS_startCalculateMatrixInfo(startCalculateMatrixInfoRequest request)
	{
		return base.Channel.startCalculateMatrixInfo(request);
	}

	startCalculateMatrixInfoResponse XRouteWS.startCalculateMatrixInfo(startCalculateMatrixInfoRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xRoute_XRouteWS_startCalculateMatrixInfo
		return this.xRoute_XRouteWS_startCalculateMatrixInfo(request);
	}

	public Job startCalculateMatrixInfo(WaypointDesc[] ArrayOfWaypointDesc_1, WaypointDesc[] ArrayOfWaypointDesc_2, RoutingOption[] ArrayOfRoutingOption_3, MatrixOptions MatrixOptions_4, CallerContext CallerContext_5)
	{
		startCalculateMatrixInfoRequest startCalculateMatrixInfoRequest2 = new startCalculateMatrixInfoRequest();
		startCalculateMatrixInfoRequest2.ArrayOfWaypointDesc_1 = ArrayOfWaypointDesc_1;
		startCalculateMatrixInfoRequest2.ArrayOfWaypointDesc_2 = ArrayOfWaypointDesc_2;
		startCalculateMatrixInfoRequest2.ArrayOfRoutingOption_3 = ArrayOfRoutingOption_3;
		startCalculateMatrixInfoRequest2.MatrixOptions_4 = MatrixOptions_4;
		startCalculateMatrixInfoRequest2.CallerContext_5 = CallerContext_5;
		startCalculateMatrixInfoResponse startCalculateMatrixInfoResponse2 = ((XRouteWS)this).startCalculateMatrixInfo(startCalculateMatrixInfoRequest2);
		return startCalculateMatrixInfoResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public watchJobResponse xRoute_XRouteWS_watchJob(watchJobRequest request)
	{
		return base.Channel.watchJob(request);
	}

	watchJobResponse XRouteWS.watchJob(watchJobRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xRoute_XRouteWS_watchJob
		return this.xRoute_XRouteWS_watchJob(request);
	}

	public Job watchJob(string String_1, WatchOptions WatchOptions_2, CallerContext CallerContext_3)
	{
		watchJobRequest watchJobRequest2 = new watchJobRequest();
		watchJobRequest2.String_1 = String_1;
		watchJobRequest2.WatchOptions_2 = WatchOptions_2;
		watchJobRequest2.CallerContext_3 = CallerContext_3;
		watchJobResponse watchJobResponse2 = ((XRouteWS)this).watchJob(watchJobRequest2);
		return watchJobResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public deleteJobResponse xRoute_XRouteWS_deleteJob(deleteJobRequest request)
	{
		return base.Channel.deleteJob(request);
	}

	deleteJobResponse XRouteWS.deleteJob(deleteJobRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xRoute_XRouteWS_deleteJob
		return this.xRoute_XRouteWS_deleteJob(request);
	}

	public Job deleteJob(string String_1, CallerContext CallerContext_2)
	{
		deleteJobRequest deleteJobRequest2 = new deleteJobRequest();
		deleteJobRequest2.String_1 = String_1;
		deleteJobRequest2.CallerContext_2 = CallerContext_2;
		deleteJobResponse deleteJobResponse2 = ((XRouteWS)this).deleteJob(deleteJobRequest2);
		return deleteJobResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public stopJobResponse xRoute_XRouteWS_stopJob(stopJobRequest request)
	{
		return base.Channel.stopJob(request);
	}

	stopJobResponse XRouteWS.stopJob(stopJobRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xRoute_XRouteWS_stopJob
		return this.xRoute_XRouteWS_stopJob(request);
	}

	public Job stopJob(string String_1, CallerContext CallerContext_2)
	{
		stopJobRequest stopJobRequest2 = new stopJobRequest();
		stopJobRequest2.String_1 = String_1;
		stopJobRequest2.CallerContext_2 = CallerContext_2;
		stopJobResponse stopJobResponse2 = ((XRouteWS)this).stopJob(stopJobRequest2);
		return stopJobResponse2.result;
	}
}
