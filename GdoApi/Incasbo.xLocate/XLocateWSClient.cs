using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
#if !NETFRAMEWORK
using Incasbo.ServiceModel;
#endif

namespace Incasbo.xLocate;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class XLocateWSClient : ClientBase<XLocateWS>, XLocateWS
{
#if NETFRAMEWORK
	public XLocateWSClient()
	{
	}

	public XLocateWSClient(string endpointConfigurationName)
		: base(endpointConfigurationName)
	{
	}

	public XLocateWSClient(string endpointConfigurationName, string remoteAddress)
		: base(endpointConfigurationName, remoteAddress)
	{
	}

	public XLocateWSClient(string endpointConfigurationName, EndpointAddress remoteAddress)
		: base(endpointConfigurationName, remoteAddress)
	{
	}

#else
	// .NET 8: indirizzo e binding da Incasbo.ServiceModel.WcfEndpoints (non piu' dal web.config)
	public XLocateWSClient()
		: base(WcfEndpoints.GetBinding(null, "xLocate.XLocateWS"), WcfEndpoints.GetAddress(null, "xLocate.XLocateWS"))
	{
	}

	public XLocateWSClient(string endpointConfigurationName)
		: base(WcfEndpoints.GetBinding(endpointConfigurationName, "xLocate.XLocateWS"), WcfEndpoints.GetAddress(endpointConfigurationName, "xLocate.XLocateWS"))
	{
	}

	public XLocateWSClient(string endpointConfigurationName, string remoteAddress)
		: base(WcfEndpoints.GetBinding(endpointConfigurationName, "xLocate.XLocateWS"), WcfEndpoints.GetAddress(endpointConfigurationName, "xLocate.XLocateWS", remoteAddress))
	{
	}

	public XLocateWSClient(string endpointConfigurationName, EndpointAddress remoteAddress)
		: base(WcfEndpoints.GetBinding(endpointConfigurationName, "xLocate.XLocateWS"), remoteAddress)
	{
	}

#endif
	public XLocateWSClient(Binding binding, EndpointAddress remoteAddress)
		: base(binding, remoteAddress)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public fetchAddressResponsesResponse xLocate_XLocateWS_fetchAddressResponses(fetchAddressResponsesRequest request)
	{
		return base.Channel.fetchAddressResponses(request);
	}

	fetchAddressResponsesResponse XLocateWS.fetchAddressResponses(fetchAddressResponsesRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_fetchAddressResponses
		return this.xLocate_XLocateWS_fetchAddressResponses(request);
	}

