namespace Incasbo.Web.WFI;

public class WFIAutoTooltipifyConfig
{
	public bool Enable { get; set; }

	public string Type { get; set; }

	public string RelativeTo { get; set; }

	public string Position { get; set; }

	public string ContentScrolling { get; set; }

	public string Animation { get; set; }

	public int AnimationDuration { get; set; }

	public int Width { get; set; }

	public int Height { get; set; }

	public bool ShowCallout { get; set; }

	public int AutoCloseDelay { get; set; }

	public bool NotCloseIfHover { get; set; }

	public int ShowDelay { get; set; }

	public bool TooltipByIdEnabled { get; set; }

	public WFIAutoTooltipifyConfig()
	{
		Enable = true;
		Type = "JQUERY";
		RelativeTo = "Element";
		Position = "TopCenter";
		ContentScrolling = "Default";
		Animation = "none";
		AnimationDuration = 300;
		Width = 0;
		Height = 0;
		ShowCallout = true;
		AutoCloseDelay = 3000;
		NotCloseIfHover = true;
		ShowDelay = 500;
		TooltipByIdEnabled = false;
	}
}
