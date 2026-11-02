using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Serialization;

namespace Incasbo.xLocate;

[DebuggerStepThrough]
[GeneratedCode("System.ServiceModel", "4.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[MessageContract(WrapperName = "findSuggestion", WrapperNamespace = "http://types.xlocate.xserver.ptvag.com", IsWrapped = true)]
public class findSuggestionRequest
{
	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 0)]
	[XmlElement(IsNullable = true)]
	public string String_1;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 1)]
	[XmlElement(IsNullable = true)]
	public string String_2;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 2)]
	[XmlElement(IsNullable = true)]
	public string String_3;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 3)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xlocate.xserver.ptvag.com")]
	public SearchOptionBase[] ArrayOfSearchOptionBase_4;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 4)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xlocate.xserver.ptvag.com")]
	public SortOption[] ArrayOfSortOption_5;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 5)]
	[XmlArray(IsNullable = true)]
	[XmlArrayItem(Namespace = "http://xlocate.xserver.ptvag.com", IsNullable = false)]
	public ResultField[] ArrayOfResultField_6;

	[MessageBodyMember(Namespace = "http://types.xlocate.xserver.ptvag.com", Order = 6)]
	[XmlElement(IsNullable = true)]
	public CallerContext CallerContext_7;

	public findSuggestionRequest()
	{
	}

	public findSuggestionRequest(string String_1, string String_2, string String_3, SearchOptionBase[] ArrayOfSearchOptionBase_4, SortOption[] ArrayOfSortOption_5, ResultField[] ArrayOfResultField_6, CallerContext CallerContext_7)
	{
		this.String_1 = String_1;
		this.String_2 = String_2;
		this.String_3 = String_3;
		this.ArrayOfSearchOptionBase_4 = ArrayOfSearchOptionBase_4;
		this.ArrayOfSortOption_5 = ArrayOfSortOption_5;
		this.ArrayOfResultField_6 = ArrayOfResultField_6;
		this.CallerContext_7 = CallerContext_7;
	}
}
