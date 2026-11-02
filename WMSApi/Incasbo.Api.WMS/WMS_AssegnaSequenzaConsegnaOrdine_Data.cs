using System;
using System.Collections.Generic;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.WMS;

internal class WMS_AssegnaSequenzaConsegnaOrdine_Data : AppAbstractApi
{
	protected Dictionary<string, object> _DataInfo;

	protected string _Unibol;

	protected int _Sequenza;

	public WMS_AssegnaSequenzaConsegnaOrdine_Data(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_DataInfo = new Dictionary<string, object>();
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string[] array = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			base._ParametersOut.Add("DataInfo", _DataInfo);
			if (!base._ParametersIn.ContainsKey("Unibol"))
			{
				rsmess = this.TranslateMessage("XXX", "Parametro Unibol non specificato.");
			}
			else
			{
				_Unibol = base._ParametersIn["Unibol"].ToString();
				if (!base._ParametersIn.ContainsKey("Sequenza"))
				{
					rsmess = this.TranslateMessage("XXX", "Parametro Sequenza non specificato.");
				}
				else
				{
					_Sequenza = Conversions.ToInteger(base._ParametersIn["Sequenza"]);
					val2 = (FXRETURN)0;
				}
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT Unibol, Cliente, NumeroOrdine, DataOrdine, ProgressivoConsegna FROM Spedizioni WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val != 0)
			{
				val2 = val;
			}
			else if (rObjDataTable.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Spedizione {0} non trovata.", new string[1] { _Unibol });
			}
			else
			{
				DataRow dataRow = rObjDataTable.Rows[0];
				_DataInfo.Add("SpedizioneCommittente", dataRow["Cliente"].ToString());
				_DataInfo.Add("SpedizioneOrdine", dataRow["NumeroOrdine"].ToString());
				_DataInfo.Add("SpedizioneData", Conversions.ToDate(dataRow["DataOrdine"]));
				dataRow = null;
				_DataInfo.Add("SequenzaConsegna", _Sequenza);
				val2 = (FXRETURN)0;
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string Unibol, int Sequenza, ref Dictionary<string, object> DataInfo, ref string rsmess)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			WMS_AssegnaSequenzaConsegnaOrdine_Data wMS_AssegnaSequenzaConsegnaOrdine_Data = new WMS_AssegnaSequenzaConsegnaOrdine_Data(objApiContext);
			((AppAbstractApi)wMS_AssegnaSequenzaConsegnaOrdine_Data).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)wMS_AssegnaSequenzaConsegnaOrdine_Data).ParametersIn.Add("Sequenza", Sequenza);
			val = ((AppAbstractApi)wMS_AssegnaSequenzaConsegnaOrdine_Data).Run(ref rsmess);
			if ((int)val != 0)
			{
				val2 = val;
			}
			else
			{
				DataInfo = (Dictionary<string, object>)((AppAbstractApi)wMS_AssegnaSequenzaConsegnaOrdine_Data).ParametersOut["DataInfo"];
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
