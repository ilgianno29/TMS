using System;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Api_ViaggioRiapriArgs : Api_ViaggioArgs
{
	[DataMember]
	public DateTime? DataRiapertura { get; set; }

	[DataMember]
	public string Autista { get; set; }

	[DataMember]
	public string Terminale { get; set; }

	public Api_ViaggioRiapriArgs()
	{
		string autista = "";
		Autista = autista;
		autista = "";
		Terminale = autista;
	}
}
