using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "matchLocationsResponse", WrapperNamespace = "http://types.xlocate.xserver.ptvag.com", IsWrapped = true)]
public class matchLocationsResponse
{
	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 0)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem("ArrayOfResultAddress", Namespace = "http://xlocate.xserver.ptvag.com")]
	[XmlArrayItem(Namespace = "http://xlocate.xserver.ptvag.com", NestingLevel = 1)]
	public ResultAddress[][] result;

	public matchLocationsResponse()
	{
	}

	public matchLocationsResponse(ResultAddress[][] result)
	{
		this.result = result;
	}
}
