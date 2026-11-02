using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class EventoViaggio_Spedizione : AppAbstractApi
{
	protected EventoViaggio _Evento;

	protected string _EventoTipo;

	protected string _IdViaggio;

	protected string _Autista;

	protected DateTime? _Data;

	protected string _Motrice;

	protected string _Rimorchio;

	protected string _Contenitore;

	protected string _Terminale;

	protected string _Tipo;

	protected string _Unibol;

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

	protected string _Note;

	protected bool _ApplyQuery;

	public EventoViaggio_Spedizione(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Evento = null;
		_EventoTipo = "";
		_IdViaggio = "";
		_Autista = "";
		_Motrice = "";
		_Rimorchio = "";
		_Contenitore = "";
		_Terminale = "";
		_Tipo = "";
		_Unibol = "";
		_Latitudine = "";
		_Longitudine = "";
		_Localita = "";
		_Indirizzo = "";
		_Cap = "";
		_Provincia = "";
		_Nazione = "";
		_Note = "";
		_ApplyQuery = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Invalid comparison between Unknown and I4
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object objRes = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			((AppAbstractApi)this).ParametersOut.Add("RetQueryToApply", "");
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ApplyQuery"))
			{
				_ApplyQuery = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ApplyQuery"]);
			}
			_IdViaggio = ((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString();
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
			_Tipo = ((AppAbstractApi)this).ParametersIn["Tipo"].ToString();
			if (Operators.CompareString(_Tipo, "", false) == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Tipo Evento Spedizione non specificato");
			}
			else
			{
				_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
				text = "SELECT COUNT(*) FROM SPEDIZIONI WHERE UNIBOL = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
				val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else if (Conversions.ToInteger(objRes) == 0)
				{
					rsmess = this.TranslateMessage("XXX", "Spedizione {0} non trovata a sistema", new string[1] { _Unibol });
				}
				else
				{
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
					_Note = ((AppAbstractApi)this).ParametersIn["Note"].ToString();
					_Evento = new EventoViaggio();
					_EventoTipo = EventoViaggioTipo.ViaggioSpedizione;
					if (Operators.CompareString(_Tipo, "C", false) == 0)
					{
						_Evento.CodiceEvento = "VIACAR";
						goto IL_03d9;
					}
					if (Operators.CompareString(_Tipo, "S", false) == 0)
					{
						_Evento.CodiceEvento = "VIASCAR";
						goto IL_03d9;
					}
					rsmess = this.TranslateMessage("XXX", "Tipo Evento Spedizione non corretto");
				}
			}
			goto end_IL_000e;
			IL_03d9:
			_Evento.IdViaggio = _IdViaggio;
			_Evento.Unibol = _Unibol;
			_Evento.DataOraEvento = _Data;
			_Evento.Autista = _Autista;
			_Evento.Motrice = _Motrice;
			_Evento.Rimorchio1 = _Rimorchio;
			_Evento.Contenitore1 = _Contenitore;
			_Evento.Terminale = _Terminale;
			_Evento.Latitudine = _Latitudine;
			_Evento.Longitudine = _Longitudine;
			_Evento.KmGPS = _KmGps;
			_Evento.DataValiditaGPS = _DataGPS;
			_Evento.KmManuali = _KmManuali;
			_Evento.Localita = _Localita;
			_Evento.Indirizzo = _Indirizzo;
			_Evento.Cap = _Cap;
			_Evento.Provincia = _Provincia;
			_Evento.Nazione = _Nazione;
			_Evento.NoteInterne = _Note;
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string RetQueryToApply = "";
			val = EventoViaggio_Inserisci.RunProc(this._ApiContext, _Evento, _EventoTipo, this._User, _ApplyQuery, ref RetQueryToApply, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = RetQueryToApply;
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, string Tipo, string Unibol, DateTime? Data, string Autista, string Motrice, string Rimorchio, string Contenitore, string Terminale, string Latitudine, string Longitudine, decimal? KmGps, DateTime? DataGPS, decimal? KmManuali, string Localita, string Indirizzo, string Cap, string Provincia, string Nazione, bool ApplyQuery, ref string RetQueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Invalid comparison between Unknown and I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			EventoViaggio_Spedizione eventoViaggio_Spedizione = new EventoViaggio_Spedizione(objApiContext);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Data", Data);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Autista", Autista);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Motrice", Motrice);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Rimorchio", Rimorchio);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Contenitore", Contenitore);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Terminale", Terminale);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Tipo", Tipo);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Latitudine", Latitudine);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Longitudine", Longitudine);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("KmGps", KmGps);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("DataGPS", DataGPS);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("KmManuali", KmManuali);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Localita", Localita);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Indirizzo", Indirizzo);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Cap", Cap);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Provincia", Provincia);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Nazione", Nazione);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Note", "");
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)eventoViaggio_Spedizione).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				RetQueryToApply = ((AppAbstractApi)eventoViaggio_Spedizione).ParametersOut["RetQueryToApply"].ToString();
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = (FXRETURN)3;
			rsmess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
		}
		return result;
	}

	public static FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, string Tipo, string Unibol, DateTime? Data, string Autista, string Motrice, string Rimorchio, string Contenitore, string Terminale, string Latitudine, string Longitudine, decimal? KmGps, DateTime? DataGPS, decimal? KmManuali, string Localita, string Indirizzo, string Cap, string Provincia, string Nazione, string Note, bool ApplyQuery, ref string RetQueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Invalid comparison between Unknown and I4
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			EventoViaggio_Spedizione eventoViaggio_Spedizione = new EventoViaggio_Spedizione(objApiContext);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Data", Data);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Autista", Autista);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Motrice", Motrice);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Rimorchio", Rimorchio);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Contenitore", Contenitore);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Terminale", Terminale);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Tipo", Tipo);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Latitudine", Latitudine);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Longitudine", Longitudine);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("KmGps", KmGps);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("DataGPS", DataGPS);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("KmManuali", KmManuali);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Localita", Localita);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Indirizzo", Indirizzo);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Cap", Cap);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Provincia", Provincia);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Nazione", Nazione);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("Note", Note);
			((AppAbstractApi)eventoViaggio_Spedizione).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)eventoViaggio_Spedizione).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				RetQueryToApply = ((AppAbstractApi)eventoViaggio_Spedizione).ParametersOut["RetQueryToApply"].ToString();
				val2 = (FXRETURN)0;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			val2 = (FXRETURN)3;
			rsmess = ex2.Message;
			ProjectData.ClearProjectError();
		}
		finally
		{
			result = val2;
		}
		return result;
	}
}
