using System;
using System.Collections.Generic;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class ViaggioDiLinea_AssociaSpedizioneAttiva : GdoAbstractApi
{
	protected string _IdViaggioDiLinea;

	protected string _Unibol;

	protected DataTable _dtSpedizione;

	protected int _GiornoCutOff;

	protected DateTime _OraCutOff;

	protected string _PCS;

	protected DateTime _DataPartenzaPianificata;

	protected int _SettimanaCutOff;

	protected int _AnnoCutOff;

	protected DateTime _LineaCutOff;

	protected DataTable _dtGiroStandard;

	protected DataTable _dtViaggioLinea;

	public ViaggioDiLinea_AssociaSpedizioneAttiva(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_IdViaggioDiLinea = "";
		_Unibol = "";
		_dtSpedizione = null;
		_PCS = "";
		_dtGiroStandard = null;
		_dtViaggioLinea = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Unibol = this._ParametersIn["Unibol"].ToString();
			this._ParametersOut.Add("IdViaggioDiLinea", _IdViaggioDiLinea);
			val = CheckSpedizione(ref rsmess);
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
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Invalid comparison between Unknown and I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = DeterminaGiroStandard(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (_dtGiroStandard.Rows.Count <= 0)
				{
					goto IL_00ec;
				}
				val = VerificaPresenzaViaggioDiLinea(ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (_dtViaggioLinea.Rows.Count != 0)
					{
						goto IL_0096;
					}
					val = CreaViaggioDiLinea(ref rsmess);
					if ((int)val <= 0)
					{
						goto IL_0096;
					}
					val2 = val;
				}
			}
			goto end_IL_0005;
			IL_00ec:
			val2 = (FXRETURN)0;
			goto end_IL_0005;
			IL_0096:
			_IdViaggioDiLinea = _dtViaggioLinea.Rows[0]["Id"].ToString();
			val = AssociaSpedizioneAViaggioDiLinea(ref rsmess);
			if ((int)val <= 0)
			{
				this._ParametersOut["IdViaggioDiLinea"] = _IdViaggioDiLinea;
				goto IL_00ec;
			}
			val2 = val;
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

	protected virtual FXRETURN CheckSpedizione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string vsSQLClause = "SELECT * FROM SPEDIZIONI WHERE UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref _dtSpedizione, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtSpedizione.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione {0} non esiste", new string[1] { _Unibol });
			}
			else if ((Conversions.ToInteger(_dtSpedizione.Rows[0]["Stato"]) != 18) & (Conversions.ToInteger(_dtSpedizione.Rows[0]["Stato"]) != 20))
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione {0} non è attiva", new string[1] { _Unibol });
			}
			else if (Operators.CompareString(_dtSpedizione.Rows[0]["IdViaggioLinea"].ToString(), "", false) != 0)
			{
				rsmess = this.TranslateMessage("XXX", "La spedizione {0} appartiene alla linea {1}", new string[2]
				{
					_Unibol,
					_dtSpedizione.Rows[0]["IdViaggioLinea"].ToString()
				});
			}
			else
			{
				_PCS = _dtSpedizione.Rows[0]["PCSDestinazione"].ToString();
				_GiornoCutOff = modGeneral.IncasDayOfWeek(DateAndTime.Now.Date);
				_OraCutOff = DateAndTime.Now;
				_SettimanaCutOff = modGeneral.IncasWeekOfYear(DateAndTime.Now.Date);
				_AnnoCutOff = DateAndTime.Now.Year;
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

	protected virtual FXRETURN DeterminaGiroStandard(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Invalid comparison between Unknown and I4
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "";
			text = "SELECT * FROM (SELECT T.Codice,T.Descrizione,T.RiferimentoEsterno, ";
			text = ((this._DbConn.ServerType != DBFormatFunctions.eServerType.Oracle) ? (text + "CASE WHEN ((T.GIORNOPARTENZA < T.GIORNOCUTOFF) AND (S.SETTIMANA >= " + _SettimanaCutOff + ")) THEN 7 + CAST(T.GIORNOPARTENZA AS INT) ELSE CAST(T.GIORNOPARTENZA AS INT) END GIORNOPARTENZA,") : (text + "CASE WHEN ((T.GIORNOPARTENZA < T.GIORNOCUTOFF) AND (S.SETTIMANA >= " + _SettimanaCutOff + ")) THEN 7 + TO_NUMBER(T.GIORNOPARTENZA) ELSE TO_NUMBER(T.GIORNOPARTENZA) END GIORNOPARTENZA,"));
			text += "T.OraPartenza,T.GiornoCutOff, T.GiornoCutOff GiornoCutOffOrig, ";
			text += "T.OraCutOff,S.Settimana,T.TipoViaggio,T.ZonaSpedizione,";
			text += "T.ZonaTariffaAttiva,T.ZonaTariffaPassiva,T.Mezzo,";
			text += "T.TipoMezzo,T.Trasportatore,T.Autista,";
			text += "T.TipoMerce,T.TipoSpedizione,T.DepositoPartenza,";
			text += "T.DepositoArrivo,T.Nota,T.Attivo,";
			text += "T.DatAgg,T.UteAgg,T.DatIns,T.UteIns,";
			text += "D.Corrispondente Dett_Corrispondente, ";
			text += "D.PCS Dett_PCS, ";
			text += "D.OraConsegna Dett_OraConsegna,";
			text += "D.Sequenza Dett_Sequenza ";
			text += "FROM GiriStandard_Testata T INNER JOIN GiriStandard_Dettagli D ON T.Codice=D.Codice ";
			text += "INNER JOIN GiriStandard_Settimane S ON T.Codice=S.Giro ";
			text += "WHERE T.Attivo='S' ";
			text = text + "AND D.PCS=" + ((AppBaseClass)this).DbConn.SQLFormatString(_PCS) + ") T ";
			text += "WHERE ";
			text = text + "( T.Settimana = " + _SettimanaCutOff + " ";
			text = text + "AND ((T.GiornoCutOff > " + _GiornoCutOff + ") ";
			text = text + "OR (T.GiornoCutOff = " + _GiornoCutOff + " AND ";
			text = ((((AppBaseClass)this).DbConn.ServerType != DBFormatFunctions.eServerType.Oracle) ? (text + "dbo.FORMATTIME(ORACUTOFF, 'HHMMSS','.') >= dbo.FORMATTIME(" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)3, _OraCutOff) + ",'HHMMSS','.') ") : (text + "TO_CHAR(ORACUTOFF,'HH24:MI:SS') >= TO_CHAR(" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)3, _OraCutOff) + ",'HH24:MI:SS') "));
			text += "))";
			text += ") OR ";
			text = text + "( T.Settimana <> " + _SettimanaCutOff + " ";
			text = text + "AND ((T.GiornoCutOff + 7 > " + _GiornoCutOff + ") ";
			text = text + "OR (T.GiornoCutOff + 7 = " + _GiornoCutOff + "+7 AND ";
			text = ((((AppBaseClass)this).DbConn.ServerType != DBFormatFunctions.eServerType.Oracle) ? (text + "dbo.FORMATTIME(ORACUTOFF, 'HHMMSS','.') >= dbo.FORMATTIME(" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)3, _OraCutOff) + ",'HHMMSS','.') ") : (text + "TO_CHAR(ORACUTOFF,'HH24:MI:SS') >= TO_CHAR(" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)3, _OraCutOff) + ",'HH24:MI:SS') "));
			text += "))) ";
			text = text + "ORDER BY CASE WHEN SETTIMANA >= " + Conversions.ToString(_SettimanaCutOff) + " THEN SETTIMANA ELSE SETTIMANA + " + modGeneral.IncasWeekOfYear(_AnnoCutOff) + " END, GiornoCutOff, OraCutOff";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtGiroStandard, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				checked
				{
					if (_dtGiroStandard.Rows.Count > 0)
					{
						if (Conversions.ToInteger(_dtGiroStandard.Rows[0]["Settimana"]) < _SettimanaCutOff)
						{
							_DataPartenzaPianificata = DateAndTime.DateAdd((DateInterval)4, (double)(Conversions.ToInteger(_dtGiroStandard.Rows[0]["GiornoPartenza"]) - 1), modGeneral.IncasFirstDateOfWeek(_AnnoCutOff + 1, Conversions.ToInteger(_dtGiroStandard.Rows[0]["Settimana"])));
							_DataPartenzaPianificata = DateAndTime.DateAdd((DateInterval)7, (double)Conversions.ToDate(_dtGiroStandard.Rows[0]["OraPartenza"]).Hour, _DataPartenzaPianificata);
							_DataPartenzaPianificata = DateAndTime.DateAdd((DateInterval)8, (double)Conversions.ToDate(_dtGiroStandard.Rows[0]["OraPartenza"]).Minute, _DataPartenzaPianificata);
							_LineaCutOff = DateAndTime.DateAdd((DateInterval)4, (double)(Conversions.ToInteger(_dtGiroStandard.Rows[0]["GiornoCutOff"]) - 1), modGeneral.IncasFirstDateOfWeek(_AnnoCutOff + 1, Conversions.ToInteger(_dtGiroStandard.Rows[0]["Settimana"])));
							if (Conversions.ToInteger(_dtGiroStandard.Rows[0]["GiornoCutOff"]) > Conversions.ToInteger(_dtGiroStandard.Rows[0]["GiornoPartenza"]))
							{
								_LineaCutOff = _LineaCutOff.AddDays(-7.0);
							}
							_LineaCutOff = DateAndTime.DateAdd((DateInterval)7, (double)Conversions.ToDate(_dtGiroStandard.Rows[0]["OraCutOff"]).Hour, _LineaCutOff);
							_LineaCutOff = DateAndTime.DateAdd((DateInterval)8, (double)Conversions.ToDate(_dtGiroStandard.Rows[0]["OraCutOff"]).Minute, _LineaCutOff);
						}
						else
						{
							_DataPartenzaPianificata = DateAndTime.DateAdd((DateInterval)4, (double)(Conversions.ToInteger(_dtGiroStandard.Rows[0]["GiornoPartenza"]) - 1), modGeneral.IncasFirstDateOfWeek(_AnnoCutOff, Conversions.ToInteger(_dtGiroStandard.Rows[0]["Settimana"])));
							_DataPartenzaPianificata = DateAndTime.DateAdd((DateInterval)7, (double)Conversions.ToDate(_dtGiroStandard.Rows[0]["OraPartenza"]).Hour, _DataPartenzaPianificata);
							_DataPartenzaPianificata = DateAndTime.DateAdd((DateInterval)8, (double)Conversions.ToDate(_dtGiroStandard.Rows[0]["OraPartenza"]).Minute, _DataPartenzaPianificata);
							if (Conversions.ToInteger(_dtGiroStandard.Rows[0]["GiornoPartenza"]) <= 7)
							{
								_LineaCutOff = DateAndTime.DateAdd((DateInterval)4, (double)(Conversions.ToInteger(_dtGiroStandard.Rows[0]["GiornoCutOff"]) - 1), modGeneral.IncasFirstDateOfWeek(_AnnoCutOff, Conversions.ToInteger(_dtGiroStandard.Rows[0]["Settimana"])));
							}
							else
							{
								_LineaCutOff = DateAndTime.DateAdd((DateInterval)4, (double)(Conversions.ToInteger(_dtGiroStandard.Rows[0]["GiornoCutOff"]) - 1), modGeneral.IncasFirstDateOfWeek(_AnnoCutOff, Conversions.ToInteger(_dtGiroStandard.Rows[0]["Settimana"])));
							}
							_LineaCutOff = DateAndTime.DateAdd((DateInterval)7, (double)Conversions.ToDate(_dtGiroStandard.Rows[0]["OraCutOff"]).Hour, _LineaCutOff);
							_LineaCutOff = DateAndTime.DateAdd((DateInterval)8, (double)Conversions.ToDate(_dtGiroStandard.Rows[0]["OraCutOff"]).Minute, _LineaCutOff);
						}
					}
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

	protected virtual FXRETURN VerificaPresenzaViaggioDiLinea(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "";
			text = "SELECT * FROM Viaggi_Linea WHERE GIRO=" + ((AppBaseClass)this).DbConn.SQLFormatString(_dtGiroStandard.Rows[0]["Codice"].ToString()) + " ";
			text += "AND Stato=10 AND DataPartenzaPianificata >= %GETDATE% ";
			text += "AND CUTOFF >= %GETDATE% ";
			text = ((AppBaseClass)this).DbConn.SqlConvertForServer(text);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtViaggioLinea, ref rsmess);
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

	protected virtual FXRETURN CreaViaggioDiLinea(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Invalid comparison between Unknown and I4
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Invalid comparison between Unknown and I4
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			ViaggioDiLinea ViaggioDiLinea = new ViaggioDiLinea();
			DataRow dataRow = _dtGiroStandard.Rows[0];
			ViaggioDiLinea.TipoViaggio = dataRow["TipoViaggio"].ToString();
			ViaggioDiLinea.DataPartenzaPianificata = _DataPartenzaPianificata;
			ViaggioDiLinea.Giro = dataRow["Codice"].ToString();
			ViaggioDiLinea.RiferimentoEsterno = dataRow["RiferimentoEsterno"].ToString();
			ViaggioDiLinea.Descrizione = dataRow["Descrizione"].ToString();
			ViaggioDiLinea.Mezzo = dataRow["Mezzo"].ToString();
			ViaggioDiLinea.Vettore = dataRow["Trasportatore"].ToString();
			ViaggioDiLinea.Autista = dataRow["Autista"].ToString();
			ViaggioDiLinea.TipoSpedizione = dataRow["TipoSpedizione"].ToString();
			ViaggioDiLinea.TipoMerce = dataRow["TipoMerce"].ToString();
			ViaggioDiLinea.ZonaSpedizione = dataRow["ZonaSpedizione"].ToString();
			ViaggioDiLinea.ZonaTariffaAttiva = dataRow["ZonaTariffaAttiva"].ToString();
			ViaggioDiLinea.ZonaTariffaPassiva = dataRow["ZonaTariffaPassiva"].ToString();
			ViaggioDiLinea.PCSPartenza = dataRow["DepositoPartenza"].ToString();
			ViaggioDiLinea.PCSArrivo = dataRow["DepositoArrivo"].ToString();
			ViaggioDiLinea.Note = dataRow["Nota"].ToString();
			ViaggioDiLinea.CutOff = _LineaCutOff;
			dataRow = null;
			val = ViaggioDiLinea_Inserisci_Invoker.Instance.RunProc(this._ApiContext, ref ViaggioDiLinea, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				string text = "";
				text = "SELECT * FROM Viaggi_Linea WHERE Id=" + ((AppBaseClass)this).DbConn.SQLFormatString(ViaggioDiLinea.Id);
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtViaggioLinea, ref rsmess);
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

	protected virtual FXRETURN AssociaSpedizioneAViaggioDiLinea(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Invalid comparison between Unknown and I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Invalid comparison between Unknown and I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Invalid comparison between Unknown and I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Invalid comparison between Unknown and I4
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string text = "";
			text = "UPDATE Spedizioni SET IdViaggioLinea = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggioDiLinea) + " ";
			text = text + "WHERE Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + ";";
			string RetQueryToApply = "";
			val = EventoSpedizione_AssociaALinea.RunProc(this._ApiContext, _Unibol, DateAndTime.Now, _IdViaggioDiLinea, this._User, ApplyQuery: false, ref RetQueryToApply, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text += RetQueryToApply;
				val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (Operators.CompareString(_dtGiroStandard.Rows[0]["Dett_Corrispondente"].ToString(), "", false) == 0)
					{
						goto IL_0153;
					}
					List<string> list = new List<string>();
					list.Add(_Unibol);
					val = Spedizione_AggiungiTransitPoint.RunProc(this._ApiContext, list, _dtGiroStandard.Rows[0]["Dett_Corrispondente"].ToString(), ref rsmess);
					if ((int)val <= 0)
					{
						goto IL_0153;
					}
					val2 = val;
				}
			}
			goto end_IL_0005;
			IL_0153:
			val = WMS_Spedizione_AssociaALinea_Invoker.Instance.RunProc(this._ApiContext, _Unibol, _IdViaggioDiLinea, ref rsmess);
			val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
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
