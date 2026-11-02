using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class UDS_SpuntaUscitaAnnulla : GdoAbstractApi
{
	protected string _Unibol;

	protected string _Codice;

	protected string _IdViaggio;

	protected UDS _UDS;

	protected bool _ApplyQuery;

	public UDS_SpuntaUscitaAnnulla(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_Codice = "";
		_IdViaggio = "";
		_UDS = null;
		_ApplyQuery = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Invalid comparison between Unknown and I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
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
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ApplyQuery"))
			{
				_ApplyQuery = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ApplyQuery"]);
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("IDVIAGGIO"))
			{
				_IdViaggio = this._ParametersIn["IDVIAGGIO"].ToString();
			}
			this._ParametersOut.Add("RetQueryToApply", "");
			this._ParametersOut.Add("UDS", _UDS);
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
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Invalid comparison between Unknown and I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "";
			text = "UPDATE SPEDIZIONIUDS SET SpuntaDataUscita = NULL, SpuntaOperatoreUscita = NULL WHERE ";
			text = ((Operators.CompareString(_IdViaggio, "", false) == 0) ? (text + "CODICE = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Codice) + " AND UNIBOL = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + ";") : (text + "UNIBOL IN (SELECT UNIBOl FROM SPEDIZIONI WHERE IDVIAGGIO=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ");"));
			if (!_ApplyQuery || Operators.CompareString(text, "", false) == 0)
			{
				goto IL_00f2;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_00f2;
			}
			val2 = val;
			goto end_IL_0005;
			IL_00f2:
			((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = text;
			((AppAbstractApi)this).ParametersOut["UDS"] = _UDS;
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
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "";
			text = "SELECT * FROM SPEDIZIONIUDS WHERE ";
			if (Operators.CompareString(_IdViaggio, "", false) != 0)
			{
				text = text + "UNIBOL IN (SELECT UNIBOl FROM SPEDIZIONI WHERE IDVIAGGIO=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + ")";
			}
			else
			{
				text = text + "CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Codice) + " ";
				text = text + "AND UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			}
			DataTable rObjDataTable = null;
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (rObjDataTable.Rows.Count != 0)
				{
					if (Operators.CompareString(_IdViaggio, "", false) == 0)
					{
						_UDS = new UDS();
						UDS uDS = _UDS;
						uDS.Id = Conversions.ToInteger(rObjDataTable.Rows[0]["Id"].ToString());
						uDS.Codice = _Codice;
						uDS.Unibol = _Unibol;
						uDS.TipoUds = rObjDataTable.Rows[0]["TipoUds"].ToString();
						uDS.Descrizione = rObjDataTable.Rows[0]["Descrizione"].ToString();
						uDS.SpuntaDataUscita = null;
						uDS.SpuntaOperatoreUscita = "";
						if (Information.IsDate((object)rObjDataTable.Rows[0]["SpuntaDataIngresso"].ToString()))
						{
							uDS.SpuntaDataIngresso = Conversions.ToDate(rObjDataTable.Rows[0]["SpuntaDataIngresso"].ToString());
						}
						uDS.SpuntaOperatoreIngresso = rObjDataTable.Rows[0]["SpuntaOperatoreIngresso"].ToString();
						uDS.PesoLordo = Conversions.ToDecimal(rObjDataTable.Rows[0]["PesoLordo"].ToString());
						uDS.Colli = Conversions.ToInteger(rObjDataTable.Rows[0]["Colli"].ToString());
						uDS.Pallet = Conversions.ToInteger(rObjDataTable.Rows[0]["Pallet"].ToString());
						uDS.Volume = Conversions.ToDecimal(rObjDataTable.Rows[0]["Volume"].ToString());
						uDS.PalletVolumetrici = Conversions.ToDecimal(rObjDataTable.Rows[0]["PalletVolumetrici"].ToString());
						uDS.ValoreMerce = Conversions.ToDecimal(rObjDataTable.Rows[0]["ValoreMerce"].ToString());
						uDS.CampoCalcolo1 = Conversions.ToDecimal(rObjDataTable.Rows[0]["CampoCalcolo1"].ToString());
						uDS.CampoCalcolo2 = Conversions.ToDecimal(rObjDataTable.Rows[0]["CampoCalcolo2"].ToString());
						uDS.CampoCalcolo3 = Conversions.ToDecimal(rObjDataTable.Rows[0]["CampoCalcolo3"].ToString());
						uDS.CampoCalcolo4 = Conversions.ToDecimal(rObjDataTable.Rows[0]["CampoCalcolo4"].ToString());
						uDS.CampoCalcolo5 = Conversions.ToDecimal(rObjDataTable.Rows[0]["CampoCalcolo5"].ToString());
						uDS.CampoCalcolo6 = Conversions.ToDecimal(rObjDataTable.Rows[0]["CampoCalcolo6"].ToString());
						uDS.CampoCalcolo7 = Conversions.ToDecimal(rObjDataTable.Rows[0]["CampoCalcolo7"].ToString());
						uDS.CampoCalcolo8 = Conversions.ToDecimal(rObjDataTable.Rows[0]["CampoCalcolo8"].ToString());
						uDS.CampoCalcolo9 = Conversions.ToDecimal(rObjDataTable.Rows[0]["CampoCalcolo9"].ToString());
						uDS.CampoCalcolo10 = Conversions.ToDecimal(rObjDataTable.Rows[0]["CampoCalcolo10"].ToString());
						uDS.Altezza = Conversions.ToDecimal(rObjDataTable.Rows[0]["Altezza"].ToString());
						uDS.Larghezza = Conversions.ToDecimal(rObjDataTable.Rows[0]["Larghezza"].ToString());
						uDS.Profondita = Conversions.ToDecimal(rObjDataTable.Rows[0]["Profondita"].ToString());
						if (Information.IsDate((object)rObjDataTable.Rows[0]["InConsegna"].ToString()))
						{
							uDS.InConsegna = Conversions.ToDate(rObjDataTable.Rows[0]["InConsegna"].ToString());
						}
						uDS.UdsMaster = rObjDataTable.Rows[0]["UdsMaster"].ToString();
						uDS.Filler1 = rObjDataTable.Rows[0]["Filler1"].ToString();
						uDS.Filler2 = rObjDataTable.Rows[0]["Filler2"].ToString();
						uDS.Filler3 = rObjDataTable.Rows[0]["Filler3"].ToString();
						uDS.Filler4 = rObjDataTable.Rows[0]["Filler4"].ToString();
						uDS.Filler5 = rObjDataTable.Rows[0]["Filler5"].ToString();
						uDS.Filler6 = rObjDataTable.Rows[0]["Filler6"].ToString();
						uDS.Filler7 = rObjDataTable.Rows[0]["Filler7"].ToString();
						uDS.Filler8 = rObjDataTable.Rows[0]["Filler8"].ToString();
						uDS.Filler9 = rObjDataTable.Rows[0]["Filler9"].ToString();
						uDS.Filler10 = rObjDataTable.Rows[0]["Filler10"].ToString();
						uDS.UteIns = rObjDataTable.Rows[0]["UteIns"].ToString();
						uDS.UteAgg = rObjDataTable.Rows[0]["UteAgg"].ToString();
						uDS.DatIns = Conversions.ToDate(rObjDataTable.Rows[0]["DatIns"].ToString());
						uDS.DatAgg = Conversions.ToDate(rObjDataTable.Rows[0]["DatAgg"].ToString());
						uDS = null;
					}
					goto IL_0881;
				}
				if (Operators.CompareString(_IdViaggio, "", false) != 0)
				{
					goto IL_0881;
				}
				rsmess = this.TranslateMessage("XXX", "Uds {0} della spedizione {1} non presente a sistema", new string[2] { _Codice, _Unibol });
			}
			goto end_IL_0005;
			IL_0881:
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
}
