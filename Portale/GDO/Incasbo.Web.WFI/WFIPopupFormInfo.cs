using System.Web.UI;

namespace Incasbo.Web.WFI;

public class WFIPopupFormInfo
{
	public bool Visible { get; set; }

	public bool ButtonsVisible { get; set; }

	public bool ButtonsOkVisible { get; set; }

	public bool ButtonsAnnullaVisible { get; set; }

	public string ContentObjectId { get; set; }

	public Control ContentObject { get; set; }

	public string Tag { get; set; }

	public string Title { get; set; }

	public bool CloseOnConfirm { get; set; }

	public bool CloseOnExit { get; set; }

	public bool _AreInOpeningPhase { get; set; }

	public string CssClass { get; set; }

	public WFIPopupFormInfo()
	{
		Visible = false;
		ButtonsVisible = true;
		ButtonsOkVisible = true;
		ButtonsAnnullaVisible = true;
		ContentObjectId = "";
		ContentObject = null;
		Tag = "";
		Title = "";
		CloseOnConfirm = true;
		CloseOnExit = true;
		_AreInOpeningPhase = false;
		CssClass = "";
	}

	public void Reset()
	{
		Visible = false;
		ButtonsVisible = true;
		ButtonsOkVisible = true;
		ButtonsAnnullaVisible = true;
		ContentObjectId = "";
		ContentObject = null;
		Tag = "";
		Title = "";
		CloseOnConfirm = true;
		CloseOnExit = true;
		CssClass = "";
	}
}
