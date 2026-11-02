using System;
using System.ServiceModel;
using Incasbo.Api.App;
using Incasbo.WMSService;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.CustomApi.WMS;

public class WMS_ConcludiImportazioneOrdine : AppAbstractApi
{
	protected IwmsServiceForTMSClient _WMSService;

	protected int _IdRecord;

	protected string _OrdineCommittente;

	protected string _OrdineNumero;

	protected string _EsitoImportazione;

	protected bool _GestioneWms;

	public WMS_ConcludiImportazioneOrdine(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	public static modGeneral.FXRETURN RunProc(AppApiContext objApiContext, int IdRecord, string OrdineCommittente, string OrdineNumero, string EsitoImportazione, bool GestioneWms, ref string rsmess)
	{
		modGeneral.FXRETURN fXRETURN = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN fXRETURN2 = modGeneral.FXRETURN.GenericError;
		modGeneral.FXRETURN result;
		try
		{
			rsmess = "";
			WMS_ConcludiImportazioneOrdine wMS_ConcludiImportazioneOrdine = new WMS_ConcludiImportazioneOrdine(objApiContext);
			wMS_ConcludiImportazioneOrdine.ParametersIn.Add("IdRecord", IdRecord);
			wMS_ConcludiImportazioneOrdine.ParametersIn.Add("OrdineCommittente", OrdineCommittente);
			wMS_ConcludiImportazioneOrdine.ParametersIn.Add("OrdineNumero", OrdineNumero);
			wMS_ConcludiImportazioneOrdine.ParametersIn.Add("EsitoImportazione", EsitoImportazione);
			wMS_ConcludiImportazioneOrdine.ParametersIn.Add("GestioneWms", GestioneWms);
			fXRETURN = wMS_ConcludiImportazioneOrdine.Run(ref rsmess);
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
			_IdRecord = Conversions.ToInteger(_ParametersIn["IdRecord"]);
			_OrdineCommittente = _ParametersIn["OrdineCommittente"].ToString();
			_OrdineNumero = _ParametersIn["OrdineNumero"].ToString();
			if (_ParametersIn["EsitoImportazione"] != null)
			{
				_EsitoImportazione = _ParametersIn["EsitoImportazione"].ToString();
			}
			_GestioneWms = Conversions.ToBoolean(_ParametersIn["GestioneWms"].ToString());
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
			ConcludiImportazioneOrdineArgs concludiImportazioneOrdineArgs = new ConcludiImportazioneOrdineArgs();
			concludiImportazioneOrdineArgs.InTransmissionRecordId = _IdRecord;
			concludiImportazioneOrdineArgs.InOrdine = new TestataOrdine();
			concludiImportazioneOrdineArgs.InOrdine.Committente = _OrdineCommittente;
			concludiImportazioneOrdineArgs.InOrdine.Ordine = _OrdineNumero;
			concludiImportazioneOrdineArgs.InErroreImportTms = _EsitoImportazione;
			concludiImportazioneOrdineArgs.InGestioneWms = _GestioneWms;
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
			WriteLog("BEFORE ConcludiImportazioneOrdine");
			Result result = _WMSService.ConcludiImportazioneOrdine(sender, concludiImportazioneOrdineArgs);
			if (!result.Good)
			{
				rsmess = TranslateMessage("XXX", "Errore nell'esecuzione del metodo {0}: {1}.", "ConcludiImportazioneOrdine", result.Reason);
			}
			else
			{
				WriteLog("AFTER ConcludiImportazioneOrdine: OK");
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
				WriteLog("AFTER ConcludiImportazioneOrdine: " + rsmess);
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
