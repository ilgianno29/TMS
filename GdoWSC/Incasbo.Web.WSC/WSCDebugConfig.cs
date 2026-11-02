namespace Incasbo.Web.WSC;

public class WSCDebugConfig
{
	public bool DebugMode { get; set; }

	public string UserDebug { get; set; }

	public bool InterfaceMode { get; set; }

	public WSCDebugConfig()
	{
		bool debugMode = false;
		DebugMode = debugMode;
		string userDebug = "";
		UserDebug = userDebug;
		debugMode = false;
		InterfaceMode = debugMode;
	}
}
