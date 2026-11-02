using Incasbo.Web.Components;

namespace Incasbo.Web.WFI;

public interface IIboMenuClickable
{
	void mnuMainItemClick(object sender, IboMenuEventArgs e);

	void mnuMainItemClick(object sender, IboMenuEventArgsTlk e);
}
