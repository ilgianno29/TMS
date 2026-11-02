using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class ViaggioPalletSagomeArgs : ViaggioArgs
{
	[DataMember]
	public int? NumeroPallet;

	[DataMember]
	public int? NumeroSagome;

	[DataMember]
	public decimal? Volume;

	[DataMember]
	public int? NumeroPalletEffettivi;

	[DataMember]
	public int? NumeroSagomeEffettive;

	[DataMember]
	public decimal? VolumeEffettivo;
}
