using System;
using System.Web.UI;
using Incasbo.Web.Library;

namespace Incasbo.Web.WFI;

public class WFIDefault : WFIPage
{
	public WFIDefault()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		string sUrl = "~\\WFI\\Form\\WFLogin2.aspx";
		base.SessionEnvironment.Session["PageRedirectAfterLogOff"] = "~" + ((Page)this).Request.RawUrl;
		IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
		IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
	}
}
