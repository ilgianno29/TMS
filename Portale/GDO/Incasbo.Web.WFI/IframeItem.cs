namespace Incasbo.Web.WFI;

public class IframeItem
{
	public string Id { get; set; }

	public int Width { get; set; }

	public int Height { get; set; }

	public string Url { get; set; }

	public string Title { get; set; }

	public IframeItem()
	{
		Id = "";
		Url = "";
		Title = "";
	}
}
