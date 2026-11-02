namespace Incasbo.Web.WFI;

public class WFIMenuManagerConfig
{
	public string UseVersion { get; set; }

	public string DesktopGenericIcon { get; set; }

	public string FolderGenericIcon { get; set; }

	public int DesktopRepeatColumns { get; set; }

	public WFIMenuManagerConfig()
	{
		UseVersion = "1";
		DesktopGenericIcon = "~/images/Toolbar/96/DesktopGenericIcon.png";
		FolderGenericIcon = "~/images/Toolbar/96/folderIcon.png";
		DesktopRepeatColumns = 6;
	}
}
