using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class ViaggioArgs
{
	[DataMember]
	public string Id;

	public ViaggioArgs()
	{
		Id = "";
	}
}
