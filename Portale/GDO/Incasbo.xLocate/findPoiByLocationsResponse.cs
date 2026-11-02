using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "findPoiByLocationsResponse", WrapperNamespace = "http://types.xlocate.xserver.ptvag.com", IsWrapped = true)]
public class findPoiByLocationsResponse
{
	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 0)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xlocate.xserver.ptvag.com")]
	public PoiAddressResponse[] result;

	public findPoiByLocationsResponse()
	{
	}

	public findPoiByLocationsResponse(PoiAddressResponse[] result)
	{
		this.result = result;
	}
}
