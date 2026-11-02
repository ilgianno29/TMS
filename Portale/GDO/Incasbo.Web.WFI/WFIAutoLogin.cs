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

	/// <summary>
	/// Autologin per dispositivi (totem, monitor):
	/// <list type="bullet">
	/// <item><c>?t=TOKEN</c>: token per dispositivo (vedi AutoLoginTokens), modalita' raccomandata;</item>
	/// <item><c>?u=UTENTE&amp;p=PASSWORD</c>: vecchia modalita', DISATTIVATA salvo [AutoLogin] ConsentiPasswordInUrl=True
	/// (la password finiva in cronologia, log del server e dei proxy).</item>
	/// </list>
	/// Il parametro <c>r</c> (pagina di destinazione) e' accettato solo se interno all'applicazione.
	/// </summary>
	private void Page_Init1(object sender, EventArgs e)
	{
		FXRETURN val = (FXRETURN)3;
		string rsMess = "";
		try
		{
			string token = ((Page)this).Request.QueryString["t"] ?? "";
			string text = ((Page)this).Request.QueryString["u"] ?? "";
			string text2 = ((Page)this).Request.QueryString["p"] ?? "";
			string sUrl = Incasbo.Security.SafeRedirect.LocalOrEmpty(((Page)this).Request.QueryString["r"] ?? "");
			string text3 = ((Page)this).Request.QueryString["par"] ?? "";
			if (token.Length > 0)
			{
				AutoLoginTokens.TokenInfo info = null;
				try
				{
					info = AutoLoginTokens.Find(base.SessionEnvironment.WFIConfig.DefaultDBConnectionConfig, token, ((Page)this).Request.UserHostAddress);
				}
				catch (Exception)
				{
					info = null;
				}
				if (info == null)
				{
					WriteError("Token di accesso non valido, scaduto o revocato.");
					return;
				}
				text = info.Utente;
				text2 = TrustedLogin.Token;
				if (sUrl.Length == 0)
				{
					sUrl = Incasbo.Security.SafeRedirect.LocalOrEmpty(info.Pagina);
				}
			}
			else if (!base.SessionEnvironment.WFIConfig.AutoLoginConsentiPasswordInUrl)
			{
				WriteError("Accesso con utente e password nell'indirizzo disattivato: usare un token di accesso.");
				return;
			}
			val = base.SessionEnvironment.Init(text, text2, "", base.SessionEnvironment.Session["ConfigFile"].ToString(), base.SessionEnvironment.Session["DBConfigFile"].ToString(), "", ref rsMess);
			if ((int)val > 0)
			{
				WriteError(rsMess);
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

	private void WriteError(string message)
	{
		((Page)this).Response.Clear();
		((Page)this).Response.ContentType = "text/HTML";
		((Page)this).Response.ContentEncoding = Encoding.UTF8;
		// Messaggio codificato: prima veniva inserito nella pagina cosi' com'era (XSS)
		((Page)this).Response.Write("<!DOCTYPE html><html><head><title>Errore di login</title></head><body><h1><p>Si è verificato un errore sulla pagina web</p></h1><h3><p>" + System.Web.HttpUtility.HtmlEncode(message ?? "") + "</p></h3></body></html>");
		((Page)this).Response.End();
	}

	protected void Page_Load(object sender, EventArgs e)
	{
	}
}
