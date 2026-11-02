using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Contrassegno_AnnullaEsito : ContrassegniAbstractApi
{
	protected int _IdContrassegno;

	protected DataTable _dtSpedizioni;

	protected DataTable _dtContrassegno;

	protected DataTable _dtEvento;

	protected bool _ApplyQuery;

	public Contrassegno_AnnullaEsito(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_dtSpedizioni = null;
		_dtContrassegno = null;
		_dtEvento = null;
		_ApplyQuery = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdContrassegno = Conversions.ToInteger(((AppAbstractApi)this).ParametersIn["IdContrassegno"]);
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
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Invalid comparison between Unknown and I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "UPDATE Contrassegni SET CausaleEsito=NULL, ";
			text += "DataEsito=NULL, ";
			text += "NoteEsito=NULL, ";
			text += "Stato=10, ";
			text += "DataIncasso=NULL, ";
			text += "TipoIncasso=NULL, ";
			text += "NoteIncasso=NULL, ";
			text = text + "DatAgg=" + ((AppBaseClass)this).DbConn.GetDate() + ", ";
			text = text + "UteAgg=" + this.DbConn.SQLFormatString(this._User) + " ";
			text = text + "WHERE Id = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdContrassegno) + "; ";
			((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = text;
			if (!_ApplyQuery)
			{
				goto IL_0104;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_0104;
			}
			val2 = val;
			goto end_IL_000b;
			IL_0104:
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
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
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
			else if (Conversions.ToInteger(_dtContrassegno.Rows[0]["Stato"]) == 40)
			{
				rsmess = this.TranslateMessage("XXX", "Il contrassegno con Id {0} risulta già rimesso al cliente. Impossibile annullare l'esito.", new string[1] { _IdContrassegno.ToString() });
			}
			else if (Conversions.ToInteger(_dtContrassegno.Rows[0]["Stato"]) == 10)
			{
				rsmess = this.TranslateMessage("XXX", "Il contrassegno con Id {0} non risulta ancora esitato", new string[1] { _IdContrassegno.ToString() });
			}
			else if ((Operators.CompareString(_dtContrassegno.Rows[0]["IdFatturaAttiva"].ToString(), "", false) != 0) | (Operators.CompareString(_dtContrassegno.Rows[0]["IdFatturaPassiva"].ToString(), "", false) != 0))
			{
				rsmess = this.TranslateMessage("XXX", "Il contrassegno con Id {0} risulta già fatturato", new string[1] { _IdContrassegno.ToString() });
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
