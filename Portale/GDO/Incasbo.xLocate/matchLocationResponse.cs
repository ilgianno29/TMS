using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "matchLocationResponse", WrapperNamespace = "http://types.xlocate.xserver.ptvag.com", IsWrapped = true)]
public class matchLocationResponse
{
	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 0)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xlocate.xserver.ptvag.com")]
	public ResultAddress[] result;

	public matchLocationResponse()
	{
	}

	public matchLocationResponse(ResultAddress[] result)
	{
		this.result = result;
	}
}
