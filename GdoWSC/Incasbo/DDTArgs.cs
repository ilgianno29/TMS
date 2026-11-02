using System;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class DDTArgs : OrdineArgs
{
	[DataMember]
	public string NumeroDDT;

	[DataMember]
	public DateTime DataDDT;

	[DataMember]
	public string Corrispondente;

	public DDTArgs()
	{
		NumeroDDT = "";
		Corrispondente = "";
	}
}
