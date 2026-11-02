using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Api_UdsAssociaUdtArgs
{
	[DataMember]
	public string[] CodiceUds { get; set; }

	[DataMember]
	public string UdsMaster { get; set; }

	[DataMember]
	public string[] Unibols { get; set; }

	public Api_UdsAssociaUdtArgs()
	{
		string udsMaster = "";
		UdsMaster = udsMaster;
	}
}
