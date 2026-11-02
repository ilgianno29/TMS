using System;
using System.Collections.Generic;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.WMS;

internal class WMS_AggiornaQuantitaSpedizione_Data : AppAbstractApi
{
	protected Dictionary<string, object> _DataInfo;

	protected string _Unibol;

	protected string _NumeroOrdine;

	protected DateTime _DataOrdine;

	protected string _Cliente;

	public WMS_AggiornaQuantitaSpedizione_Data(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_DataInfo = new Dictionary<string, object>();
		_Unibol = "";
		_NumeroOrdine = "";
		_Cliente = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			base._ParametersOut.Add("DataInfo", _DataInfo);
			_Unibol = base._ParametersIn["Unibol"].ToString();
			_NumeroOrdine = base._ParametersIn["NumeroOrdine"].ToString();
			_DataOrdine = Conversions.ToDate(base._ParametersIn["DataOrdine"]);
			_Cliente = base._ParametersIn["Cliente"].ToString();
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
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_Unibol, "", false) == 0)
			{
				_DataInfo.Add("SpedizioneCommittente", _Cliente);
				_DataInfo.Add("SpedizioneOrdine", _NumeroOrdine);
				_DataInfo.Add("SpedizioneData", _DataOrdine);
				goto IL_0165;
			}
			text = "SELECT Unibol, Cliente, NumeroOrdine, DataOrdine FROM Spedizioni WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val != 0)
			{
				val2 = val;
			}
			else
			{
				if (rObjDataTable.Rows.Count != 0)
				{
					DataRow dataRow = rObjDataTable.Rows[0];
					_DataInfo.Add("SpedizioneCommittente", dataRow["Cliente"].ToString());
					_DataInfo.Add("SpedizioneOrdine", dataRow["NumeroOrdine"].ToString());
					_DataInfo.Add("SpedizioneData", Conversions.ToDate(dataRow["DataOrdine"]));
					dataRow = null;
					goto IL_0165;
				}
				rsmess = this.TranslateMessage("XXX", "Spedizione {0} non trovata.", new string[1] { _Unibol });
			}
			goto end_IL_000d;
			IL_0165:
			val2 = (FXRETURN)0;
			end_IL_000d:;
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string Unibol, ref Dictionary<string, object> DataInfo, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Invalid comparison between Unknown and I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			WMS_AggiornaQuantitaSpedizione_Data wMS_AggiornaQuantitaSpedizione_Data = new WMS_AggiornaQuantitaSpedizione_Data(objApiContext);
			((AppAbstractApi)wMS_AggiornaQuantitaSpedizione_Data).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)wMS_AggiornaQuantitaSpedizione_Data).ParametersIn.Add("NumeroOrdine", "");
			((AppAbstractApi)wMS_AggiornaQuantitaSpedizione_Data).ParametersIn.Add("DataOrdine", DateTime.MinValue);
			((AppAbstractApi)wMS_AggiornaQuantitaSpedizione_Data).ParametersIn.Add("Cliente", "");
			val = ((AppAbstractApi)wMS_AggiornaQuantitaSpedizione_Data).Run(ref rsmess);
			if ((int)val != 0)
			{
				val2 = val;
			}
			else
			{
				DataInfo = (Dictionary<string, object>)((AppAbstractApi)wMS_AggiornaQuantitaSpedizione_Data).ParametersOut["DataInfo"];
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = (FXRETURN)3;
			rsmess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
		}
		return result;
	}

	public static FXRETURN RunProc(AppApiContext objApiContext, string NumeroOrdine, DateTime DataOrdine, string Cliente, ref Dictionary<string, object> DataInfo, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			WMS_AggiornaQuantitaSpedizione_Data wMS_AggiornaQuantitaSpedizione_Data = new WMS_AggiornaQuantitaSpedizione_Data(objApiContext);
			((AppAbstractApi)wMS_AggiornaQuantitaSpedizione_Data).ParametersIn.Add("NumeroOrdine", NumeroOrdine);
			((AppAbstractApi)wMS_AggiornaQuantitaSpedizione_Data).ParametersIn.Add("DataOrdine", DataOrdine);
			((AppAbstractApi)wMS_AggiornaQuantitaSpedizione_Data).ParametersIn.Add("Cliente", Cliente);
			((AppAbstractApi)wMS_AggiornaQuantitaSpedizione_Data).ParametersIn.Add("Unibol", "");
			val = ((AppAbstractApi)wMS_AggiornaQuantitaSpedizione_Data).Run(ref rsmess);
			if ((int)val != 0)
			{
				val2 = val;
			}
			else
			{
				DataInfo = (Dictionary<string, object>)((AppAbstractApi)wMS_AggiornaQuantitaSpedizione_Data).ParametersOut["DataInfo"];
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = (FXRETURN)3;
			rsmess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
		}
		return result;
	}
}
