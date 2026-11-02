using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Api_UdsSpuntaInArgs
{
	[DataMember]
	public string Unibol { get; set; }

	[DataMember]
	public string Codice { get; set; }

	[DataMember]
	public string UdsMaster { get; set; }

	[DataMember]
	public string IdViaggio { get; set; }

	[DataMember]
	public string IdViaggioLinea { get; set; }

	public Api_UdsSpuntaInArgs()
	{
		string unibol = "";
		Unibol = unibol;
		unibol = "";
		Codice = unibol;
		unibol = "";
		UdsMaster = unibol;
		unibol = "";
		IdViaggio = unibol;
		unibol = "";
		IdViaggioLinea = unibol;
	}
}
