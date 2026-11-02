using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[DebuggerStepThrough]
[MessageContract(WrapperName = "calculateTour", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
public class calculateTourRequest
{
	[XmlArray(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	public WaypointDesc[] ArrayOfWaypointDesc_1;

	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 1)]
	[XmlArray(IsNullable = true)]
	public RoutingOption[] ArrayOfRoutingOption_2;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 2)]
	[XmlArrayItem(Namespace = "http://xroute.xserver.ptvag.com")]
	[XmlArray(IsNullable = true)]
	public ExceptionPath[] ArrayOfExceptionPath_3;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 3)]
	public ResultListOptions ResultListOptions_4;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 4)]
	[XmlElement(IsNullable = true)]
	public CountryInfoOptions CountryInfoOptions_5;

	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 5)]
	public CallerContext CallerContext_6;

	public calculateTourRequest()
	{
	}

	public calculateTourRequest(WaypointDesc[] ArrayOfWaypointDesc_1, RoutingOption[] ArrayOfRoutingOption_2, ExceptionPath[] ArrayOfExceptionPath_3, ResultListOptions ResultListOptions_4, CountryInfoOptions CountryInfoOptions_5, CallerContext CallerContext_6)
	{
		this.ArrayOfWaypointDesc_1 = ArrayOfWaypointDesc_1;
		this.ArrayOfRoutingOption_2 = ArrayOfRoutingOption_2;
		this.ArrayOfExceptionPath_3 = ArrayOfExceptionPath_3;
		this.ResultListOptions_4 = ResultListOptions_4;
		this.CountryInfoOptions_5 = CountryInfoOptions_5;
		this.CallerContext_6 = CallerContext_6;
	}
}
