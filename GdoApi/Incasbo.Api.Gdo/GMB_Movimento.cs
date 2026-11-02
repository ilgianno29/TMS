using System;

namespace Incasbo.Api.Gdo;

public class GMB_Movimento
{
	public string Id { get; set; }

	public DateTime? Data { get; set; }

	public string Causale { get; set; }

	public GMB_TipoSoggetto TipoSoggetto1 { get; set; }

	public string Soggetto1 { get; set; }

	public GMB_Segno Segno1 { get; set; }

	public GMB_TipoSoggetto TipoSoggetto2 { get; set; }

	public string Soggetto2 { get; set; }

	public GMB_Segno Segno2 { get; set; }

	public string TipoBancale { get; set; }

	public int Quantita { get; set; }

	public string Cliente { get; set; }

	public string IdRiferimento1 { get; set; }

	public DateTime? DataRiferimento1 { get; set; }

	public string IdRiferimento2 { get; set; }

	public DateTime? DataRiferimento2 { get; set; }

	public string Note { get; set; }

	public string NumeroBuono { get; set; }

	public string Filler1 { get; set; }

	public string Filler2 { get; set; }

	public string Filler3 { get; set; }

	public string Filler4 { get; set; }

	public string Filler5 { get; set; }

	public DateTime? DatAgg { get; set; }

	public string UteAgg { get; set; }

	public DateTime? DatIns { get; set; }

	public string UteIns { get; set; }

	internal GMB_Movimento()
	{
		Id = "";
		Data = null;
		Causale = "";
		TipoSoggetto1 = GMB_TipoSoggetto.NotDefined;
		Soggetto1 = "";
		Segno1 = GMB_Segno.NotDefined;
		TipoSoggetto2 = GMB_TipoSoggetto.NotDefined;
		Soggetto2 = "";
		Segno2 = GMB_Segno.NotDefined;
		TipoBancale = "";
		Quantita = 0;
		Cliente = "";
		IdRiferimento1 = "";
		DataRiferimento1 = null;
		IdRiferimento2 = "";
		DataRiferimento2 = null;
		Note = null;
		NumeroBuono = null;
		Filler1 = "";
		Filler2 = "";
		Filler3 = "";
		Filler4 = "";
		Filler5 = "";
		UteAgg = null;
		UteIns = null;
	}
}
