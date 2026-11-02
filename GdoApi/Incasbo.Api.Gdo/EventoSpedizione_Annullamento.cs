using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class EventoSpedizione_Annullamento : AppAbstractApi
{
	protected EventoSpedizione _Evento;

	protected string _EventoTipo;

	protected string _Unibol;

	protected string _Note;

	protected string _CodiceEvento;

	protected bool _ApplyQuery;

	public EventoSpedizione_Annullamento(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Evento = null;
		_EventoTipo = "";
		_Unibol = "";
		_Note = "";
		_CodiceEvento = "";
		_ApplyQuery = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			((AppAbstractApi)this).ParametersOut.Add("RetQueryToApply", "");
			_Evento = new EventoSpedizione();
			_EventoTipo = EventoSpedizioneTipo.SpedizioneAnnullamento;
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ApplyQuery"))
			{
				_ApplyQuery = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ApplyQuery"]);
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("Utente") && Operators.CompareString(((AppAbstractApi)this).ParametersIn["Utente"].ToString(), "", false) != 0)
			{
				this._User = ((AppAbstractApi)this).ParametersIn["Utente"].ToString();
			}
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			_CodiceEvento = ((AppAbstractApi)this).ParametersIn["CodiceEvento"].ToString();
			_Note = ((AppAbstractApi)this).ParametersIn["Note"].ToString();
			_Evento.Unibol = _Unibol;
			if (Operators.CompareString(_Note, "", false) != 0)
			{
				_Evento.NoteInterne = this.TranslateMessage("XXX", _Note);
			}
			_Evento.CodiceEvento = _CodiceEvento;
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string Unibol, string CodiceEvento, string Note, string Utente, bool ApplyQuery, ref string RetQueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Invalid comparison between Unknown and I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			EventoSpedizione_Annullamento eventoSpedizione_Annullamento = new EventoSpedizione_Annullamento(objApiContext);
			((AppAbstractApi)eventoSpedizione_Annullamento).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)eventoSpedizione_Annullamento).ParametersIn.Add("CodiceEvento", CodiceEvento);
			((AppAbstractApi)eventoSpedizione_Annullamento).ParametersIn.Add("Note", Note);
			((AppAbstractApi)eventoSpedizione_Annullamento).ParametersIn.Add("Utente", Utente);
			((AppAbstractApi)eventoSpedizione_Annullamento).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)eventoSpedizione_Annullamento).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				RetQueryToApply = ((AppAbstractApi)eventoSpedizione_Annullamento).ParametersOut["RetQueryToApply"].ToString();
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
