using System;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.App;

public class WriteDebugInfo : AppAbstractApi
{
	protected string _Applicazione;

	protected string _Contesto;

	protected string _Messaggio1;

	protected string _Messaggio2;

	protected string _IdSessione;

	protected new bool _AlwaysInsert;

	protected string _DebugUser;

	protected bool _ApplyQuery;

	public WriteDebugInfo(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Applicazione = "";
		_Contesto = "";
		_Messaggio1 = "";
		_Messaggio2 = "";
		_IdSessione = "";
		_AlwaysInsert = false;
		_DebugUser = "";
		_ApplyQuery = true;
	}

	protected override modGeneral.FXRETURN CheckData(ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			if (ParametersIn.ContainsKey("Applicazione"))
			{
				_Applicazione = ParametersIn["Applicazione"].ToString();
			}
			else
			{
				_Applicazione = _ApiContext.AppName;
			}
			if (ParametersIn.ContainsKey("IdSessione"))
			{
				_IdSessione = ParametersIn["IdSessione"].ToString();
			}
			else
			{
				_IdSessione = _ApiContext.AppSessionId;
			}
			if (ParametersIn.ContainsKey("Contesto"))
			{
				_Contesto = ParametersIn["Contesto"].ToString();
			}
			if (ParametersIn.ContainsKey("Messaggio1"))
			{
				_Messaggio1 = ParametersIn["Messaggio1"].ToString();
			}
			if (ParametersIn.ContainsKey("Messaggio2"))
			{
				_Messaggio2 = ParametersIn["Messaggio2"].ToString();
			}
			if (ParametersIn.ContainsKey("AlwaysInsert"))
			{
				_AlwaysInsert = Conversions.ToBoolean(ParametersIn["AlwaysInsert"]);
			}
			if (ParametersIn.ContainsKey("DebugUser"))
			{
				_DebugUser = ParametersIn["DebugUser"].ToString();
			}
			if (ParametersIn.ContainsKey("ApplyQuery"))
			{
				_ApplyQuery = Conversions.ToBoolean(ParametersIn["ApplyQuery"]);
			}
			ParametersOut.Add("QueryToApply", "");
			fXRETURN2 = modGeneral.FXRETURN.OK;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = fXRETURN2;
		}
		return result;
	}

	protected override modGeneral.FXRETURN Core(ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		string text = "";
		modGeneral.FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			if (!(_AlwaysInsert | (_ApiContext.IsDebug & ((Operators.CompareString(_DebugUser, "", false) == 0) | (Operators.CompareString(_DebugUser.ToUpper(), _User.ToUpper(), false) == 0)))))
			{
				goto IL_0166;
			}
			text = "INSERT INTO WFI_DebugInfo ";
			text += "(Applicazione,Utente,Contesto,Messaggio1,Messaggio2,IdSessione) VALUES (";
			text = text + DbConn.SQLFormatString(_Applicazione) + ", ";
			text = text + DbConn.SQLFormatString(_User) + ", ";
			text = text + DbConn.SQLFormatString(_Contesto) + ", ";
			text = text + DbConn.SQLFormatString(Strings.Left(_Messaggio1, 500)) + ", ";
			text = text + DbConn.SQLFormatString(Strings.Left(_Messaggio2, 500)) + ", ";
			text = text + DbConn.SQLFormatString(_IdSessione) + "); ";
			ParametersOut["QueryToApply"] = text;
			if (!_ApplyQuery)
			{
				goto IL_0166;
			}
			fXRETURN = DbConn.SqlExec(text, ref rsmess);
			if (fXRETURN == modGeneral.FXRETURN.OK)
			{
				goto IL_0166;
			}
			fXRETURN2 = fXRETURN;
			goto end_IL_000a;
			IL_0166:
			fXRETURN2 = modGeneral.FXRETURN.OK;
			end_IL_000a:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception objEx = ex;
			fXRETURN2 = HandleError(ref objEx, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			CallStackRemove();
			result = fXRETURN2;
		}
		return result;
	}

	public static modGeneral.FXRETURN RunProc(AppApiContext objApiContext, string Applicazione, string Contesto, string Messaggio1, string Messaggio2, string IdSessione, bool AlwaysInsert, string DebugUser, bool ApplyQuery, ref string QueryToApply, ref string rsmess)
	{
		WriteDebugInfo writeDebugInfo = new WriteDebugInfo(objApiContext);
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			writeDebugInfo.ParametersIn.Add("Applicazione", Applicazione);
			writeDebugInfo.ParametersIn.Add("Contesto", Contesto);
			writeDebugInfo.ParametersIn.Add("Messaggio1", Messaggio1);
			writeDebugInfo.ParametersIn.Add("Messaggio2", Messaggio2);
			writeDebugInfo.ParametersIn.Add("IdSessione", IdSessione);
			writeDebugInfo.ParametersIn.Add("AlwaysInsert", AlwaysInsert);
			writeDebugInfo.ParametersIn.Add("DebugUser", DebugUser);
			writeDebugInfo.ParametersIn.Add("ApplyQuery", ApplyQuery);
			fXRETURN = writeDebugInfo.Run(ref rsmess);
			if (fXRETURN != 0)
			{
				fXRETURN2 = fXRETURN;
			}
			else
			{
				QueryToApply = writeDebugInfo.ParametersOut["QueryToApply"].ToString();
				fXRETURN2 = modGeneral.FXRETURN.OK;
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
			result = fXRETURN2;
		}
		return result;
	}

	public static modGeneral.FXRETURN RunProc(AppApiContext objApiContext, string Applicazione, string Contesto, string Messaggio1, string Messaggio2, string IdSessione, bool AlwaysInsert, string DebugUser, ref string rsmess)
	{
		WriteDebugInfo writeDebugInfo = new WriteDebugInfo(objApiContext);
		writeDebugInfo.ParametersIn.Add("Applicazione", Applicazione);
		writeDebugInfo.ParametersIn.Add("Contesto", Contesto);
		writeDebugInfo.ParametersIn.Add("Messaggio1", Messaggio1);
		writeDebugInfo.ParametersIn.Add("Messaggio2", Messaggio2);
		writeDebugInfo.ParametersIn.Add("IdSessione", IdSessione);
		writeDebugInfo.ParametersIn.Add("AlwaysInsert", AlwaysInsert);
		writeDebugInfo.ParametersIn.Add("DebugUser", DebugUser);
		return writeDebugInfo.Run(ref rsmess);
	}

	public static modGeneral.FXRETURN RunProc(AppApiContext objApiContext, string Contesto, string Messaggio1, string Messaggio2, bool AlwaysInsert, string DebugUser, ref string rsmess)
	{
		WriteDebugInfo writeDebugInfo = new WriteDebugInfo(objApiContext);
		writeDebugInfo.ParametersIn.Add("Contesto", Contesto);
		writeDebugInfo.ParametersIn.Add("Messaggio1", Messaggio1);
		writeDebugInfo.ParametersIn.Add("Messaggio2", Messaggio2);
		writeDebugInfo.ParametersIn.Add("AlwaysInsert", AlwaysInsert);
		writeDebugInfo.ParametersIn.Add("DebugUser", DebugUser);
		return writeDebugInfo.Run(ref rsmess);
	}

	public static modGeneral.FXRETURN RunProc(AppApiContext objApiContext, string Contesto, string Messaggio1, string Messaggio2, ref string rsmess)
	{
		WriteDebugInfo writeDebugInfo = new WriteDebugInfo(objApiContext);
		writeDebugInfo.ParametersIn.Add("Contesto", Contesto);
		writeDebugInfo.ParametersIn.Add("Messaggio1", Messaggio1);
		writeDebugInfo.ParametersIn.Add("Messaggio2", Messaggio2);
		return writeDebugInfo.Run(ref rsmess);
	}
}
