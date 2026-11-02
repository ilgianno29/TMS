using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[DebuggerStepThrough]
[MessageContract(WrapperName = "calculateAdvancedTour", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
[EditorBrowsable(EditorBrowsableState.Advanced)]
public class calculateAdvancedTourRequest
{
	[XmlArray(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	public WaypointDesc[] ArrayOfWaypointDesc_1;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 1)]
	public TourOptions TourOptions_2;

	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	[XmlArray(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 2)]
	public RoutingOption[] ArrayOfRoutingOption_3;

	[XmlArray(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 3)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	public ExceptionPath[] ArrayOfExceptionPath_4;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 4)]
	public ResultListOptions ResultListOptions_5;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 5)]
	[XmlElement(IsNullable = true)]
	public CountryInfoOptions CountryInfoOptions_6;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 6)]
	public CallerContext CallerContext_7;

	public calculateAdvancedTourRequest()
	{
	}

	public calculateAdvancedTourRequest(WaypointDesc[] ArrayOfWaypointDesc_1, TourOptions TourOptions_2, RoutingOption[] ArrayOfRoutingOption_3, ExceptionPath[] ArrayOfExceptionPath_4, ResultListOptions ResultListOptions_5, CountryInfoOptions CountryInfoOptions_6, CallerContext CallerContext_7)
	{
		this.ArrayOfWaypointDesc_1 = ArrayOfWaypointDesc_1;
		this.TourOptions_2 = TourOptions_2;
		this.ArrayOfRoutingOption_3 = ArrayOfRoutingOption_3;
		this.ArrayOfExceptionPath_4 = ArrayOfExceptionPath_4;
		this.ResultListOptions_5 = ResultListOptions_5;
		this.CountryInfoOptions_6 = CountryInfoOptions_6;
		this.CallerContext_7 = CallerContext_7;
	}
}
