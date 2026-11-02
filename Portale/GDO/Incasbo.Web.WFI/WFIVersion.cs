namespace Incasbo.Web.WFI;

public class WFIVersion
{
	public string Version { get; set; }

	public string ReleaseDate { get; set; }

	public string Patch { get; set; }

	public new string ToString => "Version=" + Version + ", ReleaseDate=" + ReleaseDate + ", Patch=" + Patch;

	public WFIVersion()
	{
		Version = "";
		ReleaseDate = "";
	}
}
