using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Default;

public class ApplicationDefault : AppDefault
{
	protected string _PCS_Partenza_Default;

	protected string _PCS_Destinazione_Default;

	protected string _PCS_Generico_Default;

	protected string _Trasportatore_Default;

	protected string _NazioneDefault;

	protected string _CausaleBollaDefault;

	protected string _TipoServizioDefault;

	protected string _TipoSpedizioneDefault;

	protected string _PuntoDiRitiroDefault;

	protected string _TrasportoCuraDefault;

	protected string _MezziCategorieDefault;

	protected string _TipoMezzoDefault;

	protected string _SchedulazioneTipo;

	protected string _TipoMerceDefault;

	protected string _ZonaSpedizioneDefault;

	protected string _ZonaTariffaAttivaDefault;

	protected string _ZonaTariffaPassivaDefault;

	protected string _TipoUdsDefault;

	protected string _TipoViaggioDefault;

	protected string _TipoViaggioFermoDeposito;

	protected bool _TipoViaggioFermoDepositoChecked;

	protected string _TipoViaggioMultiTratta;

	protected bool _TipoViaggioMultiTrattaChecked;

	protected string _XServerCoordFormatDefault;

	protected ApplicationCustomDefault _Custom;

	protected string _TipoIncasso_Default;

	protected string _TipoContestazione_Default;

	protected string _SezionalePassivoDefault;

	protected string _SezionaleAttivoDefault;

	protected string _Giacenze_CausaliChiusura_Default;

	protected string _TipoEsito_Default;

	protected string _Esito_OverrideGeneraRiconsegna;

	public ApplicationCustomDefault Custom => _Custom;

	public ApplicationDefault(AppApiContext objApiContext)
		: base(objApiContext)
	{
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		_PCS_Partenza_Default = "";
		_PCS_Destinazione_Default = "";
		_PCS_Generico_Default = "";
		_Trasportatore_Default = "";
		_NazioneDefault = "";
		_CausaleBollaDefault = "";
		_TipoServizioDefault = "";
		_TipoSpedizioneDefault = "";
		_PuntoDiRitiroDefault = "";
		_TrasportoCuraDefault = "";
		_MezziCategorieDefault = "";
		_TipoMezzoDefault = "";
		_SchedulazioneTipo = "";
		_TipoMerceDefault = "";
		_ZonaSpedizioneDefault = "";
		_ZonaTariffaAttivaDefault = "";
		_ZonaTariffaPassivaDefault = "";
		_TipoUdsDefault = "";
		_TipoViaggioDefault = "";
		_TipoViaggioFermoDeposito = "";
		_TipoViaggioFermoDepositoChecked = false;
		_TipoViaggioMultiTratta = "";
		_TipoViaggioMultiTrattaChecked = false;
		_XServerCoordFormatDefault = "";
		_TipoIncasso_Default = "";
		_TipoContestazione_Default = "";
		_SezionalePassivoDefault = "";
		_SezionaleAttivoDefault = "";
		_Giacenze_CausaliChiusura_Default = "";
		_TipoEsito_Default = "";
		_Esito_OverrideGeneraRiconsegna = "";
		_Custom = new ApplicationCustomDefault(objApiContext);
	}

