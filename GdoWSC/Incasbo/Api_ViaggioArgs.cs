using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Api_ViaggioArgs
{
	[DataMember]
	public string IdViaggio { get; set; }

	public Api_ViaggioArgs()
	{
		string idViaggio = "";
		IdViaggio = idViaggio;
	}
}
