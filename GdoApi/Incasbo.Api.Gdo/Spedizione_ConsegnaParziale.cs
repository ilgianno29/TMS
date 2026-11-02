using System;
using System.Collections.Specialized;
using System.Data;
using System.Runtime.CompilerServices;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_ConsegnaParziale : AppAbstractApi
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

	public Spedizione_ConsegnaParziale(AppApiContext objApiContext)
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
		//IL_0a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Invalid comparison between Unknown and I4
		//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Invalid comparison between Unknown and I4
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Invalid comparison between Unknown and I4
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Invalid comparison between Unknown and I4
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Invalid comparison between Unknown and I4
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_078c: Invalid comparison between Unknown and I4
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Invalid comparison between Unknown and I4
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Invalid comparison between Unknown and I4
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_091f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0921: Invalid comparison between Unknown and I4
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Invalid comparison between Unknown and I4
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Invalid comparison between Unknown and I4
		//IL_09a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09af: Invalid comparison between Unknown and I4
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Invalid comparison between Unknown and I4
		//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a11: Unknown result type (might be due to invalid IL or missing references)
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
			if (Operators.CompareString(_EventoUds, "", false) != 0 && _dtUds.Rows.Count > 0)
			{
				text = "UPDATE SpedizioniUds SET Esito=" + ((AppBaseClass)this).DbConn.SQLFormatString(_EventoUds) + ", ";
				text = text + "DataEsito=" + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, _Data) + " ";
				text = text + "WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " ";
				text += "AND Esito IS NULL;";
			}
			if (!((_Stato == 40) & (Operators.CompareString(_Corrispondente, "", false) != 0)))
			{
				goto IL_01a6;
			}
			text2 = "";
			AppApiContext apiContext = this._ApiContext;
			string unibol = _Unibol;
			string CodiceEvento = "";
			val = EventoSpedizione_ArrivoATP.RunProc(apiContext, unibol, ref CodiceEvento, _Data, _Autista, _Motrice, _Rimorchio, _Contenitore, _Terminale, _Latitudine, _Longitudine, _KmGps, _DataGPS, _KmManuali, _Localita, _Indirizzo, _Cap, _Provincia, _Nazione, _NoteInterne, _NoteEsterne, ApplyQuery: false, ref text2, ref rsmess);
			if ((int)val <= 0)
			{
				text += text2;
				goto IL_01a6;
			}
			val2 = val;
			goto end_IL_0015;
			IL_06fd:
			string sSql = "SELECT COUNT(*) FROM Spedizioni WHERE Stato<48 AND IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio);
			obj = null;
			val = ((AppBaseClass)this).DbConn.DoSql(sSql, ref obj, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (Conversions.ToInteger(obj) != 0)
				{
					goto IL_07ea;
				}
				sSql = "SELECT COUNT(*) FROM Viaggi WHERE IdViaggio=" + ((AppBaseClass)this).DbConn.SQLFormatString(_IdViaggio) + " AND Terminale IS NULL AND FlagViaggioSospeso='N'";
				obj = null;
				val = ((AppBaseClass)this).DbConn.DoSql(sSql, ref obj, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (Conversions.ToInteger(obj) <= 0)
					{
						goto IL_07ea;
					}
					Viaggio_Fine_Invoker instance = Viaggio_Fine_Invoker.Instance;
					AppApiContext apiContext2 = this._ApiContext;
					string idViaggio = _IdViaggio;
					DateTime? data = _Data;
					CodiceEvento = "";
					val = instance.RunProc(apiContext2, idViaggio, doCheckSpedizioni: true, data, ApplyQuery: true, ref CodiceEvento, ref rsmess);
					if ((int)val <= 0)
					{
						goto IL_07ea;
					}
					val2 = val;
				}
			}
			goto end_IL_0015;
			IL_062a:
			if (!((Operators.CompareString(_dtEvento.Rows[0]["CREACONTESTAZIONE"].ToString(), "S", false) == 0) & (Operators.CompareString(_dtSpedizione.Rows[0]["TS_CreaContestazione"].ToString(), "S", false) == 0)))
			{
				goto IL_06fd;
			}
			text2 = "";
			Contestazione_Crea_Invoker instance2 = Contestazione_Crea_Invoker.Instance;
			AppApiContext apiContext3 = this._ApiContext;
			string unibol2 = _Unibol;
			DateTime? data2 = _Data;
			int? IdContestazione = null;
			val = instance2.RunProc(apiContext3, unibol2, "", null, "", "CON", data2, "CONTESTAZIONE APERTA DALL'ESITO DELLA SPEDIZIONE", "", "", ApplyQuery: true, ref IdContestazione, ref text2, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_06fd;
			}
			val2 = val;
			goto end_IL_0015;
			IL_0a2a:
			val2 = (FXRETURN)0;
			goto end_IL_0015;
			IL_0478:
			if (Operators.CompareString(text, "", false) == 0)
			{
				goto IL_04af;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_04af;
			}
			val2 = val;
			goto end_IL_0015;
			IL_07ea:
			if (Operators.CompareString(_dtSpedizione.Rows[0]["UnibolSpedizioneCompleta"].ToString(), "", false) == 0)
			{
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
					goto IL_0a2a;
				}
				Spedizione_Riconsegna_Invoker instance3 = Spedizione_Riconsegna_Invoker.Instance;
				AppApiContext apiContext4 = this._ApiContext;
				string unibol3 = _Unibol;
				CodiceEvento = "";
				val = instance3.RunProc(apiContext4, unibol3, ApplyQuery: true, ref CodiceEvento, ref rsmess);
				if ((int)val <= 0)
				{
					goto IL_0a2a;
				}
				val2 = val;
			}
			else
			{
				if (!((Operators.CompareString(_IdSpedizioneMadre, "", false) != 0) & (_IdsSubSpedizioniSuccessive.Count == 0)))
				{
					if ((Operators.CompareString(_IdSpedizioneMadre, "", false) != 0) & (_IdsSubSpedizioniSuccessive.Count > 0))
					{
						StringEnumerator enumerator = _IdsSubSpedizioniSuccessive.GetEnumerator();
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							sSql = "SELECT Evento_CodiceEsito FROM VW_SPEDIZIONI WHERE UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(current);
							val = ((AppBaseClass)this).DbConn.DoSql(sSql, "", ref obj, ref rsmess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								if (Operators.CompareString(obj.ToString(), "", false) != 0)
								{
									continue;
								}
								val = Spedizione_ConsegnaParziale_Invoker.Instance.RunProc(this._ApiContext, current, _CodiceEvento, _Data, _NoteInterne, _NoteEsterne, ref rsmess);
								if ((int)val <= 0)
								{
									continue;
								}
								val2 = val;
							}
							goto end_IL_0015;
						}
					}
					goto IL_0a2a;
				}
				val = Spedizione_ConsegnaParziale_Invoker.Instance.RunProc(this._ApiContext, _IdSpedizioneMadre, _CodiceEvento, _Data, _NoteInterne, _NoteEsterne, ref rsmess);
				if ((int)val <= 0)
				{
					goto IL_0a2a;
				}
				val2 = val;
			}
			goto end_IL_0015;
			IL_01a6:
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
			val = EventoSpedizione_ConsegnaParziale.RunProc(this._ApiContext, _Unibol, _CodiceEvento, _Data, _Autista, _Motrice, _Rimorchio, _Contenitore, _Terminale, _Latitudine, _Longitudine, _KmGps, _DataGPS, _KmManuali, _Localita, _Indirizzo, _Cap, _Provincia, _Nazione, _NoteInterne, _NoteEsterne, ApplyQuery: false, ref text2, ref rsmess);
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
					goto IL_0478;
				}
				val = EventoViaggio_Spedizione.RunProc(this._ApiContext, _IdViaggio, text3, _Unibol, _Data, _Autista, _Motrice, _Rimorchio, _Contenitore, _Terminale, _Latitudine, _Longitudine, _KmGps, _DataGPS, _KmManuali, _Localita, _Indirizzo, _Cap, _Provincia, _Nazione, _NoteEsterne, ApplyQuery: false, ref text2, ref rsmess);
				if ((int)val <= 0)
				{
					text += text2;
					goto IL_0478;
				}
				val2 = val;
			}
			goto end_IL_0015;
			IL_04af:
			if (!(((Operators.CompareString(_dtSpedizione.Rows[0]["UnibolSpedizioneCompleta"].ToString(), "", false) == 0) & (Conversions.ToInteger(_dtSpedizione.Rows[0]["CountOfSubSpedizioni"]) == 0)) | (Operators.CompareString(_dtSpedizione.Rows[0]["UnibolSpedizioneCompleta"].ToString(), "", false) != 0)))
			{
				goto IL_06fd;
			}
			if (!((Operators.CompareString(_dtEvento.Rows[0]["CREAGIACENZA"].ToString(), "A", false) == 0) & (Operators.CompareString(_dtSpedizione.Rows[0]["TS_CreaGiacenza"].ToString(), "S", false) == 0)) || Operators.CompareString(_dtSpedizione.Rows[0]["IdGiacenza"].ToString(), "", false) != 0)
			{
				goto IL_062a;
			}
			text2 = "";
			Giacenza_Crea_Invoker instance4 = Giacenza_Crea_Invoker.Instance;
			AppApiContext apiContext5 = this._ApiContext;
			string unibol4 = _Unibol;
			DateTime? data3 = _Data;
			IdContestazione = null;
			val = instance4.RunProc(apiContext5, unibol4, data3, "", "", "", ApplyQuery: true, ref IdContestazione, ref text2, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_062a;
			}
			val2 = val;
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
}
