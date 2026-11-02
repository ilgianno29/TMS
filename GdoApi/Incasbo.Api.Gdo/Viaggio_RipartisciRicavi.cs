using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Viaggio_RipartisciRicavi : GdoAbstractApi
{
	protected string _IdViaggio;

	protected DataTable _dtViaggio;

	protected DataTable _dtSpedizioni;

	protected bool _ApplyQuery;

	protected string _CampoDiRipartizione;

	protected decimal _SumOfCampoDiRipartizione;

	protected int _StatoMinimo;

	public Viaggio_RipartisciRicavi(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggio = "";
		_dtViaggio = null;
		_dtSpedizioni = null;
		_ApplyQuery = true;
		_CampoDiRipartizione = "1";
		_SumOfCampoDiRipartizione = default(decimal);
		_StatoMinimo = 20;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Invalid comparison between Unknown and I4
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Invalid comparison between Unknown and I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
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
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("CampoDiRipartizione"))
			{
				_CampoDiRipartizione = ((AppAbstractApi)this).ParametersIn["CampoDiRipartizione"].ToString();
			}
			if (Operators.CompareString(_CampoDiRipartizione, "", false) == 0)
			{
				string text2 = base.ApplicationParams.CampoRipartizioneRicaviViaggio();
				if (Operators.CompareString(text2, "", false) != 0)
				{
					_CampoDiRipartizione = text2;
				}
			}
			if (Operators.CompareString(_CampoDiRipartizione, "", false) == 0)
			{
				_CampoDiRipartizione = "1";
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
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Invalid comparison between Unknown and I4
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		decimal d = default(decimal);
		decimal d2 = default(decimal);
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (!((Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]) >= _StatoMinimo) & (Conversions.ToInteger(_dtViaggio.Rows[0]["Stato"]) < 90)))
			{
				goto IL_032d;
			}
			text = "SELECT SUM(ImportoArrotondato) AS Somma, SUM(CASE WHEN V.FlagNolo='S' THEN ImportoArrotondato ELSE 0 END) AS SommaNolo ";
			text += "FROM Viaggi_Ricavi VR INNER JOIN Voci V ON V.Codice = VR.Voce ";
			text += "WHERE RecordZZ='N' ";
			text = text + "AND IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " ";
			DataTable rObjDataTable = null;
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (rObjDataTable.Rows.Count > 0)
				{
					try
					{
						d = Conversions.ToDecimal(rObjDataTable.Rows[0]["Somma"]);
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					try
					{
						d2 = Conversions.ToDecimal(rObjDataTable.Rows[0]["SommaNolo"]);
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
				}
				text = "";
				text += "UPDATE Spedizioni SET RicavoViaggioRipartito=0, RicavoViaggioRipartitoNolo=0 ";
				text = text + "WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + "; ";
				if ((decimal.Compare(d, 0m) != 0) | (decimal.Compare(d2, 0m) != 0))
				{
					foreach (DataRow row in _dtSpedizioni.Rows)
					{
						decimal pNumero = default(decimal);
						decimal pNumero2 = default(decimal);
						decimal d3 = Conversions.ToDecimal(row["My_CampoDiRipartizione"]);
						if (decimal.Compare(_SumOfCampoDiRipartizione, 0m) > 0)
						{
							pNumero = decimal.Multiply(d, decimal.Divide(d3, _SumOfCampoDiRipartizione));
							pNumero2 = decimal.Multiply(d2, decimal.Divide(d3, _SumOfCampoDiRipartizione));
						}
						text = text + "UPDATE Spedizioni SET RicavoViaggioRipartito=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero) + ", ";
						text = text + "RicavoViaggioRipartitoNolo=" + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref pNumero2) + " ";
						text = text + "WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(row["Unibol"].ToString()) + ";";
					}
				}
				if (!_ApplyQuery || Operators.CompareString(text, "", false) == 0)
				{
					goto IL_032d;
				}
				val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
				if ((int)val <= 0)
				{
					goto IL_032d;
				}
				val2 = val;
			}
			goto end_IL_0022;
			IL_032d:
			((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = text;
			val2 = (FXRETURN)0;
			end_IL_0022:;
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			val2 = this.HandleError(ref ex6, ref rsmess);
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
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
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
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT S.*, " + _CampoDiRipartizione + " AS My_CampoDiRipartizione FROM Spedizioni S WHERE Stato < 90 AND IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizioni, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				foreach (DataRow row in _dtSpedizioni.Rows)
				{
					ref decimal sumOfCampoDiRipartizione = ref _SumOfCampoDiRipartizione;
					sumOfCampoDiRipartizione = decimal.Add(sumOfCampoDiRipartizione, Conversions.ToDecimal(row["My_CampoDiRipartizione"]));
				}
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
