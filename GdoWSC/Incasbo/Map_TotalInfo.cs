using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Map_TotalInfo
{
	[DataMember]
	public int? DurataTotale;

	[DataMember]
	public int? DurataGuida;

	[DataMember]
	public decimal? KmTotali;
}
