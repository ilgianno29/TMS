using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Contrassegno_Incasso : ContrassegniAbstractApi
{
	protected int _IdContrassegno;

	protected DateTime? _dataIncasso;

	protected bool _ApplyQuery;

	protected DataTable _dtContrassegno;

	public Contrassegno_Incasso(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_ApplyQuery = true;
		_dtContrassegno = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Invalid comparison between Unknown and I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdContrassegno = Conversions.ToInteger(((AppAbstractApi)this).ParametersIn["IdContrassegno"]);
			_dataIncasso = (DateTime?)((AppAbstractApi)this).ParametersIn["DataIncasso"];
			if (!_dataIncasso.HasValue)
			{
				_dataIncasso = DateAndTime.Now.Date;
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ApplyQuery"))
			{
				_ApplyQuery = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ApplyQuery"]);
			}
			val = CheckContrassegno(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				((AppAbstractApi)this).ParametersOut.Add("RetQueryToApply", "");
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Invalid comparison between Unknown and I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "UPDATE Contrassegni SET Stato=30, ";
			text = text + "DataIncasso=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _dataIncasso) + ", ";
			text = text + "DataCompetenzaAttiva=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _dataIncasso) + ", ";
			text = text + "DataCompetenzaPassiva=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _dataIncasso) + ", ";
			text = text + "DatAgg=" + ((AppBaseClass)this).DbConn.GetDate() + ", ";
			text = text + "UteAgg=" + this.DbConn.SQLFormatString(this._User) + " ";
			text = text + "WHERE Id = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdContrassegno) + "; ";
			((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = text;
			if (!_ApplyQuery)
			{
				goto IL_0125;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_0125;
			}
			val2 = val;
			goto end_IL_000b;
			IL_0125:
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

	protected virtual FXRETURN CheckContrassegno(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "SELECT * FROM Contrassegni ";
			text = text + "WHERE Id = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdContrassegno) + " ";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtContrassegno, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtContrassegno.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La pratica di contrassegno con Id {0} non esiste", new string[1] { _IdContrassegno.ToString() });
			}
			else if (Conversions.ToInteger(_dtContrassegno.Rows[0]["Stato"]) == 10)
			{
				rsmess = this.TranslateMessage("XXX", "Il contrassegno con Id {0} non risulta esitato", new string[1] { _IdContrassegno.ToString() });
			}
			else if (Conversions.ToInteger(_dtContrassegno.Rows[0]["Stato"]) == 99)
			{
				rsmess = this.TranslateMessage("XXX", "Il contrassegno con Id {0} risulta annullato e non incassato", new string[1] { _IdContrassegno.ToString() });
			}
			else if (Conversions.ToInteger(_dtContrassegno.Rows[0]["Stato"]) > 20)
			{
				rsmess = this.TranslateMessage("XXX", "Il contrassegno con Id {0} risulta già incassato", new string[1] { _IdContrassegno.ToString() });
			}
			else
			{
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
}
