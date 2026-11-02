using System;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class WMS_OrdTrasfArgs
{
	[DataMember]
	public string SkidOrdine;

	[DataMember]
	public string Committente;

	[DataMember]
	public string NumeroOrdine;

	[DataMember]
	public DateTime DataOrdine;

	[DataMember]
	public string Vettore;

	[DataMember]
	public string MagPartenza;

	[DataMember]
	public string MagArrivo;

	[DataMember]
	public string TipoMerce;

	[DataMember]
	public decimal? Peso;

	[DataMember]
	public int? Colli;

	[DataMember]
	public int? Pallet;

	[DataMember]
	public decimal? Volume;

	public WMS_OrdTrasfArgs()
	{
		SkidOrdine = "";
		Committente = "";
		NumeroOrdine = "";
		Vettore = "";
		MagPartenza = "";
		MagArrivo = "";
		TipoMerce = "";
	}
}
