using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Api.Default;
using Incasbo.Api.Params;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.WMS;

public class WMSMessage_PrepareData : WMSAbstractApi
{
	protected Dictionary<string, object> _DataInfo;

	protected WMSMessageType _WMSMessageType;

	protected object _Param1;

	protected object _Param2;

	protected object _Param3;

	protected object _Param4;

	protected object _Param5;

	protected object _Param6;

	protected object _Param7;

	protected object _Param8;

	protected object _Param9;

	protected object _Param10;

	public ApplicationDefault ApplicationDefault => (ApplicationDefault)(object)this._ApiContext.AppDefault;

	public ApplicationParams ApplicationParams => (ApplicationParams)(object)this._ApiContext.AppParams;

	public WMSMessage_PrepareData(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_DataInfo = new Dictionary<string, object>();
		_WMSMessageType = WMSMessageType.UnKnown;
		_Param1 = null;
		_Param2 = null;
		_Param3 = null;
		_Param4 = null;
		_Param5 = null;
		_Param6 = null;
		_Param7 = null;
		_Param8 = null;
		_Param9 = null;
		_Param10 = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_WMSMessageType = (WMSMessageType)this._ParametersIn["TipoMessaggio"];
			_Param1 = RuntimeHelpers.GetObjectValue(this._ParametersIn["Param1"]);
			_Param2 = RuntimeHelpers.GetObjectValue(this._ParametersIn["Param2"]);
			_Param3 = RuntimeHelpers.GetObjectValue(this._ParametersIn["Param3"]);
			_Param4 = RuntimeHelpers.GetObjectValue(this._ParametersIn["Param4"]);
			_Param5 = RuntimeHelpers.GetObjectValue(this._ParametersIn["Param5"]);
			_Param6 = RuntimeHelpers.GetObjectValue(this._ParametersIn["Param6"]);
			_Param7 = RuntimeHelpers.GetObjectValue(this._ParametersIn["Param7"]);
			_Param8 = RuntimeHelpers.GetObjectValue(this._ParametersIn["Param8"]);
			_Param9 = RuntimeHelpers.GetObjectValue(this._ParametersIn["Param9"]);
			_Param10 = RuntimeHelpers.GetObjectValue(this._ParametersIn["Param10"]);
			this._ParametersOut.Add("DataInfo", _DataInfo);
			AppApiContext apiContext = this._ApiContext;
			AppParams appParams = apiContext.AppParams;
			WMSMessageConfig.Init(ref appParams);
			apiContext.AppParams = appParams;
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Invalid comparison between Unknown and I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Invalid comparison between Unknown and I4
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Invalid comparison between Unknown and I4
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Invalid comparison between Unknown and I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Invalid comparison between Unknown and I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Invalid comparison between Unknown and I4
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Invalid comparison between Unknown and I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Invalid comparison between Unknown and I4
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Invalid comparison between Unknown and I4
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Invalid comparison between Unknown and I4
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Invalid comparison between Unknown and I4
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Invalid comparison between Unknown and I4
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Invalid comparison between Unknown and I4
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Invalid comparison between Unknown and I4
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Invalid comparison between Unknown and I4
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Invalid comparison between Unknown and I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Invalid comparison between Unknown and I4
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Invalid comparison between Unknown and I4
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(ApplicationParams.WmsEnabled(), "S", false) == 0 && WMSMessageConfig.WmsMessageEnabled[_WMSMessageType])
			{
				switch (_WMSMessageType)
				{
				case WMSMessageType.AssegnaSequenzaConsegnaOrdine:
					val = WMS_AssegnaSequenzaConsegnaOrdine_Data.RunProc(this._ApiContext, _Param1.ToString(), Conversions.ToInteger(_Param2), ref _DataInfo, ref rsmess);
					if ((int)val == 0)
					{
						break;
					}
					val2 = val;
					goto end_IL_0004;
				case WMSMessageType.AssociaSpedizioneABatch:
					val = WMS_AssociaSpedizioneABatch_Data.RunProc(this._ApiContext, _Param1.ToString(), _Param2.ToString(), ref _DataInfo, ref rsmess);
					if ((int)val == 0)
					{
						break;
					}
					val2 = val;
					goto end_IL_0004;
				case WMSMessageType.CreazioneViaggio:
					val = WMS_CreazioneViaggio_Data.RunProc(this._ApiContext, _Param1.ToString(), ref _DataInfo, ref rsmess);
					if ((int)val == 0)
					{
						break;
					}
					val2 = val;
					goto end_IL_0004;
				case WMSMessageType.CancellazioneViaggio:
					val = WMS_CancellazioneViaggio_Data.RunProc(this._ApiContext, _Param1.ToString(), ref _DataInfo, ref rsmess);
					if ((int)val == 0)
					{
						break;
					}
					val2 = val;
					goto end_IL_0004;
				case WMSMessageType.RiapriViaggio:
					val = WMS_RiapriViaggio_Data.RunProc(this._ApiContext, _Param1.ToString(), ref _DataInfo, ref rsmess);
					if ((int)val == 0)
					{
						break;
					}
					val2 = val;
					goto end_IL_0004;
				case WMSMessageType.AssociaSpedizioneAViaggio:
					val = WMS_AssociaSpedizioneAViaggio_Data.RunProc(this._ApiContext, _Param1.ToString(), _Param2.ToString(), ref _DataInfo, ref rsmess);
					if ((int)val == 0)
					{
						break;
					}
					val2 = val;
					goto end_IL_0004;
				case WMSMessageType.AssociaSpedizioneAViaggioChiuso:
					val = WMS_AssociaSpedizioneAViaggioChiuso_Data.RunProc(this._ApiContext, _Param1.ToString(), _Param2.ToString(), ref _DataInfo, ref rsmess);
					if ((int)val == 0)
					{
						break;
					}
					val2 = val;
					goto end_IL_0004;
				case WMSMessageType.DisassociaSpedizioneAViaggio:
					val = WMS_DisassociaSpedizioneAViaggio_Data.RunProc(this._ApiContext, _Param1.ToString(), _Param2.ToString(), ref _DataInfo, ref rsmess);
					if ((int)val == 0)
					{
						break;
					}
					val2 = val;
					goto end_IL_0004;
				case WMSMessageType.DisassociaSpedizioneAViaggioChiuso:
					val = WMS_DisassociaSpedizioneAViaggioChiuso_Data.RunProc(this._ApiContext, _Param1.ToString(), _Param2.ToString(), ref _DataInfo, ref rsmess);
					if ((int)val == 0)
					{
						break;
					}
					val2 = val;
					goto end_IL_0004;
				case WMSMessageType.CalcolaNumeroPalletSagomeViaggio:
					val = WMS_CalcolaNumeroPalletSagomeViaggio_Data.RunProc(this._ApiContext, _Param1.ToString(), ref _DataInfo, ref rsmess);
					if ((int)val == 0)
					{
						break;
					}
					val2 = val;
					goto end_IL_0004;
				case WMSMessageType.CalcolaNumeroPalletSagome:
					val = WMS_CalcolaNumeroPalletSagome_Data.RunProc(this._ApiContext, _Param1.ToString(), ref _DataInfo, ref rsmess);
					if ((int)val == 0)
					{
						break;
					}
					val2 = val;
					goto end_IL_0004;
				case WMSMessageType.CreazioneBatch:
					val = WMS_CreazioneBatch_Data.RunProc(this._ApiContext, _Param1.ToString(), ref _DataInfo, ref rsmess);
					if ((int)val == 0)
					{
						break;
					}
					val2 = val;
					goto end_IL_0004;
				case WMSMessageType.DisassociaSpedizioneABatch:
					val = WMS_DisassociaSpedizioneABatch_Data.RunProc(this._ApiContext, _Param1.ToString(), _Param2.ToString(), ref _DataInfo, ref rsmess);
					if ((int)val == 0)
					{
						break;
					}
					val2 = val;
					goto end_IL_0004;
				case WMSMessageType.AggiornaQuantitaSpedizione:
					if (_Param2 == null)
					{
						val = WMS_AggiornaQuantitaSpedizione_Data.RunProc(this._ApiContext, _Param1.ToString(), ref _DataInfo, ref rsmess);
						if ((int)val == 0)
						{
							break;
						}
						val2 = val;
					}
					else
					{
						val = WMS_AggiornaQuantitaSpedizione_Data.RunProc(this._ApiContext, _Param1.ToString(), Conversions.ToDate(_Param2), _Param3.ToString(), ref _DataInfo, ref rsmess);
						if ((int)val == 0)
						{
							break;
						}
						val2 = val;
					}
					goto end_IL_0004;
				case WMSMessageType.AssociaSpedizioneALinea:
					val = WMS_AssociaSpedizioneALinea_Data.RunProc(this._ApiContext, _Param1.ToString(), _Param2.ToString(), ref _DataInfo, ref rsmess);
					if ((int)val == 0)
					{
						break;
					}
					val2 = val;
					goto end_IL_0004;
				case WMSMessageType.DisassociaSpedizioneALinea:
					val = WMS_DisassociaSpedizioneALinea_Data.RunProc(this._ApiContext, _Param1.ToString(), _Param2.ToString(), ref _DataInfo, ref rsmess);
					if ((int)val == 0)
					{
						break;
					}
					val2 = val;
					goto end_IL_0004;
				case WMSMessageType.CreaViaggio_AssociaSpedizioniAViaggio:
					val = WMS_CreaViaggio_AssociaSpedizioniAViaggio_Data.RunProc(this._ApiContext, _Param1.ToString(), (StringCollection)_Param2, ref _DataInfo, ref rsmess);
					if ((int)val == 0)
					{
						break;
					}
					val2 = val;
					goto end_IL_0004;
				case WMSMessageType.RichiesteVolumetrichePerRaggruppamentoOrdini:
					val = WMS_VolumetricaPerRaggruppamentoOrdini_Data.RunProc(this._ApiContext, _Param1.ToString(), (StringCollection)_Param2, _Param3.ToString(), ref _DataInfo, ref rsmess);
					if ((int)val == 0)
					{
						break;
					}
					val2 = val;
					goto end_IL_0004;
				}
			}
			this._ParametersOut["DataInfo"] = _DataInfo;
			val2 = (FXRETURN)0;
			end_IL_0004:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsmess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}
}
