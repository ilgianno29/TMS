using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class EventoSpedizione_Inserisci : AppAbstractApi
{
	protected EventoSpedizione _Evento;

	protected string _EventoTipo;

	protected string _EventoTipoEsportazione;

	protected string _Unibol;

	protected bool _ApplyQuery;

	protected bool _EventoSingolo;

	public EventoSpedizione_Inserisci(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Evento = null;
		_EventoTipo = "";
		_EventoTipoEsportazione = "";
		_Unibol = "";
		_ApplyQuery = true;
		_EventoSingolo = false;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Invalid comparison between Unknown and I4
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Invalid comparison between Unknown and I4
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			((AppAbstractApi)this).ParametersOut.Add("RetQueryToApply", "");
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("Evento"))
			{
				_Evento = (EventoSpedizione)((AppAbstractApi)this).ParametersIn["Evento"];
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("EventoTipo"))
			{
				_EventoTipo = ((AppAbstractApi)this).ParametersIn["EventoTipo"].ToString();
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("ApplyQuery"))
			{
				_ApplyQuery = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ApplyQuery"]);
			}
			_Unibol = _Evento.Unibol;
			if ((Operators.CompareString(_Evento.CodiceEvento, "", false) == 0) & (Operators.CompareString(_EventoTipo, "", false) == 0))
			{
				val = (FXRETURN)5;
				rsmess = this.TranslateMessage("XXX", "Chiamata all'api sbagliata. Specificare o l'evento o la tipologia dell'evento");
			}
			else
			{
				if (((AppAbstractApi)this).ParametersIn.ContainsKey("Utente") && Operators.CompareString(((AppAbstractApi)this).ParametersIn["Utente"].ToString(), "", false) != 0)
				{
					this._User = ((AppAbstractApi)this).ParametersIn["Utente"].ToString();
				}
				DataTable dataTable = null;
				if (Operators.CompareString(_Evento.CodiceEvento, "", false) == 0)
				{
					dataTable = null;
					text = "SELECT EventoDefault,EventoSingolo,Esportazione FROM Eventi_Tipi ";
					text = text + "WHERE Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(_EventoTipo);
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref dataTable, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else if (dataTable.Rows.Count == 0)
					{
						rsmess = this.TranslateMessage("XXX", "Impossibile determinare l'evento di default dal tipo evento '{0}'", new string[1] { _EventoTipo });
					}
					else
					{
						_Evento.CodiceEvento = dataTable.Rows[0]["EventoDefault"].ToString();
						_EventoSingolo = Operators.CompareString(dataTable.Rows[0]["EventoSingolo"].ToString(), "S", false) == 0;
						_EventoTipoEsportazione = dataTable.Rows[0]["Esportazione"].ToString();
						if (Operators.CompareString(_Evento.CodiceEvento, "", false) != 0)
						{
							goto IL_0447;
						}
						rsmess = this.TranslateMessage("XXX", "Impossibile determinare l'evento di default dal tipo evento '{0}'", new string[1] { _EventoTipo });
					}
				}
				else
				{
					dataTable = null;
					text = "SELECT E.TipoEvento, ET.EventoSingolo,ET.Esportazione FROM Eventi E INNER JOIN Eventi_Tipi ET ON ET.CODICE=E.TipoEvento ";
					text = text + "WHERE E.Codice=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.CodiceEvento);
					val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref dataTable, ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else if (dataTable.Rows.Count == 0)
					{
						rsmess = this.TranslateMessage("XXX", "Impossibile determinare il tipo evento di default dall'evento '{0}'", new string[1] { _Evento.CodiceEvento });
					}
					else
					{
						if (Operators.CompareString(dataTable.Rows[0]["TipoEvento"].ToString().ToUpper(), _EventoTipo.ToUpper(), false) == 0)
						{
							_EventoSingolo = Operators.CompareString(dataTable.Rows[0]["EventoSingolo"].ToString(), "S", false) == 0;
							_EventoTipoEsportazione = dataTable.Rows[0]["Esportazione"].ToString();
							goto IL_0447;
						}
						rsmess = this.TranslateMessage("XXX", "L'evento {0} non è congruente con il tipo evento {1}", new string[2] { _Evento.CodiceEvento, _EventoTipo });
					}
				}
			}
			goto end_IL_000b;
			IL_0447:
			if (!_Evento.DataOraEvento.HasValue)
			{
				_Evento.DataOraEvento = DateAndTime.Now;
			}
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

	protected override FXRETURN Core(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Invalid comparison between Unknown and I4
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			text = "";
			if (_EventoSingolo)
			{
				text += "UPDATE Spedizioni_Eventi SET ANNULLATO='S' ";
				text = text + "WHERE Unibol=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " ";
				text = text + "AND CodiceEvento IN (SELECT CODICE FROM EVENTI WHERE TipoEvento=" + ((AppBaseClass)this).DbConn.SQLFormatString(_EventoTipo) + "); ";
			}
			text += "INSERT INTO Spedizioni_Eventi (Unibol,CodiceEvento,DataOraEvento,NoteInterne,NoteEsterne,Importato,";
			text += "DataConsegnaConcordata,OraConsegnaConcordata1,OraConsegnaConcordata2,Riferimento,Autista,Terminale,";
			text += "Motrice,Rimorchio1,Contenitore1,Rimorchio2,Contenitore2,DatiAggiuntivi,Latitudine,Longitudine,DataValiditaGPS,KmGPS,KmManuali,";
			text += "Localita,Indirizzo,Cap,Provincia,Nazione,EsportatoCliente,UteIns,UteAgg) VALUES (";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.CodiceEvento) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, _Evento.DataOraEvento) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.NoteInterne) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.NoteEsterne) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(Interaction.IIf(_Evento.Importato, (object)"S", (object)"N").ToString()) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _Evento.DataConsegnaConcordata) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)3, _Evento.OraConsegnaConcordata1) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)3, _Evento.OraConsegnaConcordata2) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.Riferimento) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.Autista) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.Terminale) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.Motrice) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.Rimorchio1) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.Contenitore1) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.Rimorchio2) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.Contenitore2) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.DatiAggiuntivi) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.Latitudine) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.Longitudine) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)2, _Evento.DataValiditaGPS) + ", ";
			string text2 = text;
			DBConnection dbConn = ((AppBaseClass)this).DbConn;
			EventoSpedizione evento;
			decimal? pNumero = (evento = _Evento).KmGPS;
			string text3 = dbConn.SQLFormatNumber(ref pNumero);
			evento.KmGPS = pNumero;
			text = text2 + text3 + ", ";
			string text4 = text;
			DBConnection dbConn2 = ((AppBaseClass)this).DbConn;
			pNumero = (evento = _Evento).KmManuali;
			string text5 = dbConn2.SQLFormatNumber(ref pNumero);
			evento.KmManuali = pNumero;
			text = text4 + text5 + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.Localita) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.Indirizzo) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.Cap) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.Provincia) + ", ";
			text = text + ((AppBaseClass)this).DbConn.SQLFormatString(_Evento.Nazione) + ", ";
			if (Operators.CompareString(_EventoTipoEsportazione, "S", false) == 0)
			{
				text = text + "(SELECT CASE WHEN C.EsportazioneEsiti='S' AND " + ((AppBaseClass)this).DbConn.IsNullFunc("CET.Esportazione", "'N'") + "='S' THEN 'X' ELSE 'N' END ";
				text = text + "FROM Spedizioni S INNER JOIN Clienti C ON C.Codice=S.Cliente LEFT JOIN ClientiEventiTipi CET ON CET.Cliente=C.Codice AND CET.TipoEvento =" + ((AppBaseClass)this).DbConn.SQLFormatString(_EventoTipo) + " ";
				text = text + "WHERE UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + "),";
			}
			else
			{
				text += "'N',";
			}
			text = text + this.DbConn.SQLFormatString(this._User) + ", ";
			text = text + this.DbConn.SQLFormatString(this._User) + "); ";
			if (!_ApplyQuery)
			{
				goto IL_0595;
			}
			val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
			if ((int)val <= 0)
			{
				goto IL_0595;
			}
			val2 = val;
			goto end_IL_000b;
			IL_0595:
			((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = text;
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

	public static FXRETURN RunProc(AppApiContext objApiContext, EventoSpedizione Evento, string EventoTipo, string Utente, bool ApplyQuery, ref string RetQueryToApply, ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Invalid comparison between Unknown and I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			rsmess = "";
			EventoSpedizione_Inserisci eventoSpedizione_Inserisci = new EventoSpedizione_Inserisci(objApiContext);
			((AppAbstractApi)eventoSpedizione_Inserisci).ParametersIn.Add("Evento", Evento);
			((AppAbstractApi)eventoSpedizione_Inserisci).ParametersIn.Add("EventoTipo", EventoTipo);
			((AppAbstractApi)eventoSpedizione_Inserisci).ParametersIn.Add("Utente", Utente);
			((AppAbstractApi)eventoSpedizione_Inserisci).ParametersIn.Add("ApplyQuery", ApplyQuery);
			val = ((AppAbstractApi)eventoSpedizione_Inserisci).Run(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				RetQueryToApply = ((AppAbstractApi)eventoSpedizione_Inserisci).ParametersOut["RetQueryToApply"].ToString();
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
