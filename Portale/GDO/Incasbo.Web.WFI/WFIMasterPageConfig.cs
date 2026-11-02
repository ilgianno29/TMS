namespace Incasbo.Web.WFI;

public class WFIMasterPageConfig
{
	public bool PanelTopHeaderVisible { get; set; }

	public bool EnableEventValidation { get; set; }

	public bool StandardHeaderUserVisible { get; set; }

	public bool StandardHeaderFilialeVisible { get; set; }

	public bool StandardHeaderOrganizationVisible { get; set; }

	public WFIMasterPageConfig()
	{
		PanelTopHeaderVisible = true;
		EnableEventValidation = true;
		StandardHeaderUserVisible = true;
		StandardHeaderFilialeVisible = true;
		StandardHeaderOrganizationVisible = true;
	}
}
