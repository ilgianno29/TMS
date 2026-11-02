using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "matchAddress", WrapperNamespace = "http://types.xlocate.xserver.ptvag.com", IsWrapped = true)]
public class matchAddressRequest
{
	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 0)]
	[XmlElement(IsNullable = true)]
	public Address Address_1;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 1)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xlocate.xserver.ptvag.com")]
	public SearchOptionBase[] ArrayOfSearchOptionBase_2;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 2)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xlocate.xserver.ptvag.com")]
	public SortOption[] ArrayOfSortOption_3;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 3)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xlocate.xserver.ptvag.com", IsNullable = false)]
	public ResultField[] ArrayOfResultField_4;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 4)]
	[XmlElement(IsNullable = true)]
	public CallerContext CallerContext_5;

	public matchAddressRequest()
	{
	}

	public matchAddressRequest(Address Address_1, SearchOptionBase[] ArrayOfSearchOptionBase_2, SortOption[] ArrayOfSortOption_3, ResultField[] ArrayOfResultField_4, CallerContext CallerContext_5)
	{
		this.Address_1 = Address_1;
		this.ArrayOfSearchOptionBase_2 = ArrayOfSearchOptionBase_2;
		this.ArrayOfSortOption_3 = ArrayOfSortOption_3;
		this.ArrayOfResultField_4 = ArrayOfResultField_4;
		this.CallerContext_5 = CallerContext_5;
	}
}
