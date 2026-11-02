using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class FattureCalcolaDateScadenza : AppAbstractApi
{
	protected string _IdFattura;

	protected string _TipoPagamento;

	protected DateTime? _DataFattura;

	protected DateTime? _Data1;

	protected DateTime? _Data2;

	protected DateTime? _Data3;

	protected DateTime? Data1 => _Data1;

	protected DateTime? Data2 => _Data2;

	protected DateTime? Data3 => _Data3;

	public FattureCalcolaDateScadenza(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdFattura = "";
		_TipoPagamento = "";
	}

	protected override FXRETURN CheckData(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			_IdFattura = ((AppAbstractApi)this).ParametersIn["IdFattura"].ToString();
			_TipoPagamento = ((AppAbstractApi)this).ParametersIn["TipoPagamento"].ToString();
			_DataFattura = (DateTime?)((AppAbstractApi)this).ParametersIn["DataFattura"];
			((AppAbstractApi)this).ParametersOut.Add("Data1", null);
			((AppAbstractApi)this).ParametersOut.Add("Data2", null);
			((AppAbstractApi)this).ParametersOut.Add("Data3", null);
			val2 = (FXRETURN)0;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected override FXRETURN Core(ref string rsMess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsMess = "";
			if (!_DataFattura.HasValue)
			{
				goto IL_0252;
			}
			text = "Select * From CodiciPagamento Where Codice = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoPagamento);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess);
			if ((int)val <= 0)
			{
				if (rObjDataTable.Rows.Count > 0)
				{
					if (Conversions.ToInteger(rObjDataTable.Rows[0]["Giorni1"]) != 0)
					{
						_Data1 = DataScadenza(_DataFattura.Value, Conversions.ToInteger(rObjDataTable.Rows[0]["Giorni1"]), Conversions.ToInteger(rObjDataTable.Rows[0]["GiorniOffset"]), Conversions.ToString(rObjDataTable.Rows[0]["FineMese"]));
					}
					if (Conversions.ToInteger(rObjDataTable.Rows[0]["Giorni2"]) != 0)
					{
						_Data2 = DataScadenza(_DataFattura.Value, Conversions.ToInteger(rObjDataTable.Rows[0]["Giorni2"]), Conversions.ToInteger(rObjDataTable.Rows[0]["GiorniOffset"]), Conversions.ToString(rObjDataTable.Rows[0]["FineMese"]));
					}
					if (Conversions.ToInteger(rObjDataTable.Rows[0]["Giorni3"]) != 0)
					{
						_Data3 = DataScadenza(_DataFattura.Value, Conversions.ToInteger(rObjDataTable.Rows[0]["Giorni3"]), Conversions.ToInteger(rObjDataTable.Rows[0]["GiorniOffset"]), Conversions.ToString(rObjDataTable.Rows[0]["FineMese"]));
					}
				}
				goto IL_0252;
			}
			val2 = val;
			goto end_IL_0011;
			IL_0252:
			if (Data1.HasValue)
			{
				((AppAbstractApi)this).ParametersOut["Data1"] = _Data1;
			}
			if (Data2.HasValue)
			{
				((AppAbstractApi)this).ParametersOut["Data2"] = _Data2;
			}
			if (Data3.HasValue)
			{
				((AppAbstractApi)this).ParametersOut["Data3"] = _Data3;
			}
			val2 = (FXRETURN)0;
			end_IL_0011:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = this.HandleError(ref ex2, ref rsMess);
			ProjectData.ClearProjectError();
		}
		finally
		{
			this.CallStackRemove();
			result = val2;
		}
		return result;
	}

	protected virtual DateTime DataScadenza(DateTime sDataRiferimento, int nNumGiorniScadenza, int nGiorniOffset, string sFineMese)
	{
		DateTime dateTime = default(DateTime);
		if (nNumGiorniScadenza != 0)
		{
			if (Operators.CompareString(sFineMese, "S", false) == 0)
			{
				dateTime = DateAndTime.DateAdd("m", (double)nNumGiorniScadenza / 30.0, (object)sDataRiferimento);
				dateTime = DateAndTime.DateAdd("d", -1.0, (object)DateAndTime.DateSerial(DateAndTime.Year(dateTime), checked(DateAndTime.Month(dateTime) + 1), 1));
			}
			else
			{
				dateTime = DateAndTime.DateAdd("d", (double)nNumGiorniScadenza, (object)sDataRiferimento);
			}
			if (nGiorniOffset != 0)
			{
				dateTime = DateAndTime.DateAdd("d", (double)nGiorniOffset, (object)dateTime);
			}
		}
		return dateTime;
	}
}
