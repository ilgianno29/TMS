using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_ConsegnaOk : AppAbstractApi
{
	protected string _Unibol;

	protected string _CodiceEvento;

	protected int _SequenzaEffettiva;

	protected string _Autista;

	protected DateTime? _Data;

	protected DateTime? _DataArrivo;

	protected DateTime? _DataPartenza;

	protected string _Motrice;

	protected string _Rimorchio;

	protected string _Contenitore;

	protected string _Terminale;

	protected string _Latitudine;

	protected string _Longitudine;

	protected decimal? _KmGps;

	protected DateTime? _DataGPS;

	protected decimal? _KmManuali;

	protected string _Localita;

	protected string _Indirizzo;

	protected string _Cap;

	protected string _Provincia;

	protected string _Nazione;

	protected string _NoteInterne;

	protected string _NoteEsterne;

	protected DataTable _dtUds;

	protected DataTable _dtSpedizione;

	protected string _EventoUds;

	protected int _StatoOBC;

	protected string _IdViaggio;

	protected string _IsRitiro;

	protected string _IsConsegna;

	protected string _IdSpedizioneMadre;

	protected int _Stato;

	protected string _Corrispondente;

	public Spedizione_ConsegnaOk(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_CodiceEvento = "";
		_SequenzaEffettiva = 0;
		_Autista = "";
		_Motrice = "";
		_Rimorchio = "";
		_Contenitore = "";
		_Terminale = "";
		_Latitudine = "";
		_Longitudine = "";
		_Localita = "";
		_Indirizzo = "";
		_Cap = "";
		_Provincia = "";
		_Nazione = "";
		_NoteInterne = "";
		_NoteEsterne = "";
		_dtUds = null;
		_dtSpedizione = null;
		_EventoUds = "";
		_StatoOBC = 0;
		_IdViaggio = "";
		_IsRitiro = "";
		_IsConsegna = "";
		_IdSpedizioneMadre = "";
		_Stato = 0;
		_Corrispondente = "";
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Invalid comparison between Unknown and I4
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			_CodiceEvento = ((AppAbstractApi)this).ParametersIn["CodiceEvento"].ToString();
			if (Versioned.IsNumeric((object)((AppAbstractApi)this).ParametersIn["SequenzaEffettiva"].ToString()))
			{
				_SequenzaEffettiva = Conversions.ToInteger(((AppAbstractApi)this).ParametersIn["SequenzaEffettiva"].ToString());
			}
			_Data = (DateTime?)((AppAbstractApi)this).ParametersIn["Data"];
			if (!_Data.HasValue)
			{
				_Data = DateAndTime.Now;
			}
			_Autista = ((AppAbstractApi)this).ParametersIn["Autista"].ToString();
			_Motrice = ((AppAbstractApi)this).ParametersIn["Motrice"].ToString();
			_Rimorchio = ((AppAbstractApi)this).ParametersIn["Rimorchio"].ToString();
			_Contenitore = ((AppAbstractApi)this).ParametersIn["Contenitore"].ToString();
			_Terminale = ((AppAbstractApi)this).ParametersIn["Terminale"].ToString();
			_Latitudine = ((AppAbstractApi)this).ParametersIn["Latitudine"].ToString();
			_Longitudine = ((AppAbstractApi)this).ParametersIn["Longitudine"].ToString();
			_KmGps = (decimal?)((AppAbstractApi)this).ParametersIn["KmGps"];
			_DataGPS = (DateTime?)((AppAbstractApi)this).ParametersIn["DataGPS"];
			_KmManuali = (decimal?)((AppAbstractApi)this).ParametersIn["KmManuali"];
			_Localita = ((AppAbstractApi)this).ParametersIn["Localita"].ToString();
			_Indirizzo = ((AppAbstractApi)this).ParametersIn["Indirizzo"].ToString();
			_Cap = ((AppAbstractApi)this).ParametersIn["Cap"].ToString();
			_Provincia = ((AppAbstractApi)this).ParametersIn["Provincia"].ToString();
			_Nazione = ((AppAbstractApi)this).ParametersIn["Nazione"].ToString();
			_NoteInterne = ((AppAbstractApi)this).ParametersIn["NoteInterne"].ToString();
			_NoteEsterne = ((AppAbstractApi)this).ParametersIn["NoteEsterne"].ToString();
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("DataPartenza"))
			{
				_DataPartenza = Conversions.ToDate(((AppAbstractApi)this).ParametersIn["DataPartenza"]);
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("DataArrivo"))
			{
				_DataArrivo = Conversions.ToDate(((AppAbstractApi)this).ParametersIn["DataArrivo"]);
			}
			if (!_DataPartenza.HasValue)
			{
				_DataPartenza = _Data;
			}
			if (!_DataArrivo.HasValue)
			{
				_DataArrivo = _Data;
			}
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
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Invalid comparison between Unknown and I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Invalid comparison between Unknown and I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Invalid comparison between Unknown and I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Invalid comparison between Unknown and I4
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Invalid comparison between Unknown and I4
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Invalid comparison between Unknown and I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (!((_Stato == 40) & (Operators.CompareString(_Corrispondente, "", false) != 0)))
			{
				goto IL_00f7;
			}
			text2 = "";
			AppApiContext apiContext = this._ApiContext;
			string unibol = _Unibol;
			string CodiceEvento = "";
			val = EventoSpedizione_ArrivoATP.RunProc(apiContext, unibol, ref CodiceEvento, _Data, _Autista, _Motrice, _Rimorchio, _Contenitore, _Terminale, _Latitudine, _Longitudine, _KmGps, _DataGPS, _KmManuali, _Localita, _Indirizzo, _Cap, _Provincia, _Nazione, _NoteInterne, _NoteEsterne, ApplyQuery: false, ref text2, ref rsmess);
			if ((int)val <= 0)
			{
				text += text2;
				goto IL_00f7;
			}
			val2 = val;
			goto end_IL_0012;
			IL_00f7:
			text2 = "";
			val = EsitaUds(ref text2, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text += text2;
				text2 = "";
				val = AggiornaSpedizione(ref text2, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					text += text2;
					if (Operators.CompareString(text, "", false) == 0)
					{
						goto IL_0183;
					}
					val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
					if ((int)val <= 0)
					{
						goto IL_0183;
					}
					val2 = val;
				}
			}
			goto end_IL_0012;
			IL_0183:
			val = GestisciGiacenza(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = GestisciEsitoSpedizioneMadre(ref rsmess);
				val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
			}
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

	protected FXRETURN CheckSpedizione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Invalid comparison between Unknown and I4
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Invalid comparison between Unknown and I4
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Invalid comparison between Unknown and I4
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Invalid comparison between Unknown and I4
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT S.Stato, S.StatoOBC, S.ProgressivoConsegna, S.IdViaggio, S.TipoServizio, S.IdGiacenza, TS.Is_Consegna, TS.Is_Ritiro, S.UnibolSpedizioneCompleta, S.CountOfSubSpedizioni, S.Corrispondente ";
			text += "FROM VW_Spedizioni S INNER JOIN TipiServizi TS ON TS.Codice=S.TipoServizio ";
			text = text + "WHERE S.Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizione, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (_dtSpedizione.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} non è presente a sistema", new string[1] { _Unibol });
			}
			else
			{
				_StatoOBC = Conversions.ToInteger(_dtSpedizione.Rows[0]["STATOOBC"].ToString());
				_IdViaggio = _dtSpedizione.Rows[0]["IdViaggio"].ToString();
				_IsConsegna = _dtSpedizione.Rows[0]["Is_Consegna"].ToString();
				_IsRitiro = _dtSpedizione.Rows[0]["Is_Ritiro"].ToString();
				_Stato = Conversions.ToInteger(_dtSpedizione.Rows[0]["STATO"]);
				if (_Stato < 40)
				{
					rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} non risulta in consegna", new string[1] { _Unibol });
				}
				else if (_Stato >= 50)
				{
					rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} risulta già esitata", new string[1] { _Unibol });
				}
				else
				{
					_Corrispondente = _dtSpedizione.Rows[0]["Corrispondente"].ToString();
					if (Conversions.ToInteger(_dtSpedizione.Rows[0]["CountOfSubSpedizioni"]) <= 0)
					{
						goto IL_02fd;
					}
					text = "SELECT S.* FROM VW_Spedizioni S INNER JOIN Spedizioni_SubSpedizioni SS ON S.Unibol=SS.Unibol_SubSpedizione ";
					text = text + "WHERE SS.UNIBOL_SPEDIZIONE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " ";
					text += "ORDER BY SS.Sequenza DESC";
					DataTable rObjDataTable = null;
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						if (rObjDataTable.Rows.Count <= 0 || Operators.CompareString(rObjDataTable.Rows[0]["Evento_CodiceEsito"].ToString(), "", false) != 0)
						{
							goto IL_02fd;
						}
						rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} possiede delle subspedizioni. Esitare le subspedizioni.", new string[1] { _Unibol });
					}
				}
			}
			goto end_IL_000b;
			IL_03ff:
			text = "SELECT * FROM SpedizioniUds WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " AND Esito IS NULL";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtUds, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (_dtUds.Rows.Count <= 0)
				{
					goto IL_04b0;
				}
				object objRes = null;
				text = "SELECT EventoDefault FROM Eventi_Tipi WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(EventoSpedizioneTipo.UdsEsitoOk);
				val = ((AppBaseClass)this).DbConn.DoSql(text, "", ref objRes, ref rsmess);
				if ((int)val <= 0)
				{
					_EventoUds = objRes.ToString();
					goto IL_04b0;
				}
				val2 = val;
			}
			goto end_IL_000b;
			IL_02fd:
			if (Operators.CompareString(_dtSpedizione.Rows[0]["UnibolSpedizioneCompleta"].ToString(), "", false) == 0)
			{
				goto IL_03ff;
			}
			text = "SELECT SS.* FROM VW_Spedizioni S INNER JOIN Spedizioni_SubSpedizioni SS ON S.UnibolSpedizioneCompleta=SS.Unibol_Spedizione ";
			text = text + "WHERE S.Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " ";
			text += "ORDER BY SS.Sequenza DESC";
			DataTable rObjDataTable2 = null;
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable2, ref rsmess);
			if ((int)val <= 0)
			{
				if (rObjDataTable2.Rows.Count > 0 && Operators.CompareString(rObjDataTable2.Rows[0]["Unibol_SubSpedizione"].ToString(), _Unibol, false) == 0)
				{
					_IdSpedizioneMadre = _dtSpedizione.Rows[0]["UnibolSpedizioneCompleta"].ToString();
				}
				goto IL_03ff;
			}
			val2 = val;
			goto end_IL_000b;
			IL_04b0:
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

	protected virtual FXRETURN EsitaUds(ref string ssqlRet, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			ssqlRet = "";
			if (Operators.CompareString(_EventoUds, "", false) != 0 && _dtUds.Rows.Count > 0)
			{
				text = "UPDATE SpedizioniUds SET Esito=" + ((AppBaseClass)this).DbConn.SQLFormatString(_EventoUds) + ", ";
				text = text + "DataEsito=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, _Data) + " ";
				text = text + "WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " ";
				text += "AND Esito IS NULL;";
			}
			ssqlRet = text;
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

	protected virtual FXRETURN AggiornaSpedizione(ref string ssqlRet, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Invalid comparison between Unknown and I4
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Invalid comparison between Unknown and I4
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Invalid comparison between Unknown and I4
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Invalid comparison between Unknown and I4
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Invalid comparison between Unknown and I4
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			ssqlRet = "";
			text += "UPDATE Spedizioni SET Stato=CASE WHEN STATO<=50 THEN 50 ELSE STATO END, ";
			text = text + "DataOraArrivoEffettiva = " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, _DataArrivo) + ", ";
			text = text + "DataOraPartenzaEffettiva = " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, _DataPartenza) + ", ";
			if (_KmManuali.HasValue)
			{
				text = text + "KmManuali = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _KmManuali) + ", ";
			}
			if (_SequenzaEffettiva > 0)
			{
				text = text + "SequenzaEffettiva = " + ((AppBaseClass)this).DbConn.SQLFormatNumber(ref _SequenzaEffettiva) + ", ";
			}
			text = text + "DatAgg=" + ((AppBaseClass)this).DbConn.GetDate() + ", ";
			text = text + "UteAgg=" + this.DbConn.SQLFormatString(this._User) + " ";
			text = text + "WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + ";";
			text2 = "";
			val = EventoSpedizione_ConsegnaOK.RunProc(this._ApiContext, _Unibol, ref _CodiceEvento, _Data, _Autista, _Motrice, _Rimorchio, _Contenitore, _Terminale, _Latitudine, _Longitudine, _KmGps, _DataGPS, _KmManuali, _Localita, _Indirizzo, _Cap, _Provincia, _Nazione, _NoteInterne, _NoteEsterne, ApplyQuery: false, ref text2, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text += text2;
				text2 = "";
				string text3 = "";
				if (Operators.CompareString(_IsConsegna, "S", false) == 0)
				{
					text3 = "S";
				}
				else if (Operators.CompareString(_IsRitiro, "S", false) == 0)
				{
					text3 = "C";
				}
				if (Operators.CompareString(text3, "", false) == 0)
				{
					goto IL_02f9;
				}
				val = EventoViaggio_Spedizione.RunProc(this._ApiContext, _IdViaggio, text3, _Unibol, _Data, _Autista, _Motrice, _Rimorchio, _Contenitore, _Terminale, _Latitudine, _Longitudine, _KmGps, _DataGPS, _KmManuali, _Localita, _Indirizzo, _Cap, _Provincia, _Nazione, _NoteEsterne, ApplyQuery: false, ref text2, ref rsmess);
				if ((int)val <= 0)
				{
					text += text2;
					goto IL_02f9;
				}
				val2 = val;
			}
			goto end_IL_0012;
			IL_02f9:
			string sSql = "SELECT COUNT(*) FROM Spedizioni WHERE Stato<48 AND IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " AND UNIBOL<>" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			object objRes = null;
			val = ((AppBaseClass)this).DbConn.DoSql(sSql, ref objRes, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (Conversions.ToInteger(objRes) != 0)
				{
					goto IL_0402;
				}
				sSql = "SELECT COUNT(*) FROM Viaggi WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " AND Terminale IS NULL AND FlagViaggioSospeso='N'";
				objRes = null;
				val = ((AppBaseClass)this).DbConn.DoSql(sSql, ref objRes, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (Conversions.ToInteger(objRes) <= 0)
					{
						goto IL_0402;
					}
					text2 = "";
					val = Viaggio_Fine_Invoker.Instance.RunProc(this._ApiContext, _IdViaggio, doCheckSpedizioni: false, _Data, ApplyQuery: false, ref text2, ref rsmess);
					if ((int)val <= 0)
					{
						text += text2;
						goto IL_0402;
					}
					val2 = val;
				}
			}
			goto end_IL_0012;
			IL_0402:
			ssqlRet = text;
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

	protected virtual FXRETURN GestisciGiacenza(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Invalid comparison between Unknown and I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_dtSpedizione.Rows[0]["IdGiacenza"].ToString(), "", false) == 0 || Conversions.ToInteger(_dtSpedizione.Rows[0]["ProgressivoConsegna"]) <= 0)
			{
				goto IL_00e4;
			}
			string causaleChiusura = "";
			Giacenza_Chiudi_Invoker instance = Giacenza_Chiudi_Invoker.Instance;
			AppApiContext apiContext = this._ApiContext;
			int idGiacenza = Conversions.ToInteger(_dtSpedizione.Rows[0]["IdGiacenza"]);
			string unibol = _Unibol;
			DateTime? data = _Data;
			string RetQueryToApply = "";
			val = instance.RunProc(apiContext, idGiacenza, unibol, data, causaleChiusura, "", null, ApplyQuery: true, ref RetQueryToApply, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_00e4;
			}
			val2 = val;
			goto end_IL_0005;
			IL_00e4:
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

	protected virtual FXRETURN GestisciEsitoSpedizioneMadre(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_IdSpedizioneMadre, "", false) == 0)
			{
				goto IL_006c;
			}
			val = Spedizione_ConsegnaOk_Invoker.Instance.RunProc(this._ApiContext, _IdSpedizioneMadre, _CodiceEvento, _Data, _NoteInterne, _NoteEsterne, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_006c;
			}
			val2 = val;
			goto end_IL_0005;
			IL_006c:
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
