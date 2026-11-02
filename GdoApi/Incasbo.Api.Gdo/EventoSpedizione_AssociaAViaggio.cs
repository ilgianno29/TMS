using System;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class EventoSpedizione_AssociaAViaggio : AppAbstractApi
{
	protected EventoSpedizione _Evento;

	protected string _EventoTipo;

	protected string _Unibol;

	protected DateTime? _DataEvento;

	protected string _IdViaggio;

	protected bool _ApplyQuery;

	protected bool _ViaggioChiuso;

	public EventoSpedizione_AssociaAViaggio(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Evento = null;
		_EventoTipo = "";
		_Unibol = "";
		_DataEvento = null;
		_IdViaggio = "";
		_ApplyQuery = true;
		_ViaggioChiuso = false;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
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
			_EventoTipo = EventoSpedizioneTipo.SpedizioneAssociaAViaggio;
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ApplyQuery"))
			{
				_ApplyQuery = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ApplyQuery"]);
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("Utente") && Operators.CompareString(((AppAbstractApi)this).ParametersIn["Utente"].ToString(), "", false) != 0)
			{
				this._User = ((AppAbstractApi)this).ParametersIn["Utente"].ToString();
			}
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			_DataEvento = (DateTime?)((AppAbstractApi)this).ParametersIn["DataEvento"];
			if (!_DataEvento.HasValue)
			{
				_DataEvento = DateAndTime.Now;
			}
			_IdViaggio = ((AppAbstractApi)this).ParametersIn["IdViaggio"].ToString();
			_ViaggioChiuso = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ViaggioChiuso"]);
			_Evento.Unibol = _Unibol;
			if (_ViaggioChiuso)
			{
				_Evento.NoteInterne = this.TranslateMessage("XXX", "ASSOCIAZIONE A VIAGGIO CHIUSO {0}", new string[1] { _IdViaggio });
			}
			else
			{
				_Evento.NoteInterne = this.TranslateMessage("XXX", "ASSOCIAZIONE A VIAGGIO {0}", new string[1] { _IdViaggio });
			}
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string Unibol, DateTime? DataEvento, string IdViaggio, string Utente, bool ApplyQuery, ref string RetQueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			EventoSpedizione_AssociaAViaggio eventoSpedizione_AssociaAViaggio = new EventoSpedizione_AssociaAViaggio(objApiContext);
			((AppAbstractApi)eventoSpedizione_AssociaAViaggio).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)eventoSpedizione_AssociaAViaggio).ParametersIn.Add("DataEvento", DataEvento);
			((AppAbstractApi)eventoSpedizione_AssociaAViaggio).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)eventoSpedizione_AssociaAViaggio).ParametersIn.Add("ViaggioChiuso", false);
			((AppAbstractApi)eventoSpedizione_AssociaAViaggio).ParametersIn.Add("Utente", Utente);
			((AppAbstractApi)eventoSpedizione_AssociaAViaggio).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)eventoSpedizione_AssociaAViaggio).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				RetQueryToApply = ((AppAbstractApi)eventoSpedizione_AssociaAViaggio).ParametersOut["RetQueryToApply"].ToString();
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

	public static FXRETURN RunProc(AppApiContext objApiContext, string Unibol, DateTime? DataEvento, string IdViaggio, bool ViaggioChiuso, string Utente, bool ApplyQuery, ref string RetQueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Invalid comparison between Unknown and I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			EventoSpedizione_AssociaAViaggio eventoSpedizione_AssociaAViaggio = new EventoSpedizione_AssociaAViaggio(objApiContext);
			((AppAbstractApi)eventoSpedizione_AssociaAViaggio).ParametersIn.Add("Unibol", Unibol);
			((AppAbstractApi)eventoSpedizione_AssociaAViaggio).ParametersIn.Add("IdViaggio", IdViaggio);
			((AppAbstractApi)eventoSpedizione_AssociaAViaggio).ParametersIn.Add("DataEvento", DataEvento);
			((AppAbstractApi)eventoSpedizione_AssociaAViaggio).ParametersIn.Add("ViaggioChiuso", ViaggioChiuso);
			((AppAbstractApi)eventoSpedizione_AssociaAViaggio).ParametersIn.Add("Utente", Utente);
			((AppAbstractApi)eventoSpedizione_AssociaAViaggio).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)eventoSpedizione_AssociaAViaggio).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				RetQueryToApply = ((AppAbstractApi)eventoSpedizione_AssociaAViaggio).ParametersOut["RetQueryToApply"].ToString();
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
