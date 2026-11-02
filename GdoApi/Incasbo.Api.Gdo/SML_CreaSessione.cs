using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class SML_CreaSessione : SimulationAbstractApi
{
	protected int? _IdSessione;

	protected DateTime? _Data;

	protected string _Descrizione;

	protected StringCollection _IdGiri;

	protected StringCollection _PCSLiberi;

	protected DataTable _dtGiriTestata;

	protected DataTable _dtGiriDettagli;

	protected DataTable _dtPCSLiberi;

	protected SML_Model _SML_Model;

	protected DateTime? _OraDisponibilitaInizio;

	protected DateTime? _OraDisponibilitaFine;

	protected SML_Viaggio _PrimoViaggio;

	[SpecialName]
	private int _0024STATIC_0024GeneraMezzo_002420811809910EEEEEEE10E_0024CodiceMezzoAutomatico;

	public SML_CreaSessione(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Descrizione = "";
		_dtGiriTestata = null;
		_dtGiriDettagli = null;
		_dtPCSLiberi = null;
		_SML_Model = new SML_Model();
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Invalid comparison between Unknown and I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Invalid comparison between Unknown and I4
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Invalid comparison between Unknown and I4
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_IdGiri = (StringCollection)((AppAbstractApi)this).ParametersIn["IdGiri"];
			_PCSLiberi = (StringCollection)((AppAbstractApi)this).ParametersIn["PCSLiberi"];
			_Data = (DateTime?)((AppAbstractApi)this).ParametersIn["Data"];
			if (!_Data.HasValue)
			{
				_Data = DateAndTime.Now.Date;
			}
			_Descrizione = ((AppAbstractApi)this).ParametersIn["Descrizione"].ToString();
			if (Operators.CompareString(_Descrizione, "", false) == 0)
			{
				_Descrizione = "Sessione di simulazione del " + _Data.Value.ToString("dd/MM/yyyy");
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("OraDisponibilitaInizio"))
			{
				DateTime? dateTime = (DateTime?)((AppAbstractApi)this).ParametersIn["OraDisponibilitaInizio"];
				if (dateTime.HasValue)
				{
					_OraDisponibilitaInizio = _Data.Value.Date.AddHours(dateTime.Value.Hour).AddMinutes(dateTime.Value.Minute).AddSeconds(dateTime.Value.Second);
				}
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("OraDisponibilitaFine"))
			{
				DateTime? dateTime2 = (DateTime?)((AppAbstractApi)this).ParametersIn["OraDisponibilitaFine"];
				if (dateTime2.HasValue)
				{
					_OraDisponibilitaFine = _Data.Value.Date.AddHours(dateTime2.Value.Hour).AddMinutes(dateTime2.Value.Minute).AddSeconds(dateTime2.Value.Second);
				}
			}
			string text = "SELECT T.* FROM SML_GiriTestata T WHERE (";
			StringEnumerator enumerator = _IdGiri.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				text = text + "Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(current) + " OR ";
			}
			text += "1=2) AND (Attivo='S') AND ((SELECT COUNT(*) FROM SML_GiriDettagli D WHERE D.CODICE=T.CODICE)>0)";
			val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtGiriTestata, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				text = "SELECT * FROM SML_GiriDettagli WHERE ";
				foreach (DataRow row in _dtGiriTestata.Rows)
				{
					text = text + "Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(row["Codice"].ToString()) + " OR ";
				}
				text += "1=2";
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtGiriDettagli, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					text = "SELECT * FROM PCS WHERE ";
					StringEnumerator enumerator3 = _PCSLiberi.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						string current2 = enumerator3.Current;
						text = text + "Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(current2) + " OR ";
					}
					text += "1=2";
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtPCSLiberi, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						((AppAbstractApi)this).ParametersOut.Add("IdSessione", null);
						val2 = (FXRETURN)0;
					}
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Invalid comparison between Unknown and I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Invalid comparison between Unknown and I4
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = GeneraSessione(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				foreach (DataRow row in _dtGiriTestata.Rows)
				{
					val = GeneraViaggio(row, ref rsmess);
					if ((int)val <= 0)
					{
						continue;
					}
					val2 = val;
					goto end_IL_000b;
				}
				foreach (DataRow row2 in _dtPCSLiberi.Rows)
				{
					val = GeneraSpedizioneLibera(row2, ref rsmess);
					if ((int)val <= 0)
					{
						continue;
					}
					val2 = val;
					goto end_IL_000b;
				}
				val = PersistToDB(ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					((AppAbstractApi)this).ParametersOut["IdSessione"] = _IdSessione.Value;
					val2 = (FXRETURN)0;
				}
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

	protected virtual FXRETURN GeneraSessione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			long rlReturnValue = default(long);
			val = ((AppBaseClass)this).Parametrica.LeggiContatore("COUNTERS.SIMULAZIONE.ID", vbStartTrans: false, ref rlReturnValue, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				_IdSessione = Conversions.ToInteger(Strings.Right(rlReturnValue.ToString(), 4));
				_SML_Model.SML_Sessione.IdSessione = _IdSessione.Value;
				_SML_Model.SML_Sessione.Descrizione = _Descrizione;
				_SML_Model.SML_Sessione.Data = _Data.Value;
				_SML_Model.SML_Sessione.Utente = this._User;
				_SML_Model.SML_Sessione.UteAgg = this._User;
				_SML_Model.SML_Sessione.UteIns = this._User;
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

	protected virtual FXRETURN GeneraMezzo(ref string CodiceMezzo, string TipoMezzo, string TipoMerce, string PCSPartenza, string PCSArrivo, string ZonaSpedizione, string Trasportatore, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Invalid comparison between Unknown and I4
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			SML_MezzoDisponibilita sML_MezzoDisponibilita;
			DataTable rObjDataTable;
			checked
			{
				if (Operators.CompareString(CodiceMezzo, "", false) == 0)
				{
					CodiceMezzo = _SML_Model.SML_Sessione.IdSessione.ToString().PadLeft(4, '0') + _0024STATIC_0024GeneraMezzo_002420811809910EEEEEEE10E_0024CodiceMezzoAutomatico.ToString().PadLeft(2, '0');
					_0024STATIC_0024GeneraMezzo_002420811809910EEEEEEE10E_0024CodiceMezzoAutomatico++;
				}
				if (!_SML_Model.ListOfSML_Mezzi.ContainsKey(CodiceMezzo))
				{
					SML_Mezzo sML_Mezzo = new SML_Mezzo();
					sML_Mezzo.Codice = CodiceMezzo;
					sML_Mezzo.TipoMezzo = TipoMezzo;
					sML_Mezzo.IdSessione = _IdSessione.Value;
					sML_Mezzo.Descrizione = "Mezzo di simulazione ".ToUpper() + CodiceMezzo;
					sML_Mezzo.PuntoPartenza = PCSPartenza;
					sML_Mezzo.PuntoArrivo = PCSArrivo;
					sML_Mezzo.TipoMerce = TipoMerce;
					sML_Mezzo.DispDalleOre = _OraDisponibilitaInizio;
					sML_Mezzo.DispDalleOre = _OraDisponibilitaFine;
					sML_Mezzo.Targa = "XXXXXX";
					sML_Mezzo.IdSessione = _SML_Model.SML_Sessione.IdSessione;
					sML_Mezzo.UteAgg = this._User;
					sML_Mezzo.UteIns = this._User;
					sML_Mezzo.Trasportatore = Trasportatore;
					_SML_Model.ListOfSML_Mezzi.Add(CodiceMezzo, sML_Mezzo);
				}
				if (_SML_Model.ListOfSML_MezziDisponibilita.ContainsKey(CodiceMezzo))
				{
					goto IL_042d;
				}
				sML_MezzoDisponibilita = new SML_MezzoDisponibilita();
				sML_MezzoDisponibilita.Mezzo = CodiceMezzo;
				sML_MezzoDisponibilita.Data = _SML_Model.SML_Sessione.Data;
				sML_MezzoDisponibilita.IdSessione = _SML_Model.SML_Sessione.IdSessione;
				sML_MezzoDisponibilita.PuntoPartenza = PCSPartenza;
				sML_MezzoDisponibilita.PuntoArrivo = PCSArrivo;
				sML_MezzoDisponibilita.TipoMerce = TipoMerce;
				sML_MezzoDisponibilita.TipoMezzo = TipoMezzo;
				sML_MezzoDisponibilita.ZonaSpedizione = ZonaSpedizione;
				sML_MezzoDisponibilita.DispDalleOre = _OraDisponibilitaInizio;
				sML_MezzoDisponibilita.DispAlleOre = _OraDisponibilitaFine;
				if (!(!sML_MezzoDisponibilita.DispDalleOre.HasValue | !sML_MezzoDisponibilita.DispAlleOre.HasValue))
				{
					goto IL_03d6;
				}
				string vsSQLClause = "SELECT * FROM TipiMezzo WHERE Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(sML_MezzoDisponibilita.TipoMezzo);
				rObjDataTable = null;
				val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref rObjDataTable, ref rsmess);
			}
			if ((int)val <= 0)
			{
				DateTime? dateTime = (DateTime?)rObjDataTable.Rows[0]["DispDalleOre"];
				if (dateTime.HasValue)
				{
					sML_MezzoDisponibilita.DispDalleOre = _SML_Model.SML_Sessione.Data.Date.AddHours(dateTime.Value.Hour).AddMinutes(dateTime.Value.Minute).AddSeconds(dateTime.Value.Second);
				}
				dateTime = (DateTime?)rObjDataTable.Rows[0]["DispAlleOre"];
				if (dateTime.HasValue)
				{
					sML_MezzoDisponibilita.DispAlleOre = _SML_Model.SML_Sessione.Data.Date.AddHours(dateTime.Value.Hour).AddMinutes(dateTime.Value.Minute).AddSeconds(dateTime.Value.Second);
				}
				goto IL_03d6;
			}
			val2 = val;
			goto end_IL_0005;
			IL_03d6:
			sML_MezzoDisponibilita.Tipologia = "R";
			sML_MezzoDisponibilita.TipologiaRecord = "D";
			sML_MezzoDisponibilita.UteAgg = this._User;
			sML_MezzoDisponibilita.UteIns = this._User;
			sML_MezzoDisponibilita.Trasportatore = Trasportatore;
			_SML_Model.ListOfSML_MezziDisponibilita.Add(CodiceMezzo, sML_MezzoDisponibilita);
			goto IL_042d;
			IL_042d:
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

	protected virtual FXRETURN GeneraViaggio(DataRow GiroTestata, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Invalid comparison between Unknown and I4
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Invalid comparison between Unknown and I4
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			SML_Viaggio sML_Viaggio = new SML_Viaggio();
			long rlReturnValue = default(long);
			val = ((AppBaseClass)this).Parametrica.LeggiContatore("COUNTERS.SIMULAZIONE.IDVIAGGIO", vbStartTrans: false, ref rlReturnValue, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				sML_Viaggio.IdViaggio = checked((int)rlReturnValue);
				sML_Viaggio.IdSessione = _SML_Model.SML_Sessione.IdSessione;
				sML_Viaggio.CodiceGiro = GiroTestata["Codice"].ToString();
				sML_Viaggio.Stato = 0;
				sML_Viaggio.TipoViaggio = GiroTestata["TipoViaggio"].ToString();
				if (Operators.CompareString(sML_Viaggio.TipoViaggio, "", false) == 0)
				{
					sML_Viaggio.TipoViaggio = base.ApplicationDefault.TipoViaggio_Default();
				}
				if (Operators.CompareString(sML_Viaggio.TipoViaggio, "", false) == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Impossibile determinare il tipo viaggio di default");
				}
				else
				{
					sML_Viaggio.DataPartenza = _SML_Model.SML_Sessione.Data.AddMinutes(checked(Conversions.ToDate(GiroTestata["OraPartenza"]).Hour * 60 + Conversions.ToDate(GiroTestata["OraPartenza"]).Minute));
					sML_Viaggio.Mezzo = GiroTestata["Mezzo"].ToString();
					sML_Viaggio.TipoMezzo = GiroTestata["TipoMezzo"].ToString();
					if (Operators.CompareString(sML_Viaggio.TipoMezzo, "", false) == 0)
					{
						sML_Viaggio.TipoMezzo = base.ApplicationDefault.TipoMezzoDefault();
					}
					if (Operators.CompareString(sML_Viaggio.TipoMezzo, "", false) == 0)
					{
						sML_Viaggio.TipoMezzo = "*ALL";
					}
					sML_Viaggio.Vettore = GiroTestata["Trasportatore"].ToString();
					if (Operators.CompareString(sML_Viaggio.Vettore, "", false) == 0)
					{
						sML_Viaggio.Vettore = base.ApplicationDefault.Trasportatore_Default();
					}
					if (Operators.CompareString(sML_Viaggio.Vettore, "", false) == 0)
					{
						sML_Viaggio.Vettore = "*ALL";
					}
					sML_Viaggio.Autista = GiroTestata["Autista"].ToString();
					sML_Viaggio.TipoSpedizione = GiroTestata["TipoSpedizione"].ToString();
					if (Operators.CompareString(sML_Viaggio.TipoSpedizione, "", false) == 0)
					{
						sML_Viaggio.TipoSpedizione = base.ApplicationDefault.TipoSpedizioneDefault();
					}
					if (Operators.CompareString(sML_Viaggio.TipoSpedizione, "", false) == 0)
					{
						sML_Viaggio.TipoSpedizione = "*ALL";
					}
					sML_Viaggio.TipoMerce = GiroTestata["TipoMerce"].ToString();
					if (Operators.CompareString(sML_Viaggio.TipoMerce, "", false) == 0)
					{
						sML_Viaggio.TipoMerce = base.ApplicationDefault.TipoMerceDefault();
					}
					if (Operators.CompareString(sML_Viaggio.TipoMerce, "", false) == 0)
					{
						sML_Viaggio.TipoMerce = "*ALL";
					}
					sML_Viaggio.PCSPartenza = GiroTestata["DepositoPartenza"].ToString();
					if (Operators.CompareString(sML_Viaggio.PCSPartenza, "", false) == 0)
					{
						sML_Viaggio.PCSPartenza = base.ApplicationDefault.PCS_Partenza_Default();
					}
					if (Operators.CompareString(sML_Viaggio.PCSPartenza, "", false) == 0)
					{
						rsmess = this.TranslateMessage("XXX", "Impossibile determinare il deposito di partenza di default");
					}
					else
					{
						sML_Viaggio.PCSArrivo = GiroTestata["DepositoArrivo"].ToString();
						if (Operators.CompareString(sML_Viaggio.PCSArrivo, "", false) == 0)
						{
							sML_Viaggio.PCSArrivo = base.ApplicationDefault.PCS_Partenza_Default();
						}
						if (Operators.CompareString(sML_Viaggio.PCSArrivo, "", false) == 0)
						{
							rsmess = this.TranslateMessage("XXX", "Impossibile determinare il deposito di arrivo di default");
						}
						else
						{
							sML_Viaggio.ZonaSpedizione = GiroTestata["ZonaSpedizione"].ToString();
							if (Operators.CompareString(sML_Viaggio.ZonaSpedizione, "", false) == 0)
							{
								sML_Viaggio.ZonaSpedizione = "*ALL";
							}
							sML_Viaggio.Macrozona = GiroTestata["Macrozona"].ToString();
							if (Operators.CompareString(sML_Viaggio.Macrozona, "", false) == 0)
							{
								sML_Viaggio.Macrozona = "*ALL";
							}
							sML_Viaggio.FillerAlfa1 = GiroTestata["Filler1"].ToString();
							sML_Viaggio.FillerAlfa2 = GiroTestata["Filler2"].ToString();
							sML_Viaggio.FillerAlfa3 = GiroTestata["Filler3"].ToString();
							sML_Viaggio.FillerAlfa4 = GiroTestata["Filler4"].ToString();
							sML_Viaggio.FillerAlfa5 = GiroTestata["Filler5"].ToString();
							sML_Viaggio.Note1 = GiroTestata["Nota"].ToString();
							sML_Viaggio.UteAgg = this._User;
							sML_Viaggio.UteIns = this._User;
							if (_PrimoViaggio == null)
							{
								_PrimoViaggio = sML_Viaggio;
							}
							_SML_Model.ListOfSML_Viaggi.Add(sML_Viaggio.IdViaggio.ToString(), sML_Viaggio);
							string CodiceMezzo = sML_Viaggio.Mezzo;
							val = GeneraMezzo(ref CodiceMezzo, sML_Viaggio.TipoMezzo, sML_Viaggio.TipoMerce, sML_Viaggio.PCSPartenza, sML_Viaggio.PCSArrivo, sML_Viaggio.ZonaSpedizione, sML_Viaggio.Vettore, ref rsmess);
							if ((int)val > 0)
							{
								val2 = val;
							}
							else
							{
								sML_Viaggio.Mezzo = CodiceMezzo;
								DataRow[] array = _dtGiriDettagli.Select("Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(sML_Viaggio.CodiceGiro), "Sequenza ASC");
								DataRow[] array2 = array;
								int num = 0;
								while (true)
								{
									if (num < array2.Length)
									{
										DataRow giroDettaglio = array2[num];
										val = GeneraSpedizione(giroDettaglio, sML_Viaggio, ref rsmess);
										if ((int)val > 0)
										{
											val2 = val;
											break;
										}
										num = checked(num + 1);
										continue;
									}
									val2 = (FXRETURN)0;
									break;
								}
							}
						}
					}
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

	protected FXRETURN GeneraSpedizione(DataRow GiroDettaglio, SML_Viaggio ViaggioAssociato, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Invalid comparison between Unknown and I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			SML_Spedizione sML_Spedizione = new SML_Spedizione();
			long rlReturnValue = default(long);
			val = ((AppBaseClass)this).Parametrica.LeggiContatore("COUNTERS.SIMULAZIONE.UNIBOL", vbStartTrans: false, ref rlReturnValue, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				sML_Spedizione.Unibol = rlReturnValue.ToString();
				sML_Spedizione.IdSessione = _SML_Model.SML_Sessione.IdSessione;
				sML_Spedizione.CodiceGiro = GiroDettaglio["Codice"].ToString();
				sML_Spedizione.Stato = 20;
				sML_Spedizione.Cliente = "*ALL";
				sML_Spedizione.NumeroBolla = sML_Spedizione.Unibol;
				sML_Spedizione.DataBolla = _SML_Model.SML_Sessione.Data;
				sML_Spedizione.NumeroOrdine = sML_Spedizione.Unibol;
				sML_Spedizione.DataOrdine = _SML_Model.SML_Sessione.Data;
				sML_Spedizione.TipoSpedizione = ViaggioAssociato.TipoSpedizione;
				sML_Spedizione.TipoMerce = ViaggioAssociato.TipoMerce;
				sML_Spedizione.PCSPartenza = ViaggioAssociato.PCSPartenza;
				string vsSQLClause = "SELECT * FROM PCS WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(sML_Spedizione.PCSPartenza);
				DataTable rObjDataTable = null;
				val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref rObjDataTable, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					sML_Spedizione.PCSPartenza_RagSoc = rObjDataTable.Rows[0]["RagioneSociale"].ToString();
					sML_Spedizione.PCSPartenza_Indirizzo = rObjDataTable.Rows[0]["Indirizzo"].ToString();
					sML_Spedizione.PCSPartenza_Cap = rObjDataTable.Rows[0]["Cap"].ToString();
					sML_Spedizione.PCSPartenza_Localita = rObjDataTable.Rows[0]["Localita"].ToString();
					sML_Spedizione.PCSPartenza_Provincia = rObjDataTable.Rows[0]["Provincia"].ToString();
					sML_Spedizione.PCSPartenza_Nazione = rObjDataTable.Rows[0]["Nazione"].ToString();
					sML_Spedizione.PCSDestinazione = GiroDettaglio["PCS"].ToString();
					vsSQLClause = "SELECT * FROM PCS WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(sML_Spedizione.PCSDestinazione);
					rObjDataTable = null;
					val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref rObjDataTable, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						sML_Spedizione.PCSDestinazione_RagSoc = rObjDataTable.Rows[0]["RagioneSociale"].ToString();
						sML_Spedizione.PCSDestinazione_Indirizzo = rObjDataTable.Rows[0]["Indirizzo"].ToString();
						sML_Spedizione.PCSDestinazione_Cap = rObjDataTable.Rows[0]["Cap"].ToString();
						sML_Spedizione.PCSDestinazione_Localita = rObjDataTable.Rows[0]["Localita"].ToString();
						sML_Spedizione.PCSDestinazione_Provincia = rObjDataTable.Rows[0]["Provincia"].ToString();
						sML_Spedizione.PCSDestinazione_Nazione = rObjDataTable.Rows[0]["Nazione"].ToString();
						sML_Spedizione.ZonaSpedizione = ViaggioAssociato.ZonaSpedizione;
						sML_Spedizione.Macrozona = ViaggioAssociato.Macrozona;
						sML_Spedizione.Corrispondente = GiroDettaglio["Corrispondente"].ToString();
						sML_Spedizione.IdViaggio = ViaggioAssociato.IdViaggio;
						sML_Spedizione.Sequenza = Conversions.ToInteger(GiroDettaglio["Sequenza"]);
						sML_Spedizione.DataOraConsegna = _SML_Model.SML_Sessione.Data;
						if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(GiroDettaglio["OraConsegna"])))
						{
							sML_Spedizione.DataOraConsegna = sML_Spedizione.DataOraConsegna.Value.AddMinutes(checked(Conversions.ToDate(GiroDettaglio["OraConsegna"]).Hour * 60 + Conversions.ToDate(GiroDettaglio["OraConsegna"]).Minute));
						}
						sML_Spedizione.DataOraArrivo = sML_Spedizione.DataOraConsegna;
						sML_Spedizione.DataOraPartenza = sML_Spedizione.DataOraConsegna;
						sML_Spedizione.Colli = 1;
						sML_Spedizione.Peso = 1m;
						sML_Spedizione.Volume = 1m;
						sML_Spedizione.UteAgg = this._User;
						sML_Spedizione.UteIns = this._User;
						_SML_Model.ListOfSML_Spedizioni.Add(sML_Spedizione.Unibol.ToString(), sML_Spedizione);
						val2 = (FXRETURN)0;
					}
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

	protected FXRETURN GeneraSpedizioneLibera(DataRow PCS, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Invalid comparison between Unknown and I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Invalid comparison between Unknown and I4
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			SML_Spedizione sML_Spedizione = new SML_Spedizione();
			long rlReturnValue = default(long);
			val = ((AppBaseClass)this).Parametrica.LeggiContatore("COUNTERS.SIMULAZIONE.UNIBOL", vbStartTrans: false, ref rlReturnValue, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				sML_Spedizione.Unibol = rlReturnValue.ToString();
				sML_Spedizione.IdSessione = _SML_Model.SML_Sessione.IdSessione;
				sML_Spedizione.CodiceGiro = "";
				sML_Spedizione.Stato = 20;
				sML_Spedizione.Cliente = "*ALL";
				sML_Spedizione.NumeroBolla = sML_Spedizione.Unibol;
				sML_Spedizione.DataBolla = _SML_Model.SML_Sessione.Data;
				sML_Spedizione.NumeroOrdine = sML_Spedizione.Unibol;
				sML_Spedizione.DataOrdine = _SML_Model.SML_Sessione.Data;
				sML_Spedizione.TipoSpedizione = _PrimoViaggio.TipoSpedizione;
				string vsSQLClause = "SELECT * FROM PCS_ZONE WHERE PCS=" + ((AppBaseClass)this).DbConn.SQLFormatString(PCS["Codice"].ToString()) + " ORDER BY ID";
				DataTable rObjDataTable = null;
				val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref rObjDataTable, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (rObjDataTable.Rows.Count > 0)
					{
						sML_Spedizione.TipoMerce = rObjDataTable.Rows[0]["TipoMerce"].ToString();
						sML_Spedizione.ZonaSpedizione = rObjDataTable.Rows[0]["ZonaSpedizione"].ToString();
					}
					if (Operators.CompareString(sML_Spedizione.TipoMerce, "", false) == 0)
					{
						sML_Spedizione.TipoMerce = "*ALL";
					}
					if (Operators.CompareString(sML_Spedizione.ZonaSpedizione, "", false) == 0)
					{
						sML_Spedizione.ZonaSpedizione = "*ALL";
					}
					vsSQLClause = "SELECT * FROM ZONE WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(sML_Spedizione.ZonaSpedizione);
					rObjDataTable = null;
					val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref rObjDataTable, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						if (rObjDataTable.Rows.Count > 0)
						{
							sML_Spedizione.Macrozona = rObjDataTable.Rows[0]["CodiceZonaMacro"].ToString();
						}
						if (Operators.CompareString(sML_Spedizione.Macrozona, "", false) == 0)
						{
							sML_Spedizione.Macrozona = "*ALL";
						}
						sML_Spedizione.PCSPartenza = PCS["PuntoRitiro1"].ToString();
						if (Operators.CompareString(sML_Spedizione.PCSPartenza, "", false) == 0)
						{
							sML_Spedizione.PCSPartenza = _PrimoViaggio.PCSPartenza;
						}
						vsSQLClause = "SELECT * FROM PCS WHERE CODICE=" + ((AppBaseClass)this).DbConn.SQLFormatString(sML_Spedizione.PCSPartenza);
						rObjDataTable = null;
						val = ((AppBaseClass)this).DbConn.OpenDataTable(vsSQLClause, ref rObjDataTable, ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
						}
						else
						{
							sML_Spedizione.PCSPartenza_RagSoc = rObjDataTable.Rows[0]["RagioneSociale"].ToString();
							sML_Spedizione.PCSPartenza_Indirizzo = rObjDataTable.Rows[0]["Indirizzo"].ToString();
							sML_Spedizione.PCSPartenza_Cap = rObjDataTable.Rows[0]["Cap"].ToString();
							sML_Spedizione.PCSPartenza_Localita = rObjDataTable.Rows[0]["Localita"].ToString();
							sML_Spedizione.PCSPartenza_Provincia = rObjDataTable.Rows[0]["Provincia"].ToString();
							sML_Spedizione.PCSPartenza_Nazione = rObjDataTable.Rows[0]["Nazione"].ToString();
							sML_Spedizione.PCSDestinazione = PCS["Codice"].ToString();
							sML_Spedizione.PCSDestinazione_RagSoc = PCS["RagioneSociale"].ToString();
							sML_Spedizione.PCSDestinazione_Indirizzo = PCS["Indirizzo"].ToString();
							sML_Spedizione.PCSDestinazione_Cap = PCS["Cap"].ToString();
							sML_Spedizione.PCSDestinazione_Localita = PCS["Localita"].ToString();
							sML_Spedizione.PCSDestinazione_Provincia = PCS["Provincia"].ToString();
							sML_Spedizione.PCSDestinazione_Nazione = PCS["Nazione"].ToString();
							sML_Spedizione.Corrispondente = "";
							sML_Spedizione.IdViaggio = null;
							sML_Spedizione.Sequenza = 0;
							sML_Spedizione.DataOraConsegna = _SML_Model.SML_Sessione.Data;
							sML_Spedizione.DataOraArrivo = sML_Spedizione.DataOraConsegna;
							sML_Spedizione.DataOraPartenza = sML_Spedizione.DataOraConsegna;
							sML_Spedizione.Colli = 1;
							sML_Spedizione.Peso = 1m;
							sML_Spedizione.Volume = 1m;
							sML_Spedizione.UteAgg = this._User;
							sML_Spedizione.UteIns = this._User;
							_SML_Model.ListOfSML_Spedizioni.Add(sML_Spedizione.Unibol.ToString(), sML_Spedizione);
							val2 = (FXRETURN)0;
						}
					}
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

	protected FXRETURN PersistToDB(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Invalid comparison between Unknown and I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Invalid comparison between Unknown and I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Invalid comparison between Unknown and I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Invalid comparison between Unknown and I4
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Invalid comparison between Unknown and I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		StringBuilder stringBuilder = new StringBuilder();
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			DBConnection dbConn = ((AppBaseClass)this).DbConn;
			SML_Sessione sML_Sessione;
			int pNumero = (sML_Sessione = _SML_Model.SML_Sessione).IdSessione;
			string text = dbConn.SQLFormatNumber(ref pNumero);
			sML_Sessione.IdSessione = pNumero;
			string value = "DELETE FROM SML_Sessioni WHERE IdSessione=" + text + ";";
			stringBuilder.Append(value);
			value = "";
			val = CreateQueryINSERT(_SML_Model.SML_Sessione, ref value, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				stringBuilder.Append(value);
				KeyValuePair<string, SML_Mezzo>[] array = _SML_Model.ListOfSML_Mezzi.ToArray();
				int num = 0;
				while (true)
				{
					if (num < array.Length)
					{
						KeyValuePair<string, SML_Mezzo> keyValuePair = array[num];
						val = CreateQueryINSERT(keyValuePair.Value, ref value, ref rsmess);
						if ((int)val > 0)
						{
							val2 = val;
							break;
						}
						stringBuilder.Append(value);
						num = checked(num + 1);
						continue;
					}
					KeyValuePair<string, SML_MezzoDisponibilita>[] array2 = _SML_Model.ListOfSML_MezziDisponibilita.ToArray();
					int num2 = 0;
					while (true)
					{
						if (num2 < array2.Length)
						{
							KeyValuePair<string, SML_MezzoDisponibilita> keyValuePair2 = array2[num2];
							val = CreateQueryINSERT(keyValuePair2.Value, ref value, ref rsmess);
							if ((int)val > 0)
							{
								val2 = val;
								break;
							}
							stringBuilder.Append(value);
							num2 = checked(num2 + 1);
							continue;
						}
						KeyValuePair<string, SML_Viaggio>[] array3 = _SML_Model.ListOfSML_Viaggi.ToArray();
						int num3 = 0;
						while (true)
						{
							if (num3 < array3.Length)
							{
								KeyValuePair<string, SML_Viaggio> keyValuePair3 = array3[num3];
								val = CreateQueryINSERT(keyValuePair3.Value, ref value, ref rsmess);
								if ((int)val > 0)
								{
									val2 = val;
									break;
								}
								stringBuilder.Append(value);
								num3 = checked(num3 + 1);
								continue;
							}
							KeyValuePair<string, SML_Spedizione>[] array4 = _SML_Model.ListOfSML_Spedizioni.ToArray();
							int num4 = 0;
							while (true)
							{
								if (num4 < array4.Length)
								{
									KeyValuePair<string, SML_Spedizione> keyValuePair4 = array4[num4];
									val = CreateQueryINSERT(keyValuePair4.Value, ref value, ref rsmess);
									if ((int)val > 0)
									{
										val2 = val;
										break;
									}
									stringBuilder.Append(value);
									num4 = checked(num4 + 1);
									continue;
								}
								val = ((AppBaseClass)this).DbConn.SqlExec(stringBuilder.ToString(), ref rsmess);
								val2 = (((int)val <= 0) ? ((FXRETURN)0) : val);
								break;
							}
							break;
						}
						break;
					}
					break;
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
}
