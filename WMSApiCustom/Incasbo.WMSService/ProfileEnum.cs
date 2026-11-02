using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace Incasbo.WMSService;

[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
[DataContract(Name = "ProfileEnum", Namespace = "http://schemas.datacontract.org/2004/07/Incas.EasyStor.Host.Tms")]
public enum ProfileEnum
{
	[EnumMember]
	batch,
	[EnumMember]
	interactive
}
