using System;
using Incasbo.Web.Library;

namespace Incasbo.Api.Gdo;

[CustomListAttributes("TableName", "SpedizioniUDS", "Key", new string[] { "Codice", "Unibol" })]
public class UDS
{
	public long? Id { get; set; }

	public string Codice { get; set; }

	public string Unibol { get; set; }

	public string TipoUds { get; set; }

	public string Descrizione { get; set; }

	public DateTime? SpuntaDataUscita { get; set; }

	public string SpuntaOperatoreUscita { get; set; }

	public DateTime? SpuntaDataIngresso { get; set; }

	public string SpuntaOperatoreIngresso { get; set; }

	public decimal? PesoLordo { get; set; }

	public int? Colli { get; set; }

	public int? Pallet { get; set; }

	public decimal? Volume { get; set; }

	public decimal? PalletVolumetrici { get; set; }

	public decimal? ValoreMerce { get; set; }

	public decimal? CampoCalcolo1 { get; set; }

	public decimal? CampoCalcolo2 { get; set; }

	public decimal? CampoCalcolo3 { get; set; }

	public decimal? CampoCalcolo4 { get; set; }

	public decimal? CampoCalcolo5 { get; set; }

	public decimal? CampoCalcolo6 { get; set; }

	public decimal? CampoCalcolo7 { get; set; }

	public decimal? CampoCalcolo8 { get; set; }

	public decimal? CampoCalcolo9 { get; set; }

	public decimal? CampoCalcolo10 { get; set; }

	public decimal? Altezza { get; set; }

	public decimal? Larghezza { get; set; }

	public decimal? Profondita { get; set; }

	public DateTime? InConsegna { get; set; }

	public string UdsMaster { get; set; }

	public string Filler1 { get; set; }

	public string Filler2 { get; set; }

	public string Filler3 { get; set; }

	public string Filler4 { get; set; }

	public string Filler5 { get; set; }

	public string Filler6 { get; set; }

	public string Filler7 { get; set; }

	public string Filler8 { get; set; }

	public string Filler9 { get; set; }

	public string Filler10 { get; set; }

	public DateTime? DatAgg { get; set; }

	public string UteAgg { get; set; }

	public DateTime? DatIns { get; set; }

	public string UteIns { get; set; }

	public UDS()
	{
		Codice = "";
		Unibol = "";
		TipoUds = "";
		Descrizione = "";
		SpuntaOperatoreUscita = "";
		SpuntaOperatoreIngresso = "";
		UdsMaster = "";
		Filler1 = "";
		Filler2 = "";
		Filler3 = "";
		Filler4 = "";
		Filler5 = "";
		Filler6 = "";
		Filler7 = "";
		Filler8 = "";
		Filler9 = "";
		Filler10 = "";
		UteAgg = null;
		UteIns = null;
	}
}
