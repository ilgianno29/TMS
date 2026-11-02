namespace Incasbo.Web.GDO.Foglione;

public class Autista
{
	public int Ordinale { get; set; }

	public string Codice { get; set; }

	public string RagioneSociale { get; set; }

	public string Telefono { get; set; }

	public string Cellulare { get; set; }

	public string Dipendente { get; set; }

	public string Trasportatore { get; set; }

	public string Autista_ToolTip { get; set; }

	public string Autista_Descrizione { get; set; }

	public string Pianificatore { get; set; }

	public Autista()
	{
		Codice = "";
		RagioneSociale = "";
		Telefono = "";
		Cellulare = "";
		Dipendente = "";
		Trasportatore = "";
		Autista_ToolTip = "";
		Autista_Descrizione = "";
		Pianificatore = "";
	}
}
