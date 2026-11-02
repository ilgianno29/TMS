namespace Incasbo.Web.WFI;

public class WindowPopupProperties
{
	public string Address;

	public int Top;

	public int Left;

	public int Width;

	public int Height;

	public string JavascriptVar;

	public bool MultipleInstance;

	public WindowPopupProperties()
	{
		Address = "";
		Top = 0;
		Left = 0;
		Width = 500;
		Height = 300;
		JavascriptVar = "";
		MultipleInstance = false;
	}
}
