using System;
using System.Collections.Generic;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class UDS_ElencoSpuntaUscita : GdoAbstractApi
{
	protected string _Unibol;

	protected string _Codice;

	protected string _UdsMaster;

	protected string _IdViaggio;

	protected string _IdViaggioLinea;

	protected DateTime? _DataSpunta;

	protected string _UtenteSpunta;

	protected List<UDS> _ListofUDS;

	protected bool _AssociaViaggio;

	protected DataTable _ElencoUds;

	public UDS_ElencoSpuntaUscita(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_Codice = "";
		_UdsMaster = "";
		_IdViaggio = "";
		_IdViaggioLinea = "";
		_UtenteSpunta = "";
		_ListofUDS = null;
		_AssociaViaggio = false;
		_ElencoUds = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Invalid comparison between Unknown and I4
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Codice = this._ParametersIn["CODICE"].ToString();
			_Unibol = this._ParametersIn["UNIBOL"].ToString();
			_UdsMaster = this._ParametersIn["UdsMaster"].ToString();
			_IdViaggio = this._ParametersIn["IdViaggio"].ToString();
			_IdViaggioLinea = this._ParametersIn["IdViaggioLinea"].ToString();
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("UtenteSpunta"))
			{
				_UtenteSpunta = ((AppAbstractApi)this).ParametersIn["UtenteSpunta"].ToString();
			}
			else
			{
				_UtenteSpunta = this._User;
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("DataSpunta"))
			{
				if (Information.IsDate((object)this._ParametersIn["DataSpunta"].ToString()))
				{
					_DataSpunta = Conversions.ToDate(this._ParametersIn["DataSpunta"].ToString());
				}
				else
				{
					_DataSpunta = DateAndTime.Now;
				}
			}
			else
			{
				_DataSpunta = DateAndTime.Now;
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("AssociaViaggio"))
			{
				_AssociaViaggio = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["AssociaViaggio"]);
			}
			this._ParametersOut.Add("ListofUDS", _ListofUDS);
			val = CheckUds(ref rsmess);
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
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Invalid comparison between Unknown and I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "";
			_ListofUDS = new List<UDS>();
			foreach (DataRow row in _ElencoUds.Rows)
			{
				UDS UDS = null;
				string RetQueryToApply = "";
				val = UDS_SpuntaUscita_Invoker.Instance.RunProc(this._ApiContext, row["Codice"].ToString(), row["Unibol"].ToString(), _UtenteSpunta, _DataSpunta, ApplyQuery: false, ref RetQueryToApply, ref UDS, ref rsmess);
				if ((int)val <= 0)
				{
					text += RetQueryToApply;
					_ListofUDS.Add(UDS);
					continue;
				}
				val2 = val;
				goto end_IL_0005;
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				goto IL_011f;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_011f;
			}
			val2 = val;
			goto end_IL_0005;
			IL_011f:
			((AppAbstractApi)this).ParametersOut["ListofUDS"] = _ListofUDS;
			val2 = (FXRETURN)0;
			end_IL_0005:;
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

	protected FXRETURN CheckUds(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Invalid comparison between Unknown and I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "";
			text = "SELECT U.CODICE,U.UNIBOL FROM SPEDIZIONIUDS U INNER JOIN SPEDIZIONI S ON S.UNIBOL = U.UNIBOL WHERE 1=1 ";
			if (Operators.CompareString(_Codice, "", false) != 0)
			{
				text = text + "AND U.CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Codice) + " ";
			}
			if (Operators.CompareString(_Unibol, "", false) != 0)
			{
				text = text + "AND U.UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " ";
			}
			if (Operators.CompareString(_UdsMaster, "", false) != 0)
			{
				text = text + "AND U.UDSMASTER=" + ((AppBaseClass)this).DbConn.SQLFormatString(_UdsMaster) + " ";
			}
			if ((Operators.CompareString(_IdViaggio, "", false) != 0) & !_AssociaViaggio)
			{
				text = text + "AND S.IDVIAGGIO=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
			}
			if (Operators.CompareString(_IdViaggioLinea, "", false) != 0)
			{
				text = text + "AND S.IDVIAGGIOLINEA=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggioLinea) + " ";
			}
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _ElencoUds, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_ElencoUds.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Nessuna UDS trovata");
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
