using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Api.Gdo;
using Incasbo.Api.Params;
using Incasbo.CustomApi.WMS;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.CustomApi.Gdo;

public class Viaggio_Partenza : Incasbo.Api.Gdo.Viaggio_Partenza
{
	protected new ApplicationParams ApplicationParams => (ApplicationParams)(object)this._ApiContext.AppParams;

	public Viaggio_Partenza(AppApiContext objApiContext)
		: base(objApiContext)
	{
	}

	protected override FXRETURN AfterRun(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Invalid comparison between Unknown and I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = this.AfterRun(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(ApplicationParams.Custom.InvioTransporeonPartenzaViaggio(), "S", false) != 0)
				{
					goto IL_007f;
				}
				text = "INSERT INTO  DelsyTasks_Triggers (Istanza, Task, Applicazione) VALUES ('MAIN','INVIATRANS','DSI')";
				val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
				if ((int)val <= 0)
				{
					goto IL_007f;
				}
				val2 = val;
			}
			goto end_IL_000b;
			IL_007f:
			bool flag = false;
			foreach (DataRow row in _dtSpedizioni.Rows)
			{
				if (Operators.CompareString(row["StatoWMS"].ToString(), "99", false) != 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				goto IL_0127;
			}
			val = WMS_ViaggioPartenza.RunProc(this._ApiContext, _IdViaggio, "", ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_0127;
			}
			val2 = val;
			goto end_IL_000b;
			IL_0127:
			val2 = (FXRETURN)0;
			end_IL_000b:;
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