	public string PCS_Partenza_Default()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_PCS_Partenza_Default, "", false) == 0)
			{
				text = "SELECT CODICE FROM PCS WHERE PuntoDiCarico='S' AND IsDefault='S' AND Attivo='S'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0 && rObjDataTable.Rows.Count > 0)
				{
					_PCS_Partenza_Default = rObjDataTable.Rows[0]["Codice"].ToString();
				}
			}
			result = _PCS_Partenza_Default;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string PCS_Destinazione_Default()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_PCS_Destinazione_Default, "", false) == 0)
			{
				text = "SELECT CODICE FROM PCS WHERE PuntoDiDestino='S' AND IsDefault='S' and Attivo='S'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0 && rObjDataTable.Rows.Count > 0)
				{
					_PCS_Destinazione_Default = rObjDataTable.Rows[0]["Codice"].ToString();
				}
			}
			result = _PCS_Destinazione_Default;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string PCS_Generico_Default()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		string text = "";
		string rsMess = "";
		FXRETURN rnRes = (FXRETURN)3;
		string result;
		try
		{
			if (Operators.CompareString(_PCS_Generico_Default, "", false) != 0)
			{
				goto IL_0048;
			}
			_PCS_Generico_Default = ((AppBaseClass)this).Parametrica.LeggiParametro("DEFAULT.PCS.GENERICO", ref rnRes, ref rsMess);
			if ((int)rnRes == 0)
			{
				goto IL_0048;
			}
			result = "";
			goto end_IL_000e;
			IL_0048:
			result = _PCS_Generico_Default;
			end_IL_000e:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string Trasportatore_Default()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_Trasportatore_Default, "", false) == 0)
			{
				text = "SELECT CODICE FROM Trasportatori WHERE IsDefault='S' AND Attivo='S'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0 && rObjDataTable.Rows.Count > 0)
				{
					_Trasportatore_Default = rObjDataTable.Rows[0]["Codice"].ToString();
				}
			}
			result = _Trasportatore_Default;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string NazioneDefault()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and I4
		string text = "";
		string rsMess = "";
		FXRETURN rnRes = (FXRETURN)3;
		string result;
		try
		{
			if (Operators.CompareString(_NazioneDefault, "", false) == 0)
			{
				_NazioneDefault = ((AppBaseClass)this).Parametrica.LeggiParametro("DEFAULT.NAZIONE", ref rnRes, ref rsMess);
				if ((int)rnRes != 0)
				{
					_NazioneDefault = "ITA";
				}
				if (Operators.CompareString(_NazioneDefault, "", false) == 0)
				{
					_NazioneDefault = "ITA";
				}
			}
			result = _NazioneDefault;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string TipoServizioDefault()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_TipoServizioDefault, "", false) == 0)
			{
				text = "SELECT CODICE FROM TipiServizi WHERE IsDefault='S'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0 && rObjDataTable.Rows.Count > 0)
				{
					_TipoServizioDefault = rObjDataTable.Rows[0]["Codice"].ToString();
				}
			}
			result = _TipoServizioDefault;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string TipoSpedizioneDefault()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_TipoSpedizioneDefault, "", false) == 0)
			{
				text = "SELECT CODICE FROM TipiSpedizione WHERE IsDefault='S'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0 && rObjDataTable.Rows.Count > 0)
				{
					_TipoSpedizioneDefault = rObjDataTable.Rows[0]["Codice"].ToString();
				}
			}
			result = _TipoSpedizioneDefault;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string TipoMerceDefault()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_TipoMerceDefault, "", false) == 0)
			{
				text = "SELECT CODICE FROM TipiMerce WHERE IsDefault='S'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0 && rObjDataTable.Rows.Count > 0)
				{
					_TipoMerceDefault = rObjDataTable.Rows[0]["Codice"].ToString();
				}
			}
			result = _TipoMerceDefault;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string ZonaSpedizioneDefault()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_ZonaSpedizioneDefault, "", false) == 0)
			{
				text = "SELECT CODICE FROM Zone WHERE ZonaSpedizione='S' AND ZonaSpedizioneIsDefault='S'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0)
				{
					if (rObjDataTable.Rows.Count > 0)
					{
						_ZonaSpedizioneDefault = rObjDataTable.Rows[0]["Codice"].ToString();
					}
					else
					{
						_ZonaSpedizioneDefault = "*ALL";
					}
				}
			}
			result = _ZonaSpedizioneDefault;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string ZonaTariffaAttivaDefault()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_ZonaTariffaAttivaDefault, "", false) == 0)
			{
				text = "SELECT CODICE FROM Zone WHERE ZonaTariffaAttiva='S' AND ZonaTariffaAttivaIsDefault='S'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0)
				{
					if (rObjDataTable.Rows.Count > 0)
					{
						_ZonaTariffaAttivaDefault = rObjDataTable.Rows[0]["Codice"].ToString();
					}
					else
					{
						_ZonaTariffaAttivaDefault = "*ALL";
					}
				}
			}
			result = _ZonaTariffaAttivaDefault;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string ZonaTariffaPassivaDefault()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_ZonaTariffaPassivaDefault, "", false) == 0)
			{
				text = "SELECT CODICE FROM Zone WHERE ZonaTariffaPassiva='S' AND ZonaTariffaPassivaIsDefault='S'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0)
				{
					if (rObjDataTable.Rows.Count > 0)
					{
						_ZonaTariffaPassivaDefault = rObjDataTable.Rows[0]["Codice"].ToString();
					}
					else
					{
						_ZonaTariffaPassivaDefault = "*ALL";
					}
				}
			}
			result = _ZonaTariffaPassivaDefault;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string MezziCategorieDefault()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_MezziCategorieDefault, "", false) == 0)
			{
				text = "SELECT CODICE FROM MezziCategorie WHERE IsDefault='S'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0 && rObjDataTable.Rows.Count > 0)
				{
					_MezziCategorieDefault = rObjDataTable.Rows[0]["Codice"].ToString();
				}
			}
			result = _MezziCategorieDefault;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string TipoMezzoDefault()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_TipoMezzoDefault, "", false) == 0)
			{
				text = "SELECT CODICE FROM TipiMezzo WHERE IsDefault='S' and Attivo='S'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0 && rObjDataTable.Rows.Count > 0)
				{
					_TipoMezzoDefault = rObjDataTable.Rows[0]["Codice"].ToString();
				}
			}
			result = _TipoMezzoDefault;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string SchedulazioneTipo()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_SchedulazioneTipo, "", false) == 0)
			{
				text = "SELECT CODICE FROM VW_DSI_SCHEDULAZIONETIPO WHERE IsDefault='S'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0 && rObjDataTable.Rows.Count > 0)
				{
					_SchedulazioneTipo = rObjDataTable.Rows[0]["Codice"].ToString();
				}
			}
			result = _SchedulazioneTipo;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string TipoUds_Default()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_TipoUdsDefault, "", false) == 0)
			{
				text = "SELECT CODICE FROM TipiUds WHERE IsDefault='S' and Attivo='S'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0 && rObjDataTable.Rows.Count > 0)
				{
					_TipoUdsDefault = rObjDataTable.Rows[0]["Codice"].ToString();
				}
			}
			result = _TipoUdsDefault;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string TipoViaggio_Default()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_TipoViaggioDefault, "", false) == 0)
			{
				text = "SELECT CODICE FROM Viaggi_TipiViaggio WHERE IsDefault='S' and Attivo='S'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0)
				{
					if (rObjDataTable.Rows.Count > 0)
					{
						_TipoViaggioDefault = rObjDataTable.Rows[0]["Codice"].ToString();
					}
					else
					{
						_TipoViaggioDefault = "GEN";
					}
				}
			}
			result = _TipoViaggioDefault;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string TipoViaggio_FermoDeposito()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN rnRes = (FXRETURN)3;
		string tipoViaggioFermoDeposito;
		try
		{
			bool flag = false;
			if (Operators.CompareString(_TipoViaggioFermoDeposito, "", false) == 0)
			{
				IboWebParam parametrica = ((AppBaseClass)this).Parametrica;
				string rsMess = "";
				_TipoViaggioFermoDeposito = parametrica.LeggiParametro("DEFAULT.TIPIVIAGGIO.FERMODEPOSITO", ref rnRes, ref rsMess);
				flag = true;
			}
			if (Operators.CompareString(_TipoViaggioFermoDeposito, "", false) == 0)
			{
				_TipoViaggioFermoDeposito = "FDP";
				flag = true;
			}
			if (flag && !_TipoViaggioFermoDepositoChecked)
			{
				string sSql = "SELECT COUNT(*) FROM Viaggi_TipiViaggio WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoViaggioFermoDeposito);
				object objRes = 0;
				DBConnection dbConn = ((AppBaseClass)this).DbConn;
				object vObjDefault = 0;
				string rsMess = "";
				dbConn.DoSql(sSql, vObjDefault, ref objRes, ref rsMess);
				if (Conversions.ToInteger(objRes) == 0)
				{
					_TipoViaggioFermoDeposito = "";
				}
				else
				{
					_TipoViaggioFermoDepositoChecked = true;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finally
		{
			tipoViaggioFermoDeposito = _TipoViaggioFermoDeposito;
		}
		return tipoViaggioFermoDeposito;
	}

	public string TipoViaggio_ViaggioMultiTratta()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN rnRes = (FXRETURN)3;
		string tipoViaggioMultiTratta;
		try
		{
			bool flag = false;
			if (Operators.CompareString(_TipoViaggioMultiTratta, "", false) == 0)
			{
				IboWebParam parametrica = ((AppBaseClass)this).Parametrica;
				string rsMess = "";
				_TipoViaggioMultiTratta = parametrica.LeggiParametro("DEFAULT.TIPIVIAGGIO.MULTITRATTA", ref rnRes, ref rsMess);
				flag = true;
			}
			if (Operators.CompareString(_TipoViaggioMultiTratta, "", false) == 0)
			{
				_TipoViaggioMultiTratta = "VMT";
				flag = true;
			}
			if (flag && !_TipoViaggioMultiTrattaChecked)
			{
				string sSql = "SELECT COUNT(*) FROM Viaggi_TipiViaggio WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoViaggioMultiTratta) + " AND Attivo='S'";
				object objRes = 0;
				DBConnection dbConn = ((AppBaseClass)this).DbConn;
				object vObjDefault = 0;
				string rsMess = "";
				dbConn.DoSql(sSql, vObjDefault, ref objRes, ref rsMess);
				if (Conversions.ToInteger(objRes) == 0)
				{
					_TipoViaggioMultiTratta = "";
				}
				else
				{
					_TipoViaggioMultiTrattaChecked = true;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		finally
		{
			tipoViaggioMultiTratta = _TipoViaggioMultiTratta;
		}
		return tipoViaggioMultiTratta;
	}

	public string XServerCoordFormatDefault()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN rnRes = (FXRETURN)3;
		string rsMess = "";
		string result;
		try
		{
			if (_XServerCoordFormatDefault == null)
			{
				_XServerCoordFormatDefault = ((AppBaseClass)this).Parametrica.LeggiParametro("XSERVER.COORD_FORMAT_DEFAULT", ref rnRes, ref rsMess);
			}
			if (Operators.CompareString(_XServerCoordFormatDefault, "", false) == 0)
			{
				_XServerCoordFormatDefault = "OG_GEODECIMAL";
			}
			result = _XServerCoordFormatDefault;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string TipoIncasso_Default()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_TipoIncasso_Default, "", false) == 0)
			{
				text = "SELECT CODICE FROM TipiIncasso WHERE IsDefault='S' AND Attivo='S'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0 && rObjDataTable.Rows.Count > 0)
				{
					_TipoIncasso_Default = rObjDataTable.Rows[0]["Codice"].ToString();
				}
			}
			result = _TipoIncasso_Default;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string TipoContestazione_Default()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_TipoContestazione_Default, "", false) == 0)
			{
				text = "SELECT CODICE FROM Contestazioni_Tipi WHERE IsDefault='S' AND Attivo='S'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0 && rObjDataTable.Rows.Count > 0)
				{
					_TipoContestazione_Default = rObjDataTable.Rows[0]["Codice"].ToString();
				}
			}
			result = _TipoContestazione_Default;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string SezionaleAttivoDefault()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_SezionaleAttivoDefault, "", false) == 0)
			{
				text = "SELECT CODICE FROM Sezionali WHERE IsDefault='S' AND Attivo='S' AND AttivoPassivo='A'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0 && rObjDataTable.Rows.Count > 0)
				{
					_SezionaleAttivoDefault = rObjDataTable.Rows[0]["Codice"].ToString();
				}
			}
			result = _SezionaleAttivoDefault;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string SezionalePassivoDefault()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_SezionalePassivoDefault, "", false) == 0)
			{
				text = "SELECT CODICE FROM Sezionali WHERE IsDefault='S' AND Attivo='S' AND AttivoPassivo='P'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0 && rObjDataTable.Rows.Count > 0)
				{
					_SezionalePassivoDefault = rObjDataTable.Rows[0]["Codice"].ToString();
				}
			}
			result = _SezionalePassivoDefault;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string Giacenza_CausaleChiusura_Default()
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		string text = "";
		DataTable rObjDataTable = null;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_Giacenze_CausaliChiusura_Default, "", false) == 0)
			{
				text = "SELECT CODICE FROM Giacenze_CausaliChiusura WHERE IsDefault='S' AND Attivo='S'";
				if ((int)((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsMess) == 0 && rObjDataTable.Rows.Count > 0)
				{
					_Giacenze_CausaliChiusura_Default = rObjDataTable.Rows[0]["Codice"].ToString();
				}
			}
			result = _Giacenze_CausaliChiusura_Default;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string TipoEsito_Default()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN rnRes = (FXRETURN)3;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_TipoEsito_Default, "", false) == 0)
			{
				_TipoEsito_Default = ((AppBaseClass)this).Parametrica.LeggiParametro("DM.ESITAZIONE.TIPO_ESITO_DEFAULT", ref rnRes, ref rsMess);
			}
			if (Operators.CompareString(_TipoEsito_Default, "", false) == 0)
			{
				_TipoEsito_Default = "OK";
			}
			result = _TipoEsito_Default;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "OK";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public string Esito_OverrideGeneraRiconsegna()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN rnRes = (FXRETURN)3;
		string rsMess = "";
		string result;
		try
		{
			if (Operators.CompareString(_Esito_OverrideGeneraRiconsegna, "", false) == 0)
			{
				_Esito_OverrideGeneraRiconsegna = ((AppBaseClass)this).Parametrica.LeggiParametro("DM.ESITAZIONE.OVERRIDE_RICONSEGNA", ref rnRes, ref rsMess);
			}
			if (Operators.CompareString(_Esito_OverrideGeneraRiconsegna, "", false) == 0)
			{
				_Esito_OverrideGeneraRiconsegna = "S";
			}
			result = _Esito_OverrideGeneraRiconsegna;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			this.HandleError(ref ex2, ref rsMess);
			result = "OK";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void ResetDefault()
	{
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		_NazioneDefault = "";
		_CausaleBollaDefault = "";
		_TipoServizioDefault = "";
		_PuntoDiRitiroDefault = "";
		_TrasportoCuraDefault = "";
		_SchedulazioneTipo = "";
		_TipoMezzoDefault = "";
		_PCS_Partenza_Default = "";
		_PCS_Destinazione_Default = "";
		_PCS_Generico_Default = "";
		_TipoMerceDefault = "";
		_TipoUdsDefault = "";
		_TipoViaggioDefault = "";
		_TipoViaggioFermoDeposito = "";
		_TipoViaggioFermoDepositoChecked = false;
		_TipoViaggioMultiTratta = "";
		_TipoViaggioMultiTrattaChecked = false;
		_XServerCoordFormatDefault = "";
		_Trasportatore_Default = "";
		_TipoSpedizioneDefault = "";
		_TipoIncasso_Default = "";
		_TipoContestazione_Default = "";
		_SezionaleAttivoDefault = "";
		_SezionalePassivoDefault = "";
		_Giacenze_CausaliChiusura_Default = "";
		_TipoEsito_Default = "";
		_Esito_OverrideGeneraRiconsegna = "";
		_Custom.ResetDefault();
		try
		{
			IboWebParam parametrica = this._Parametrica;
			string rsMess = "";
			parametrica.RicaricaParametri(ref rsMess);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
