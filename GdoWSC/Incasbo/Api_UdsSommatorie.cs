using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Api_UdsSommatorie
{
	[DataMember]
	public decimal? PesoLordo { get; set; }

	[DataMember]
	public int? Colli { get; set; }

	[DataMember]
	public int? Pallet { get; set; }

	[DataMember]
	public decimal? Volume { get; set; }

	[DataMember]
	public decimal? PalletVolumetrici { get; set; }

	[DataMember]
	public decimal? ValoreMerce { get; set; }

	[DataMember]
	public decimal? CampoCalcolo1 { get; set; }

	[DataMember]
	public decimal? CampoCalcolo2 { get; set; }

	[DataMember]
	public decimal? CampoCalcolo3 { get; set; }

	[DataMember]
	public decimal? CampoCalcolo4 { get; set; }

	[DataMember]
	public decimal? CampoCalcolo5 { get; set; }

	[DataMember]
	public decimal? CampoCalcolo6 { get; set; }

	[DataMember]
	public decimal? CampoCalcolo7 { get; set; }

	[DataMember]
	public decimal? CampoCalcolo8 { get; set; }

	[DataMember]
	public decimal? CampoCalcolo9 { get; set; }

	[DataMember]
	public decimal? CampoCalcolo10 { get; set; }

	[DataMember]
	public int? NumeroSpedizioni { get; set; }

	[DataMember]
	public int? TotaleUds { get; set; }

	[DataMember]
	public int? TotaleUdt { get; set; }

	[DataMember]
	public int? TotaleUdsSpuntate { get; set; }

	[DataMember]
	public int? TotaleUdtSpuntate { get; set; }
}
