using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Incasbo.XMap;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
public class XMapWSClient : ClientBase<XMapWS>, XMapWS
{
	public XMapWSClient()
	{
	}

	public XMapWSClient(string endpointConfigurationName)
		: base(endpointConfigurationName)
	{
	}

	public XMapWSClient(string endpointConfigurationName, string remoteAddress)
		: base(endpointConfigurationName, remoteAddress)
	{
	}

	public XMapWSClient(string endpointConfigurationName, EndpointAddress remoteAddress)
		: base(endpointConfigurationName, remoteAddress)
	{
	}

	public XMapWSClient(Binding binding, EndpointAddress remoteAddress)
		: base(binding, remoteAddress)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public renderMapResponse XMap_XMapWS_renderMap(renderMapRequest request)
	{
		return base.Channel.renderMap(request);
	}

	renderMapResponse XMapWS.renderMap(renderMapRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in XMap_XMapWS_renderMap
		return this.XMap_XMapWS_renderMap(request);
	}

	public Map renderMap(MapSection MapSection_1, MapParams MapParams_2, ImageInfo ImageInfo_3, Layer[] ArrayOfLayer_4, bool boolean_5, CallerContext CallerContext_6)
	{
		renderMapRequest renderMapRequest2 = new renderMapRequest();
		renderMapRequest2.MapSection_1 = MapSection_1;
		renderMapRequest2.MapParams_2 = MapParams_2;
		renderMapRequest2.ImageInfo_3 = ImageInfo_3;
		renderMapRequest2.ArrayOfLayer_4 = ArrayOfLayer_4;
		renderMapRequest2.boolean_5 = boolean_5;
		renderMapRequest2.CallerContext_6 = CallerContext_6;
		renderMapResponse renderMapResponse2 = ((XMapWS)this).renderMap(renderMapRequest2);
		return renderMapResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public renderMapBoundingBoxResponse XMap_XMapWS_renderMapBoundingBox(renderMapBoundingBoxRequest request)
	{
		return base.Channel.renderMapBoundingBox(request);
	}

	renderMapBoundingBoxResponse XMapWS.renderMapBoundingBox(renderMapBoundingBoxRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in XMap_XMapWS_renderMapBoundingBox
		return this.XMap_XMapWS_renderMapBoundingBox(request);
	}

	public Map renderMapBoundingBox(BoundingBox BoundingBox_1, MapParams MapParams_2, ImageInfo ImageInfo_3, Layer[] ArrayOfLayer_4, bool boolean_5, CallerContext CallerContext_6)
	{
		renderMapBoundingBoxRequest renderMapBoundingBoxRequest2 = new renderMapBoundingBoxRequest();
		renderMapBoundingBoxRequest2.BoundingBox_1 = BoundingBox_1;
		renderMapBoundingBoxRequest2.MapParams_2 = MapParams_2;
		renderMapBoundingBoxRequest2.ImageInfo_3 = ImageInfo_3;
		renderMapBoundingBoxRequest2.ArrayOfLayer_4 = ArrayOfLayer_4;
		renderMapBoundingBoxRequest2.boolean_5 = boolean_5;
		renderMapBoundingBoxRequest2.CallerContext_6 = CallerContext_6;
		renderMapBoundingBoxResponse renderMapBoundingBoxResponse2 = ((XMapWS)this).renderMapBoundingBox(renderMapBoundingBoxRequest2);
		return renderMapBoundingBoxResponse2.result;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public renderMapRotResponse XMap_XMapWS_renderMapRot(renderMapRotRequest request)
	{
		return base.Channel.renderMapRot(request);
	}

	renderMapRotResponse XMapWS.renderMapRot(renderMapRotRequest request)
	{
		//ILSpy generated this explicit interface implementation from .override directive in XMap_XMapWS_renderMapRot
		return this.XMap_XMapWS_renderMapRot(request);
	}

	public Map renderMapRot(MapSectionRot MapSectionRot_1, MapParams MapParams_2, ImageInfo ImageInfo_3, Layer[] ArrayOfLayer_4, bool boolean_5, CallerContext CallerContext_6)
	{
		renderMapRotRequest renderMapRotRequest2 = new renderMapRotRequest();
		renderMapRotRequest2.MapSectionRot_1 = MapSectionRot_1;
		renderMapRotRequest2.MapParams_2 = MapParams_2;
		renderMapRotRequest2.ImageInfo_3 = ImageInfo_3;
		renderMapRotRequest2.ArrayOfLayer_4 = ArrayOfLayer_4;
		renderMapRotRequest2.boolean_5 = boolean_5;
		renderMapRotRequest2.CallerContext_6 = CallerContext_6;
		renderMapRotResponse renderMapRotResponse2 = ((XMapWS)this).renderMapRot(renderMapRotRequest2);
		return renderMapRotResponse2.result;
	}
}
