using System;
using System.Collections.Generic;
using System.Web;
using System.Web.SessionState;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WFI;

public class LogRisorseAzioni
{
	protected IboSessionEnvironment SessionEnvironment;

	protected HttpSessionState _Session;

	protected HttpSessionState Session => _Session;

	public LogRisorseAzioni()
	{
		_Session = HttpContext.Current.Session;
		SessionEnvironment = (IboSessionEnvironment)Session["SessionEnvironment"];
	}

	public LogRisorseAzioni(HttpSessionState objSession)
	{
		_Session = objSession;
		SessionEnvironment = (IboSessionEnvironment)Session["SessionEnvironment"];
	}

	public FXRETURN Inserisci(string sRisorsa, string sAzione, string sModulo, string sInfo1, string sInfo2, ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Invalid comparison between Unknown and I4
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			rsMess = "";
			SessionEnvironment.CallStackHandler.CallStackAdd();
			text = "INSERT INTO WFI_LogRisorseAzioni (SessionId, RemoteAddress, RemoteHostName, Risorsa, Azione, Modulo, Utente, Info1, Info2) VALUES (";
			text = text + SessionEnvironment.DbConn.SQLFormatString(Session.SessionID) + ", ";
			text = text + SessionEnvironment.DbConn.SQLFormatString(Session["Session.REMOTE_ADDR"].ToString()) + ", ";
			text = text + SessionEnvironment.DbConn.SQLFormatString(Session["Session.REMOTE_HOSTNAME"].ToString()) + ", ";
			text = text + SessionEnvironment.DbConn.SQLFormatString(sRisorsa) + ", ";
			text = text + SessionEnvironment.DbConn.SQLFormatString(sAzione) + ", ";
			text = text + SessionEnvironment.DbConn.SQLFormatString(sModulo) + ", ";
			text = text + SessionEnvironment.DbConn.SQLFormatString(SessionEnvironment.WebUser.WebUserInfo.Codice) + ", ";
			text = text + SessionEnvironment.DbConn.SQLFormatString(Strings.Left(sInfo1, 1024)) + ", ";
			text = text + SessionEnvironment.DbConn.SQLFormatString(Strings.Left(sInfo2, 1024)) + "); ";
			if (Operators.CompareString(sAzione.ToUpper(), "LOGIN", false) == 0)
			{
				text = text + "UPDATE WFI_UTENTI SET LastLogin=" + SessionEnvironment.DbConn.GetDate() + ", LastActivity=" + SessionEnvironment.DbConn.GetDate() + ", IsLoggedOn='S' WHERE CODICE=" + SessionEnvironment.DbConn.SQLFormatString(SessionEnvironment.WebUser.WebUserInfo.Codice) + ";";
			}
			else if (Operators.CompareString(sAzione.ToUpper(), "LOGOUT", false) == 0)
			{
				Dictionary<string, int> dictionary = (Dictionary<string, int>)SessionEnvironment.AppApplicationVariables()["LOGGEDUSERS"];
				string text2 = "N";
				if (dictionary.ContainsKey(SessionEnvironment.WebUser.WebUserInfo.Codice) && dictionary[SessionEnvironment.WebUser.WebUserInfo.Codice] > 1)
				{
					text2 = "S";
				}
				text = text + "UPDATE WFI_UTENTI SET LastLogout=" + SessionEnvironment.DbConn.GetDate() + ", LastActivity=" + SessionEnvironment.DbConn.GetDate() + ", IsLoggedOn='" + text2 + "' WHERE CODICE=" + SessionEnvironment.DbConn.SQLFormatString(SessionEnvironment.WebUser.WebUserInfo.Codice) + ";";
			}
			else
			{
				text = text + "UPDATE WFI_UTENTI SET LastActivity=" + SessionEnvironment.DbConn.GetDate() + ", IsLoggedOn='S' WHERE CODICE=" + SessionEnvironment.DbConn.SQLFormatString(SessionEnvironment.WebUser.WebUserInfo.Codice) + ";";
			}
			val = SessionEnvironment.DbConn.SqlExec(text, ref rsMess);
			if ((int)val <= 0)
			{
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = SessionEnvironment.LogHandling.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			SessionEnvironment.CallStackHandler.CallStackRemove();
			result = val2;
		}
		return result;
	}

	public FXRETURN Inserisci(IIboResource Risorsa, string sAzione, string sModulo, string sInfo1, string sInfo2, ref string rsMess)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return Inserisci(Risorsa.ResourceName, sAzione, sModulo, sInfo1, sInfo2, ref rsMess);
	}
}
