using System;
using Incasbo.Web.Library;

namespace Incasbo.Api.Gdo;

[CustomListAttributes("TableName", "SML_Mezzi", "Key", new string[] { "Id" })]
public class SML_Mezzo
{
	public int? Id { get; set; }

	public string Codice { get; set; }

	public int IdSessione { get; set; }

	public string Descrizione { get; set; }

	public string Targa { get; set; }

	public string TipoMezzo { get; set; }

	public string TipoMerce { get; set; }

	public string Autista { get; set; }

	public decimal? PortataPeso { get; set; }

	public decimal? PortataVolume { get; set; }

	public decimal? PortataMetriLineari { get; set; }

	public decimal? PortataColli { get; set; }

	public decimal? PortataPallet { get; set; }

	public decimal? PortataRoll { get; set; }

	public decimal? PortataQ1 { get; set; }

	public decimal? PortataQ2 { get; set; }

	public decimal? PortataQ3 { get; set; }

	public decimal? GradoSaturazionePeso { get; set; }

	public decimal? GradoSaturazioneVolume { get; set; }

	public decimal? GradoSaturazioneML { get; set; }

	public decimal? GradoSaturazioneColli { get; set; }

	public decimal? GradoSaturazionePallet { get; set; }

	public decimal? GradoSaturazioneRoll { get; set; }

	public decimal? GradoSaturazioneQ1 { get; set; }

	public decimal? GradoSaturazioneQ2 { get; set; }

	public decimal? GradoSaturazioneQ3 { get; set; }

	public decimal? Lunghezza { get; set; }

	public decimal? Larghezza { get; set; }

	public decimal? Altezza { get; set; }

	public decimal? EmissioneCO2 { get; set; }

	public int? Tara { get; set; }

	public int? Assi { get; set; }

	public string Note { get; set; }

	public string Attivo { get; set; }

	public string Trasportatore { get; set; }

	public string PuntoPartenza { get; set; }

	public string PuntoArrivo { get; set; }

	public DateTime? DispDalleOre { get; set; }

	public DateTime? DispAlleOre { get; set; }

	public DateTime? TempoReimpiego { get; set; }

	public int? NumMaxFermate { get; set; }

	public int? NumMaxReimpieghi { get; set; }

	public string ClasseDiGrandezza { get; set; }

	public DateTime? DatIns { get; set; }

	public DateTime? DatAgg { get; set; }

	public string UteAgg { get; set; }

	public string UteIns { get; set; }

	public SML_Mezzo()
	{
		Codice = "";
		Descrizione = "";
		Targa = "";
		TipoMezzo = "";
		TipoMerce = "";
		Autista = "";
		Note = "";
		Attivo = "S";
		Trasportatore = "";
		PuntoPartenza = "";
		PuntoArrivo = "";
		DispDalleOre = null;
		DispAlleOre = null;
		TempoReimpiego = null;
		ClasseDiGrandezza = "";
		UteAgg = "";
		UteIns = "";
	}
}
