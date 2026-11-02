using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

internal class GMB_AggiornaMovimentazioneBancaliPerData : GdoAbstractApi
{
	protected GMB_Movimento _GMB_Movimento;

	public GMB_AggiornaMovimentazioneBancaliPerData(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_GMB_Movimento = new GMB_Movimento();
	}

	public static FXRETURN RunProc(AppApiContext objApiContext, GMB_Movimento GMB_Movimento, ref string QueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			GMB_AggiornaMovimentazioneBancaliPerData gMB_AggiornaMovimentazioneBancaliPerData = new GMB_AggiornaMovimentazioneBancaliPerData(objApiContext);
			((AppAbstractApi)gMB_AggiornaMovimentazioneBancaliPerData).ParametersIn.Add("GMB_Movimento", GMB_Movimento);
			val = ((AppAbstractApi)gMB_AggiornaMovimentazioneBancaliPerData).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				QueryToApply = ((AppAbstractApi)gMB_AggiornaMovimentazioneBancaliPerData).ParametersOut["QueryToApply"].ToString();
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			rsmess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
		}
		return result;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_GMB_Movimento = (GMB_Movimento)((AppAbstractApi)this).ParametersIn["GMB_Movimento"];
			((AppAbstractApi)this).ParametersOut.Add("QueryToApply", null);
			val2 = (FXRETURN)0;
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
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			bool flag = _GMB_Movimento.TipoSoggetto2 == GMB_TipoSoggetto.NotDefined;
			string text = "";
			text = "INSERT INTO BancaliMovimentazioneData(Data, TipoSoggetto, Soggetto, TipoBancale, Cliente, Quantita, DatIns, DatAgg, UteAgg, UteIns, TipoSoggettoControparte, SoggettoControparte, IdMovimento) VALUES (";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _GMB_Movimento.Data) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(ConvertTipoSoggettoToString(_GMB_Movimento.TipoSoggetto1)) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_GMB_Movimento.Soggetto1) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_GMB_Movimento.TipoBancale) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_GMB_Movimento.Cliente) + ", ";
			if (_GMB_Movimento.Segno1 == GMB_Segno.Plus)
			{
				text += "+";
			}
			else if (_GMB_Movimento.Segno1 == GMB_Segno.Minus)
			{
				text += "-";
			}
			string text2 = text;
			DBConnection dbConn = ((AppBaseClass)this).DbConn;
			GMB_Movimento gMB_Movimento;
			int pNumero = (gMB_Movimento = _GMB_Movimento).Quantita;
			string text3 = dbConn.SQLFormatNumber(ref pNumero);
			gMB_Movimento.Quantita = pNumero;
			text = text2 + text3 + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, DateAndTime.Now) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, DateAndTime.Now) + ", ";
			text = text + this.DbConn.SQLFormatString(this._User) + ", ";
			text = text + this.DbConn.SQLFormatString(this._User) + ", ";
			text = text + (flag ? "NULL" : ((AppBaseClass)this).DbConn.SQLFormatString(ConvertTipoSoggettoToString(_GMB_Movimento.TipoSoggetto2))) + ", ";
			text = text + (flag ? "NULL" : ((AppBaseClass)this).DbConn.SQLFormatString(_GMB_Movimento.Soggetto2)) + ", ";
			string text4 = text;
			DBConnection dbConn2 = ((AppBaseClass)this).DbConn;
			string pNumero2 = (gMB_Movimento = _GMB_Movimento).Id;
			string text5 = dbConn2.SQLFormatNumber(ref pNumero2);
			gMB_Movimento.Id = pNumero2;
			text = text4 + text5 + "); ";
			if (!flag)
			{
				text += "INSERT INTO BancaliMovimentazioneData(Data, TipoSoggetto, Soggetto, TipoBancale, Cliente, Quantita, DatIns, DatAgg, UteAgg, UteIns, TipoSoggettoControparte, SoggettoControparte, IdMovimento) VALUES (";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _GMB_Movimento.Data) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(ConvertTipoSoggettoToString(_GMB_Movimento.TipoSoggetto2)) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_GMB_Movimento.Soggetto2) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_GMB_Movimento.TipoBancale) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_GMB_Movimento.Cliente) + ", ";
				if (_GMB_Movimento.Segno2 == GMB_Segno.Plus)
				{
					text += "+";
				}
				else if (_GMB_Movimento.Segno2 == GMB_Segno.Minus)
				{
					text += "-";
				}
				string text6 = text;
				DBConnection dbConn3 = ((AppBaseClass)this).DbConn;
				pNumero = (gMB_Movimento = _GMB_Movimento).Quantita;
				string text7 = dbConn3.SQLFormatNumber(ref pNumero);
				gMB_Movimento.Quantita = pNumero;
				text = text6 + text7 + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, DateAndTime.Now) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, DateAndTime.Now) + ", ";
				text = text + this.DbConn.SQLFormatString(this._User) + ", ";
				text = text + this.DbConn.SQLFormatString(this._User) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(ConvertTipoSoggettoToString(_GMB_Movimento.TipoSoggetto1)) + ", ";
				text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_GMB_Movimento.Soggetto1) + ", ";
				string text8 = text;
				DBConnection dbConn4 = ((AppBaseClass)this).DbConn;
				pNumero2 = (gMB_Movimento = _GMB_Movimento).Id;
				string text9 = dbConn4.SQLFormatNumber(ref pNumero2);
				gMB_Movimento.Id = pNumero2;
				text = text8 + text9 + "); ";
			}
			((AppAbstractApi)this).ParametersOut["QueryToApply"] = text;
			val2 = (FXRETURN)0;
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

	protected string ConvertTipoSoggettoToString(GMB_TipoSoggetto ts)
	{
		string result = "";
		switch (ts)
		{
		case GMB_TipoSoggetto.Cliente:
			result = "C";
			break;
		case GMB_TipoSoggetto.Corrispondente:
			result = "H";
			break;
		case GMB_TipoSoggetto.Destinatario:
			result = "D";
			break;
		case GMB_TipoSoggetto.Filiale:
			result = "F";
			break;
		case GMB_TipoSoggetto.Vettore:
			result = "V";
			break;
		}
		return result;
	}

	protected string ConvertSegnoToString(GMB_Segno ts)
	{
		string result = "";
		switch (ts)
		{
		case GMB_Segno.Minus:
			result = "-";
			break;
		case GMB_Segno.Plus:
			result = "+";
			break;
		}
		return result;
	}
}
