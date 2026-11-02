using System;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Api_UdsSpuntaUscitaInArgs : Api_UdsSpuntaInArgs
{
	[DataMember]
	public DateTime? DataSpunta { get; set; }

	[DataMember]
	public string UtenteSpunta { get; set; }

	[DataMember]
	public bool AssociaViaggio { get; set; }

	public Api_UdsSpuntaUscitaInArgs()
	{
		string utenteSpunta = "";
		UtenteSpunta = utenteSpunta;
		bool associaViaggio = false;
		AssociaViaggio = associaViaggio;
	}
}
