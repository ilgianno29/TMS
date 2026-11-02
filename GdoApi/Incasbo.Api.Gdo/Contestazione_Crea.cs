using System;
using System.Data;
using Incasbo.Api.App;
using Incasbo.Web.Library;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Incasbo.Api.Gdo;

public class Contestazione_Crea : ContestazioniAbstractApi
{
	protected string _Unibol;

	protected string _NumeroDocumento;

	protected DateTime? _DataDocumento;

	protected string _NoteDocumento;

	protected DataTable _dtSpedizione;

	protected DateTime? _DataApertura;

	protected string _TipoContestazione;

	protected string _Note1;

	protected string _Note2;

	protected string _Note3;

	protected Contestazione _contestazione;

	protected bool _ApplyQuery;

	public Contestazione_Crea(AppApiContext objApiContext)
		: base(objApiContext)
	{
		_Unibol = "";
		_NumeroDocumento = "";
		_NoteDocumento = "";
		_dtSpedizione = null;
		_TipoContestazione = "";
		_ApplyQuery = true;
	}

	protected override FXRETURN CheckData(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Invalid comparison between Unknown and I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Invalid comparison between Unknown and I4
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			_Unibol = ((AppAbstractApi)this).ParametersIn["Unibol"].ToString();
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("DataApertura"))
			{
				_DataApertura = (DateTime?)((AppAbstractApi)this).ParametersIn["DataApertura"];
			}
			if (!_DataApertura.HasValue)
			{
				_DataApertura = DateAndTime.Now;
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("NumeroDocumento"))
			{
				_NumeroDocumento = Conversions.ToString(((AppAbstractApi)this).ParametersIn["NumeroDocumento"]);
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("DataDocumento"))
			{
				_DataDocumento = (DateTime?)((AppAbstractApi)this).ParametersIn["DataDocumento"];
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("NoteDocumento"))
			{
				_NoteDocumento = Conversions.ToString(((AppAbstractApi)this).ParametersIn["NoteDocumento"]);
			}
			if (((AppAbstractApi)this).ParametersIn.ContainsKey("TipoContestazione"))
			{
				_TipoContestazione = Conversions.ToString(((AppAbstractApi)this).ParametersIn["TipoContestazione"]);
			}
			if (Operators.CompareString(_TipoContestazione, "", false) == 0)
			{
				_TipoContestazione = base.ApplicationDefault.TipoContestazione_Default();
			}
			if (Operators.CompareString(_TipoContestazione, "", false) == 0)
			{
				rsmess = this.TranslateMessage("XXX", "Il tipo di contestazione di default non è stato definito");
			}
			else
			{
				if (((AppAbstractApi)this).ParametersIn.ContainsKey("Note1"))
				{
					_Note1 = Conversions.ToString(((AppAbstractApi)this).ParametersIn["Note1"]);
				}
				if (((AppAbstractApi)this).ParametersIn.ContainsKey("Note2"))
				{
					_Note2 = Conversions.ToString(((AppAbstractApi)this).ParametersIn["Note2"]);
				}
				if (((AppAbstractApi)this).ParametersIn.ContainsKey("Note3"))
				{
					_Note3 = Conversions.ToString(((AppAbstractApi)this).ParametersIn["Note3"]);
				}
				if (((AppAbstractApi)this).ParametersIn.ContainsKey("ApplyQuery"))
				{
					_ApplyQuery = Conversions.ToBoolean(((AppAbstractApi)this).ParametersIn["ApplyQuery"]);
				}
				val = CheckSpedizione(ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					val = CheckContestazione(ref rsmess);
					if ((int)val > 0)
					{
						val2 = val;
					}
					else
					{
						((AppAbstractApi)this).ParametersOut.Add("IdContestazione", null);
						((AppAbstractApi)this).ParametersOut.Add("RetQueryToApply", "");
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
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Invalid comparison between Unknown and I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			val = CreazioneContestazione(ref rsmess);
			if ((int)val > 0)
			{
				val2 = val;
			}
			else
			{
				if (_contestazione == null)
				{
					goto IL_00d1;
				}
				string sQuery = "";
				val = CreateQueryINSERT(_contestazione, ref sQuery, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					text = sQuery;
					((AppAbstractApi)this).ParametersOut["RetQueryToApply"] = text;
					if (!_ApplyQuery)
					{
						goto IL_00ae;
					}
					val = ((AppBaseClass)this).DbConn.SqlExec(text, ref rsmess);
					if ((int)val <= 0)
					{
						goto IL_00ae;
					}
					val2 = val;
				}
			}
			goto end_IL_000b;
			IL_00d1:
			val2 = (FXRETURN)0;
			goto end_IL_000b;
			IL_00ae:
			((AppAbstractApi)this).ParametersOut["IdContestazione"] = _contestazione.Id;
			goto IL_00d1;
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

	protected virtual FXRETURN CheckSpedizione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_Unibol, "", false) != 0)
			{
				text = "SELECT S.*, TS.CreaContestazione TipoServizio_CreaContestazione, T.FatturaA TrasportatoreFatturazione, V.Vettore VettoreCodice, T2.FatturaA VettoreFatturazione ";
				text += "FROM Spedizioni S INNER JOIN TipiServizi TS ON S.TipoServizio=TS.Codice ";
				text += "LEFT JOIN Trasportatori T ON T.Codice=S.Trasportatore ";
				text += "LEFT JOIN Viaggi V ON V.IdViaggio=S.IdViaggio ";
				text += "LEFT JOIN Trasportatori T2 ON T2.Codice=V.Vettore ";
				text = text + "WHERE S.Unibol = " + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol);
				val = ((AppBaseClass)this).DbConn.OpenDataTable(text, ref _dtSpedizione, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else if (_dtSpedizione.Rows.Count == 0)
				{
					rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non esiste", new string[1] { _Unibol });
				}
				else
				{
					DataRow dataRow = _dtSpedizione.Rows[0];
					if (!((Conversions.ToInteger(dataRow["Stato"]) < 20) | (Conversions.ToInteger(dataRow["Stato"]) >= 90)))
					{
						goto IL_019e;
					}
					rsmess = this.TranslateMessage("XXX", "La spedizione con Id {0} non è in uno stato che permette la creazione di una contestazione", new string[1] { _Unibol });
				}
			}
			else
			{
				if (!((Operators.CompareString(_NumeroDocumento, "", false) == 0) | !_DataDocumento.HasValue))
				{
					goto IL_019e;
				}
				rsmess = this.TranslateMessage("XXX", "Per creare una contestazione è necessario avere una spedizione esiste oppure gli estremi di un documento esterno");
			}
			goto end_IL_000b;
			IL_019e:
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

	protected virtual FXRETURN CheckContestazione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Invalid comparison between Unknown and I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Invalid comparison between Unknown and I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		string text = "";
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_Unibol, "", false) != 0)
			{
				object objRes = null;
				text = "SELECT COUNT(*) FROM CONTESTAZIONI WHERE UNIBOL=" + ((AppBaseClass)this).DbConn.SQLFormatString(_Unibol) + " ";
				text = text + "AND TipoContestazione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoContestazione);
				val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (Conversions.ToInteger(objRes) <= 0)
					{
						goto IL_01a7;
					}
					rsmess = this.TranslateMessage("XXX", "Essite già una pratica di contestazione di tipo {0} per la spedizione {1}", new string[2] { _TipoContestazione, _Unibol });
				}
			}
			else
			{
				object objRes2 = null;
				text = "SELECT COUNT(*) FROM CONTESTAZIONI WHERE Riferimento1=" + ((AppBaseClass)this).DbConn.SQLFormatString(_NumeroDocumento) + " ";
				text = text + "AND DataRiferimento1 = " + ((AppBaseClass)this).DbConn.SQLFormatDate((eTipoData)1, _DataDocumento.Value) + " ";
				text = text + "AND TipoContestazione = " + ((AppBaseClass)this).DbConn.SQLFormatString(_TipoContestazione);
				val = ((AppBaseClass)this).DbConn.DoSql(text, ref objRes2, ref rsmess);
				if ((int)val > 0)
				{
					val2 = val;
				}
				else
				{
					if (Conversions.ToInteger(objRes2) <= 0)
					{
						goto IL_01a7;
					}
					rsmess = this.TranslateMessage("XXX", "Essite già una pratica di contestazione di tipo {0} per il documento {1}", new string[2] { _TipoContestazione, _NumeroDocumento });
				}
			}
			goto end_IL_000b;
			IL_01a7:
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

	protected virtual FXRETURN CreazioneContestazione(ref string rsmess)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		FXRETURN val = (FXRETURN)3;
		FXRETURN val2 = (FXRETURN)3;
		FXRETURN result;
		try
		{
			this.CallStackAdd();
			rsmess = "";
			if (Operators.CompareString(_dtSpedizione.Rows[0]["TipoServizio_CreaContestazione"].ToString().ToUpper(), "S", false) != 0)
			{
				goto IL_0179;
			}
			_contestazione = new Contestazione();
			long rlReturnValue = default(long);
			val = ((AppBaseClass)this).Parametrica.LeggiContatore("COUNTERS.CONTESTAZIONI.ID", ref rlReturnValue, ref rsmess);
			if ((int)val <= 0)
			{
				_contestazione.Id = checked((int)rlReturnValue);
				_contestazione.Stato = 10;
				_contestazione.DataApertura = _DataApertura.Value;
				_contestazione.Unibol = _Unibol;
				_contestazione.Riferimento1 = _NumeroDocumento;
				_contestazione.DataRiferimento1 = _DataDocumento;
				_contestazione.NoteRiferimento1 = _NoteDocumento;
				_contestazione.TipoContestazione = _TipoContestazione;
				_contestazione.TipoSoggetto = "X";
				_contestazione.Note1 = _Note1;
				_contestazione.Note2 = _Note2;
				_contestazione.Note3 = _Note3;
				_contestazione.UteAgg = this._User;
				_contestazione.UteIns = this._User;
				goto IL_0179;
			}
			val2 = val;
			goto end_IL_0005;
			IL_0179:
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
}
