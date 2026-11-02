using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Map_Mezzo
{
	[DataMember]
	public string ProfiloVelocita;

	[DataMember]
	public int IdDima;
}
