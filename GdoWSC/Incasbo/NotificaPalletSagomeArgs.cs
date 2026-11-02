using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class NotificaPalletSagomeArgs : BatchArgs
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
