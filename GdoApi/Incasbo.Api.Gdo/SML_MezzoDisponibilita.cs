using System;
using Incasbo.Web.Library;

namespace Incasbo.Api.Gdo;

[CustomListAttributes("TableName", "SML_MezziDisponibilita", "Key", new string[] { "Id" })]
public class SML_MezzoDisponibilita
{
	public int? Id { get; set; }

	public int IdSessione { get; set; }

	public DateTime Data { get; set; }

	public string Mezzo { get; set; }

	public string TipoMezzo { get; set; }

	public string TipoMerce { get; set; }

	public string Trasportatore { get; set; }

	public DateTime? DispDalleOre { get; set; }

	public DateTime? DispAlleOre { get; set; }

	public string ZonaSpedizione { get; set; }

	public string PuntoPartenza { get; set; }

	public string PuntoArrivo { get; set; }

	public string Tipologia { get; set; }

	public string TipologiaRecord { get; set; }

	public string Trattore { get; set; }

	public string Semirimorchio { get; set; }

	public string Autista { get; set; }

	public DateTime? DatIns { get; set; }

	public DateTime? DatAgg { get; set; }

	public string UteAgg { get; set; }

	public string UteIns { get; set; }

	public SML_MezzoDisponibilita()
	{
		Mezzo = "";
		TipoMezzo = "";
		TipoMerce = "";
		Trasportatore = "";
		ZonaSpedizione = "";
		PuntoPartenza = "";
		PuntoArrivo = "";
		Tipologia = "";
		TipologiaRecord = "";
		Trattore = "";
		Semirimorchio = "";
		Autista = "";
		UteAgg = "";
		UteIns = "";
	}
}
