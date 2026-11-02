using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class BatchDetermina : AppAbstractApi
{
	protected string _ZonaSpedizione;

	protected DateTime _DataSpedizione;

	protected string _Tipo;

	protected string _Batch;

	public BatchDetermina(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_ZonaSpedizione = null;
		_DataSpedizione = DateTime.MinValue;
		_Tipo = null;
		_Batch = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			((AppAbstractApi)this).ParametersOut.Add("Batch", "");
			_ZonaSpedizione = base._ParametersIn["ZonaSpedizione"].ToString();
			_DataSpedizione = Conversions.ToDate(base._ParametersIn["DataSpedizione"]);
			_Tipo = base._ParametersIn["Tipo"].ToString();
			if (Operators.CompareString(_Tipo, "", false) == 0)
			{
				_Tipo = "D";
			}
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
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Invalid comparison between Unknown and I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Invalid comparison between Unknown and I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		DataTable dataTable = null;
		object objRes = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_Tipo, "T", false) == 0)
			{
				_Batch = "";
				goto IL_0217;
			}
			if (Operators.CompareString(_Tipo, "D", false) == 0)
			{
				string text = "SELECT Id FROM Spedizioni_Batch WHERE ";
				text = text + "ZonaSpedizione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaSpedizione) + " AND ";
				text = text + "Data = " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DataSpedizione) + " AND ";
				text = text + "Tipo = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Tipo) + " AND ";
				text += "Stato = 10";
				val = ((AppBaseClass)this).DbConn.DoSql(text, "", ref objRes, ref rsmess);
				if ((int)val <= 0)
				{
					if (Operators.CompareString(objRes.ToString(), "", false) != 0)
					{
						_Batch = objRes.ToString();
					}
					goto IL_0217;
				}
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(_Tipo, "X", false) != 0)
				{
					goto IL_0217;
				}
				string text = "SELECT Id FROM Spedizioni_Batch WHERE ";
				text = text + "ZonaSpedizione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_ZonaSpedizione) + " AND ";
				text = text + "Data = " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DataSpedizione) + " AND ";
				text = text + "Tipo = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Tipo) + " AND ";
				text += "Stato < 30";
				val = ((AppBaseClass)this).DbConn.DoSql(text, "", ref objRes, ref rsmess);
				if ((int)val <= 0)
				{
					if (Operators.CompareString(objRes.ToString(), "", false) != 0)
					{
						_Batch = objRes.ToString();
					}
					goto IL_0217;
				}
				val2 = val;
			}
			goto end_IL_000b;
			IL_0217:
			((AppAbstractApi)this).ParametersOut["Batch"] = _Batch;
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
