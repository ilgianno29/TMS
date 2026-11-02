using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Web.Security;
using System.Web.Services;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WSC;

public abstract class IncasServiceFormsAuth : IncasWebService
{
	protected override FXRETURN AutenticazioneUtente(string sUtente, string sPassword, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Invalid comparison between Unknown and I4
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Invalid comparison between Unknown and I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		int totalBytes = default(int);
		FXRETURN result;
		try
		{
			rsmess = "";
			val2 = InitWebService(ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else
			{
				CallStackAdd();
				Username = sUtente;
				totalBytes = ((WebService)this).Context.Request.TotalBytes;
				if ((Operators.CompareString(sUtente, _EmbeddedUser, false) == 0) & (Operators.CompareString(sPassword, _EmbeddedPassword, false) == 0))
				{
					text2 = "EMBEDDED USER OK";
					text3 = "EMBEDDED USER";
					text4 = "GRP.WFI";
					text5 = "ORG.WFI";
					goto IL_0362;
				}
				text = "SELECT * FROM " + SessionEnvironment.WSCConfig.TablesConfig.UserTable + " WHERE CODICE=" + SessionEnvironment.DbMain.SQLFormatString(sUtente) + " AND Tipo='U'";
				val2 = SessionEnvironment.DbMain.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val2 != 0)
				{
					val = val2;
				}
				else if (rObjDataTable.Rows.Count == 0)
				{
					rsmess = $"Utente {sUtente} non valido";
				}
				else if (Operators.CompareString(rObjDataTable.Rows[0]["ATTIVO"].ToString().ToUpper(), "S", false) != 0)
				{
					rsmess = $"Utente {sUtente} non attivo";
				}
				else
				{
					string text6 = rObjDataTable.Rows[0]["PASSWORD"].ToString();
					if (SessionEnvironment.WSCConfig.LoginManagerConfig.CryptographyEnable)
					{
						IboCrypt val3 = new IboCrypt();
						text6 = val3.DecryptString128Bit(text6);
					}
					if (Operators.CompareString(text6, sPassword, false) != 0)
					{
						rsmess = "Password non valida";
					}
					else if (DateTime.Compare(Conversions.ToDate(rObjDataTable.Rows[0]["SCADENZAPASSWORD"]), DateAndTime.Now) < 0)
					{
						rsmess = $"Password scaduta per l'utente {sUtente}";
					}
					else
					{
						text2 = "AUTENTICAZIONE AVVENUTA";
						text3 = rObjDataTable.Rows[0]["DESCRIZIONE"].ToString();
						text4 = rObjDataTable.Rows[0]["GRUPPO"].ToString();
						text = "SELECT * FROM " + SessionEnvironment.WSCConfig.TablesConfig.UserTable + " WHERE CODICE=" + SessionEnvironment.DbMain.SQLFormatString(text4) + " AND Tipo='G'";
						val2 = SessionEnvironment.DbMain.OpenDataTable(text, ref rObjDataTable, ref rsmess);
						if ((int)val2 != 0)
						{
							val = val2;
						}
						else if (rObjDataTable.Rows.Count == 0)
						{
							rsmess = $"Gruppo {text4} non valido";
						}
						else
						{
							if (Operators.CompareString(rObjDataTable.Rows[0]["ATTIVO"].ToString().ToUpper(), "S", false) == 0)
							{
								text5 = rObjDataTable.Rows[0]["ORGANIZZAZIONE"].ToString();
								goto IL_0362;
							}
							rsmess = $"Gruppo {text4} non attivo";
						}
					}
				}
			}
			goto end_IL_002b;
			IL_0362:
			Username = sUtente;
			Password = sPassword;
			UserDescription = text3;
			Group = text4;
			Organizzazione = text5;
			val = (FXRETURN)0;
			end_IL_002b:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			if (this is WSCStateless)
			{
				string sNote = text2;
				string sNote2 = rsmess;
				string rsmess2 = "";
				LogEventiScrivi("LOGIN", sNote, sNote2, ref rsmess2);
			}
			else
			{
				string sNote3 = text2;
				string sNote4 = rsmess;
				int bytesRicevuti = totalBytes;
				string rsmess2 = "";
				LogEventiMem("LOGIN", sNote3, sNote4, bytesRicevuti, ref rsmess2);
			}
			if (Operators.CompareString(rsmess, "", false) != 0)
			{
				Username = "";
			}
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override string ServiceName()
	{
		return "IncasWebServiceFormsAuth";
	}

	protected virtual FXRETURN LogEventiScrivi(string sEvento, string sNote1, string sNote2, ref string rsmess)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return LogEventiScrivi(sEvento, sNote1, sNote2, 0, 0, ref rsmess);
	}

	protected virtual FXRETURN LogEventiScrivi(string sEvento, string sNote1, string sNote2, int BytesRicevuti, int BytesInviati, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Invalid comparison between Unknown and I4
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Invalid comparison between Unknown and I4
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Invalid comparison between Unknown and I4
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Invalid comparison between Unknown and I4
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)0;
		FXRETURN val2 = (FXRETURN)0;
		string text = "";
		int sQLLeftLength = SessionEnvironment.WSCConfig.LogConfig.SQLLeftLength;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			text = "INSERT INTO " + SessionEnvironment.WSCConfig.TablesConfig.EventLogTable + " (SessionID, Utente, Evento, Note1, Note2, Ip, BytesRicevuti, BytesInviati) VALUES (";
			text = text + SessionEnvironment.DbMain.SQLFormatString(((WebService)this).Session.SessionID) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(SessionEnvironment.User) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(sEvento) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote1, sQLLeftLength)) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote2, sQLLeftLength)) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(ClientIp) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesRicevuti) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesInviati) + ") ";
			val2 = SessionEnvironment.DbLog.SqlExec(text, ref rsmess);
			if ((int)val2 != 0)
			{
				val = val2;
			}
			else if (Operators.CompareString(sEvento, "LOGIN", false) == 0)
			{
				text = "INSERT INTO " + SessionEnvironment.WSCConfig.TablesConfig.SessionTable + " (SessionID, Utente, Evento, Note1, Note2, Ip, BytesRicevuti, BytesInviati) VALUES (";
				text = text + SessionEnvironment.DbMain.SQLFormatString(((WebService)this).Session.SessionID) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatString(SessionEnvironment.User) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatString(sEvento) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote1, sQLLeftLength)) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote2, sQLLeftLength)) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatString(ClientIp) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesRicevuti) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesInviati) + ") ";
				val2 = SessionEnvironment.DbLog.SqlExec(text, ref rsmess);
				if ((int)val2 == 0)
				{
					goto IL_05b0;
				}
				val = val2;
			}
			else if (Operators.CompareString(sEvento, "LOGOUT", false) == 0)
			{
				text = "UPDATE " + SessionEnvironment.WSCConfig.TablesConfig.SessionTable + " SET Evento=" + SessionEnvironment.DbMain.SQLFormatString(sEvento) + ", ";
				text = text + "NOTE1=" + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote1, sQLLeftLength)) + ", ";
				text = text + "NOTE2=" + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote2, sQLLeftLength)) + ", ";
				text = text + "BytesRicevuti=BytesRicevuti+" + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesRicevuti) + ", ";
				text = text + "BytesInviati=BytesInviati+" + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesInviati) + ", ";
				text += "DATAFINE=GETDATE() ";
				text = text + "WHERE SESSIONID=" + SessionEnvironment.DbMain.SQLFormatString(((WebService)this).Session.SessionID);
				val2 = SessionEnvironment.DbLog.SqlExec(text, ref rsmess);
				if ((int)val2 == 0)
				{
					goto IL_05b0;
				}
				val = val2;
			}
			else
			{
				text = "UPDATE " + SessionEnvironment.WSCConfig.TablesConfig.SessionTable + " SET Evento=" + SessionEnvironment.DbMain.SQLFormatString(sEvento) + ", ";
				text = text + "NOTE1=" + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote1, sQLLeftLength)) + ", ";
				text = text + "NOTE2=" + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote2, sQLLeftLength)) + ", ";
				text = text + "BytesRicevuti=BytesRicevuti+" + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesRicevuti) + ", ";
				text = text + "BytesInviati=BytesInviati+" + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesInviati) + " ";
				text = text + "WHERE SESSIONID=" + SessionEnvironment.DbMain.SQLFormatString(((WebService)this).Session.SessionID);
				val2 = SessionEnvironment.DbLog.SqlExec(text, ref rsmess);
				if ((int)val2 == 0)
				{
					goto IL_05b0;
				}
				val = val2;
			}
			goto end_IL_0021;
			IL_05b0:
			val = (FXRETURN)0;
			end_IL_0021:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected virtual FXRETURN LogEventiMem(string sEvento, string sNote1, string sNote2, int BytesRicevuti, ref string rsmess)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		int? bytesInviati = default(int?);
		return LogEventiMem(sEvento, sNote1, sNote2, BytesRicevuti, bytesInviati, ref rsmess);
	}

	protected virtual FXRETURN LogEventiMem(string sEvento, string sNote1, string sNote2, int BytesRicevuti, int? BytesInviati, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)0;
		FXRETURN val2 = (FXRETURN)0;
		string text = "";
		int sQLLeftLength = SessionEnvironment.WSCConfig.LogConfig.SQLLeftLength;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			text = "INSERT INTO " + SessionEnvironment.WSCConfig.TablesConfig.EventLogTable + " (SessionID, Utente, Evento, Note1, Note2, Ip, BytesRicevuti, BytesInviati) VALUES (";
			text = text + SessionEnvironment.DbMain.SQLFormatString(((WebService)this).Session.SessionID) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(SessionEnvironment.User) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(sEvento) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote1, sQLLeftLength)) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote2, sQLLeftLength)) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(ClientIp) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesRicevuti) + ", ";
			text += "<%BytesInviati%>); ";
			if (Operators.CompareString(sEvento, "LOGIN", false) == 0)
			{
				text = text + "INSERT INTO " + SessionEnvironment.WSCConfig.TablesConfig.SessionTable + " (SessionID, Utente, Evento, Note1, Note2, Ip, BytesRicevuti, BytesInviati) VALUES (";
				text = text + SessionEnvironment.DbMain.SQLFormatString(((WebService)this).Session.SessionID) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatString(SessionEnvironment.User) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatString(sEvento) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote1, sQLLeftLength)) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote2, sQLLeftLength)) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatString(ClientIp) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesRicevuti) + ", ";
				text += "<%BytesInviati%>); ";
			}
			else if (Operators.CompareString(sEvento, "LOGOUT", false) == 0)
			{
				text = text + "UPDATE " + SessionEnvironment.WSCConfig.TablesConfig.SessionTable + " SET Evento=" + SessionEnvironment.DbMain.SQLFormatString(sEvento) + ", ";
				text = text + "NOTE1=" + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote1, sQLLeftLength)) + ", ";
				text = text + "NOTE2=" + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote2, sQLLeftLength)) + ", ";
				text = text + "BytesRicevuti=BytesRicevuti+" + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesRicevuti) + ", ";
				text += "BytesInviati=BytesInviati+<%BytesInviati%>, ";
				text += "DATAFINE=GETDATE() ";
				text = text + "WHERE SESSIONID=" + SessionEnvironment.DbMain.SQLFormatString(((WebService)this).Session.SessionID) + ";";
			}
			else
			{
				text = text + "UPDATE " + SessionEnvironment.WSCConfig.TablesConfig.SessionTable + " SET Evento=" + SessionEnvironment.DbMain.SQLFormatString(sEvento) + ", ";
				text = text + "NOTE1=" + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote1, sQLLeftLength)) + ", ";
				text = text + "NOTE2=" + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote2, sQLLeftLength)) + ", ";
				text = text + "BytesRicevuti=BytesRicevuti+" + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesRicevuti) + ", ";
				text += "BytesInviati=BytesInviati+<%BytesInviati%> ";
				text = text + "WHERE SESSIONID=" + SessionEnvironment.DbMain.SQLFormatString(((WebService)this).Session.SessionID) + ";";
			}
			if (BytesInviati.HasValue)
			{
				text = text.Replace("<%BytesInviati%>", BytesInviati.Value.ToString());
			}
			if (((WebService)this).Session["WSC.SqlToApply"] == null)
			{
				((WebService)this).Session["WSC.SqlToApply"] = "";
			}
			((WebService)this).Session["WSC.SqlToApply"] = ((WebService)this).Session["WSC.SqlToApply"].ToString() + text;
			((WebService)this).Session["WSC.WebServiceInstance"] = this;
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	public virtual FXRETURN LogEventiFlush(int BytesInviati, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)0;
		FXRETURN val2 = (FXRETURN)0;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			object obj = null;
			if (((WebService)this).Session["WSC.SqlToApply"] != null)
			{
				text = ((WebService)this).Session["WSC.SqlToApply"].ToString();
				obj = RuntimeHelpers.GetObjectValue(((WebService)this).Session["WSC.WebServiceInstance"]);
				((WebService)this).Session["WSC.WebServiceInstance"] = null;
				((WebService)this).Session["WSC.SqlToApply"] = "";
				if (Operators.CompareString(text, "", false) != 0)
				{
					text = text.Replace("<%BytesInviati%>", BytesInviati.ToString());
					DBConnection dbLog = SessionEnvironment.DbLog;
					string vsSQLClause = text;
					string rsMess = "";
					dbLog.SqlExec(vsSQLClause, ref rsMess);
				}
			}
			if (obj is WSCStateless)
			{
				if (SessionEnvironment.DbMain != null)
				{
					DBConnection dbMain = SessionEnvironment.DbMain;
					string rsMess = "";
					dbMain.CloseConnection(ref rsMess);
					SessionEnvironment.DbMain.Dispose();
				}
				if (SessionEnvironment.DbLog != null)
				{
					DBConnection dbLog2 = SessionEnvironment.DbLog;
					string rsMess = "";
					dbLog2.CloseConnection(ref rsMess);
					SessionEnvironment.DbLog.Dispose();
				}
				FormsAuthentication.SignOut();
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	[WebMethod(Description = "Autentica l'utente", EnableSession = true)]
	public override bool LogIn(string User, string Password, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		bool flag = default(bool);
		bool result;
		try
		{
			rsmess = "";
			PerformanceLogAppend("LOGIN - BEGIN");
			val = AutenticazioneUtente(User, Password, ref rsmess);
			if ((int)val == 0)
			{
				FormsAuthentication.SetAuthCookie(User, true);
				val = LoginComplete(ref rsmess);
				if ((int)val == 0)
				{
					flag = true;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsmess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			PerformanceLogAppend("LOGIN - END");
			result = flag;
		}
		return result;
	}

	[WebMethod(Description = "Log out dell'utente", EnableSession = true)]
	public override bool LogOut(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		bool flag = false;
		bool result;
		try
		{
			rsmess = "";
			CallStackAdd();
			PerformanceLogAppend("LOGOUT - BEGIN");
			int totalBytes = ((WebService)this).Context.Request.TotalBytes;
			if (this is WSCStateless)
			{
				string rsmess2 = "";
				LogEventiMem("LOGOUT", "", "", 0, ref rsmess2);
			}
			else
			{
				string rsmess2 = "";
				int bytesInviati = default(int);
				LogEventiScrivi("LOGOUT", "", "", totalBytes, bytesInviati, ref rsmess2);
			}
			val = LogoutBegin(ref rsmess);
			if ((int)val == 0)
			{
				FormsAuthentication.SignOut();
				string rsmess2 = "";
				LogoutComplete(ref rsmess2);
				flag = true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			HandleError(ref objEx, ref rsmess);
			flag = false;
			ProjectData.ClearProjectError();
		}
		finally
		{
			PerformanceLogAppend("LOGOUT - END");
			CallStackRemove();
			result = flag;
		}
		return result;
	}

	[WebMethod(Description = "Dice se l'utente è autenticato", EnableSession = true)]
	public override bool isAuthenticate()
	{
		if (((WebService)this).User.Identity.IsAuthenticated)
		{
			return true;
		}
		return false;
	}

	protected override FXRETURN LoginComplete(ref string rsMess)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN result = default(FXRETURN);
		return result;
	}

	protected override FXRETURN LogoutComplete(ref string rsMess)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN result = default(FXRETURN);
		return result;
	}
}
