using System;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Api_ViaggioLineaRecuperaInArgs
{
	[DataMember]
	public string Id { get; set; }

	[DataMember]
	public DateTime? DataPartenzaPianificata { get; set; }

	[DataMember]
	public string Giro { get; set; }

	[DataMember]
	public string RiferimentoEsterno { get; set; }

	public Api_ViaggioLineaRecuperaInArgs()
	{
		string id = "";
		Id = id;
		id = "";
		Giro = id;
		id = "";
		RiferimentoEsterno = id;
	}
}
