using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "watchJob", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
public class watchJobRequest
{
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	[XmlElement(IsNullable = true)]
	public string String_1;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 1)]
	[XmlElement(IsNullable = true)]
	public WatchOptions WatchOptions_2;

	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 2)]
	[XmlElement(IsNullable = true)]
	public CallerContext CallerContext_3;

	public watchJobRequest()
	{
	}

	public watchJobRequest(string String_1, WatchOptions WatchOptions_2, CallerContext CallerContext_3)
	{
		this.String_1 = String_1;
		this.WatchOptions_2 = WatchOptions_2;
		this.CallerContext_3 = CallerContext_3;
	}
}
