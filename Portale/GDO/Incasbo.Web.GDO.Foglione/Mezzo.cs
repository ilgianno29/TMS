namespace Incasbo.Web.GDO.Foglione;

public class Mezzo
{
	public string Codice { get; set; }

	public string Descrizione { get; set; }

	public string Targa { get; set; }

	public string Cliente { get; set; }

	public string Trasportatore { get; set; }

	public string Autista { get; set; }

	public string TipoMerce { get; set; }

	public int KmAttuali { get; set; }

	public decimal PortataPeso { get; set; }

	public decimal PortataVolume { get; set; }

	public decimal PortataColli { get; set; }

	public decimal PortataPallet { get; set; }

	public string PuntoPartenza { get; set; }

	public string ZonaPartenza { get; set; }

	public string Mezzo_Descrizione { get; set; }

	public Mezzo()
	{
		Codice = "";
		Descrizione = "";
		Targa = "";
		Cliente = "";
		Trasportatore = "";
		Autista = "";
		TipoMerce = "";
		KmAttuali = 0;
		PortataPeso = 0m;
		PortataVolume = 0m;
		PortataColli = 0m;
		PortataPallet = 0m;
		PuntoPartenza = "";
		ZonaPartenza = "";
		Mezzo_Descrizione = "";
	}
}
