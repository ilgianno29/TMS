namespace Incasbo.Web.WFI;

public class WFICookiesConfig
{
	public bool enabled { get; set; }

	public string message { get; set; }

	public bool? acceptButton { get; set; }

	public string acceptText { get; set; }

	public bool? declineButton { get; set; }

	public string declineText { get; set; }

	public bool? policyButton { get; set; }

	public string policyText { get; set; }

	public string policyURL { get; set; }

	public bool? autoEnable { get; set; }

	public bool? acceptOnContinue { get; set; }

	public bool? acceptOnScroll { get; set; }

	public bool? acceptAnyClick { get; set; }

	public int? expireDays { get; set; }

	public bool? renewOnVisit { get; set; }

	public bool? forceShow { get; set; }

	public string effect { get; set; }

	public string element { get; set; }

	public bool? append { get; set; }

	public bool @fixed { get; set; }

	public bool bottom { get; set; }

	public WFICookiesConfig()
	{
		enabled = false;
		@fixed = true;
		bottom = true;
	}
}
