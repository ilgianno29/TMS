using System;
using System.ServiceModel;
using Incasbo.Api.App;
using Incasbo.WMSService;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.CustomApi.WMS;

public class WMS_ViaggioPartenzaParziale : AppAbstractApi
{
	protected IwmsServiceForTMSClient _WMSService;

	protected string _IdViaggio;

	protected string _Opzioni;

	public WMS_ViaggioPartenzaParziale(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	public static modGeneral.FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, string Opzioni, ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			WMS_ViaggioPartenzaParziale wMS_ViaggioPartenzaParziale = new WMS_ViaggioPartenzaParziale(objApiContext);
			wMS_ViaggioPartenzaParziale.ParametersIn.Add("IdViaggio", IdViaggio);
			wMS_ViaggioPartenzaParziale.ParametersIn.Add("Opzioni", Opzioni);
			fXRETURN = wMS_ViaggioPartenzaParziale.Run(ref rsmess);
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

	protected override modGeneral.FXRETURN CheckData(ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		string text = "";
		modGeneral.FXRETURN result;
		try
		{
			CallStackAdd();
			rsmess = "";
			_IdViaggio = _ParametersIn["IdViaggio"].ToString();
			_Opzioni = _ParametersIn["Opzioni"].ToString();
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
		modGeneral.FXRETURN result2;
		try
		{
			CallStackAdd();
			rsmess = "";
			_WMSService = new IwmsServiceForTMSClient();
			SpedizionePartenzaArgs spedizionePartenzaArgs = new SpedizionePartenzaArgs();
			spedizionePartenzaArgs.InSpedizione = new Spedizione();
			spedizionePartenzaArgs.InSpedizione.Codice = _IdViaggio;
			spedizionePartenzaArgs.InOptions = "<MODO:PARZIALE>";
			Sender sender = new Sender();
			sender.Name = "GDO";
			if (Operators.CompareString(_User, "DSI", false) == 0)
			{
				sender.Profile = ProfileEnum.batch;
			}
			else
			{
				sender.Profile = ProfileEnum.interactive;
			}
			WriteLog("BEFORE ViaggioPartenzaParziale");
			Result result = _WMSService.SpedizionePartenza(sender, spedizionePartenzaArgs);
			if (!result.Good)
			{
				rsmess = TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", "ViaggioPartenzaParziale", result.Reason);
			}
			else
			{
				WriteLog("AFTER ViaggioPartenzaParziale: OK");
				fXRETURN2 = modGeneral.FXRETURN.OK;
			}
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
			if (fXRETURN2 != 0 && Operators.CompareString(rsmess, "", false) != 0)
			{
				WriteLog("AFTER ViaggioPartenzaParziale: " + rsmess);
			}
			try
			{
				if (_WMSService != null)
				{
					((ClientBase<IwmsServiceForTMS>)_WMSService).Close();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex3 = ex2;
				ProjectData.ClearProjectError();
			}
			CallStackRemove();
			result2 = fXRETURN2;
		}
		return result2;
	}
}
