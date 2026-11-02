using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class EventoViaggio_Rifornimento : AppAbstractApi
{
	protected EventoViaggio _Evento;

	protected string _EventoTipo;

	protected string _IdViaggio;

	protected string _Autista;

	protected DateTime? _Data;

	protected string _Motrice;

	protected string _Terminale;

	protected string _IdRifornimento;

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

	protected bool _ApplyQuery;

	public EventoViaggio_Rifornimento(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Evento = null;
		_EventoTipo = "";
		_IdViaggio = "";
		_Autista = "";
		_Motrice = "";
		_Terminale = "";
		_IdRifornimento = "";
		_Latitudine = "";
		_Longitudine = "";
		_Localita = "";
		_Indirizzo = "";
		_Cap = "";
		_Provincia = "";
		_Nazione = "";
		_ApplyQuery = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Invalid comparison between Unknown and I4
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
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
			_Terminale = ((AppAbstractApi)this).ParametersIn["Terminale"].ToString();
			_IdRifornimento = ((AppAbstractApi)this).ParametersIn["IdRifornimento"].ToString();
			text = "SELECT COUNT(*) FROM MEZZI_RIFORNIMENTI WHERE ID = " + ((AppBaseClass)this).DbConn.SQLFormatString(_IdRifornimento);
			val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else if (Conversions.ToInteger(objRes) == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Rifornimento {0} non trovato a sistema", new string[1] { _IdRifornimento });
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
				_Evento = new EventoViaggio();
				_EventoTipo = EventoViaggioTipo.ViaggioRifornimento;
				_Evento.IdViaggio = _IdViaggio;
				_Evento.IdRifornimento = _IdRifornimento;
				_Evento.DataOraEvento = _Data;
				_Evento.Autista = _Autista;
				_Evento.Motrice = _Motrice;
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string IdViaggio, string IdRifornimento, DateTime? Data, string Autista, string Motrice, string Terminale, string Latitudine, string Longitudine, decimal? KmGps, DateTime? DataGPS, decimal? KmManuali, string Localita, string Indirizzo, string Cap, string Provincia, string Nazione, bool ApplyQuery, ref string RetQueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Invalid comparison between Unknown and I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			EventoViaggio_Rifornimento eventoViaggio_Rifornimento = new EventoViaggio_Rifornimento(objApiContext);
			((AppAbstractApi)eventoViaggio_Rifornimento).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)eventoViaggio_Rifornimento).ParametersIn.Add("Data", Data);
			((AppAbstractApi)eventoViaggio_Rifornimento).ParametersIn.Add("Autista", Autista);
			((AppAbstractApi)eventoViaggio_Rifornimento).ParametersIn.Add("Motrice", Motrice);
			((AppAbstractApi)eventoViaggio_Rifornimento).ParametersIn.Add("Terminale", Terminale);
			((AppAbstractApi)eventoViaggio_Rifornimento).ParametersIn.Add("IdRifornimento", IdRifornimento);
			((AppAbstractApi)eventoViaggio_Rifornimento).ParametersIn.Add("Latitudine", Latitudine);
			((AppAbstractApi)eventoViaggio_Rifornimento).ParametersIn.Add("Longitudine", Longitudine);
			((AppAbstractApi)eventoViaggio_Rifornimento).ParametersIn.Add("KmGps", KmGps);
			((AppAbstractApi)eventoViaggio_Rifornimento).ParametersIn.Add("DataGPS", DataGPS);
			((AppAbstractApi)eventoViaggio_Rifornimento).ParametersIn.Add("KmManuali", KmManuali);
			((AppAbstractApi)eventoViaggio_Rifornimento).ParametersIn.Add("Localita", Localita);
			((AppAbstractApi)eventoViaggio_Rifornimento).ParametersIn.Add("Indirizzo", Indirizzo);
			((AppAbstractApi)eventoViaggio_Rifornimento).ParametersIn.Add("Cap", Cap);
			((AppAbstractApi)eventoViaggio_Rifornimento).ParametersIn.Add("Provincia", Provincia);
			((AppAbstractApi)eventoViaggio_Rifornimento).ParametersIn.Add("Nazione", Nazione);
			((AppAbstractApi)eventoViaggio_Rifornimento).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)eventoViaggio_Rifornimento).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				RetQueryToApply = ((AppAbstractApi)eventoViaggio_Rifornimento).ParametersOut["RetQueryToApply"].ToString();
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
