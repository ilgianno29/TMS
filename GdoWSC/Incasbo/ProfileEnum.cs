using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public enum ProfileEnum
{
	[EnumMember]
	Batch,
	[EnumMember]
	Interactive
}
