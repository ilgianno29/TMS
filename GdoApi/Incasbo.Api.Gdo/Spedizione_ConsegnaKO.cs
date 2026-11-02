using System;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_ConsegnaKO : AppAbstractApi
{
	protected string _Unibol;

	protected int _SequenzaEffettiva;

	protected string _Autista;

	protected string _CodiceEvento;

	protected DateTime? _Data;

	protected DateTime? _DataArrivo;

	protected DateTime? _DataPartenza;

	protected string _Motrice;

	protected string _Rimorchio;

	protected string _Contenitore;

	protected string _Terminale;

	protected string _Latitudine;

	protected string _Longitudine;

	protected decimal? _KmManuali;

	protected decimal? _KmGps;

	protected DateTime? _DataGPS;

	protected string _Localita;

	protected string _Indirizzo;

	protected string _Cap;

	protected string _Provincia;

	protected string _Nazione;

	protected string _NoteInterne;

	protected string _NoteEsterne;

	protected DataTable _dtUds;

	protected string _EventoUds;

	protected int _StatoOBC;

	protected string _IdViaggio;

	protected string _IsRitiro;

	protected string _IsConsegna;

	protected string _IdSpedizioneMadre;

	protected StringCollection _IdsSubSpedizioniPrecedenti;

	protected StringCollection _IdsSubSpedizioniSuccessive;

	protected DataTable _dtSpedizione;

	protected DataTable _dtEvento;

	protected int _Stato;

	protected string _Corrispondente;

	protected bool? _ForzaGenerazioneRiconsegna;

	public Spedizione_ConsegnaKO(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_SequenzaEffettiva = 0;
		_Autista = "";
		_CodiceEvento = "";
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
		_EventoUds = "";
		_StatoOBC = 0;
		_IdViaggio = "";
		_IsRitiro = "";
		_IsConsegna = "";
		_IdSpedizioneMadre = "";
		_IdsSubSpedizioniPrecedenti = new StringCollection();
		_IdsSubSpedizioniSuccessive = new StringCollection();
		_dtSpedizione = null;
		_dtEvento = null;
		_Stato = 0;
		_Corrispondente = "";
		_ForzaGenerazioneRiconsegna = null;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Invalid comparison between Unknown and I4
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Invalid comparison between Unknown and I4
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			if (Versioned.IsNumeric((object)((AppAbstractApi)this).ParametersIn["SequenzaEffettiva"].ToString()))
			{
				_SequenzaEffettiva = Conversions.ToInteger(((AppAbstractApi)this).ParametersIn["SequenzaEffettiva"].ToString());
			}
			_CodiceEvento = ((AppAbstractApi)this).ParametersIn["CodiceEvento"].ToString();
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
			_KmManuali = (decimal?)((AppAbstractApi)this).ParametersIn["KmManuali"];
			_KmGps = (decimal?)((AppAbstractApi)this).ParametersIn["KmGps"];
			_DataGPS = (DateTime?)((AppAbstractApi)this).ParametersIn["DataGPS"];
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
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ForzaGenerazioneRiconsegna"))
			{
				_ForzaGenerazioneRiconsegna = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ForzaGenerazioneRiconsegna"]);
			}
			val = CheckSpedizione(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = CheckEvento(ref rsmess);
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
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Invalid comparison between Unknown and I4
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Invalid comparison between Unknown and I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Invalid comparison between Unknown and I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Invalid comparison between Unknown and I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Invalid comparison between Unknown and I4
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Invalid comparison between Unknown and I4
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Invalid comparison between Unknown and I4
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Invalid comparison between Unknown and I4
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		object obj = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (!((_Stato == 40) & (Operators.CompareString(_Corrispondente, "", false) != 0)))
			{
				goto IL_00fa;
			}
			text2 = "";
			AppApiContext apiContext = this._ApiContext;
			string unibol = _Unibol;
			string CodiceEvento = "";
			val = EventoSpedizione_ArrivoATP.RunProc(apiContext, unibol, ref CodiceEvento, _Data, _Autista, _Motrice, _Rimorchio, _Contenitore, _Terminale, _Latitudine, _Longitudine, _KmGps, _DataGPS, _KmManuali, _Localita, _Indirizzo, _Cap, _Provincia, _Nazione, _NoteInterne, _NoteEsterne, ApplyQuery: false, ref text2, ref rsmess);
			if ((int)val <= 0)
			{
				text += text2;
				goto IL_00fa;
			}
			val2 = val;
			goto end_IL_0015;
			IL_00fa:
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
						goto IL_0189;
					}
					val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
					if ((int)val <= 0)
					{
						goto IL_0189;
					}
					val2 = val;
				}
			}
			goto end_IL_0015;
			IL_0189:
			val = GestionePratiche(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				val = GestioneViaggio(ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = GestioneRiconsegna(ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						val = GestioneSpedizioneMadre(ref rsmess);
						val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
					}
				}
			}
			end_IL_0015:;
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
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Invalid comparison between Unknown and I4
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Invalid comparison between Unknown and I4
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Invalid comparison between Unknown and I4
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT S.Stato, S.StatoOBC, S.IdViaggio, S.TipoServizio, S.IdGiacenza, TS.Is_Consegna, TS.Is_Ritiro, TS.CreaGiacenza TS_CreaGiacenza, TS.CreaContestazione TS_CreaContestazione, S.UnibolSpedizioneCompleta, S.CountOfSubSpedizioni, S.Corrispondente ";
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
			else if (Conversions.ToInteger(_dtSpedizione.Rows[0]["STATO"]) < 40)
			{
				rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} non risulta in consegna", new string[1] { _Unibol });
			}
			else if (Conversions.ToInteger(_dtSpedizione.Rows[0]["STATO"]) >= 50)
			{
				rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} risulta già esitata", new string[1] { _Unibol });
			}
			else
			{
				_Stato = Conversions.ToInteger(_dtSpedizione.Rows[0]["STATO"]);
				_Corrispondente = _dtSpedizione.Rows[0]["Corrispondente"].ToString();
				_StatoOBC = Conversions.ToInteger(_dtSpedizione.Rows[0]["STATOOBC"].ToString());
				_IdViaggio = _dtSpedizione.Rows[0]["IdViaggio"].ToString();
				_IsConsegna = _dtSpedizione.Rows[0]["Is_Consegna"].ToString();
				_IsRitiro = _dtSpedizione.Rows[0]["Is_Ritiro"].ToString();
				if (Operators.CompareString(_dtSpedizione.Rows[0]["UnibolSpedizioneCompleta"].ToString(), "", false) == 0)
				{
					goto IL_03f2;
				}
				text = "SELECT SS.*, S.Evento_CodiceEsito FROM VW_Spedizioni S INNER JOIN Spedizioni_SubSpedizioni SS ON S.UnibolSpedizioneCompleta=SS.Unibol_Spedizione ";
				text = text + "WHERE S.Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " ";
				text += "ORDER BY SS.Sequenza";
				DataTable rObjDataTable = null;
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
				if ((int)val <= 0)
				{
					if (rObjDataTable.Rows.Count > 0)
					{
						_IdSpedizioneMadre = _dtSpedizione.Rows[0]["UnibolSpedizioneCompleta"].ToString();
						bool flag = true;
						foreach (object row in rObjDataTable.Rows)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(row);
							if (Operators.CompareString(rObjDataTable.Rows[0]["Unibol_SubSpedizione"].ToString(), _Unibol, false) == 0)
							{
								flag = false;
							}
							else if (flag)
							{
								_IdsSubSpedizioniPrecedenti.Add(rObjDataTable.Rows[0]["Unibol_SubSpedizione"].ToString());
							}
							else
							{
								_IdsSubSpedizioniSuccessive.Add(rObjDataTable.Rows[0]["Unibol_SubSpedizione"].ToString());
							}
						}
					}
					goto IL_03f2;
				}
				val2 = val;
			}
			goto end_IL_000b;
			IL_04a3:
			val2 = (FXRETURN)0;
			goto end_IL_000b;
			IL_03f2:
			text = "SELECT Codice FROM SpedizioniUds WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " AND Esito IS NULL";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtUds, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (_dtUds.Rows.Count <= 0)
				{
					goto IL_04a3;
				}
				object objRes = null;
				text = "SELECT EventoDefault FROM Eventi_Tipi WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(EventoSpedizioneTipo.UdsEsitoKo);
				val = ((AppBaseClass)this).DbConn.DoSql(text, "", ref objRes, ref rsmess);
				if ((int)val <= 0)
				{
					_EventoUds = objRes.ToString();
					goto IL_04a3;
				}
				val2 = val;
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

	protected FXRETURN CheckEvento(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT * FROM EVENTI WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(_CodiceEvento);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtEvento, ref rsmess);
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
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Invalid comparison between Unknown and I4
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Invalid comparison between Unknown and I4
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
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
			val = EventoSpedizione_ConsegnaKO.RunProc(this._ApiContext, _Unibol, ref _CodiceEvento, _Data, _Autista, _Motrice, _Rimorchio, _Contenitore, _Terminale, _Latitudine, _Longitudine, _KmGps, _DataGPS, _KmManuali, _Localita, _Indirizzo, _Cap, _Provincia, _Nazione, _NoteInterne, _NoteEsterne, ApplyQuery: false, ref text2, ref rsmess);
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
					goto IL_02f6;
				}
				val = EventoViaggio_Spedizione.RunProc(this._ApiContext, _IdViaggio, text3, _Unibol, _Data, _Autista, _Motrice, _Rimorchio, _Contenitore, _Terminale, _Latitudine, _Longitudine, _KmGps, _DataGPS, _KmManuali, _Localita, _Indirizzo, _Cap, _Provincia, _Nazione, _NoteEsterne, ApplyQuery: false, ref text2, ref rsmess);
				if ((int)val <= 0)
				{
					text += text2;
					goto IL_02f6;
				}
				val2 = val;
			}
			goto end_IL_0012;
			IL_02f6:
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

	protected virtual FXRETURN GestionePratiche(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Invalid comparison between Unknown and I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Invalid comparison between Unknown and I4
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (!(((Operators.CompareString(_dtSpedizione.Rows[0]["UnibolSpedizioneCompleta"].ToString(), "", false) == 0) & (Conversions.ToInteger(_dtSpedizione.Rows[0]["CountOfSubSpedizioni"]) == 0)) | (Operators.CompareString(_dtSpedizione.Rows[0]["UnibolSpedizioneCompleta"].ToString(), "", false) != 0)))
			{
				goto IL_026b;
			}
			if (!((Operators.CompareString(_dtEvento.Rows[0]["CREAGIACENZA"].ToString(), "A", false) == 0) & (Operators.CompareString(_dtSpedizione.Rows[0]["TS_CreaGiacenza"].ToString(), "S", false) == 0)) || Operators.CompareString(_dtSpedizione.Rows[0]["IdGiacenza"].ToString(), "", false) != 0)
			{
				goto IL_019b;
			}
			text2 = "";
			Giacenza_Crea_Invoker instance = Giacenza_Crea_Invoker.Instance;
			AppApiContext apiContext = this._ApiContext;
			string unibol = _Unibol;
			DateTime? data = _Data;
			int? IdGiacenza = null;
			val = instance.RunProc(apiContext, unibol, data, "", "", "", ApplyQuery: true, ref IdGiacenza, ref text2, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_019b;
			}
			val2 = val;
			goto end_IL_0012;
			IL_026b:
			val2 = (FXRETURN)0;
			goto end_IL_0012;
			IL_019b:
			if (!((Operators.CompareString(_dtEvento.Rows[0]["CREACONTESTAZIONE"].ToString(), "S", false) == 0) & (Operators.CompareString(_dtSpedizione.Rows[0]["TS_CreaContestazione"].ToString(), "S", false) == 0)))
			{
				goto IL_026b;
			}
			text2 = "";
			Contestazione_Crea_Invoker instance2 = Contestazione_Crea_Invoker.Instance;
			AppApiContext apiContext2 = this._ApiContext;
			string unibol2 = _Unibol;
			DateTime? data2 = _Data;
			IdGiacenza = null;
			val = instance2.RunProc(apiContext2, unibol2, "", null, "", "CON", data2, "CONTESTAZIONE APERTA DALL'ESITO DELLA SPEDIZIONE", "", "", ApplyQuery: true, ref IdGiacenza, ref text2, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_026b;
			}
			val2 = val;
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

	protected virtual FXRETURN GestioneViaggio(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Invalid comparison between Unknown and I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string sSql = "SELECT COUNT(*) FROM Spedizioni WHERE Stato<48 AND IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
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
					goto IL_0100;
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
						goto IL_0100;
					}
					Viaggio_Fine_Invoker instance = Viaggio_Fine_Invoker.Instance;
					AppApiContext apiContext = this._ApiContext;
					string idViaggio = _IdViaggio;
					DateTime? data = _Data;
					string RetQueryToApply = "";
					val = instance.RunProc(apiContext, idViaggio, doCheckSpedizioni: true, data, ApplyQuery: true, ref RetQueryToApply, ref rsmess);
					if ((int)val <= 0)
					{
						goto IL_0100;
					}
					val2 = val;
				}
			}
			goto end_IL_000b;
			IL_0100:
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

	protected virtual FXRETURN GestioneRiconsegna(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Invalid comparison between Unknown and I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_dtSpedizione.Rows[0]["UnibolSpedizioneCompleta"].ToString(), "", false) != 0)
			{
				goto IL_0151;
			}
			if (Operators.CompareString(_dtEvento.Rows[0]["ANNULLAMENTO"].ToString(), "S", false) != 0)
			{
				goto IL_00b5;
			}
			val = Spedizione_AnnullaDaEsito_Invoker.Instance.RunProc(this._ApiContext, _Unibol, "", ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_00b5;
			}
			val2 = val;
			goto end_IL_000b;
			IL_00b5:
			bool flag = false;
			if (_ForzaGenerazioneRiconsegna.HasValue)
			{
				flag = _ForzaGenerazioneRiconsegna.Value;
			}
			else if (Operators.CompareString(_dtEvento.Rows[0]["GENERARICONSEGNA"].ToString(), "S", false) == 0)
			{
				flag = true;
			}
			if (!flag)
			{
				goto IL_0151;
			}
			Spedizione_Riconsegna_Invoker instance = Spedizione_Riconsegna_Invoker.Instance;
			AppApiContext apiContext = this._ApiContext;
			string unibol = _Unibol;
			string RetQueryToApply = "";
			val = instance.RunProc(apiContext, unibol, ApplyQuery: true, ref RetQueryToApply, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_0151;
			}
			val2 = val;
			goto end_IL_000b;
			IL_0151:
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

	protected virtual FXRETURN GestioneSpedizioneMadre(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Invalid comparison between Unknown and I4
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Invalid comparison between Unknown and I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Invalid comparison between Unknown and I4
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_dtSpedizione.Rows[0]["UnibolSpedizioneCompleta"].ToString(), "", false) == 0)
			{
				goto IL_01b5;
			}
			if (!((Operators.CompareString(_IdSpedizioneMadre, "", false) != 0) & (_IdsSubSpedizioniSuccessive.Count == 0)))
			{
				if ((Operators.CompareString(_IdSpedizioneMadre, "", false) != 0) & (_IdsSubSpedizioniSuccessive.Count > 0))
				{
					StringEnumerator enumerator = _IdsSubSpedizioniSuccessive.GetEnumerator();
					object objRes = default(object);
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						string sSql = "SELECT Evento_CodiceEsito FROM VW_SPEDIZIONI WHERE UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(current);
						val = ((AppBaseClass)this).DbConn.DoSql(sSql, "", ref objRes, ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							if (Operators.CompareString(objRes.ToString(), "", false) != 0)
							{
								continue;
							}
							val = Spedizione_ConsegnaKO_Invoker.Instance.RunProc(this._ApiContext, current, _CodiceEvento, _Data, _NoteInterne, _NoteEsterne, ref rsmess);
							if ((int)val <= 0)
							{
								continue;
							}
							val2 = val;
						}
						goto end_IL_000b;
					}
				}
				goto IL_01b5;
			}
			val = Spedizione_ConsegnaKO_Invoker.Instance.RunProc(this._ApiContext, _IdSpedizioneMadre, _CodiceEvento, _Data, _NoteInterne, _NoteEsterne, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_01b5;
			}
			val2 = val;
			goto end_IL_000b;
			IL_01b5:
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
}
