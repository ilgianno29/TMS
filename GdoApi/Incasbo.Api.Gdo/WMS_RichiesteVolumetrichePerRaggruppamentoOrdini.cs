using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Incasbo.Api.App;
using Incasbo.Api.WMS;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class WMS_RichiesteVolumetrichePerRaggruppamentoOrdini : WMSAbstractApi
{
	protected string _IdViaggio;

	protected string _CodiceRaggruppamento;

	protected StringCollection _Unibols;

	public WMS_RichiesteVolumetrichePerRaggruppamentoOrdini(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_CodiceRaggruppamento = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdViaggio = ((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString();
			_CodiceRaggruppamento = ((AppAbstractApi)this).ParametersIn["CodiceRaggruppamento"].ToString();
			_Unibols = (StringCollection)((AppAbstractApi)this).ParametersIn["Unibols"];
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			Dictionary<string, object> DataInfo = null;
			val = WMSMessage_PrepareData_Invoker.Instance.RunProc(this._ApiContext, WMSMessageType.RichiesteVolumetrichePerRaggruppamentoOrdini, _IdViaggio, _Unibols, _CodiceRaggruppamento, null, null, null, null, null, null, null, ref DataInfo, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				WMSMessage_Send_Invoker instance = WMSMessage_Send_Invoker.Instance;
				AppApiContext apiContext = this._ApiContext;
				Dictionary<string, object> inputInfo = DataInfo;
				Dictionary<string, object> OutputInfo = null;
				val = instance.RunProc(apiContext, WMSMessageType.RichiesteVolumetrichePerRaggruppamentoOrdini, inputInfo, ref OutputInfo, ref rsmess);
				val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
			}
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
