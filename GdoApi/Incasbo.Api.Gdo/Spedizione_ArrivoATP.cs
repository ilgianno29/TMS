using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Spedizione_ArrivoATP : AppAbstractApi
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

	protected bool _ApplyQuery;

	protected int _StatoOBC;

	protected string _IdViaggio;

	protected string _IsRitiro;

	protected string _IsConsegna;

	protected bool _doIt;

	public Spedizione_ArrivoATP(AppApiContext objApiContext)
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
		_ApplyQuery = true;
		_StatoOBC = 0;
		_IdViaggio = "";
		_IsRitiro = "";
		_IsConsegna = "";
		_doIt = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Invalid comparison between Unknown and I4
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			((AppAbstractApi)this).ParametersOut.Add("RetQueryToApply", "");
			((AppAbstractApi)this).ParametersOut.Add("Warning", "");
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ApplyQuery"))
			{
				_ApplyQuery = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ApplyQuery"]);
			}
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
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Invalid comparison between Unknown and I4
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Invalid comparison between Unknown and I4
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Invalid comparison between Unknown and I4
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Invalid comparison between Unknown and I4
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Invalid comparison between Unknown and I4
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Invalid comparison between Unknown and I4
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		string text2 = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (!_doIt)
			{
				((AppAbstractApi)this).ParametersOut["Warning"] = this.TranslateMessage("XXX", "Corrispondente non valorizzato.");
				goto IL_049a;
			}
			text += "UPDATE Spedizioni SET Stato=CASE WHEN STATO<=48 THEN 48 ELSE STATO END, ";
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
			val = EventoSpedizione_ArrivoATP.RunProc(this._ApiContext, _Unibol, ref _CodiceEvento, _Data, _Autista, _Motrice, _Rimorchio, _Contenitore, _Terminale, _Latitudine, _Longitudine, _KmGps, _DataGPS, _KmManuali, _Localita, _Indirizzo, _Cap, _Provincia, _Nazione, _NoteInterne, _NoteEsterne, ApplyQuery: false, ref text2, ref rsmess);
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
					goto IL_0310;
				}
				val = EventoViaggio_Spedizione.RunProc(this._ApiContext, _IdViaggio, text3, _Unibol, _Data, _Autista, _Motrice, _Rimorchio, _Contenitore, _Terminale, _Latitudine, _Longitudine, _KmGps, _DataGPS, _KmManuali, _Localita, _Indirizzo, _Cap, _Provincia, _Nazione, this.TranslateMessage("XXX", "Arrivo A Corrispondente".ToUpper()), ApplyQuery: false, ref text2, ref rsmess);
				if ((int)val <= 0)
				{
					text += text2;
					goto IL_0310;
				}
				val2 = val;
			}
			goto end_IL_0012;
			IL_041c:
			if (!_ApplyQuery)
			{
				((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = text;
				goto IL_049a;
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				goto IL_049a;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_049a;
			}
			val2 = val;
			goto end_IL_0012;
			IL_0310:
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
					goto IL_041c;
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
						goto IL_041c;
					}
					text2 = "";
					val = Viaggio_Fine_Invoker.Instance.RunProc(this._ApiContext, _IdViaggio, doCheckSpedizioni: false, _Data, ApplyQuery: false, ref text2, ref rsmess);
					if ((int)val <= 0)
					{
						text += text2;
						goto IL_041c;
					}
					val2 = val;
				}
			}
			goto end_IL_0012;
			IL_049a:
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

	protected FXRETURN CheckSpedizione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		DataTable rObjDataTable = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "SELECT S.Stato, S.StatoOBC, S.IdViaggio, S.TipoServizio, TS.Is_Consegna, TS.Is_Ritiro, S.Corrispondente FROM Spedizioni S INNER JOIN TipiServizi TS ON TS.Codice=S.TipoServizio WHERE S.Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref rObjDataTable, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (rObjDataTable.Rows.Count == 0)
			{
				rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} non è presente a sistema", new string[1] { _Unibol });
			}
			else
			{
				if (Operators.CompareString(rObjDataTable.Rows[0]["Corrispondente"].ToString(), "", false) == 0)
				{
					_doIt = false;
				}
				if (!_doIt)
				{
					goto IL_0251;
				}
				_StatoOBC = Conversions.ToInteger(rObjDataTable.Rows[0]["STATOOBC"].ToString());
				_IdViaggio = rObjDataTable.Rows[0]["IdViaggio"].ToString();
				_IsConsegna = rObjDataTable.Rows[0]["Is_Consegna"].ToString();
				_IsRitiro = rObjDataTable.Rows[0]["Is_Ritiro"].ToString();
				if (Conversions.ToInteger(rObjDataTable.Rows[0]["STATO"]) < 40)
				{
					rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} non risulta in consegna", new string[1] { _Unibol });
				}
				else if (Conversions.ToInteger(rObjDataTable.Rows[0]["STATO"]) == 48)
				{
					rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} risulta già esitata a Transit Point", new string[1] { _Unibol });
				}
				else
				{
					if (Conversions.ToInteger(rObjDataTable.Rows[0]["STATO"]) < 50)
					{
						goto IL_0251;
					}
					rsmess = this.TranslateMessage("XXX", "La Spedizione con Id={0} risulta già esitata", new string[1] { _Unibol });
				}
			}
			goto end_IL_000e;
			IL_0251:
			val2 = (FXRETURN)0;
			end_IL_000e:;
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
