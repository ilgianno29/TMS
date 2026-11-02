using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class BatchArgs
{
	[DataMember]
	public string Id;

	public BatchArgs()
	{
		Id = "";
	}
}
