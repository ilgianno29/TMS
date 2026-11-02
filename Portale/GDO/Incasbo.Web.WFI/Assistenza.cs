using System;
using System.Web.UI;

namespace Incasbo.Web.WFI;

public class Assistenza : WFIPage
{
	public Assistenza()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		((Page)this).Response.Redirect("~\\WFI\\Form\\WFLogin2.aspx?Mod=Assistenza");
	}
}
