using System;
using System.Web;
using System.Web.UI;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class Redirector : WFIPage
{
	public Redirector()
	{
		((Control)this).Load += Page_Load;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		try
		{
			if (base.SessionEnvironment.WebUser != null)
			{
				if (base.SessionEnvironment.WebUser.WebUserInfo != null && base.SessionEnvironment.WebUser.WebUserInfo.PaginaIniziale.Length > 0)
				{
					IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
					IboWebUserInfo webUserInfo;
					string sUrl = (webUserInfo = base.SessionEnvironment.WebUser.WebUserInfo).PaginaIniziale;
					IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
					webUserInfo.PaginaIniziale = sUrl;
				}
				else if (base.SessionEnvironment.WebUser.Group != null && base.SessionEnvironment.WebUser.Group.WebUserInfo.PaginaIniziale.Length > 0)
				{
					IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
					IboWebUserInfo webUserInfo;
					string sUrl = (webUserInfo = base.SessionEnvironment.WebUser.Group.WebUserInfo).PaginaIniziale;
					IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
					webUserInfo.PaginaIniziale = sUrl;
				}
				else
				{
					IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
					string sUrl = "~/WFI/Form/WFIDesktop.aspx";
					IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
				}
			}
			else if (Operators.CompareString(HttpContext.Current.User.Identity.Name, "", false) != 0)
			{
				IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
				string sUrl = "~/WFI/Form/WFlogin2.aspx";
				IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
			}
			else
			{
				LogOff();
				IboAppCallStackHandling robjCallStackHandler = base.SessionEnvironment.CallStackHandler;
				string sUrl = "~/Default.aspx";
				IboResponseRedirect(ref robjCallStackHandler, ref sUrl);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
