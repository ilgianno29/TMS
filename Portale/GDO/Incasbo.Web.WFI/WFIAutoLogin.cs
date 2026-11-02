using System;
using System.Text;
using System.Web.Security;
using System.Web.UI;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class WFIAutoLogin : WFIPage
{
	public WFIAutoLogin()
	{
		((Control)this).Init += Page_Init1;
		((Control)this).Load += Page_Load;
	}

	private void Page_Init1(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Invalid comparison between Unknown and I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		try
		{
			string text = ((Page)this).Request.QueryString["u"] ?? "";
			string text2 = ((Page)this).Request.QueryString["p"] ?? "";
			string sUrl = ((Page)this).Request.QueryString["r"] ?? "";
			string text3 = ((Page)this).Request.QueryString["par"] ?? "";
			if (base.SessionEnvironment.WFIConfig.LoginManagerConfig.CryptographyEnable)
			{
				IboCrypt val2 = new IboCrypt();
				text2 = val2.EncryptString128Bit(text2);
			}
			val = base.SessionEnvironment.Init(text, text2, "", base.SessionEnvironment.Session["ConfigFile"].ToString(), base.SessionEnvironment.Session["DBConfigFile"].ToString(), "", ref rsMess);
			if ((int)val > 0)
			{
				((Page)this).Response.Clear();
				((Page)this).Response.ContentType = "text/HTML";
				((Page)this).Response.ContentEncoding = Encoding.UTF8;
				((Page)this).Response.Write("<!DOCTYPE html><html><head><title>Errore di login</title></head><body><h1><p>Si è verificato un errore sulla pagina web</p></h1><h3><p>" + rsMess + "</p></h3></body></html>");
				((Page)this).Response.End();
				return;
			}
			if (Operators.CompareString(sUrl, "", false) == 0)
			{
				sUrl = base.SessionEnvironment.WebUser.WebUserInfo.PaginaIniziale;
			}
			FormsAuthentication.SetAuthCookie(text, false);
			((Page)this).Session["WFIAutoLogin.QueryStringParameters"] = text3;
			IboResponseRedirect(ref sUrl);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	protected void Page_Load(object sender, EventArgs e)
	{
	}
}
