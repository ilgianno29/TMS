using System;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class OrdineArgs
{
	[DataMember]
	public string Skid;

	[DataMember]
	public string Committente;

	[DataMember]
	public string NumeroOrdine;

	[DataMember]
	public DateTime DataOrdine;

	[DataMember]
	public decimal? Peso;

	[DataMember]
	public decimal? Volume;

	[DataMember]
	public int? Colli;

	[DataMember]
	public int? Pallet;

	[DataMember]
	public DateTime? DataSpedizione;

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

	[DataMember]
	public decimal? CampoCalcolo10;

	[DataMember]
	public decimal? Contrassegno;

	public OrdineArgs()
	{
		Skid = "";
		Committente = "";
		NumeroOrdine = "";
	}
}
