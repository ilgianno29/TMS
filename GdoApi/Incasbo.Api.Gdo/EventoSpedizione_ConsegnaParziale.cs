using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class EventoSpedizione_ConsegnaParziale : AppAbstractApi
{
	protected EventoSpedizione _Evento;

	protected string _EventoTipo;

	protected string _Unibol;

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

	public EventoSpedizione_ConsegnaParziale(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Evento = null;
		_EventoTipo = "";
		_Unibol = "";
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
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
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
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ApplyQuery"))
			{
				_ApplyQuery = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ApplyQuery"]);
			}
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
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
			_EventoTipo = EventoSpedizioneTipo.SpedizioneEsitoParziale;
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
			val = EventoSpedizione_Inserisci.RunProc(this._ApiContext, _Evento, _EventoTipo, this._User, _ApplyQuery, ref RetQueryToApply, ref rsmess);
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string Unibol, string CodiceEvento, DateTime? Data, string Autista, string Motrice, string Rimorchio, string Contenitore, string Terminale, string Latitudine, string Longitudine, decimal? KmGps, DateTime? DataGPS, decimal? KmManuali, string Localita, string Indirizzo, string Cap, string Provincia, string Nazione, string NoteInterne, string NoteEsterne, bool ApplyQuery, ref string RetQueryToApply, ref string rsmess)
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
			EventoSpedizione_ConsegnaParziale eventoSpedizione_ConsegnaParziale = new EventoSpedizione_ConsegnaParziale(objApiContext);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("CodiceEvento", CodiceEvento);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("Data", Data);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("Autista", Autista);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("Motrice", Motrice);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("Rimorchio", Rimorchio);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("Contenitore", Contenitore);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("Terminale", Terminale);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("Latitudine", Latitudine);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("Longitudine", Longitudine);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("KmGps", KmGps);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("DataGPS", DataGPS);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("KmManuali", KmManuali);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("Localita", Localita);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("Indirizzo", Indirizzo);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("Cap", Cap);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("Provincia", Provincia);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("Nazione", Nazione);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("NoteInterne", NoteInterne);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("NoteEsterne", NoteEsterne);
			((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)eventoSpedizione_ConsegnaParziale).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				RetQueryToApply = ((AppAbstractApi)eventoSpedizione_ConsegnaParziale).ParametersOut["RetQueryToApply"].ToString();
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
