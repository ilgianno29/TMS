using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Incasbo.Web.Components;

public class IboWebToolbarItem
{
	public ImageButton btn { get; set; }

	public LinkButton lnk { get; set; }

	public string ItemCssClass { get; set; }

	public List<IboWebToolbarItem> SubItems { get; set; }

	public string ShortCut { get; set; }

	public string ProgId { get; set; }

	public IboWebToolbarItem()
	{
		ItemCssClass = "";
		SubItems = new List<IboWebToolbarItem>();
		ShortCut = "";
		ProgId = "";
	}

	public IboWebToolbarItem(ImageButton objBtn, LinkButton objLnk, string CssClass, string Shortcut)
	{
		ItemCssClass = "";
		SubItems = new List<IboWebToolbarItem>();
		ShortCut = "";
		ProgId = "";
		btn = objBtn;
		lnk = objLnk;
		ItemCssClass = CssClass;
		ShortCut = Shortcut;
	}

	public IboWebToolbarItem(ImageButton objBtn, LinkButton objLnk, string CssClass, string Shortcut, List<IboWebToolbarItem> objSubItems)
	{
		ItemCssClass = "";
		SubItems = new List<IboWebToolbarItem>();
		ShortCut = "";
		ProgId = "";
		btn = objBtn;
		lnk = objLnk;
		ItemCssClass = CssClass;
		ShortCut = Shortcut;
		SubItems = objSubItems;
	}
}
