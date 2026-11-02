using System;
using System.Runtime.Serialization;

namespace Incasbo;

[DataContract]
public class Api_Uds
{
	[DataMember]
	public string Id { get; set; }

	[DataMember]
	public string Codice { get; set; }

	[DataMember]
	public string Unibol { get; set; }

	[DataMember]
	public string TipoUds { get; set; }

	[DataMember]
	public string Descrizione { get; set; }

	[DataMember]
	public DateTime? SpuntaDataUscita { get; set; }

	[DataMember]
	public string SpuntaOperatoreUscita { get; set; }

	[DataMember]
	public DateTime? SpuntaDataIngresso { get; set; }

	[DataMember]
	public string SpuntaOperatoreIngresso { get; set; }

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
	public decimal? Altezza { get; set; }

	[DataMember]
	public decimal? Larghezza { get; set; }

	[DataMember]
	public decimal? Profondita { get; set; }

	[DataMember]
	public DateTime? InConsegna { get; set; }

	[DataMember]
	public string UdsMaster { get; set; }

	[DataMember]
	public string Filler1 { get; set; }

	[DataMember]
	public string Filler2 { get; set; }

	[DataMember]
	public string Filler3 { get; set; }

	[DataMember]
	public string Filler4 { get; set; }

	[DataMember]
	public string Filler5 { get; set; }

	[DataMember]
	public string Filler6 { get; set; }

	[DataMember]
	public string Filler7 { get; set; }

	[DataMember]
	public string Filler8 { get; set; }

	[DataMember]
	public string Filler9 { get; set; }

	[DataMember]
	public string Filler10 { get; set; }

	[DataMember]
	public string UteIns { get; set; }

	[DataMember]
	public DateTime? DatIns { get; set; }

	[DataMember]
	public string UteAgg { get; set; }

	[DataMember]
	public DateTime? DatAgg { get; set; }

	public Api_Uds()
	{
		string id = "";
		Id = id;
		id = "";
		Codice = id;
		id = "";
		Unibol = id;
		id = "";
		TipoUds = id;
		id = "";
		Descrizione = id;
		id = "";
		SpuntaOperatoreUscita = id;
		id = "";
		SpuntaOperatoreIngresso = id;
		id = "";
		UdsMaster = id;
		id = "";
		Filler1 = id;
		id = "";
		Filler2 = id;
		id = "";
		Filler3 = id;
		id = "";
		Filler4 = id;
		id = "";
		Filler5 = id;
		id = "";
		Filler6 = id;
		id = "";
		Filler7 = id;
		id = "";
		Filler8 = id;
		id = "";
		Filler9 = id;
		id = "";
		Filler10 = id;
		id = "";
		UteIns = id;
		id = "";
		UteAgg = id;
	}
}
