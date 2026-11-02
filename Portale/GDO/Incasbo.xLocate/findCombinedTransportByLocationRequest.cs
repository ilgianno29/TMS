using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "findCombinedTransportByLocation", WrapperNamespace = "http://types.xlocate.xserver.ptvag.com", IsWrapped = true)]
public class findCombinedTransportByLocationRequest
{
	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 0)]
	[XmlElement(IsNullable = true)]
	public Location Location_1;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 1)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xlocate.xserver.ptvag.com")]
	public SearchOptionBase[] ArrayOfSearchOptionBase_2;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 2)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xlocate.xserver.ptvag.com", IsNullable = false)]
	public ResultField[] ArrayOfResultField_3;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 3)]
	[XmlElement(IsNullable = true)]
	public CallerContext CallerContext_4;

	public findCombinedTransportByLocationRequest()
	{
	}

	public findCombinedTransportByLocationRequest(Location Location_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, ResultField[] ArrayOfResultField_3, CallerContext CallerContext_4)
	{
		this.Location_1 = Location_1;
		this.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		this.ArrayOfResultField_3 = ArrayOfResultField_3;
		this.CallerContext_4 = CallerContext_4;
	}
}
