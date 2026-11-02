using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xRoute;

[MessageContract(WrapperName = "fetchMatrixInfoResponse", WrapperNamespace = "http://types.xroute.xserver.ptvag.com", IsWrapped = true)]
[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
public class fetchMatrixInfoResponse
{
	[XmlElement(IsNullable = true)]
	[MessageBodyMember(Namespace = "http://types.xroute.xserver.ptvag.com", Order = 0)]
	public MatrixInfo result;

	public fetchMatrixInfoResponse()
	{
	}

	public fetchMatrixInfoResponse(MatrixInfo result)
	{
		this.result = result;
	}
}
