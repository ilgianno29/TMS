using System.Collections.Specialized;

namespace Incasbo.Web.WFI;

public class WFIPageConfig
{
	public string ViewStateSaveMode { get; set; }

	public StringCollection ViewStateSaveModePages { get; set; }

	public int DebugAsyncTimeout { get; set; }

	public int ReleaseAsyncTimeout { get; set; }

	public bool LastActivityRealTime { get; set; }

	public int LastActivityRealTimeInterval { get; set; }

	public int KeepAliveFrequency { get; set; }

	public WFIPageConfig()
	{
		ViewStateSaveMode = "0";
		ViewStateSaveModePages = new StringCollection();
		DebugAsyncTimeout = 300;
		ReleaseAsyncTimeout = 90;
		LastActivityRealTime = false;
		LastActivityRealTimeInterval = 10;
		KeepAliveFrequency = 0;
	}
}
