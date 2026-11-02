using System;
using System.Data;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Web.WSCWCF;

public abstract class IncasWCFStandardAuth : IncasWCF
{
	public IncasWCFStandardAuth()
	{
	}

	protected override FXRETURN AutenticazioneUtente(string sUtente, string sPassword, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Invalid comparison between Unknown and I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Invalid comparison between Unknown and I4
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
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
				int incomingBytes = getIncomingBytes();
				if (Incasbo.Web.WSCWCF.TechnicalUsers.IsInternal(sUtente, sPassword, _EmbeddedUser) || Incasbo.Web.WSCWCF.TechnicalUsers.VerifyExternal(sUtente, sPassword, WSApplicationIniConfigDir))
				{
					text2 = "EMBEDDED USER OK";
					text3 = "EMBEDDED USER";
					text4 = "GRP.WFI";
					text5 = "ORG.WFI";
					goto IL_0358;
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
					// Hash PBKDF2 oppure vecchio formato (cifrato/in chiaro); il vecchio formato viene convertito in hash
					bool passwordOk = Incasbo.Security.UserPasswords.Verify(sPassword, text6, SessionEnvironment.WSCConfig.LoginManagerConfig.CryptographyEnable, out bool passwordUpgrade);
					if (passwordOk && passwordUpgrade)
					{
						string rsMessUpgrade = "";
						SessionEnvironment.DbMain.SqlExec("UPDATE " + SessionEnvironment.WSCConfig.TablesConfig.UserTable + " SET PASSWORD=" + SessionEnvironment.DbMain.SQLFormatString(Incasbo.Security.UserPasswords.ForStorage(sPassword)) + " WHERE CODICE=" + SessionEnvironment.DbMain.SQLFormatString(sUtente) + " AND Tipo='U'", ref rsMessUpgrade);
					}
					if (!passwordOk)
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
								goto IL_0358;
							}
							rsmess = $"Gruppo {text4} non attivo";
						}
					}
				}
			}
			goto end_IL_002b;
			IL_0358:
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
			string sNote = text2;
			string sNote2 = rsmess;
			string rsmess2 = "";
			LogEventiMem("LOGIN", sNote, sNote2, ref rsmess2);
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
		return "IncasWCFStandardAuth";
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
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Invalid comparison between Unknown and I4
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)0;
		FXRETURN val2 = (FXRETURN)0;
		string text = "";
		int sQLLeftLength = SessionEnvironment.WSCConfig.LogConfig.SQLLeftLength;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(sEvento, "LOGIN", false) == 0)
			{
				text = text + "INSERT INTO " + SessionEnvironment.WSCConfig.TablesConfig.SessionTable + " (SessionID, Utente, Evento, Note1, Note2, Ip, BytesRicevuti, BytesInviati) VALUES (";
				text = text + SessionEnvironment.DbMain.SQLFormatString(SessionEnvironment.SessionID) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatString(SessionEnvironment.User) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatString(sEvento) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote1, sQLLeftLength)) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote2, sQLLeftLength)) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatString(ClientIp) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesRicevuti) + ", ";
				text = text + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesInviati) + "); ";
			}
			else if (Operators.CompareString(sEvento, "LOGOUT", false) == 0)
			{
				text = text + "UPDATE " + SessionEnvironment.WSCConfig.TablesConfig.SessionTable + " SET Evento=" + SessionEnvironment.DbMain.SQLFormatString(sEvento) + ", ";
				text = text + "NOTE1=" + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote1, sQLLeftLength)) + ", ";
				text = text + "NOTE2=" + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote2, sQLLeftLength)) + ", ";
				text = text + "BytesRicevuti=BytesRicevuti+" + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesRicevuti) + ", ";
				text = text + "BytesInviati=BytesInviati+" + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesInviati) + ", ";
				text += "DATAFINE=GETDATE() ";
				text = text + "WHERE SESSIONID=" + SessionEnvironment.DbMain.SQLFormatString(SessionEnvironment.SessionID) + ";";
			}
			else
			{
				text = text + "UPDATE " + SessionEnvironment.WSCConfig.TablesConfig.SessionTable + " SET Evento=" + SessionEnvironment.DbMain.SQLFormatString(sEvento) + ", ";
				text = text + "NOTE1=" + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote1, sQLLeftLength)) + ", ";
				text = text + "NOTE2=" + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote2, sQLLeftLength)) + ", ";
				text = text + "BytesRicevuti=BytesRicevuti+" + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesRicevuti) + ", ";
				text = text + "BytesInviati=BytesInviati+" + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesInviati) + " ";
				text = text + "WHERE SESSIONID=" + SessionEnvironment.DbMain.SQLFormatString(SessionEnvironment.SessionID) + ";";
			}
			text = text + "INSERT INTO " + SessionEnvironment.WSCConfig.TablesConfig.EventLogTable + " (SessionID, Utente, Evento, Note1, Note2, Ip, Data, BytesRicevuti, BytesInviati) VALUES (";
			text = text + SessionEnvironment.DbMain.SQLFormatString(SessionEnvironment.SessionID) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(SessionEnvironment.User) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(sEvento) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote1, sQLLeftLength)) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote2, sQLLeftLength)) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(ClientIp) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatDate((eTipoData)4, DateTime.Now) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesRicevuti) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesInviati) + "); ";
			val2 = SessionEnvironment.DbLog.SqlExec(text, ref rsmess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
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

	protected virtual FXRETURN LogEventiMem(string sEvento, string sNote1, string sNote2, ref string rsmess)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		int? bytesInviati = default(int?);
		return LogEventiMem(sEvento, sNote1, sNote2, 0, bytesInviati, ref rsmess);
	}

	protected virtual FXRETURN LogEventiMem(string sEvento, string sNote1, string sNote2, int BytesRicevuti, int? BytesInviati, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)0;
		FXRETURN val2 = (FXRETURN)0;
		string text = "";
		int sQLLeftLength = SessionEnvironment.WSCConfig.LogConfig.SQLLeftLength;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(sEvento, "LOGIN", false) == 0)
			{
				text = text + "INSERT INTO " + SessionEnvironment.WSCConfig.TablesConfig.SessionTable + " (SessionID, Utente, Evento, Note1, Note2, Ip, BytesRicevuti, BytesInviati) VALUES (";
				text = text + SessionEnvironment.DbMain.SQLFormatString(SessionEnvironment.SessionID) + ", ";
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
				text = text + "WHERE SESSIONID=" + SessionEnvironment.DbMain.SQLFormatString(SessionEnvironment.SessionID) + ";";
			}
			else
			{
				text = text + "UPDATE " + SessionEnvironment.WSCConfig.TablesConfig.SessionTable + " SET Evento=" + SessionEnvironment.DbMain.SQLFormatString(sEvento) + ", ";
				text = text + "NOTE1=" + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote1, sQLLeftLength)) + ", ";
				text = text + "NOTE2=" + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote2, sQLLeftLength)) + ", ";
				text = text + "BytesRicevuti=BytesRicevuti+" + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesRicevuti) + ", ";
				text += "BytesInviati=BytesInviati+<%BytesInviati%> ";
				text = text + "WHERE SESSIONID=" + SessionEnvironment.DbMain.SQLFormatString(SessionEnvironment.SessionID) + ";";
			}
			text = text + "INSERT INTO " + SessionEnvironment.WSCConfig.TablesConfig.EventLogTable + " (SessionID, Utente, Evento, Note1, Note2, Ip, Data, BytesRicevuti, BytesInviati) VALUES (";
			text = text + SessionEnvironment.DbMain.SQLFormatString(SessionEnvironment.SessionID) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(SessionEnvironment.User) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(sEvento) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote1, sQLLeftLength)) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(Strings.Left(sNote2, sQLLeftLength)) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatString(ClientIp) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatDate((eTipoData)4, DateTime.Now) + ", ";
			text = text + SessionEnvironment.DbMain.SQLFormatNumber(ref BytesRicevuti) + ", ";
			text += "<%BytesInviati%>); ";
			text = ((!BytesInviati.HasValue) ? text.Replace("<%BytesInviati%>", "0") : text.Replace("<%BytesInviati%>", BytesInviati.Value.ToString()));
			_Session.SessionVariable["WSC.SqlToApply"] = _Session.SessionVariable["WSC.SqlToApply"].ToString() + text;
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
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)0;
		FXRETURN val2 = (FXRETURN)0;
		string text = "";
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			object obj = null;
			if (Operators.CompareString(_Session.SessionVariable["WSC.SqlToApply"].ToString(), "", false) != 0)
			{
				text = _Session.SessionVariable["WSC.SqlToApply"].ToString();
				_Session.SessionVariable["WSC.SqlToApply"] = "";
				if (Operators.CompareString(text, "", false) != 0)
				{
					text = text.Replace("<%BytesInviati%>", BytesInviati.ToString());
					DBConnection dbLog = SessionEnvironment.DbLog;
					string vsSQLClause = text;
					string rsMess = "";
					dbLog.SqlExec(vsSQLClause, ref rsMess);
				}
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

	public override bool LogIn(string User, string Password, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		FXRETURN val = (FXRETURN)3;
		bool flag = default(bool);
		bool result;
		try
		{
			rsmess = "";
			PerformanceLogAppend("LOGIN - BEGIN");
			if (_isAuthenticate)
			{
				goto IL_0041;
			}
			val = AutenticazioneUtente(User, Password, ref rsmess);
			if ((int)val == 0)
			{
				_isAuthenticate = true;
				val = LoginComplete(ref rsmess);
				if ((int)val == 0)
				{
					goto IL_0041;
				}
			}
			goto end_IL_0002;
			IL_0041:
			flag = true;
			end_IL_0002:;
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

	public override bool LogOut(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		bool flag = false;
		bool result;
		try
		{
			rsmess = "";
			CallStackAdd();
			PerformanceLogAppend("LOGOUT - BEGIN");
			int incomingBytes = getIncomingBytes();
			string rsmess2 = "";
			LogEventiMem("LOGOUT", "", "", 0, ref rsmess2);
			val = LogoutBegin(ref rsmess);
			if ((int)val == 0)
			{
				rsmess2 = "";
				LogEventiFlush(0, ref rsmess2);
				_isAuthenticate = false;
				rsmess2 = "";
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

	public override bool isAuthenticate()
	{
		return _isAuthenticate;
	}

	protected override FXRETURN LoginComplete(ref string rsMess)
	{
		rsMess = "";
		return (FXRETURN)0;
	}

	protected override FXRETURN LogoutComplete(ref string rsMess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)0;
		FXRETURN val2 = (FXRETURN)0;
		FXRETURN result;
		try
		{
			CallStackAdd();
			rsMess = "";
			if (SessionEnvironment.DbMain != null)
			{
				DBConnection dbMain = SessionEnvironment.DbMain;
				string rsMess2 = "";
				dbMain.CloseConnection(ref rsMess2);
			}
			if (SessionEnvironment.DbLog != null)
			{
				DBConnection dbLog = SessionEnvironment.DbLog;
				string rsMess2 = "";
				dbLog.CloseConnection(ref rsMess2);
			}
			val = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			val = HandleError(ref objEx, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = val;
		}
		return result;
	}

	protected override FXRETURN MyTestDBConnection(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			val2 = base.MyTestDBConnection(ref rsmess);
			val = (((int)val2 == 0) ? ((FXRETURN)0) : val2);
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
			string sNote = rsmess;
			string rsmess2 = "";
			LogEventiMem("TEST DB", sNote, "", ref rsmess2);
			result = val;
		}
		return result;
	}
}
