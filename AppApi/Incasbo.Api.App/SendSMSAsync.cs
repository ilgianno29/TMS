using System;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.App;

public class SendSMSAsync : AppAbstractApi
{
	protected SendSMSInfo _SMSInfo;

	public SendSMSAsync(AppApiContext objApiContext)
		: base(objApiContext)
	{
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
			_SMSInfo = (SendSMSInfo)ParametersIn["SMSInfo"];
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
			text = "INSERT INTO IboMailer_SMS(TipoInvio, SMSNumber, SMSText)";
			text = text + "VALUES (" + DbConn.SQLFormatNumber(ref _SMSInfo.Tipo) + ",";
			text = text + DbConn.SQLFormatString(_SMSInfo.Number) + ", ";
			text = text + DbConn.SQLFormatString(_SMSInfo.Text) + "); ";
			fXRETURN = DbConn.SqlExec(text, ref rsmess);
			fXRETURN2 = ((fXRETURN != 0) ? fXRETURN : modGeneral.FXRETURN.OK);
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

	public static modGeneral.FXRETURN RunProc(AppApiContext objApiContext, SendSMSInfo SMSInfo, ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			SendSMSAsync sendSMSAsync = new SendSMSAsync(objApiContext);
			sendSMSAsync.ParametersIn.Add("SMSInfo", SMSInfo);
			fXRETURN = sendSMSAsync.Run(ref rsmess);
			fXRETURN2 = ((fXRETURN != 0) ? fXRETURN : modGeneral.FXRETURN.OK);
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
}
