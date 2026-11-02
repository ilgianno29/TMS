using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Contrassegno_SincronizzaConSpedizione : ContrassegniAbstractApi
{
	protected int _IdContrassegno;

	protected DataTable _dtContrassegno;

	protected DataTable _dtSpedizione;

	protected bool _ApplyQuery;

	public Contrassegno_SincronizzaConSpedizione(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_dtContrassegno = null;
		_dtSpedizione = null;
		_ApplyQuery = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
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
				val = CheckSpedizione(ref rsmess);
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
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Invalid comparison between Unknown and I4
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string vsStringa = "";
			string text2 = "";
			string text3 = "";
			if (Operators.CompareString(_dtSpedizione.Rows[0]["Corrispondente"].ToString(), "", false) != 0)
			{
				vsStringa = _dtSpedizione.Rows[0]["Corrispondente"].ToString();
				text2 = _dtSpedizione.Rows[0]["Trasportatore"].ToString();
				text3 = _dtSpedizione.Rows[0]["TrasportatoreFatturazione"].ToString();
			}
			else
			{
				text2 = _dtSpedizione.Rows[0]["VettoreCodice"].ToString();
				text3 = _dtSpedizione.Rows[0]["VettoreFatturazione"].ToString();
			}
			text = "UPDATE Contrassegni SET ";
			text = text + "Corrispondente=" + ((AppBaseClass)this).DbConn.SQLFormatString(vsStringa) + ", ";
			text = text + "Trasportatore=" + ((AppBaseClass)this).DbConn.SQLFormatString(text2) + ", ";
			text = text + "TrasportatoreFatturazione=" + ((AppBaseClass)this).DbConn.SQLFormatString(text3) + ", ";
			text = text + "DatAgg=" + ((AppBaseClass)this).DbConn.GetDate() + ", ";
			text = text + "UteAgg=" + this.DbConn.SQLFormatString(this._User) + " ";
			text = text + "WHERE Id = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _IdContrassegno) + "; ";
			((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = text;
			if (!_ApplyQuery)
			{
				goto IL_020e;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_020e;
			}
			val2 = val;
			goto end_IL_000b;
			IL_020e:
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
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
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
			else if (Conversions.ToInteger(_dtContrassegno.Rows[0]["Stato"]) != 10)
			{
				rsmess = this.TranslateMessage("XXX", "Il contrassegno con Id {0} risulta già esitata", new string[1] { _IdContrassegno.ToString() });
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

	protected virtual FXRETURN CheckSpedizione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT S.*, T.FatturaA TrasportatoreFatturazione, V.Vettore VettoreCodice, T2.FatturaA VettoreFatturazione ";
			text += "FROM Spedizioni S ";
			text += "LEFT JOIN Trasportatori T ON T.Codice=S.Trasportatore ";
			text += "LEFT JOIN Viaggi V ON V.IdViaggio=S.IdViaggio ";
			text += "LEFT JOIN Trasportatori T2 ON T2.Codice=V.Vettore ";
			text = text + "WHERE S.Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(_dtContrassegno.Rows[0]["UnibolMaster"].ToString());
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizione, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtSpedizione.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non esiste", new string[1] { _dtContrassegno.Rows[0]["UnibolMaster"].ToString() });
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
