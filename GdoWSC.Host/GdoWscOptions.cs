namespace Incasbo.Web.Host;

/// <summary>Impostazioni della sezione "GdoWSC" di appsettings.json.</summary>
public sealed class GdoWscOptions
{
	public string ApplicationRoot { get; set; } = "";

	public string TMSServiceForWMSPath { get; set; } = "/TMSServiceForWMS.svc";

	public string TMSApiServicePath { get; set; } = "/TMSApiService.svc";

	public string TMSServiceForMapPath { get; set; } = "/TMSServiceForMap.svc";

	public string WcfClientConfigFile { get; set; } = "IniConfig\\WcfClients.config";

	public bool BackgroundMaintenanceEnabled { get; set; } = true;

	public int BackgroundMaintenanceIntervalSeconds { get; set; } = 60;
}
