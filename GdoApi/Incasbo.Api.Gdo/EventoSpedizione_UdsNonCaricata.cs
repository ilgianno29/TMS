using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class EventoSpedizione_UdsNonCaricata : AppAbstractApi
{
	protected EventoSpedizione _Evento;

	protected string _EventoTipo;

	protected string _Unibol;

	protected string _CodiceUds;

	protected string _CodiceEvento;

	protected string _Autista;

	protected DateTime? _Data;

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

	public EventoSpedizione_UdsNonCaricata(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Evento = null;
		_EventoTipo = "";
		_Unibol = "";
		_CodiceUds = "";
		_CodiceEvento = "";
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
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		object obj = null;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			((AppAbstractApi)this).ParametersOut.Add("RetQueryToApply", "");
			((AppAbstractApi)this).ParametersOut.Add("CodiceEvento", "");
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ApplyQuery"))
			{
				_ApplyQuery = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ApplyQuery"]);
			}
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			_CodiceUds = ((AppAbstractApi)this).ParametersIn["CodiceUds"].ToString();
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
			_KmGps = (decimal?)((AppAbstractApi)this).ParametersIn["KmGps"];
			_DataGPS = (DateTime?)((AppAbstractApi)this).ParametersIn["DataGPS"];
			_KmManuali = (decimal?)((AppAbstractApi)this).ParametersIn["KmManuali"];
			_Localita = ((AppAbstractApi)this).ParametersIn["Localita"].ToString();
			_Indirizzo = ((AppAbstractApi)this).ParametersIn["Indirizzo"].ToString();
			_Cap = ((AppAbstractApi)this).ParametersIn["Cap"].ToString();
			_Provincia = ((AppAbstractApi)this).ParametersIn["Provincia"].ToString();
			_Nazione = ((AppAbstractApi)this).ParametersIn["Nazione"].ToString();
			_NoteEsterne = ((AppAbstractApi)this).ParametersIn["NoteEsterne"].ToString();
			_NoteInterne = ((AppAbstractApi)this).ParametersIn["NoteInterne"].ToString();
			_Evento = new EventoSpedizione();
			_EventoTipo = EventoSpedizioneTipo.UdsNonCaricata;
			if (Operators.CompareString(_CodiceEvento, "", false) != 0)
			{
				_Evento.CodiceEvento = _CodiceEvento;
			}
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
			_Evento.NoteEsterne = _NoteEsterne;
			if (Operators.CompareString(_NoteInterne, "", false) == 0)
			{
				_NoteInterne = this.TranslateMessage("XXX", "Esito Uds {0}", new string[1] { _CodiceUds });
			}
			_Evento.NoteInterne = _NoteInterne;
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
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			string RetQueryToApply = "";
			val = EventoSpedizione_Inserisci.RunProc(this._ApiContext, _Evento, _EventoTipo, this._User, _ApplyQuery, ref RetQueryToApply, ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				((AppAbstractApi)this).ParametersOut["CodiceEvento"] = _Evento.CodiceEvento;
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string Unibol, string CodiceUds, ref string CodiceEvento, DateTime? Data, string Autista, string Motrice, string Rimorchio, string Contenitore, string Terminale, string Latitudine, string Longitudine, decimal? KmGps, DateTime? DataGPS, decimal? KmManuali, string Localita, string Indirizzo, string Cap, string Provincia, string Nazione, string NoteInterne, string NoteEsterne, bool ApplyQuery, ref string RetQueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Invalid comparison between Unknown and I4
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			EventoSpedizione_UdsNonCaricata eventoSpedizione_UdsNonCaricata = new EventoSpedizione_UdsNonCaricata(objApiContext);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("CodiceUds", CodiceUds);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("CodiceEvento", CodiceEvento);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("Data", Data);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("Autista", Autista);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("Motrice", Motrice);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("Rimorchio", Rimorchio);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("Contenitore", Contenitore);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("Terminale", Terminale);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("Latitudine", Latitudine);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("Longitudine", Longitudine);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("KmGps", KmGps);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("DataGPS", DataGPS);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("KmManuali", KmManuali);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("Localita", Localita);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("Indirizzo", Indirizzo);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("Cap", Cap);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("Provincia", Provincia);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("Nazione", Nazione);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("NoteInterne", NoteInterne);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("NoteEsterne", NoteEsterne);
			((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)eventoSpedizione_UdsNonCaricata).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (Operators.CompareString(CodiceEvento, "", false) == 0)
				{
					CodiceEvento = ((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersOut["CodiceEvento"].ToString();
				}
				RetQueryToApply = ((AppAbstractApi)eventoSpedizione_UdsNonCaricata).ParametersOut["RetQueryToApply"].ToString();
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
