using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Api_ViaggioEliminaArgs
{
	[DataMember]
	public string IdViaggio { get; set; }

	[DataMember]
	public string Terminale { get; set; }

	public Api_ViaggioEliminaArgs()
	{
		string idViaggio = "";
		IdViaggio = idViaggio;
		idViaggio = "";
		Terminale = idViaggio;
	}
}
