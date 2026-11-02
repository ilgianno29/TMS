using System;
using System.Collections.Generic;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class UDS_ElencoSpuntaUscitaAnnulla : GdoAbstractApi
{
	protected string _Unibol;

	protected string _Codice;

	protected string _UdsMaster;

	protected string _IdViaggio;

	protected string _IdViaggioLinea;

	protected List<UDS> _ListofUDS;

	protected DataTable _ElencoUds;

	public UDS_ElencoSpuntaUscitaAnnulla(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_Codice = "";
		_UdsMaster = "";
		_IdViaggio = "";
		_IdViaggioLinea = "";
		_ListofUDS = null;
		_ElencoUds = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Invalid comparison between Unknown and I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Invalid comparison between Unknown and I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Invalid comparison between Unknown and I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
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
				val = UDS_SpuntaUscitaAnnulla_Invoker.Instance.RunProc(this._ApiContext, row["Codice"].ToString(), row["Unibol"].ToString(), "", ApplyQuery: false, ref RetQueryToApply, ref UDS, ref rsmess);
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
				goto IL_0118;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_0118;
			}
			val2 = val;
			goto end_IL_0005;
			IL_0118:
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
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Invalid comparison between Unknown and I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
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
				text = text + "AND CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Codice) + " ";
			}
			if (Operators.CompareString(_Unibol, "", false) != 0)
			{
				text = text + "AND U.UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " ";
			}
			if (Operators.CompareString(_UdsMaster, "", false) != 0)
			{
				text = text + "AND U.UdsMaster=" + ((AppBaseClass)this).DbConn.SQLFormatString(_UdsMaster) + " ";
			}
			if (Operators.CompareString(_IdViaggio, "", false) != 0)
			{
				text = text + "AND IDVIAGGIO=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
			}
			if (Operators.CompareString(_IdViaggioLinea, "", false) != 0)
			{
				text = text + "AND IDVIAGGIOLINEA=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggioLinea) + " ";
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
