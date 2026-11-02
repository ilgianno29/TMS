namespace Incasbo.Api.Gdo.Tariffe;

public class Spedizioni_CostiRipartiti : Spedizioni_Costi
{
	protected override string GetKeyForItem(CostoRicavo item)
	{
		return item.Voce + ";" + item.IdDocumento;
	}
}
