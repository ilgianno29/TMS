using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Viaggio_Certifica : GdoAbstractApi
{
	protected string _IdViaggio;

	protected DataTable _dtViaggio;

	protected DataTable _dtSpedizioni;

	protected DateTime? _Data;

	protected bool _ApplyQuery;

	protected int _StatoViaggio;

	protected int _StatoSpedizioni;

	public Viaggio_Certifica(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_dtViaggio = null;
		_dtSpedizioni = null;
		_ApplyQuery = true;
		_StatoViaggio = 40;
		_StatoSpedizioni = 50;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Invalid comparison between Unknown and I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Invalid comparison between Unknown and I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
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
			_IdViaggio = ((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString();
			_Data = (DateTime?)((AppAbstractApi)this).ParametersIn["Data"];
			if (!_Data.HasValue)
			{
				_Data = DateAndTime.Now;
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("StatoViaggio"))
			{
				_StatoViaggio = 0 - (((AppAbstractApi)this).ParametersIn.ContainsKey("StatoViaggio") ? 1 : 0);
			}
			if (_StatoViaggio < 40)
			{
				_StatoViaggio = 40;
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("StatoSpedizioni"))
			{
				_StatoSpedizioni = 0 - (((AppAbstractApi)this).ParametersIn.ContainsKey("StatoSpedizioni") ? 1 : 0);
			}
			if (_StatoViaggio < 48)
			{
				_StatoSpedizioni = 48;
			}
			val = CheckViaggio(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CheckSpedizioni(ref rsmess);
				val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Invalid comparison between Unknown and I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Invalid comparison between Unknown and I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Invalid comparison between Unknown and I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Invalid comparison between Unknown and I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Invalid comparison between Unknown and I4
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string RetQueryToApply = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "UPDATE VIAGGI SET Stato=50 ";
			text = text + "WHERE IDVIAGGIO = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ";";
			val = EventoViaggio_CertificaViaggio.RunProc(this._ApiContext, _IdViaggio, _Data, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text += RetQueryToApply;
				foreach (DataRow row in _dtSpedizioni.Rows)
				{
					if (Conversions.ToInteger(row["Stato"]) != 50)
					{
						continue;
					}
					RetQueryToApply = "";
					val = Spedizione_Certifica_Invoker.Instance.RunProc(this._ApiContext, row["Unibol"].ToString(), _Data, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
					if ((int)val <= 0)
					{
						text += RetQueryToApply;
						continue;
					}
					val2 = val;
					goto end_IL_0012;
				}
				RetQueryToApply = "";
				val = Viaggio_RipartisciCosti_Invoker.Instance.RunProc(this._ApiContext, _IdViaggio, "", ApplyQuery: false, ref RetQueryToApply, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					text += RetQueryToApply;
					RetQueryToApply = "";
					val = Viaggio_RipartisciRicavi_Invoker.Instance.RunProc(this._ApiContext, _IdViaggio, "", ApplyQuery: false, ref RetQueryToApply, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						text += RetQueryToApply;
						if (!_ApplyQuery || Operators.CompareString(text, "", false) == 0)
						{
							goto IL_01fc;
						}
						val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
						if ((int)val <= 0)
						{
							goto IL_01fc;
						}
						val2 = val;
					}
				}
			}
			goto end_IL_0012;
			IL_01fc:
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

	protected virtual FXRETURN CheckViaggio(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT * FROM Viaggi WHERE IDViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtViaggio, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtViaggio.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id {0} non esiste", new string[1] { _IdViaggio });
			}
			else if (Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]) < 40)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id {0} non risulta terminato", new string[1] { _IdViaggio });
			}
			else if (Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]) != _StatoViaggio)
			{
				rsmess = this.TranslateMessage("XXX", "Il viaggio con Id {0} non risulta in uno stato ideo per essere certificato", new string[1] { _IdViaggio });
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

	protected virtual FXRETURN CheckSpedizioni(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT * FROM Spedizioni WHERE Stato < 90 AND IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizioni, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				foreach (DataRow row in _dtSpedizioni.Rows)
				{
					if (Conversions.ToInteger(row["Stato"]) >= _StatoSpedizioni)
					{
						continue;
					}
					rsmess = this.TranslateMessage("XXX", "Impossibile certificare il viaggio {0} in quanto la spedizione {1} non risulta nè esitata nè arrivata a TP", new string[2]
					{
						_IdViaggio,
						row["Unibol"].ToString()
					});
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
