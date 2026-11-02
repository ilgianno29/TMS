using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Api_UdsSpuntaUscitaAnnullaInArgs : Api_UdsSpuntaInArgs
{
	[DataMember]
	public bool DisassociaViaggio { get; set; }

	public Api_UdsSpuntaUscitaAnnullaInArgs()
	{
		bool disassociaViaggio = false;
		DisassociaViaggio = disassociaViaggio;
	}
}
