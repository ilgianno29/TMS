using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "calculateAdvancedTour", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
public class calculateAdvancedTourRequest
{
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	public WaypointDesc[] ArrayOfWaypointDesc_1;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 1)]
	[XmlElement(IsNullable = true)]
	public TourOptions TourOptions_2;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 2)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	public RoutingOption[] ArrayOfRoutingOption_3;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 3)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	public ExceptionPath[] ArrayOfExceptionPath_4;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 4)]
	[XmlElement(IsNullable = true)]
	public ResultListOptions ResultListOptions_5;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 5)]
	[XmlElement(IsNullable = true)]
	public CountryInfoOptions CountryInfoOptions_6;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 6)]
	[XmlElement(IsNullable = true)]
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
