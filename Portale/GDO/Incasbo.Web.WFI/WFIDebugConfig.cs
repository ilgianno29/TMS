namespace Incasbo.Web.WFI;

public class WFIDebugConfig
{
	public bool DebugMode { get; set; }

	public string UserDebug { get; set; }

	public bool ConfigMode { get; set; }

	public string ConfigUser { get; set; }

	public WFIDebugConfig()
	{
		DebugMode = false;
		UserDebug = "";
		ConfigMode = false;
		ConfigUser = "";
	}
}
