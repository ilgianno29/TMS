using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_Certifica : GdoAbstractApi
{
	protected string _Unibol;

	protected DataTable _dtSpedizioni;

	protected DateTime? _Data;

	protected bool _ApplyQuery;

	public Spedizione_Certifica(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_dtSpedizioni = null;
		_ApplyQuery = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Invalid comparison between Unknown and I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			((AppAbstractApi)this).ParametersOut.Add("RetQueryToApply", "");
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ApplyQuery"))
			{
				_ApplyQuery = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ApplyQuery"]);
			}
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			_Data = (DateTime?)((AppAbstractApi)this).ParametersIn["Data"];
			if (!_Data.HasValue)
			{
				_Data = DateAndTime.Now;
			}
			val = CheckSpedizione(ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Invalid comparison between Unknown and I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Invalid comparison between Unknown and I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text2 = "";
			text2 = "UPDATE Spedizioni SET Stato=60 ";
			text2 = text2 + "WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + ";";
			text += text2;
			text2 = "";
			val = EventoSpedizione_Certifica.RunProc(this._ApiContext, _Unibol, _Data, ApplyQuery: false, ref text2, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text += text2;
				if (!_ApplyQuery || Operators.CompareString(text, "", false) == 0)
				{
					goto IL_00db;
				}
				val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
				if ((int)val <= 0)
				{
					goto IL_00db;
				}
				val2 = val;
			}
			goto end_IL_0012;
			IL_00db:
			((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = text;
			val2 = (FXRETURN)0;
			end_IL_0012:;
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

	protected virtual FXRETURN CheckSpedizione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT Stato, Unibol FROM Spedizioni WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizioni, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				foreach (DataRow row in _dtSpedizioni.Rows)
				{
					if (Conversions.ToInteger(row["Stato"]) < 50)
					{
						rsmess = this.TranslateMessage("XXX", "Impossibile certificare la spedizione {0} in quanto non risulta esitata", new string[1] { _Unibol });
					}
					else
					{
						if (Conversions.ToInteger(row["Stato"]) <= 50)
						{
							continue;
						}
						rsmess = this.TranslateMessage("XXX", "Impossibile certificare la spedizione {0} in quanto risulta già certificata", new string[1] { _Unibol });
					}
					goto end_IL_000b;
				}
				val2 = (FXRETURN)0;
			}
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
