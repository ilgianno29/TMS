using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.XMap;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "renderMapResponse", WrapperNamespace = "http://types.xmap.xserver.ptvag.com", IsWrapped = true)]
public class renderMapResponse
{
	[MessageBodyMember(Namespace = "http://types.xmap.xserver.ptvag.com", Order = 0)]
	[XmlElement(IsNullable = true)]
	public Map result;

	public renderMapResponse()
	{
	}

	public renderMapResponse(Map result)
	{
		this.result = result;
	}
}
