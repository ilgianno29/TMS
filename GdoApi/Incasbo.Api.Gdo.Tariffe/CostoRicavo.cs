namespace Incasbo.Api.Gdo.Tariffe;

public abstract class CostoRicavo
{
	public virtual string IdDocumento { get; set; }

	public virtual string Voce { get; set; }

	public virtual string FlagNolo { get; set; }

	public virtual string CampoCalcolo { get; set; }

	public virtual string TipoCalcolo { get; set; }

	public virtual string RecordZZ { get; set; }

	public virtual decimal QuantitaOriginale { get; set; }

	public virtual decimal QuantitaArrotondata { get; set; }

	public virtual decimal QuantitaTassata { get; set; }

	public virtual decimal ImportoUnitario { get; set; }

	public virtual decimal ImportoOriginale { get; set; }

	public virtual decimal ImportoArrotondato { get; set; }

	public virtual string UtenteForzatura { get; set; }

	public virtual string IdRaggruppamento { get; set; }

	public virtual string EstremiTariffa { get; set; }

	public virtual string NoteDiCalcolo { get; set; }

	public virtual int[] IdFasceElenco { get; set; }

	public virtual string TipoRipartizione { get; set; }

	public virtual string StatoRecord { get; set; }

	public virtual string Riconsegna { get; set; }

	public virtual string Reso { get; set; }

	public virtual int? GiorniTassati { get; set; }

	protected CostoRicavo()
	{
		IdDocumento = "";
		Voce = "";
		FlagNolo = "N";
		CampoCalcolo = "";
		TipoCalcolo = "STD";
		RecordZZ = "N";
		UtenteForzatura = "";
		IdRaggruppamento = "";
		EstremiTariffa = "";
		NoteDiCalcolo = "";
		IdFasceElenco = new int[1];
		TipoRipartizione = "P";
		StatoRecord = "I";
		Riconsegna = "T";
		Reso = "T";
	}
}
