namespace Incasbo.Api.Gdo.Tariffe;

public class Spedizioni_RicaviRipartiti : Spedizioni_Ricavi
{
	protected override string GetKeyForItem(CostoRicavo item)
	{
		return item.Voce + ";" + item.IdDocumento;
	}
}
