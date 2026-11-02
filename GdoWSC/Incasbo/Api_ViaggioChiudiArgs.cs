using System;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Api_ViaggioChiudiArgs : Api_ViaggioArgs
{
	[DataMember]
	public DateTime? DataChiusura { get; set; }

	[DataMember]
	public string Autista { get; set; }

	[DataMember]
	public string Terminale { get; set; }

	public Api_ViaggioChiudiArgs()
	{
		string autista = "";
		Autista = autista;
		autista = "";
		Terminale = autista;
	}
}
