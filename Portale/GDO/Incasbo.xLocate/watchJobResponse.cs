using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "watchJobResponse", WrapperNamespace = "http://types.xlocate.xserver.ptvag.com", IsWrapped = true)]
public class watchJobResponse
{
	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 0)]
	[XmlElement(IsNullable = true)]
	public Job result;

	public watchJobResponse()
	{
	}

	public watchJobResponse(Job result)
	{
		this.result = result;
	}
}
