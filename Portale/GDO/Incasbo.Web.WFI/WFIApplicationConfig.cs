namespace Incasbo.Web.WFI;

public class WFIApplicationConfig
{
	public string LogoApplicazione { get; set; }

	public string LogoDitta { get; set; }

	public string LogoIncas { get; set; }

	public string TitoloApplicazione { get; set; }

	public string InfoIncas { get; set; }

	public string TitoloModuloSoftware { get; set; }

	public string TitoloModuloSoftwareAcronimo { get; set; }

	public WFIApplicationConfig()
	{
		LogoApplicazione = "~/images/LogoApplicazione.gif";
		LogoDitta = "";
		LogoIncas = "";
		TitoloApplicazione = "Delsy - Delivery System";
		InfoIncas = "© Incas 2013";
		TitoloModuloSoftware = "Transport Management System";
		TitoloModuloSoftwareAcronimo = "GDO";
	}
}
