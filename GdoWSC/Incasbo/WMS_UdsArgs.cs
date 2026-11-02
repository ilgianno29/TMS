using System;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class WMS_UdsArgs
{
	[DataMember]
	public string CodiceUds;

	[DataMember]
	public string UdsMaster;

	[DataMember]
	public string SkidOrdine;

	[DataMember]
	public string Committente;

	[DataMember]
	public string NumeroOrdine;

	[DataMember]
	public DateTime DataOrdine;

	[DataMember]
	public string BatchId;

	[DataMember]
	public string TipoUds;

	[DataMember]
	public string Descrizione;

	[DataMember]
	public string OperatoreDiSpunta;

	[DataMember]
	public decimal? Peso;

	[DataMember]
	public int? Colli;

	[DataMember]
	public decimal? Volume;

	[DataMember]
	public decimal? Altezza;

	[DataMember]
	public decimal? Larghezza;

	[DataMember]
	public decimal? Profondita;

	public WMS_UdsArgs()
	{
		CodiceUds = "";
		UdsMaster = "";
		SkidOrdine = "";
		Committente = "";
		NumeroOrdine = "";
		BatchId = "";
		TipoUds = "";
		Descrizione = "";
		OperatoreDiSpunta = "";
	}
}
