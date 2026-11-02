using System;
using System.Collections.Generic;

namespace Incasbo.Api.Gdo;

public class GMB_Documento
{
	public DateTime? Data { get; set; }

	public string Causale { get; set; }

	public GMB_TipoSoggetto TipoSoggetto1 { get; set; }

	public string Soggetto1 { get; set; }

	public GMB_Segno Segno1 { get; set; }

	public GMB_TipoSoggetto TipoSoggetto2 { get; set; }

	public string Soggetto2 { get; set; }

	public GMB_Segno Segno2 { get; set; }

	public List<GMB_MovimentoBancale> Bancali { get; set; }

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

	public GMB_Documento()
	{
		Data = null;
		Causale = "";
		TipoSoggetto1 = GMB_TipoSoggetto.NotDefined;
		Soggetto1 = "";
		Segno1 = GMB_Segno.NotDefined;
		TipoSoggetto2 = GMB_TipoSoggetto.NotDefined;
		Soggetto2 = "";
		Segno2 = GMB_Segno.NotDefined;
		Bancali = new List<GMB_MovimentoBancale>();
		Cliente = null;
		IdRiferimento1 = null;
		DataRiferimento1 = null;
		IdRiferimento2 = null;
		DataRiferimento2 = null;
		Note = null;
		NumeroBuono = null;
		Filler1 = null;
		Filler2 = null;
		Filler3 = null;
		Filler4 = null;
		Filler5 = null;
		UteAgg = null;
		UteIns = null;
	}
}
