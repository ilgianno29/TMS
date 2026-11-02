using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "findAddressByText", WrapperNamespace = "http://types.xlocate.xserver.ptvag.com", IsWrapped = true)]
public class findAddressByTextRequest
{
	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 0)]
	[XmlElement(IsNullable = true)]
	public string String_1;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 1)]
	[XmlElement(IsNullable = true)]
	public string String_2;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 2)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xlocate.xserver.ptvag.com")]
	public SearchOptionBase[] ArrayOfSearchOptionBase_3;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 3)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xlocate.xserver.ptvag.com")]
	public SortOption[] ArrayOfSortOption_4;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 4)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xlocate.xserver.ptvag.com", IsNullable = false)]
	public ResultField[] ArrayOfResultField_5;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 5)]
	[XmlElement(IsNullable = true)]
	public CallerContext CallerContext_6;

	public findAddressByTextRequest()
	{
	}

	public findAddressByTextRequest(string String_1, string String_2, SearchOptionBase[] ArrayOfSearchOptionBase_3, SortOption[] ArrayOfSortOption_4, ResultField[] ArrayOfResultField_5, CallerContext CallerContext_6)
	{
		this.String_1 = String_1;
		this.String_2 = String_2;
		this.ArrayOfSearchOptionBase_3 = ArrayOfSearchOptionBase_3;
		this.ArrayOfSortOption_4 = ArrayOfSortOption_4;
		this.ArrayOfResultField_5 = ArrayOfResultField_5;
		this.CallerContext_6 = CallerContext_6;
	}
}
