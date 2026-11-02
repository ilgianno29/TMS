using System;
using System.Web.UI;
using Incasbo.Web.Library;
using Incasbo.Web.WFI;

namespace Incasbo.Web.GDO;

public class _Default : WFIPage
{
	public _Default()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
		string sUrl = "~\\WFI\\Form\\Redirector.aspx";
		IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
	}
}
