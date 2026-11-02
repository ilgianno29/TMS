using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class WMS_RaggruppamentoOrdiniArgs
{
	[DataMember]
	public List<OrdineArgs> Ordini;

	[DataMember]
	public string CodiceRaggruppamento;

	[DataMember]
	public decimal? Peso;

	[DataMember]
	public decimal? Volume;

	[DataMember]
	public int? Colli;

	[DataMember]
	public int? Pallet;

	[DataMember]
	public decimal? SagomeVolumetriche;

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

	[DataMember]
	public decimal? CampoCalcolo6;

	[DataMember]
	public decimal? CampoCalcolo7;

	[DataMember]
	public decimal? CampoCalcolo8;

	[DataMember]
	public decimal? CampoCalcolo9;

	public WMS_RaggruppamentoOrdiniArgs()
	{
		CodiceRaggruppamento = "";
	}
}
