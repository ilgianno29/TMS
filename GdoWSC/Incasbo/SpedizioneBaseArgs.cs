using System;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class SpedizioneBaseArgs
{
	[DataMember]
	public string Unibol;

	[DataMember]
	public string Cliente;

	[DataMember]
	public string NumeroBolla;

	[DataMember]
	public DateTime? DataBolla;

	[DataMember]
	public string NumeroOrdine;

	[DataMember]
	public DateTime? DataOrdine;

	public SpedizioneBaseArgs()
	{
		Unibol = "";
		Cliente = "";
		NumeroBolla = "";
		NumeroOrdine = "";
	}
}
