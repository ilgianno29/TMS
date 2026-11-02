using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class SpedizioneConfermaPrebollaArgs : SpedizioneBaseArgs
{
	[DataMember]
	public int? Colli;

	[DataMember]
	public int? Pallet;

	[DataMember]
	public decimal? Peso;

	[DataMember]
	public decimal? Volume;

	[DataMember]
	public decimal? CampoCalcolo1;

	[DataMember]
	public decimal? CampoCalcolo2;

	[DataMember]
	public decimal? CampoCalcolo3;

	[DataMember]
	public decimal? CampoCalcolo4;

	[DataMember]
	public decimal? CampoCalcolo5;
}
