namespace Incasbo.Api.Gdo;

public class GMB_MovimentoBancale
{
	public string TipoBancale { get; set; }

	public int Quantita { get; set; }

	public GMB_MovimentoBancale()
	{
		TipoBancale = "";
		Quantita = 0;
	}
}
