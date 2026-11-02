namespace Incasbo.Web.WFI;

public class WFINotificationMessageConfig
{
	public int Width { get; set; }

	public int? Height { get; set; }

	public string Animation { get; set; }

	public bool EnableRoundedCorners { get; set; }

	public bool EnableShadow { get; set; }

	public string Position { get; set; }

	public int AutoCloseDelay { get; set; }

	public string ContentScrolling { get; set; }

	public WFINotificationMessageConfig()
	{
		Width = 700;
		Height = 100;
		Animation = "Fade";
		EnableRoundedCorners = false;
		EnableShadow = true;
		Position = "TopCenter";
		AutoCloseDelay = 10000;
		ContentScrolling = "Auto";
	}
}
