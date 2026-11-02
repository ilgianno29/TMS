namespace Incasbo.Web.WFI;

public class WFIStandardGridManager
{
	public string SelectByRightClickMode { get; set; }

	public bool ShowMenuActionButton { get; set; }

	public string FilterVersion { get; set; }

	public WFIStandardGridManager()
	{
		SelectByRightClickMode = "0";
		ShowMenuActionButton = false;
		FilterVersion = "1";
	}
}
