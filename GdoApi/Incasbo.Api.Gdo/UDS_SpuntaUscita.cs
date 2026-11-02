using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class UDS_SpuntaUscita : GdoAbstractApi
{
	protected string _Unibol;

	protected string _Codice;

	protected DateTime? _DataSpunta;

	protected string _UtenteSpunta;

	protected UDS _UDS;

	protected bool _ApplyQuery;

	public UDS_SpuntaUscita(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_Codice = "";
		_UtenteSpunta = "";
		_UDS = null;
		_ApplyQuery = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Invalid comparison between Unknown and I4
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
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
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("UtenteSpunta"))
			{
				_UtenteSpunta = ((AppAbstractApi)this).ParametersIn["UtenteSpunta"].ToString();
			}
			else
			{
				_UtenteSpunta = this._User;
			}
			if (this.ParametersIn.ContainsKey("DataSpunta") && this._ParametersIn["DataSpunta"] != null)
			{
				_DataSpunta = Conversions.ToDate(this._ParametersIn["DataSpunta"].ToString());
			}
			else
			{
				_DataSpunta = DateAndTime.Now;
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
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Invalid comparison between Unknown and I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "";
			text = "UPDATE SPEDIZIONIUDS SET SpuntaDataUscita = " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, _DataSpunta) + ", ";
			text = text + "SpuntaOperatoreUscita = " + ((AppBaseClass)this).DbConn.SQLFormatString(_UtenteSpunta) + " ";
			text = text + "WHERE CODICE = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Codice) + " ";
			text = text + "AND UNIBOL = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + ";";
			if (!_ApplyQuery || Operators.CompareString(text, "", false) == 0)
			{
				goto IL_00e3;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_00e3;
			}
			val2 = val;
			goto end_IL_0005;
			IL_00e3:
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
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "";
			text = "SELECT * FROM SPEDIZIONIUDS WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Codice) + " ";
			text = text + "AND UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			DataTable rObjDataTable = null;
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (rObjDataTable.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Uds {0} della spedizione {1} non presente a sistema", new string[2] { _Codice, _Unibol });
			}
			else
			{
				_UDS = new UDS();
				UDS uDS = _UDS;
				uDS.Id = Conversions.ToInteger(rObjDataTable.Rows[0]["Id"].ToString());
				uDS.Codice = _Codice;
				uDS.Unibol = _Unibol;
				uDS.TipoUds = rObjDataTable.Rows[0]["TipoUds"].ToString();
				uDS.Descrizione = rObjDataTable.Rows[0]["Descrizione"].ToString();
				uDS.SpuntaDataUscita = _DataSpunta;
				uDS.SpuntaOperatoreUscita = _UtenteSpunta;
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