	public AddressResponse[] fetchAddressResponses(string String_1, CallerContext CallerContext_2)
	{
		fetchAddressResponsesRequest fetchAddressResponsesRequest2 = new fetchAddressResponsesRequest();
		fetchAddressResponsesRequest2.String_1 = String_1;
		fetchAddressResponsesRequest2.CallerContext_2 = CallerContext_2;
		fetchAddressResponsesResponse fetchAddressResponsesResponse2 = ((XLocateWS)this).fetchAddressResponses(fetchAddressResponsesRequest2);
		return fetchAddressResponsesResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public fetchPoiAddressResponsesResponse xLocate_XLocateWS_fetchPoiAddressResponses(fetchPoiAddressResponsesRequest request)
	{
		return base.Channel.fetchPoiAddressResponses(request);
	}

	fetchPoiAddressResponsesResponse XLocateWS.fetchPoiAddressResponses(fetchPoiAddressResponsesRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_fetchPoiAddressResponses
		return this.xLocate_XLocateWS_fetchPoiAddressResponses(request);
	}

	public PoiAddressResponse[] fetchPoiAddressResponses(string String_1, CallerContext CallerContext_2)
	{
		fetchPoiAddressResponsesRequest fetchPoiAddressResponsesRequest2 = new fetchPoiAddressResponsesRequest();
		fetchPoiAddressResponsesRequest2.String_1 = String_1;
		fetchPoiAddressResponsesRequest2.CallerContext_2 = CallerContext_2;
		fetchPoiAddressResponsesResponse fetchPoiAddressResponsesResponse2 = ((XLocateWS)this).fetchPoiAddressResponses(fetchPoiAddressResponsesRequest2);
		return fetchPoiAddressResponsesResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public findAddressResponse xLocate_XLocateWS_findAddress(findAddressRequest request)
	{
		return base.Channel.findAddress(request);
	}

	findAddressResponse XLocateWS.findAddress(findAddressRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_findAddress
		return this.xLocate_XLocateWS_findAddress(request);
	}

	public AddressResponse findAddress(Address Address_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, SortOption[] ArrayOfSortOption_3, ResultField[] ArrayOfResultField_4, CallerContext CallerContext_5)
	{
		findAddressRequest findAddressRequest2 = new findAddressRequest();
		findAddressRequest2.Address_1 = Address_1;
		findAddressRequest2.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		findAddressRequest2.ArrayOfSortOption_3 = ArrayOfSortOption_3;
		findAddressRequest2.ArrayOfResultField_4 = ArrayOfResultField_4;
		findAddressRequest2.CallerContext_5 = CallerContext_5;
		findAddressResponse findAddressResponse2 = ((XLocateWS)this).findAddress(findAddressRequest2);
		return findAddressResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public findAddressByTextResponse xLocate_XLocateWS_findAddressByText(findAddressByTextRequest request)
	{
		return base.Channel.findAddressByText(request);
	}

	findAddressByTextResponse XLocateWS.findAddressByText(findAddressByTextRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_findAddressByText
		return this.xLocate_XLocateWS_findAddressByText(request);
	}

	public AddressResponse findAddressByText(string String_1, string String_2, SearchOptionBase[] ArrayOfSearchOptionBase_3, SortOption[] ArrayOfSortOption_4, ResultField[] ArrayOfResultField_5, CallerContext CallerContext_6)
	{
		findAddressByTextRequest findAddressByTextRequest2 = new findAddressByTextRequest();
		findAddressByTextRequest2.String_1 = String_1;
		findAddressByTextRequest2.String_2 = String_2;
		findAddressByTextRequest2.ArrayOfSearchOptionBase_3 = ArrayOfSearchOptionBase_3;
		findAddressByTextRequest2.ArrayOfSortOption_4 = ArrayOfSortOption_4;
		findAddressByTextRequest2.ArrayOfResultField_5 = ArrayOfResultField_5;
		findAddressByTextRequest2.CallerContext_6 = CallerContext_6;
		findAddressByTextResponse findAddressByTextResponse2 = ((XLocateWS)this).findAddressByText(findAddressByTextRequest2);
		return findAddressByTextResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public findAddressesResponse xLocate_XLocateWS_findAddresses(findAddressesRequest request)
	{
		return base.Channel.findAddresses(request);
	}

	findAddressesResponse XLocateWS.findAddresses(findAddressesRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_findAddresses
		return this.xLocate_XLocateWS_findAddresses(request);
	}

	public AddressResponse[] findAddresses(Address[] ArrayOfAddress_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, SortOption[] ArrayOfSortOption_3, ResultField[] ArrayOfResultField_4, CallerContext CallerContext_5)
	{
		findAddressesRequest findAddressesRequest2 = new findAddressesRequest();
		findAddressesRequest2.ArrayOfAddress_1 = ArrayOfAddress_1;
		findAddressesRequest2.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		findAddressesRequest2.ArrayOfSortOption_3 = ArrayOfSortOption_3;
		findAddressesRequest2.ArrayOfResultField_4 = ArrayOfResultField_4;
		findAddressesRequest2.CallerContext_5 = CallerContext_5;
		findAddressesResponse findAddressesResponse2 = ((XLocateWS)this).findAddresses(findAddressesRequest2);
		return findAddressesResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public findCombinedTransportByLocationResponse xLocate_XLocateWS_findCombinedTransportByLocation(findCombinedTransportByLocationRequest request)
	{
		return base.Channel.findCombinedTransportByLocation(request);
	}

	findCombinedTransportByLocationResponse XLocateWS.findCombinedTransportByLocation(findCombinedTransportByLocationRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_findCombinedTransportByLocation
		return this.xLocate_XLocateWS_findCombinedTransportByLocation(request);
	}

	public CombinedTransportResponse findCombinedTransportByLocation(Location Location_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, ResultField[] ArrayOfResultField_3, CallerContext CallerContext_4)
	{
		findCombinedTransportByLocationRequest findCombinedTransportByLocationRequest2 = new findCombinedTransportByLocationRequest();
		findCombinedTransportByLocationRequest2.Location_1 = Location_1;
		findCombinedTransportByLocationRequest2.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		findCombinedTransportByLocationRequest2.ArrayOfResultField_3 = ArrayOfResultField_3;
		findCombinedTransportByLocationRequest2.CallerContext_4 = CallerContext_4;
		findCombinedTransportByLocationResponse findCombinedTransportByLocationResponse2 = ((XLocateWS)this).findCombinedTransportByLocation(findCombinedTransportByLocationRequest2);
		return findCombinedTransportByLocationResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public findLocationResponse xLocate_XLocateWS_findLocation(findLocationRequest request)
	{
		return base.Channel.findLocation(request);
	}

	findLocationResponse XLocateWS.findLocation(findLocationRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_findLocation
		return this.xLocate_XLocateWS_findLocation(request);
	}

	public AddressResponse findLocation(Location Location_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, SortOption[] ArrayOfSortOption_3, ResultField[] ArrayOfResultField_4, CallerContext CallerContext_5)
	{
		findLocationRequest findLocationRequest2 = new findLocationRequest();
		findLocationRequest2.Location_1 = Location_1;
		findLocationRequest2.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		findLocationRequest2.ArrayOfSortOption_3 = ArrayOfSortOption_3;
		findLocationRequest2.ArrayOfResultField_4 = ArrayOfResultField_4;
		findLocationRequest2.CallerContext_5 = CallerContext_5;
		findLocationResponse findLocationResponse2 = ((XLocateWS)this).findLocation(findLocationRequest2);
		return findLocationResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public findLocationsResponse xLocate_XLocateWS_findLocations(findLocationsRequest request)
	{
		return base.Channel.findLocations(request);
	}

	findLocationsResponse XLocateWS.findLocations(findLocationsRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_findLocations
		return this.xLocate_XLocateWS_findLocations(request);
	}

	public AddressResponse[] findLocations(Location[] ArrayOfLocation_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, SortOption[] ArrayOfSortOption_3, ResultField[] ArrayOfResultField_4, CallerContext CallerContext_5)
	{
		findLocationsRequest findLocationsRequest2 = new findLocationsRequest();
		findLocationsRequest2.ArrayOfLocation_1 = ArrayOfLocation_1;
		findLocationsRequest2.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		findLocationsRequest2.ArrayOfSortOption_3 = ArrayOfSortOption_3;
		findLocationsRequest2.ArrayOfResultField_4 = ArrayOfResultField_4;
		findLocationsRequest2.CallerContext_5 = CallerContext_5;
		findLocationsResponse findLocationsResponse2 = ((XLocateWS)this).findLocations(findLocationsRequest2);
		return findLocationsResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public findObjectByTextResponse xLocate_XLocateWS_findObjectByText(findObjectByTextRequest request)
	{
		return base.Channel.findObjectByText(request);
	}

	findObjectByTextResponse XLocateWS.findObjectByText(findObjectByTextRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_findObjectByText
		return this.xLocate_XLocateWS_findObjectByText(request);
	}

	public ObjectResponse findObjectByText(string String_1, string String_2, SearchOptionBase[] ArrayOfSearchOptionBase_3, SortOption[] ArrayOfSortOption_4, ResultField[] ArrayOfResultField_5, CallerContext CallerContext_6)
	{
		findObjectByTextRequest findObjectByTextRequest2 = new findObjectByTextRequest();
		findObjectByTextRequest2.String_1 = String_1;
		findObjectByTextRequest2.String_2 = String_2;
		findObjectByTextRequest2.ArrayOfSearchOptionBase_3 = ArrayOfSearchOptionBase_3;
		findObjectByTextRequest2.ArrayOfSortOption_4 = ArrayOfSortOption_4;
		findObjectByTextRequest2.ArrayOfResultField_5 = ArrayOfResultField_5;
		findObjectByTextRequest2.CallerContext_6 = CallerContext_6;
		findObjectByTextResponse findObjectByTextResponse2 = ((XLocateWS)this).findObjectByText(findObjectByTextRequest2);
		return findObjectByTextResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public findPoiByAddressResponse xLocate_XLocateWS_findPoiByAddress(findPoiByAddressRequest request)
	{
		return base.Channel.findPoiByAddress(request);
	}

	findPoiByAddressResponse XLocateWS.findPoiByAddress(findPoiByAddressRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_findPoiByAddress
		return this.xLocate_XLocateWS_findPoiByAddress(request);
	}

	public PoiAddressResponse findPoiByAddress(PoiAddress PoiAddress_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, SortOption[] ArrayOfSortOption_3, ResultField[] ArrayOfResultField_4, CallerContext CallerContext_5)
	{
		findPoiByAddressRequest findPoiByAddressRequest2 = new findPoiByAddressRequest();
		findPoiByAddressRequest2.PoiAddress_1 = PoiAddress_1;
		findPoiByAddressRequest2.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		findPoiByAddressRequest2.ArrayOfSortOption_3 = ArrayOfSortOption_3;
		findPoiByAddressRequest2.ArrayOfResultField_4 = ArrayOfResultField_4;
		findPoiByAddressRequest2.CallerContext_5 = CallerContext_5;
		findPoiByAddressResponse findPoiByAddressResponse2 = ((XLocateWS)this).findPoiByAddress(findPoiByAddressRequest2);
		return findPoiByAddressResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public findPoiByAddressesResponse xLocate_XLocateWS_findPoiByAddresses(findPoiByAddressesRequest request)
	{
		return base.Channel.findPoiByAddresses(request);
	}

	findPoiByAddressesResponse XLocateWS.findPoiByAddresses(findPoiByAddressesRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_findPoiByAddresses
		return this.xLocate_XLocateWS_findPoiByAddresses(request);
	}

	public PoiAddressResponse[] findPoiByAddresses(PoiAddress[] ArrayOfPoiAddress_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, SortOption[] ArrayOfSortOption_3, ResultField[] ArrayOfResultField_4, CallerContext CallerContext_5)
	{
		findPoiByAddressesRequest findPoiByAddressesRequest2 = new findPoiByAddressesRequest();
		findPoiByAddressesRequest2.ArrayOfPoiAddress_1 = ArrayOfPoiAddress_1;
		findPoiByAddressesRequest2.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		findPoiByAddressesRequest2.ArrayOfSortOption_3 = ArrayOfSortOption_3;
		findPoiByAddressesRequest2.ArrayOfResultField_4 = ArrayOfResultField_4;
		findPoiByAddressesRequest2.CallerContext_5 = CallerContext_5;
		findPoiByAddressesResponse findPoiByAddressesResponse2 = ((XLocateWS)this).findPoiByAddresses(findPoiByAddressesRequest2);
		return findPoiByAddressesResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public findPoiByLocationResponse xLocate_XLocateWS_findPoiByLocation(findPoiByLocationRequest request)
	{
		return base.Channel.findPoiByLocation(request);
	}

	findPoiByLocationResponse XLocateWS.findPoiByLocation(findPoiByLocationRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_findPoiByLocation
		return this.xLocate_XLocateWS_findPoiByLocation(request);
	}

	public PoiAddressResponse findPoiByLocation(PoiLocation PoiLocation_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, SortOption[] ArrayOfSortOption_3, ResultField[] ArrayOfResultField_4, CallerContext CallerContext_5)
	{
		findPoiByLocationRequest findPoiByLocationRequest2 = new findPoiByLocationRequest();
		findPoiByLocationRequest2.PoiLocation_1 = PoiLocation_1;
		findPoiByLocationRequest2.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		findPoiByLocationRequest2.ArrayOfSortOption_3 = ArrayOfSortOption_3;
		findPoiByLocationRequest2.ArrayOfResultField_4 = ArrayOfResultField_4;
		findPoiByLocationRequest2.CallerContext_5 = CallerContext_5;
		findPoiByLocationResponse findPoiByLocationResponse2 = ((XLocateWS)this).findPoiByLocation(findPoiByLocationRequest2);
		return findPoiByLocationResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public findPoiByLocationsResponse xLocate_XLocateWS_findPoiByLocations(findPoiByLocationsRequest request)
	{
		return base.Channel.findPoiByLocations(request);
	}

	findPoiByLocationsResponse XLocateWS.findPoiByLocations(findPoiByLocationsRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_findPoiByLocations
		return this.xLocate_XLocateWS_findPoiByLocations(request);
	}

	public PoiAddressResponse[] findPoiByLocations(PoiLocation[] ArrayOfPoiLocation_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, SortOption[] ArrayOfSortOption_3, ResultField[] ArrayOfResultField_4, CallerContext CallerContext_5)
	{
		findPoiByLocationsRequest findPoiByLocationsRequest2 = new findPoiByLocationsRequest();
		findPoiByLocationsRequest2.ArrayOfPoiLocation_1 = ArrayOfPoiLocation_1;
		findPoiByLocationsRequest2.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		findPoiByLocationsRequest2.ArrayOfSortOption_3 = ArrayOfSortOption_3;
		findPoiByLocationsRequest2.ArrayOfResultField_4 = ArrayOfResultField_4;
		findPoiByLocationsRequest2.CallerContext_5 = CallerContext_5;
		findPoiByLocationsResponse findPoiByLocationsResponse2 = ((XLocateWS)this).findPoiByLocations(findPoiByLocationsRequest2);
		return findPoiByLocationsResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public findSuggestionResponse xLocate_XLocateWS_findSuggestion(findSuggestionRequest request)
	{
		return base.Channel.findSuggestion(request);
	}

	findSuggestionResponse XLocateWS.findSuggestion(findSuggestionRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_findSuggestion
		return this.xLocate_XLocateWS_findSuggestion(request);
	}

	public SuggestionResponse findSuggestion(string String_1, string String_2, string String_3, SearchOptionBase[] ArrayOfSearchOptionBase_4, SortOption[] ArrayOfSortOption_5, ResultField[] ArrayOfResultField_6, CallerContext CallerContext_7)
	{
		findSuggestionRequest findSuggestionRequest2 = new findSuggestionRequest();
		findSuggestionRequest2.String_1 = String_1;
		findSuggestionRequest2.String_2 = String_2;
		findSuggestionRequest2.String_3 = String_3;
		findSuggestionRequest2.ArrayOfSearchOptionBase_4 = ArrayOfSearchOptionBase_4;
		findSuggestionRequest2.ArrayOfSortOption_5 = ArrayOfSortOption_5;
		findSuggestionRequest2.ArrayOfResultField_6 = ArrayOfResultField_6;
		findSuggestionRequest2.CallerContext_7 = CallerContext_7;
		findSuggestionResponse findSuggestionResponse2 = ((XLocateWS)this).findSuggestion(findSuggestionRequest2);
		return findSuggestionResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public matchAddressResponse xLocate_XLocateWS_matchAddress(matchAddressRequest request)
	{
		return base.Channel.matchAddress(request);
	}

	matchAddressResponse XLocateWS.matchAddress(matchAddressRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_matchAddress
		return this.xLocate_XLocateWS_matchAddress(request);
	}

	public ResultAddress[] matchAddress(Address Address_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, SortOption[] ArrayOfSortOption_3, ResultField[] ArrayOfResultField_4, CallerContext CallerContext_5)
	{
		matchAddressRequest matchAddressRequest2 = new matchAddressRequest();
		matchAddressRequest2.Address_1 = Address_1;
		matchAddressRequest2.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		matchAddressRequest2.ArrayOfSortOption_3 = ArrayOfSortOption_3;
		matchAddressRequest2.ArrayOfResultField_4 = ArrayOfResultField_4;
		matchAddressRequest2.CallerContext_5 = CallerContext_5;
		matchAddressResponse matchAddressResponse2 = ((XLocateWS)this).matchAddress(matchAddressRequest2);
		return matchAddressResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public matchAddressesResponse xLocate_XLocateWS_matchAddresses(matchAddressesRequest request)
	{
		return base.Channel.matchAddresses(request);
	}

	matchAddressesResponse XLocateWS.matchAddresses(matchAddressesRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_matchAddresses
		return this.xLocate_XLocateWS_matchAddresses(request);
	}

	public ResultAddress[][] matchAddresses(Address[] ArrayOfAddress_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, SortOption[] ArrayOfSortOption_3, ResultField[] ArrayOfResultField_4, CallerContext CallerContext_5)
	{
		matchAddressesRequest matchAddressesRequest2 = new matchAddressesRequest();
		matchAddressesRequest2.ArrayOfAddress_1 = ArrayOfAddress_1;
		matchAddressesRequest2.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		matchAddressesRequest2.ArrayOfSortOption_3 = ArrayOfSortOption_3;
		matchAddressesRequest2.ArrayOfResultField_4 = ArrayOfResultField_4;
		matchAddressesRequest2.CallerContext_5 = CallerContext_5;
		matchAddressesResponse matchAddressesResponse2 = ((XLocateWS)this).matchAddresses(matchAddressesRequest2);
		return matchAddressesResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public matchLocationResponse xLocate_XLocateWS_matchLocation(matchLocationRequest request)
	{
		return base.Channel.matchLocation(request);
	}

	matchLocationResponse XLocateWS.matchLocation(matchLocationRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_matchLocation
		return this.xLocate_XLocateWS_matchLocation(request);
	}

	public ResultAddress[] matchLocation(Point Point_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, SortOption[] ArrayOfSortOption_3, ResultField[] ArrayOfResultField_4, CallerContext CallerContext_5)
	{
		matchLocationRequest matchLocationRequest2 = new matchLocationRequest();
		matchLocationRequest2.Point_1 = Point_1;
		matchLocationRequest2.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		matchLocationRequest2.ArrayOfSortOption_3 = ArrayOfSortOption_3;
		matchLocationRequest2.ArrayOfResultField_4 = ArrayOfResultField_4;
		matchLocationRequest2.CallerContext_5 = CallerContext_5;
		matchLocationResponse matchLocationResponse2 = ((XLocateWS)this).matchLocation(matchLocationRequest2);
		return matchLocationResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public matchLocationsResponse xLocate_XLocateWS_matchLocations(matchLocationsRequest request)
	{
		return base.Channel.matchLocations(request);
	}

	matchLocationsResponse XLocateWS.matchLocations(matchLocationsRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_matchLocations
		return this.xLocate_XLocateWS_matchLocations(request);
	}

	public ResultAddress[][] matchLocations(Point[] ArrayOfPoint_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, SortOption[] ArrayOfSortOption_3, ResultField[] ArrayOfResultField_4, CallerContext CallerContext_5)
	{
		matchLocationsRequest matchLocationsRequest2 = new matchLocationsRequest();
		matchLocationsRequest2.ArrayOfPoint_1 = ArrayOfPoint_1;
		matchLocationsRequest2.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		matchLocationsRequest2.ArrayOfSortOption_3 = ArrayOfSortOption_3;
		matchLocationsRequest2.ArrayOfResultField_4 = ArrayOfResultField_4;
		matchLocationsRequest2.CallerContext_5 = CallerContext_5;
		matchLocationsResponse matchLocationsResponse2 = ((XLocateWS)this).matchLocations(matchLocationsRequest2);
		return matchLocationsResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public startFindAddressesResponse xLocate_XLocateWS_startFindAddresses(startFindAddressesRequest request)
	{
		return base.Channel.startFindAddresses(request);
	}

	startFindAddressesResponse XLocateWS.startFindAddresses(startFindAddressesRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_startFindAddresses
		return this.xLocate_XLocateWS_startFindAddresses(request);
	}

	public Job startFindAddresses(Address[] ArrayOfAddress_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, SortOption[] ArrayOfSortOption_3, ResultField[] ArrayOfResultField_4, CallerContext CallerContext_5)
	{
		startFindAddressesRequest startFindAddressesRequest2 = new startFindAddressesRequest();
		startFindAddressesRequest2.ArrayOfAddress_1 = ArrayOfAddress_1;
		startFindAddressesRequest2.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		startFindAddressesRequest2.ArrayOfSortOption_3 = ArrayOfSortOption_3;
		startFindAddressesRequest2.ArrayOfResultField_4 = ArrayOfResultField_4;
		startFindAddressesRequest2.CallerContext_5 = CallerContext_5;
		startFindAddressesResponse startFindAddressesResponse2 = ((XLocateWS)this).startFindAddresses(startFindAddressesRequest2);
		return startFindAddressesResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public startFindLocationsResponse xLocate_XLocateWS_startFindLocations(startFindLocationsRequest request)
	{
		return base.Channel.startFindLocations(request);
	}

	startFindLocationsResponse XLocateWS.startFindLocations(startFindLocationsRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_startFindLocations
		return this.xLocate_XLocateWS_startFindLocations(request);
	}

	public Job startFindLocations(Location[] ArrayOfLocation_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, SortOption[] ArrayOfSortOption_3, ResultField[] ArrayOfResultField_4, CallerContext CallerContext_5)
	{
		startFindLocationsRequest startFindLocationsRequest2 = new startFindLocationsRequest();
		startFindLocationsRequest2.ArrayOfLocation_1 = ArrayOfLocation_1;
		startFindLocationsRequest2.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		startFindLocationsRequest2.ArrayOfSortOption_3 = ArrayOfSortOption_3;
		startFindLocationsRequest2.ArrayOfResultField_4 = ArrayOfResultField_4;
		startFindLocationsRequest2.CallerContext_5 = CallerContext_5;
		startFindLocationsResponse startFindLocationsResponse2 = ((XLocateWS)this).startFindLocations(startFindLocationsRequest2);
		return startFindLocationsResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public startFindPoiByAddressesResponse xLocate_XLocateWS_startFindPoiByAddresses(startFindPoiByAddressesRequest request)
	{
		return base.Channel.startFindPoiByAddresses(request);
	}

	startFindPoiByAddressesResponse XLocateWS.startFindPoiByAddresses(startFindPoiByAddressesRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_startFindPoiByAddresses
		return this.xLocate_XLocateWS_startFindPoiByAddresses(request);
	}

	public Job startFindPoiByAddresses(PoiAddress[] ArrayOfPoiAddress_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, SortOption[] ArrayOfSortOption_3, ResultField[] ArrayOfResultField_4, CallerContext CallerContext_5)
	{
		startFindPoiByAddressesRequest startFindPoiByAddressesRequest2 = new startFindPoiByAddressesRequest();
		startFindPoiByAddressesRequest2.ArrayOfPoiAddress_1 = ArrayOfPoiAddress_1;
		startFindPoiByAddressesRequest2.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		startFindPoiByAddressesRequest2.ArrayOfSortOption_3 = ArrayOfSortOption_3;
		startFindPoiByAddressesRequest2.ArrayOfResultField_4 = ArrayOfResultField_4;
		startFindPoiByAddressesRequest2.CallerContext_5 = CallerContext_5;
		startFindPoiByAddressesResponse startFindPoiByAddressesResponse2 = ((XLocateWS)this).startFindPoiByAddresses(startFindPoiByAddressesRequest2);
		return startFindPoiByAddressesResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public startFindPoiByLocationsResponse xLocate_XLocateWS_startFindPoiByLocations(startFindPoiByLocationsRequest request)
	{
		return base.Channel.startFindPoiByLocations(request);
	}

	startFindPoiByLocationsResponse XLocateWS.startFindPoiByLocations(startFindPoiByLocationsRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_startFindPoiByLocations
		return this.xLocate_XLocateWS_startFindPoiByLocations(request);
	}

	public Job startFindPoiByLocations(PoiLocation[] ArrayOfPoiLocation_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, SortOption[] ArrayOfSortOption_3, ResultField[] ArrayOfResultField_4, CallerContext CallerContext_5)
	{
		startFindPoiByLocationsRequest startFindPoiByLocationsRequest2 = new startFindPoiByLocationsRequest();
		startFindPoiByLocationsRequest2.ArrayOfPoiLocation_1 = ArrayOfPoiLocation_1;
		startFindPoiByLocationsRequest2.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		startFindPoiByLocationsRequest2.ArrayOfSortOption_3 = ArrayOfSortOption_3;
		startFindPoiByLocationsRequest2.ArrayOfResultField_4 = ArrayOfResultField_4;
		startFindPoiByLocationsRequest2.CallerContext_5 = CallerContext_5;
		startFindPoiByLocationsResponse startFindPoiByLocationsResponse2 = ((XLocateWS)this).startFindPoiByLocations(startFindPoiByLocationsRequest2);
		return startFindPoiByLocationsResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public watchJobResponse xLocate_XLocateWS_watchJob(watchJobRequest request)
	{
		return base.Channel.watchJob(request);
	}

	watchJobResponse XLocateWS.watchJob(watchJobRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_watchJob
		return this.xLocate_XLocateWS_watchJob(request);
	}

	public Job watchJob(string String_1, WatchOptions WatchOptions_2, CallerContext CallerContext_3)
	{
		watchJobRequest watchJobRequest2 = new watchJobRequest();
		watchJobRequest2.String_1 = String_1;
		watchJobRequest2.WatchOptions_2 = WatchOptions_2;
		watchJobRequest2.CallerContext_3 = CallerContext_3;
		watchJobResponse watchJobResponse2 = ((XLocateWS)this).watchJob(watchJobRequest2);
		return watchJobResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public deleteJobResponse xLocate_XLocateWS_deleteJob(deleteJobRequest request)
	{
		return base.Channel.deleteJob(request);
	}

	deleteJobResponse XLocateWS.deleteJob(deleteJobRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_deleteJob
		return this.xLocate_XLocateWS_deleteJob(request);
	}

	public Job deleteJob(string String_1, CallerContext CallerContext_2)
	{
		deleteJobRequest deleteJobRequest2 = new deleteJobRequest();
		deleteJobRequest2.String_1 = String_1;
		deleteJobRequest2.CallerContext_2 = CallerContext_2;
		deleteJobResponse deleteJobResponse2 = ((XLocateWS)this).deleteJob(deleteJobRequest2);
		return deleteJobResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public stopJobResponse xLocate_XLocateWS_stopJob(stopJobRequest request)
	{
		return base.Channel.stopJob(request);
	}

	stopJobResponse XLocateWS.stopJob(stopJobRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in xLocate_XLocateWS_stopJob
		return this.xLocate_XLocateWS_stopJob(request);
	}

	public Job stopJob(string String_1, CallerContext CallerContext_2)
	{
		stopJobRequest stopJobRequest2 = new stopJobRequest();
		stopJobRequest2.String_1 = String_1;
		stopJobRequest2.CallerContext_2 = CallerContext_2;
		stopJobResponse stopJobResponse2 = ((XLocateWS)this).stopJob(stopJobRequest2);
		return stopJobResponse2.result;
	}
}
