using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Incasbo.TMSServiceForMap;

[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "ProfileEnum", Namespace = "http://schemas.datacontract.org/2004/07/Incasbo")]
public enum ProfileEnum
{
	[EnumMember]
	Batch,
	[EnumMember]
	Interactive
}
